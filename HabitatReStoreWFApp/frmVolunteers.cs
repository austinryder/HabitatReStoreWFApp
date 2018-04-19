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

        private void txtVolunteerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                MessageBox.Show("You must enter a first name.");
            }
            else if (string.IsNullOrEmpty(txtMName.Text))
            {
                MessageBox.Show("You must enter a middle name.");
            }
            else if (string.IsNullOrEmpty(txtLName.Text))
            {
                MessageBox.Show("You must enter a last name.");
            }
            else if (string.IsNullOrEmpty(txtDOB.Text))
            {
                MessageBox.Show("You must enter a date of birth.");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("You must enter an address.");
            }
            else if(string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("You must enter a city.");
            }
            else if (string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("You must enter a state.");
            }
            else if (string.IsNullOrEmpty(txtZipCode.Text))
            {
                MessageBox.Show("You must enter a zip code.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelVol_Click(object sender, EventArgs e)
        {
            
            DialogResult result = (MessageBox.Show("Do you really want to delete the volunteer?", "Delete Volunteer", MessageBoxButtons.YesNo));
            if (result == DialogResult.Yes)
            {
                txtFName.Text = "";
                txtMName.Text = "";
                txtLName.Text = "";
                txtGender.Text = "";
                txtDOB.Text = "";
                txtAddress.Text = "";
                txtAddress2.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZipCode.Text = "";

            }
        }
    }
}
