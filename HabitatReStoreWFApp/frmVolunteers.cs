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
            string[] genders = { "M", "F", "O" };
            cboGender.DataSource = genders;
        }

        private void frmVolunteers_Load(object sender, EventArgs e)
        {
            InitializeStatusOptions();
            GetAllVolunteers();
            DisplayVolunteer(volunteerIndex);

            DisableEdits();
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
            cboGender.SelectedItem = selectedVolunteer.Gender.ToString();
            cboStatus.SelectedItem = selectedVolunteer.Status_Map;
            pickDate.Value = selectedVolunteer.DOB;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                selectedVolunteer.Status_Map = (Status_Map)cboStatus.SelectedItem;
                selectedVolunteer.Last_Name = txtLName.Text;
                selectedVolunteer.First_Name = txtFName.Text;
                selectedVolunteer.Middle_Name = txtMName.Text;
                selectedVolunteer.Gender = cboGender.SelectedItem.ToString()[0];
                selectedVolunteer.DOB = pickDate.Value;
                selectedVolunteer.Address = txtAddress.Text;
                selectedVolunteer.Address2 = txtAddress2.Text;
                selectedVolunteer.City = txtCity.Text;
                selectedVolunteer.State = txtState.Text;
                selectedVolunteer.Zip_Code = txtZipCode.Text;

                allVolunteers[volunteerIndex] = selectedVolunteer;

                db.usp_UpdateVolunteer(
                    volunteer_ID: selectedVolunteer.Volunteer_ID,
                    status_Map_ID: selectedVolunteer.Status_Map_ID,
                    last_Name: selectedVolunteer.Last_Name,
                    first_Name: selectedVolunteer.First_Name,
                    middle_Name: selectedVolunteer.Middle_Name,
                    gender: selectedVolunteer.Gender,
                    dOB: selectedVolunteer.DOB,
                    sSN: selectedVolunteer.SSN,
                    address: selectedVolunteer.Address,
                    address2: selectedVolunteer.Address2,
                    city: selectedVolunteer.City,
                    state: selectedVolunteer.State,
                    zipCode: selectedVolunteer.Zip_Code,
                    phone: selectedVolunteer.Phone,
                    email: selectedVolunteer.Email
                    );

                DisplayVolunteer(volunteerIndex);
                MessageBox.Show("Volunteer information updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating volunteer information");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void chkEnableEdits_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableEdits.Checked)
            {
                EnableEdits();
                btnEdit.Visible = true;
            }
            else
            {
                DisableEdits();
                btnEdit.Visible = false;
            }
        }

        private void DisableEdits()
        {
            txtAddress.Enabled = false;
            txtAddress2.Enabled = false;
            txtCity.Enabled = false;
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtMName.Enabled = false;
            txtState.Enabled = false;
            txtVolunteerID.Enabled = false;
            txtZipCode.Enabled = false;
            cboGender.Enabled = false;
            cboStatus.Enabled = false;
            pickDate.Enabled = false;
        }

        private void EnableEdits()
        {
            txtAddress.Enabled = true;
            txtAddress2.Enabled = true;
            txtCity.Enabled = true;
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtMName.Enabled = true;
            txtState.Enabled = true;
            txtZipCode.Enabled = true;
            cboGender.Enabled = true;
            cboStatus.Enabled = true;
            pickDate.Enabled = true;
        }

        //keyboard shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Left):
                    btnPrevious.PerformClick();
                    break;
                case (Keys.Right):
                    btnNext.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
