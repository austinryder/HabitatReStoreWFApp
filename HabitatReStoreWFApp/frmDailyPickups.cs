using HabitatReStoreWFApp.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            e.Value = lastname + " " + firstname;
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
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

            foreach (Donation_PickUp_Schedule sched in schedules)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    sched.Donation_ID.ToString(),
                    sched.Donation.Store.Name.ToString(),
                    sched.Donation.Address.ToString(),
                    sched.Donation.Address2.ToString(),
                    sched.Donation.City.ToString(),
                    sched.Donation.State.ToString(),
                    sched.Donation.ZipCode.ToString(),
                    sched.PickUp_Window_Start.Date.ToString(),
                    sched.PickUp_Window_Start.TimeOfDay.ToString(),
                    sched.PickUp_Window_End.TimeOfDay.ToString(),
                    sched.Special_Instructions.ToString()
                });

                lstPickups.Items.Add(item);                
            }
        }
    }
}
