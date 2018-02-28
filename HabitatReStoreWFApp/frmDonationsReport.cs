using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    public partial class frmDonationsReport : HabitatReStoreWFApp.baseForm
    {
        public frmDonationsReport()
        {
            InitializeComponent();
        }

        private void frmDonationsReport_Load(object sender, EventArgs e)
        {

            this.rvDonations.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
