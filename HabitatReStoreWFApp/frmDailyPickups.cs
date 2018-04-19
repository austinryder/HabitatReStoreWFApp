using HabitatReStoreWFApp.AppData;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    public partial class frmDailyPickups : baseForm
    {
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();
        List<Donation_PickUp_Schedule> schedules = new List<Donation_PickUp_Schedule>();

        public frmDailyPickups()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDailyPickups_Load(object sender, EventArgs e)
        {
            InitializePickers();
        }

        private void InitializePickers()
        {
            var stores = from s in db.Stores
                         select s;

            cboStore.DataSource = stores;
            cboStore.DisplayMember = "Name";

            var drivers = from d in db.Drivers
                          select d;

            cboDriver.DataSource = drivers;
            cboDriver.DisplayMember = "First_Name";

            cboStore.SelectedIndex = 0;
            cboDriver.SelectedIndex = 0;
        }

        //formats driver combobox to show driver's first and last name
        private void ComboDriverFormat(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Driver)e.ListItem).Last_Name;
            string firstname = ((Driver)e.ListItem).First_Name;
            e.Value = lastname + ", " + firstname;
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            Driver driver = (Driver)cboDriver.SelectedItem;
            string driverFullName = (driver.First_Name + " " + driver.Last_Name);
            DateTime selectedDate = pickDate.Value.Date;
            Store selectedStore = (Store)cboStore.SelectedItem;
            int numPickups = Convert.ToInt32(nudNumPickups.Value);

            var donationSchedules = (from dps in db.Donation_PickUp_Schedules
                                    where dps.Completed == false &&
                                    dps.PickUp_Window_Start.Date == pickDate.Value.Date &&
                                    dps.Donation.Store.Store_ID == selectedStore.Store_ID
                                    orderby dps.PickUp_Window_Start descending
                                    select dps).Take(numPickups);

            schedules = donationSchedules.ToList();
            schedules.Reverse();

            List<Donation> donations = new List<Donation>();
            List<Store> stores = new List<Store>();

            btnAccept.Enabled = false;
            btnPrint.Enabled = false;

            if (schedules.Count > 0)
            {
                foreach (Donation_PickUp_Schedule sched in schedules)
                {
                    donations.Add(sched.Donation);
                    stores.Add(sched.Donation.Store);
                };

                //binding sources for reportviewer
                Donation_PickUp_ScheduleBindingSource.DataSource = schedules;
                DonationBindingSource.DataSource = donations;
                StoreBindingSource.DataSource = stores;

                //refresh report
                reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DailyPickups.rdlc";
                reportViewer.LocalReport.SetParameters(new ReportParameter("Date", selectedDate.ToString("MM/dd/yyyy")));
                reportViewer.LocalReport.SetParameters(new ReportParameter("DriverFullName", driverFullName));
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.RefreshReport();

                btnAccept.Enabled = true;
            }
            else
            {
                MessageBox.Show("There are no pickups scheduled for this store for this day");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportViewer.SetPageSettings(new PageSettings()
            {
                Landscape = true,
                Color = false,
                Margins = new Margins(50,50,50,50)
            });
            reportViewer.PrintDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool success = true;

            foreach (Donation_PickUp_Schedule sched in schedules)
            {
                sched.Donation.Status_Map_ID = 6;

                try {
                    db.usp_UpdateDonation(
                        donation_ID: sched.Donation.Donation_ID,
                        store_ID: sched.Donation.Store_ID,
                        status_Map_ID: sched.Donation.Status_Map_ID,
                        address: sched.Donation.Address,
                        address2: sched.Donation.Address2,
                        city: sched.Donation.City,
                        state: sched.Donation.State,
                        zipCode: sched.Donation.ZipCode,
                        bypass_Flag: sched.Donation.Bypass_Flag
                        );
                }
                catch (Exception ex)
                {
                    success = false;
                    Console.WriteLine(ex);
                }
            }

            if (success)
            {
                MessageBox.Show("Success. Donations are now marked 'In Progress'");
                btnPrint.Enabled = true;
                btnAccept.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error updating donations.");
            }
        }
    }
}
