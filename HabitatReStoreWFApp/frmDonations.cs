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
            InitializeStores();
            InitializeStatusOptions();
            
            DisableEdits();
        }

        private void InitializeStores()
        {
            var stores = from s in db.Stores
                         select s;

            cboStore.DataSource = stores;
            cboStore.DisplayMember = "Name";
        }

        private void DisableEdits()
        {
            btnEdit.Visible = false;
            txtAddress.Enabled = false;
            txtAddress2.Enabled = false;
            txtDonorID.Enabled = false;
            cboStore.Enabled = false;
            txtZipCode.Enabled = false;
            cboStatus.Enabled = false;
        }

        private void EnableEdits()
        {
            btnEdit.Visible = true;
            txtAddress.Enabled = true;
            txtAddress2.Enabled = true;
            txtDonorID.Enabled = true;
            cboStore.Enabled = true;
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
            btnNext.Enabled = true;
            btnPrevious.Enabled = false;
        }

        private void GetAllDonations()
        {
           donationIndex = 0;
           itemsIndex = 0;
           int statusID = ((Status_Map)cboViewStatus.SelectedItem).Status_Map_ID;

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

            txtDonationID.Text = selectedDonation.Donation_ID.ToString();
            txtDonorID.Text = selectedDonation.Donor_ID.ToString();
            cboStore.SelectedItem = selectedDonation.Store;
            txtAddress.Text = selectedDonation.Address;
            txtAddress2.Text = selectedDonation.Address2;
            txtZipCode.Text = selectedDonation.ZipCode;
            txtFName.Text = selectedDonation.Donor.First_Name;
            txtLName.Text = selectedDonation.Donor.Last_Name;

            try
            {
                var items = from i in db.Items
                            where i.Donation_ID == selectedDonation.Donation_ID
                            select i;
                selectedItems = items.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to retrieve items.");
                Console.WriteLine(ex);
            }
        }

        private void DisplayItem(int itemsIndex)
        {
            if (selectedItems.Count != 0)
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
            else
            {
                txtItemID.Text = "";
                txtItemCategory.Text = "";
                txtDescription.Text = "";
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

            btnItemsNext.Enabled = true;
            btnItemsPrevious.Enabled = false;
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

            btnItemsNext.Enabled = true;
            btnItemsPrevious.Enabled = false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                selectedDonation.Status_Map = (Status_Map)cboStatus.SelectedItem;
                selectedDonation.Donor_ID = this.selectedDonation.Donor_ID;
                selectedDonation.Store = (Store)cboStore.SelectedItem;
                selectedDonation.Address = txtAddress.Text;
                selectedDonation.Address2 = txtAddress2.Text;
                selectedDonation.ZipCode = txtZipCode.Text;
                selectedDonation.Bypass_Flag = chkBypass.Checked;
                selectedDonation.Donation_ID = this.selectedDonation.Donation_ID;
                selectedDonation.City = this.selectedDonation.City;
                selectedDonation.State = this.selectedDonation.State;

                allDonations[donationIndex] = selectedDonation;

                db.usp_UpdateDonation(
                    donation_ID: selectedDonation.Donation_ID,
                    store_ID: selectedDonation.Store_ID,
                    status_Map_ID: selectedDonation.Status_Map_ID,
                    city: selectedDonation.City,
                    state: selectedDonation.State,
                    address: selectedDonation.Address,
                    address2: selectedDonation.Address2,
                    zipCode: selectedDonation.ZipCode,
                    bypass_Flag: selectedDonation.Bypass_Flag
                    );

                DisplayDonation(donationIndex);

                MessageBox.Show("Donation information updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating donation information");
                Console.WriteLine(ex.StackTrace);
            }
        }

        //keyboard shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Left):
                    btnPrevious.PerformClick();
                    return true;
                case (Keys.Right):
                    btnNext.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
