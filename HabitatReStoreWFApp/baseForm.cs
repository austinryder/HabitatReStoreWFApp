using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inputTimesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputTimesheet inputTime = new frmInputTimesheet();
            Hide();
            inputTime.ShowDialog();
            Show();
        }

        private void donationsPerStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonationsReport donationsReport = new frmDonationsReport();
            Hide();
            donationsReport.ShowDialog();
            Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
