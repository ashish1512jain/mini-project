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
using System.Windows.Forms.DataVisualization.Charting;

namespace BabiesRecordsManagementSystem.UI
{
    public partial class NamePopularity : Form
    {
        public NamePopularity()
        {
            InitializeComponent();
        }
         

        private void ShowBabyChart(int yearFrom, int yearTo, string name, bool? gender)
        {
            using (var dt = BabiesDataAccess.GetBabiesRanking(name, yearFrom, yearTo, gender))
            {
                var chartCollection = dt.AsEnumerable().Select(x => new BabyModel()
                {
                    Rank = Convert.ToInt64(x["RANK"]),
                    Year = Convert.ToInt32(x["Year"])
                }
                );

                if (chartCollection.Count() < 1)
                {
                    MessageBox.Show("No result found in entered criteria, please try again");
                }

                foreach (var item in chartCollection)
                {
                    chart1.Series["Year"].Points.AddXY(item.Year, item.Rank);
                }
            }
        }

        private void btnBabyRanking_Click_1(object sender, EventArgs e)
        {
            int yearFrom = 1900, yearTo = DateTime.UtcNow.Year;
            string name = txtName.Text;
            bool? gender = null;//male gender

            //clear chart data
            ClearChartData();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter name");
                return;
            }

            if (!Int32.TryParse(txtFromYear.Text, out yearFrom))
            {
                MessageBox.Show("Please enter from date or valid date");
                return;
            }

            if (!Int32.TryParse(txtYearTo.Text, out yearTo))
            {
                MessageBox.Show("Please enter to date or valid dates");
                return;
            }

            gender = (cmdGender.SelectedValue == null) ? null : (Nullable<bool>)(cmdGender.SelectedValue.ToString() == "Male" ? false : true);

            ShowBabyChart(yearFrom, yearTo, name, gender);
        }

        private void ClearChartData()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void txtFromYear_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearTo_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
