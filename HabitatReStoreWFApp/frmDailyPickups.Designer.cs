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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Donation_PickUp_ScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Habitat_Restore_V2DataSet = new HabitatReStoreWFApp.Habitat_Restore_V2DataSet();
            this.DonationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumPickups = new System.Windows.Forms.NumericUpDown();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Donation_PickUp_ScheduleTableAdapter = new HabitatReStoreWFApp.Habitat_Restore_V2DataSetTableAdapters.Donation_PickUp_ScheduleTableAdapter();
            this.DonationTableAdapter = new HabitatReStoreWFApp.Habitat_Restore_V2DataSetTableAdapters.DonationTableAdapter();
            this.StoreTableAdapter = new HabitatReStoreWFApp.Habitat_Restore_V2DataSetTableAdapters.StoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Donation_PickUp_ScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitat_Restore_V2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPickups)).BeginInit();
            this.SuspendLayout();
            // 
            // Donation_PickUp_ScheduleBindingSource
            // 
            this.Donation_PickUp_ScheduleBindingSource.DataMember = "Donation_PickUp_Schedule";
            this.Donation_PickUp_ScheduleBindingSource.DataSource = this.Habitat_Restore_V2DataSet;
            // 
            // Habitat_Restore_V2DataSet
            // 
            this.Habitat_Restore_V2DataSet.DataSetName = "Habitat_Restore_V2DataSet";
            this.Habitat_Restore_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DonationBindingSource
            // 
            this.DonationBindingSource.DataMember = "Donation";
            this.DonationBindingSource.DataSource = this.Habitat_Restore_V2DataSet;
            // 
            // StoreBindingSource
            // 
            this.StoreBindingSource.DataMember = "Store";
            this.StoreBindingSource.DataSource = this.Habitat_Restore_V2DataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HabitatReStoreWFApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Daily Pickups";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(836, 91);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 65);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(77, 92);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(341, 28);
            this.cboStore.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Store:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date:";
            // 
            // pickDate
            // 
            this.pickDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate.Location = new System.Drawing.Point(77, 132);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(160, 26);
            this.pickDate.TabIndex = 39;
            this.pickDate.Value = new System.DateTime(2018, 4, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "No. of Pickups:";
            // 
            // nudNumPickups
            // 
            this.nudNumPickups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumPickups.Location = new System.Drawing.Point(566, 92);
            this.nudNumPickups.Name = "nudNumPickups";
            this.nudNumPickups.Size = new System.Drawing.Size(48, 26);
            this.nudNumPickups.TabIndex = 42;
            this.nudNumPickups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumPickups.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cboDriver
            // 
            this.cboDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(332, 132);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(282, 28);
            this.cboDriver.TabIndex = 44;
            this.cboDriver.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboDriverFormat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Driver:";
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSchedule.Location = new System.Drawing.Point(635, 92);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(93, 64);
            this.btnGenerateSchedule.TabIndex = 45;
            this.btnGenerateSchedule.Text = "&Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(857, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(734, 91);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(95, 65);
            this.btnAccept.TabIndex = 47;
            this.btnAccept.Text = "&Accept?";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource9.Name = "PickupSchedules";
            reportDataSource9.Value = this.Donation_PickUp_ScheduleBindingSource;
            reportDataSource10.Name = "Donations";
            reportDataSource10.Value = this.DonationBindingSource;
            reportDataSource11.Name = "Store";
            reportDataSource11.Value = this.StoreBindingSource;
            reportDataSource12.Name = "Driver";
            reportDataSource12.Value = null;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DailyPickups.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 166);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowToolBar = false;
            this.reportViewer.Size = new System.Drawing.Size(919, 426);
            this.reportViewer.TabIndex = 48;
            // 
            // Donation_PickUp_ScheduleTableAdapter
            // 
            this.Donation_PickUp_ScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // DonationTableAdapter
            // 
            this.DonationTableAdapter.ClearBeforeFill = true;
            // 
            // StoreTableAdapter
            // 
            this.StoreTableAdapter.ClearBeforeFill = true;
            // 
            // frmDailyPickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(943, 604);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerateSchedule);
            this.Controls.Add(this.cboDriver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudNumPickups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDailyPickups";
            this.Text = "Daily Pickups";
            this.Load += new System.EventHandler(this.frmDailyPickups_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboStore, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pickDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.nudNumPickups, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cboDriver, 0);
            this.Controls.SetChildIndex(this.btnGenerateSchedule, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.reportViewer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Donation_PickUp_ScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitat_Restore_V2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPickups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumPickups;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccept;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource Donation_PickUp_ScheduleBindingSource;
        private Habitat_Restore_V2DataSet Habitat_Restore_V2DataSet;
        private System.Windows.Forms.BindingSource DonationBindingSource;
        private System.Windows.Forms.BindingSource StoreBindingSource;
        private Habitat_Restore_V2DataSetTableAdapters.Donation_PickUp_ScheduleTableAdapter Donation_PickUp_ScheduleTableAdapter;
        private Habitat_Restore_V2DataSetTableAdapters.DonationTableAdapter DonationTableAdapter;
        private Habitat_Restore_V2DataSetTableAdapters.StoreTableAdapter StoreTableAdapter;
    }
}