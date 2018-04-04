using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    public partial class frmDonations : HabitatReStoreWFApp.baseForm
    {
        public frmDonations()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDonations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'habitat_Restore_V2DataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.habitat_Restore_V2DataSet.Donation);

        }
    }
}
