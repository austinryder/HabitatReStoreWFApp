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
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();
        Volunteer selectedVolunteer = new Volunteer();

        public frmInputTimesheet()
        {
            InitializeComponent();

            InitializeItems();
        }

        private void InitializeItems()
        {
            var volunteerResult = from v in db.Volunteers
                                  select v;
            
            cboVolunteerID.DataSource = volunteerResult;
            cboVolunteerID.DisplayMember = "Volunteer_ID";

            var store = from s in db.Stores
                        select s;

            cboStore.DataSource = store;
            cboStore.DisplayMember = "Name";

            DisplayVolunteerName();
            PopulateThisVolunteerCategories();
        }

        private void DisplayVolunteerName()
        {
            selectedVolunteer = (Volunteer)cboVolunteerID.SelectedItem;

            var volunteerResult = from v in db.Volunteers
                        where v.Volunteer_ID == selectedVolunteer.Volunteer_ID
                        select v;

            txtFName.Text = volunteerResult.First().First_Name;
            txtLName.Text = volunteerResult.First().Last_Name;
        }

        private void PopulateThisVolunteerCategories()
        {
            List<Volunteer_Category_Type> volunteerCategories = new List<Volunteer_Category_Type>();

            var thisVolunteerCategories = from vc in db.Volunteer_Categories
                                          where vc.Volunteer_ID == selectedVolunteer.Volunteer_ID
                                          select vc;

            foreach (Volunteer_Category vc in thisVolunteerCategories)
            {
                var cat = from vct in db.Volunteer_Category_Types
                          where vct.Category_Type_ID == vc.Category_Type_ID
                          select vct;

                volunteerCategories.AddRange(cat);
            }

            cboVolunteerCategory.DataSource = volunteerCategories;
            cboVolunteerCategory.DisplayMember = "Description";
            cboVolunteerCategory.SelectedIndex = -1;
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
            if (cboVolunteerCategory.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a volunteer category.");
            }
            else if (pickTimeIn.Value >= pickTimeOut.Value)
            {
                MessageBox.Show("Time out must be after time in.");
            }
            else
            {
                Store selectedStore = (Store)cboStore.SelectedItem;
                Volunteer_Category_Type selectedCategory = (Volunteer_Category_Type)cboVolunteerCategory.SelectedItem;

                Volunteer_Schedule newSchedule = new Volunteer_Schedule
                {
                    Volunteer_ID = selectedVolunteer.Volunteer_ID,
                    Store_ID = selectedStore.Store_ID,
                    Category_Type_ID = selectedCategory.Category_Type_ID,
                    Sign_In = pickTimeIn.Value,
                    Sign_Out = pickTimeOut.Value
                };

                db.Volunteer_Schedules.InsertOnSubmit(newSchedule);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Timesheet submitted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting timesheet.");
                    Console.WriteLine(ex);
                }
            }
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
