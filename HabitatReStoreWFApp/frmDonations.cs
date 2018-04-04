using HabitatReStoreWFApp.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using System.IO;

namespace HabitatReStoreWFApp
{
    public partial class frmDonations : HabitatReStoreWFApp.baseForm
    {
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();
        Donation selectedDonation = new Donation();
        List<Donation> allDonations;
        int index = 0;

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
            InitializeStatusOptions();
            DisableEdits();
        }

        private void DisableEdits()
        {
            btnEdit.Visible = false;
            txtAddress.Enabled = false;
            txtAddress2.Enabled = false;
            txtDescription.Enabled = false;
            txtDonorID.Enabled = false;
            txtStoreID.Enabled = false;
            txtZipCode.Enabled = false;
            cboStatus.Enabled = false;
        }

        private void EnableEdits()
        {
            btnEdit.Visible = true;
            txtAddress.Enabled = true;
            txtAddress2.Enabled = true;
            txtDescription.Enabled = true;
            txtDonorID.Enabled = true;
            txtStoreID.Enabled = true;
            txtZipCode.Enabled = true;
            cboStatus.Enabled = true;
        }

        private void InitializeStatusOptions()
        {
            var statuses = from s in db.Status_Maps
                           where s.Status_Entity_ID == 3
                           select s;

            cboViewStatus.DataSource = statuses;
            cboViewStatus.DisplayMember = "Description";

            cboStatus.DataSource = statuses;
            cboStatus.DisplayMember = "Description";
        }

        private void chkEnableEdits_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableEdits.Checked)
            {
                EnableEdits();
            }
            else
            {
                DisableEdits();
            }
        }

        private void cboViewStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDonations();
        }

        private void GetAllDonations()
        {
           index = 0;
           int statusID = ((Status_Map)cboViewStatus.SelectedItem).Status_Entity_ID;

           var donations = from d in db.Donations
                           where d.Status_Map_ID == statusID
                           select d;

            allDonations = donations.ToList();

            //display index and count
            UpdateIndexAndCount();

            DisplayDonation(index);
        }

        private void UpdateIndexAndCount()
        {
            lblIndex.Text = (index + 1).ToString();
            lblCount.Text = allDonations.Count().ToString();
        }

        private void DisplayDonation(int index)
        {
            selectedDonation = allDonations[index];
            Item selectedItem = new Item();

            var item = from i in db.Items
                       where i.Donation_ID == selectedDonation.Donation_ID
                       select i;
            selectedItem = item.ToArray()[0];

            txtDonationID.Text = selectedDonation.Donation_ID.ToString();
            txtDonorID.Text = selectedDonation.Donor_ID.ToString();
            txtStoreID.Text = selectedDonation.Store_ID.ToString();
            txtDescription.Text = selectedItem.Description;
            txtAddress.Text = selectedDonation.Address;
            txtAddress2.Text = selectedDonation.Address2;
            txtZipCode.Text = selectedDonation.ZipCode;
            if (selectedItem.Donation_Image != null && selectedItem.Donation_Image.ToArray().Length > 0)
            {
                picImage.Image = ConvertToImage(selectedItem.Donation_Image.ToArray());
            }
            else
            {
                picImage.Image = null;
            }
        }

        private Image ConvertToImage(byte[] donation_Image)
        {
            MemoryStream ms = new MemoryStream(donation_Image);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }

            DisplayDonation(index);
            UpdateIndexAndCount();

            if (index == 0)
            {
                btnPrevious.Enabled = false;
            }
            if (index < (allDonations.Count() - 1))
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < (allDonations.Count() - 1))
            {
                index++;
            }

            DisplayDonation(index);
            UpdateIndexAndCount();

            if (index == (allDonations.Count() - 1))
            {
                btnNext.Enabled = false;
            }
            if (index > 0)
            {
                btnPrevious.Enabled = true;
            }
        }
    }
}
