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
        List<Item> selectedItems = new List<Item>();
        List<Donation> allDonations;
        int donationIndex = 0;
        int itemsIndex = 0;

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
            txtStore.Enabled = false;
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
            txtStore.Enabled = true;
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
           donationIndex = 0;
           itemsIndex = 0;
           int statusID = ((Status_Map)cboViewStatus.SelectedItem).Status_Entity_ID;

           var donations = from d in db.Donations
                           where d.Status_Map_ID == statusID
                           select d;

            allDonations = donations.ToList();

            //display index and count
            UpdateIndexAndCount();

            DisplayDonation(donationIndex);
            DisplayItem(itemsIndex);

            UpdateItemsIndexAndCount();
        }

        private void UpdateIndexAndCount()
        {
            lblIndex.Text = (donationIndex + 1).ToString();
            lblCount.Text = allDonations.Count.ToString();
        }

        private void UpdateItemsIndexAndCount()
        {
            lblItemsIndex.Text = (itemsIndex + 1).ToString();
            lblItemsCount.Text = selectedItems.Count().ToString();
        }

        private void DisplayDonation(int donationIndex)
        {
            selectedDonation = allDonations[donationIndex];

            var items = from i in db.Items
                        where i.Donation_ID == selectedDonation.Donation_ID
                        select i;
            selectedItems = items.ToList();

            txtDonationID.Text = selectedDonation.Donation_ID.ToString();
            txtDonorID.Text = selectedDonation.Donor_ID.ToString();
            txtStore.Text = selectedDonation.Store.Name.ToString();
            txtAddress.Text = selectedDonation.Address;
            txtAddress2.Text = selectedDonation.Address2;
            txtZipCode.Text = selectedDonation.ZipCode;
            txtFName.Text = selectedDonation.Donor.First_Name;
            txtLName.Text = selectedDonation.Donor.Last_Name;
        }

        private void DisplayItem(int itemsIndex)
        {
            Item thisItem = selectedItems[itemsIndex];

            txtItemID.Text = thisItem.Item_ID.ToString();
            txtItemCategory.Text = thisItem.Item_Category.Description.ToString();
            txtDescription.Text = thisItem.Description;
            if (thisItem.Donation_Image != null && thisItem.Donation_Image.ToArray().Length > 0)
            {
                picImage.Image = ConvertToImage(thisItem.Donation_Image.ToArray());
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
            itemsIndex = 0;

            if (donationIndex > 0)
            {
                donationIndex--;
            }

            DisplayDonation(donationIndex);
            DisplayItem(itemsIndex);
            UpdateIndexAndCount();
            UpdateItemsIndexAndCount();

            if (donationIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
            if (donationIndex < (allDonations.Count() - 1))
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            itemsIndex = 0;

            if (donationIndex < (allDonations.Count() - 1))
            {
                donationIndex++;
            }

            DisplayDonation(donationIndex);
            DisplayItem(itemsIndex);
            UpdateIndexAndCount();
            UpdateItemsIndexAndCount();

            if (donationIndex == (allDonations.Count() - 1))
            {
                btnNext.Enabled = false;
            }
            if (donationIndex > 0)
            {
                btnPrevious.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnItemsPrevious_Click(object sender, EventArgs e)
        {
            if (itemsIndex > 0)
            {
                itemsIndex--;
            }

            DisplayItem(itemsIndex);
            UpdateItemsIndexAndCount();

            if (itemsIndex == 0)
            {
                btnItemsPrevious.Enabled = false;
            }
            if (itemsIndex < (selectedItems.Count() - 1))
            {
                btnItemsNext.Enabled = true;
            }
        }

        private void btnItemsNext_Click(object sender, EventArgs e)
        {
            if (itemsIndex < (selectedItems.Count() - 1))
            {
                itemsIndex++;
            }

            DisplayItem(itemsIndex);
            UpdateItemsIndexAndCount();

            if (itemsIndex == (selectedItems.Count() - 1))
            {
                btnItemsNext.Enabled = false;
            }
            if (itemsIndex > 0)
            {
                btnItemsPrevious.Enabled = true;
            }
        }
    }
}
