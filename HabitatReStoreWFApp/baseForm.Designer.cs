﻿using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    partial class baseForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.donationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volunteersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllVolunteersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volunteerTimesheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationsPerStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyDonationPickupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsToolStripMenuItem,
            this.volunteersToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1026, 50);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "mnuMain";
            // 
            // donationsToolStripMenuItem
            // 
            this.donationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllDonationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.donationsToolStripMenuItem.Name = "donationsToolStripMenuItem";
            this.donationsToolStripMenuItem.Size = new System.Drawing.Size(159, 44);
            this.donationsToolStripMenuItem.Text = "&Donations";
            // 
            // viewAllDonationsToolStripMenuItem
            // 
            this.viewAllDonationsToolStripMenuItem.Name = "viewAllDonationsToolStripMenuItem";
            this.viewAllDonationsToolStripMenuItem.Size = new System.Drawing.Size(346, 44);
            this.viewAllDonationsToolStripMenuItem.Text = "View All &Donations";
            this.viewAllDonationsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDonationsToolStripMenuItem_Click);
            // 
            // volunteersToolStripMenuItem
            // 
            this.volunteersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllVolunteersToolStripMenuItem,
            this.volunteerTimesheetsToolStripMenuItem,
            this.inputTimesheetToolStripMenuItem});
            this.volunteersToolStripMenuItem.Name = "volunteersToolStripMenuItem";
            this.volunteersToolStripMenuItem.Size = new System.Drawing.Size(163, 44);
            this.volunteersToolStripMenuItem.Text = "&Volunteers";
            // 
            // viewAllVolunteersToolStripMenuItem
            // 
            this.viewAllVolunteersToolStripMenuItem.Name = "viewAllVolunteersToolStripMenuItem";
            this.viewAllVolunteersToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.viewAllVolunteersToolStripMenuItem.Text = "View All &Volunteers";
            this.viewAllVolunteersToolStripMenuItem.Click += new System.EventHandler(this.viewAllVolunteersToolStripMenuItem_Click);
            // 
            // volunteerTimesheetsToolStripMenuItem
            // 
            this.volunteerTimesheetsToolStripMenuItem.Name = "volunteerTimesheetsToolStripMenuItem";
            this.volunteerTimesheetsToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.volunteerTimesheetsToolStripMenuItem.Text = "Volunteer &Timesheets";
            this.volunteerTimesheetsToolStripMenuItem.Click += new System.EventHandler(this.volunteerTimesheetsToolStripMenuItem_Click);
            // 
            // inputTimesheetToolStripMenuItem
            // 
            this.inputTimesheetToolStripMenuItem.Name = "inputTimesheetToolStripMenuItem";
            this.inputTimesheetToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.inputTimesheetToolStripMenuItem.Text = "&Input Timesheet";
            this.inputTimesheetToolStripMenuItem.Click += new System.EventHandler(this.inputTimesheetToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsPerStoreToolStripMenuItem,
            this.dailyDonationPickupsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // donationsPerStoreToolStripMenuItem
            // 
            this.donationsPerStoreToolStripMenuItem.Name = "donationsPerStoreToolStripMenuItem";
            this.donationsPerStoreToolStripMenuItem.Size = new System.Drawing.Size(398, 44);
            this.donationsPerStoreToolStripMenuItem.Text = "Donations per &Store";
            this.donationsPerStoreToolStripMenuItem.Click += new System.EventHandler(this.donationsPerStoreToolStripMenuItem_Click);
            // 
            // dailyDonationPickupsToolStripMenuItem
            // 
            this.dailyDonationPickupsToolStripMenuItem.Name = "dailyDonationPickupsToolStripMenuItem";
            this.dailyDonationPickupsToolStripMenuItem.Size = new System.Drawing.Size(398, 44);
            this.dailyDonationPickupsToolStripMenuItem.Text = "Daily Donation &Pickups";
            this.dailyDonationPickupsToolStripMenuItem.Click += new System.EventHandler(this.dailyDonationPickupsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(346, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 709);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "baseForm";
            this.Text = "Habitat for Humanity ReStore";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem donationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDonationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volunteersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllVolunteersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volunteerTimesheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputTimesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationsPerStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyDonationPickupsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}