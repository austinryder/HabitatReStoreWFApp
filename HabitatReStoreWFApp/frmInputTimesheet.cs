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
        Volunteer selectedVolunteer = new Volunteer();

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
            PopulateThisVolunteerCategories();
        }

        private void DisplayVolunteerName()
        {
            selectedVolunteer = (Volunteer)cboVolunteerID.SelectedItem;

            var volunteerResult = from v in context.Volunteers
                        where v.Volunteer_ID == selectedVolunteer.Volunteer_ID
                        select v;

            txtFName.Text = volunteerResult.First().First_Name;
            txtLName.Text = volunteerResult.First().Last_Name;
        }

        private void PopulateThisVolunteerCategories()
        {
            List<Volunteer_Category_Type> volunteerCategories = new List<Volunteer_Category_Type>();

            var thisVolunteerCategories = from vc in context.Volunteer_Categories
                                          where vc.Volunteer_ID == selectedVolunteer.Volunteer_ID
                                          select vc;

            foreach (Volunteer_Category vc in thisVolunteerCategories)
            {
                var cat = from vct in context.Volunteer_Category_Types
                          where vct.Category_Type_ID == vc.Category_Type_ID
                          select vct;

                volunteerCategories.Add((Volunteer_Category_Type)cat);
            }

            cboVolunteerCategory.DataSource = volunteerCategories;
            cboVolunteerCategory.DisplayMember = "Description";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboVolunteerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVolunteerName();
            PopulateThisVolunteerCategories();
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
