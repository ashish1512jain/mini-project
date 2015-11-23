using BabiesRecordsManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabiesRecordsManagementSystem.UI
{
    public partial class SearchBabies : Form
    {
        public SearchBabies()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var _name = txtName.Text;
            var _top = txtTopCount.Text.ToValue();
            var _gender = comboBox1.SelectedItem;
            int? _year = txtYear.Text.ToValue();

            gridRecords.DataSource = BabiesDataAccess.GetImportedRecords(_top, true, _name, null, _year, null);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTopCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
