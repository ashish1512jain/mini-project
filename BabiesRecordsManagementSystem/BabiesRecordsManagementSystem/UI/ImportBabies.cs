using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BabiesRecordsManagementSystem.CsvFileImport;
using BabiesRecordsManagementSystem.DataAccess;

namespace BabiesRecordsManagementSystem.UI
{
    public partial class ImportBabies : Form
    {
        private string _folderPath = string.Empty;
        private static int _topCount = 0;

        public ImportBabies()
        {
            InitializeComponent();
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _folderPath = dialog.FileName;
                txtFolderPath.Text = _folderPath;
                 
                ImportBabiesRecordsIntoDataBase(dialog.SafeFileNames, dialog.FileNames);

                gridImportBabies.DataSource = BabiesDataAccess.GetImportedRecords(_topCount,false);

                MessageBox.Show("Records inserted into system !!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private static void ImportBabiesRecordsIntoDataBase(string[] fileNames, string[] filesPath)
        {
            DataTable _table;
            int _year = 0;
            bool _gender = false;
            string _fileName = string.Empty;
            _topCount = 0;

            for (int i = 0; i < filesPath.Count(); i++)
            {
                _fileName = fileNames[i];

                GetYearAndGenderFromFileName(_fileName, out _year, out _gender);

                _table = CSVReader.ReadCSVFile(filesPath[i], true);

                foreach (var row in _table.AsEnumerable())
                {
                    ++_topCount;
                    BabiesDataAccess.SaveBaby(
                        Convert.ToString(row[0]),
                        Convert.ToInt64(row[1]),
                        _gender,
                        _year,
                        Convert.ToInt64(row[2].ToString().Replace("=", string.Empty))
                        );
                }
            }
        }

        private static void GetYearAndGenderFromFileName(string _fileName, out int _year, out bool _gender)
        {
            var _collection = _fileName.Split('_');

            _gender = string.Equals(_collection[0], "female", StringComparison.CurrentCultureIgnoreCase);
            int.TryParse(_collection[1].Substring(2), out _year);
        }


    }
}
