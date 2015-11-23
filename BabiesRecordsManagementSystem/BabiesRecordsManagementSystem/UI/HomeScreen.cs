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
    public partial class HomeScreen : Form
    {
        private int childFormNumber = 0;

        public HomeScreen()
        {
            InitializeComponent();
        }
  
        private void CloseAllForm()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void importBabiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            ImportBabies frmImportBabies = new ImportBabies();
            frmImportBabies.MdiParent = this; 
            frmImportBabies.Show();
        }

        private void searchBabiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            SearchBabies frmSearchBabies = new SearchBabies();
            frmSearchBabies.MdiParent = this; 
            frmSearchBabies.Show();
        }
 
        private void popularirtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm(); 
            NamePopularity frmNamePopularity = new NamePopularity();
            frmNamePopularity.MdiParent = this; 
            frmNamePopularity.Show();
        }

        
    }
}
