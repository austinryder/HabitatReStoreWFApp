using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HabitatReStoreWFApp.AppData;
using System.Linq;

namespace HabitatReStoreWFApp
{
    public partial class frmInputTimesheet : HabitatReStoreWFApp.baseForm
    {
        HabitatDataClassesDataContext context = new HabitatDataClassesDataContext();

        public frmInputTimesheet()
        {
            InitializeComponent();

            InitializeItems();
        }

        private void InitializeItems()
        {
            var volunteerResult = from v in context.Volunteers
                        select v;
            
            cboVolunteerID.DataSource = volunteerResult;
            cboVolunteerID.DisplayMember = "Volunteer_ID";

            DisplayVolunteerName();
        }

        private void DisplayVolunteerName()
        {
            Volunteer selectedVolunteer = (Volunteer)cboVolunteerID.SelectedItem;

            var volunteerResult = from v in context.Volunteers
                        where v.Volunteer_ID == selectedVolunteer.Volunteer_ID
                        select v;

            txtFName.Text = volunteerResult.First().First_Name;
            txtLName.Text = volunteerResult.First().Last_Name;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboVolunteerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVolunteerName();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
