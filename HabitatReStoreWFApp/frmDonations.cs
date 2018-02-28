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
    }
}
