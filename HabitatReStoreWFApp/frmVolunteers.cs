using HabitatReStoreWFApp.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace HabitatReStoreWFApp
{
    public partial class frmVolunteers : HabitatReStoreWFApp.baseForm
    {
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();
        Volunteer selectedVolunteer = new Volunteer();
        List<Volunteer> allVolunteers;
        int volunteerIndex = 0;

        public frmVolunteers()
        {
            InitializeComponent();
        }

        private void frmVolunteers_Load(object sender, EventArgs e)
        {
            GetAllVolunteers();
            DisplayVolunteer(volunteerIndex);
        }
        private void InitializeStatusOptions()
        {
            var statuses = from s in db.Status_Maps
                           where s.Status_Entity_ID == 1
                           select s;

            cboStatus.DataSource = statuses;
            cboStatus.DisplayMember = "Description";
        }

        private void GetAllVolunteers()
        {
            volunteerIndex = 0;

            var volunteers = from v in db.Volunteers
                             select v;

            allVolunteers = volunteers.ToList();

            //display index and count
            UpdateIndexAndCount();

            DisplayVolunteer(volunteerIndex);
        }

        private void DisplayVolunteer(int volunteerIndex)
        {
            selectedVolunteer = allVolunteers[volunteerIndex];

            txtVolunteerID.Text = selectedVolunteer.Volunteer_ID.ToString();
            txtAddress.Text = selectedVolunteer.Address;
            txtAddress2.Text = selectedVolunteer.Address2;
            txtZipCode.Text = selectedVolunteer.Zip_Code;
            txtFName.Text = selectedVolunteer.First_Name;
            txtMName.Text = selectedVolunteer.Middle_Name;
            txtLName.Text = selectedVolunteer.Last_Name;
            txtGender.Text = selectedVolunteer.Gender.ToString();
            txtDOB.Text = selectedVolunteer.DOB.ToString();
            txtCity.Text = selectedVolunteer.City;
            txtState.Text = selectedVolunteer.State.ToString();
        }

        private void UpdateIndexAndCount()
        {
            lblIndex.Text = (volunteerIndex + 1).ToString();
            lblCount.Text = allVolunteers.Count.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (volunteerIndex > 0)
            {
                volunteerIndex--;
            }

            DisplayVolunteer(volunteerIndex);
            UpdateIndexAndCount();

            if (volunteerIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
            if (volunteerIndex < (allVolunteers.Count() - 1))
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (volunteerIndex < (allVolunteers.Count() - 1))
            {
                volunteerIndex++;
            }

            DisplayVolunteer(volunteerIndex);
            UpdateIndexAndCount();

            if (volunteerIndex == (allVolunteers.Count() - 1))
            {
                btnNext.Enabled = false;
            }
            if (volunteerIndex > 0)
            {
                btnPrevious.Enabled = true;
            }
        }
    }
}
