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
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
        }

        private void inputTimesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputTimesheet inputTime = new frmInputTimesheet();
            Hide();
            inputTime.ShowDialog();
            Show();
        }

        private void donationsPerStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonationsReport donationsReport = new frmDonationsReport();
            Hide();
            donationsReport.ShowDialog();
            Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dailyDonationPickupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyPickups dailyPickups = new frmDailyPickups();
            Hide();
            dailyPickups.ShowDialog();
            Show();
        }

        private void volunteerHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVolunteerHours volunteerHours = new frmVolunteerHours();
            Hide();
            volunteerHours.ShowDialog();
            Show();
        }

        private void viewAllDonationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonations donations = new frmDonations();
            Hide();
            donations.ShowDialog();
            Show();
        }

        private void viewAllVolunteersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVolunteers volunteers = new frmVolunteers();
            Hide();
            volunteers.ShowDialog();
            Show();
        }

        private void volunteerTimesheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVolunteerHours volunteerHours = new frmVolunteerHours();
            Hide();
            volunteerHours.ShowDialog();
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void donorDonationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonorDonationsReport donorDonations = new frmDonorDonationsReport();
            Hide();
            donorDonations.ShowDialog();
            Show();
        }

        private void volunteerHoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmVolunteerHoursReport volunteerHours = new frmVolunteerHoursReport();
            Hide();
            volunteerHours.ShowDialog();
            Show();
        }
    }
}
