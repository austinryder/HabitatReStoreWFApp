namespace HabitatReStoreWFApp
{
    partial class frmDailyPickups
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rvDonations = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HabitatReStoreWFApp.Properties.Resources.habitat_for_humanity_restore_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rvDonations
            // 
            this.rvDonations.Location = new System.Drawing.Point(13, 174);
            this.rvDonations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rvDonations.Name = "rvDonations";
            this.rvDonations.ServerReport.BearerToken = null;
            this.rvDonations.Size = new System.Drawing.Size(975, 548);
            this.rvDonations.TabIndex = 4;
            // 
            // frmDailyPickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1001, 819);
            this.Controls.Add(this.rvDonations);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDailyPickups";
            this.Text = "Daily Pickups";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.rvDonations, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rvDonations;
    }
}