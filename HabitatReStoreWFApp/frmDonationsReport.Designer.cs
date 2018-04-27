﻿namespace HabitatReStoreWFApp
{
    partial class frmDonationsReport : baseForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Donations_Per_StoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Habitat_Restore_V2DataSet = new HabitatReStoreWFApp.Habitat_Restore_V2DataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pickDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.Donations_Per_StoreTableAdapter = new HabitatReStoreWFApp.Habitat_Restore_V2DataSetTableAdapters.Donations_Per_StoreTableAdapter();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.pickDateTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Donations_Per_StoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitat_Restore_V2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Donations_Per_StoreBindingSource
            // 
            this.Donations_Per_StoreBindingSource.DataMember = "Donations_Per_Store";
            this.Donations_Per_StoreBindingSource.DataSource = this.Habitat_Restore_V2DataSet;
            // 
            // Habitat_Restore_V2DataSet
            // 
            this.Habitat_Restore_V2DataSet.DataSetName = "Habitat_Restore_V2DataSet";
            this.Habitat_Restore_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DonationsPerStore";
            reportDataSource1.Value = this.Donations_Per_StoreBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DonationsPerStore.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 136);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowToolBar = false;
            this.reportViewer.Size = new System.Drawing.Size(919, 456);
            this.reportViewer.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(856, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Donations per Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HabitatReStoreWFApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(836, 76);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 54);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pickDateFrom
            // 
            this.pickDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateFrom.Location = new System.Drawing.Point(378, 100);
            this.pickDateFrom.Name = "pickDateFrom";
            this.pickDateFrom.Size = new System.Drawing.Size(127, 26);
            this.pickDateFrom.TabIndex = 37;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(312, 102);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 24);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "From:";
            // 
            // cboView
            // 
            this.cboView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboView.FormattingEnabled = true;
            this.cboView.Items.AddRange(new object[] {
            "Total Donations",
            "Donations Over Time Period"});
            this.cboView.Location = new System.Drawing.Point(75, 102);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(215, 28);
            this.cboView.TabIndex = 39;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "View:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(735, 76);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 54);
            this.btnGenerate.TabIndex = 41;
            this.btnGenerate.Text = "&Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Donations_Per_StoreTableAdapter
            // 
            this.Donations_Per_StoreTableAdapter.ClearBeforeFill = true;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(533, 102);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(38, 24);
            this.lblDate2.TabIndex = 43;
            this.lblDate2.Text = "To:";
            // 
            // pickDateTo
            // 
            this.pickDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateTo.Location = new System.Drawing.Point(577, 100);
            this.pickDateTo.Name = "pickDateTo";
            this.pickDateTo.Size = new System.Drawing.Size(127, 26);
            this.pickDateTo.TabIndex = 42;
            // 
            // frmDonationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(943, 604);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.pickDateTo);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pickDateFrom);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmDonationsReport";
            this.Load += new System.EventHandler(this.frmDonationsReport_Load);
            this.Controls.SetChildIndex(this.reportViewer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.pickDateFrom, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.cboView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.pickDateTo, 0);
            this.Controls.SetChildIndex(this.lblDate2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Donations_Per_StoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitat_Restore_V2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private Habitat_Restore_V2DataSet Habitat_Restore_V2DataSet;
        private System.Windows.Forms.DateTimePicker pickDateFrom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource Donations_Per_StoreBindingSource;
        private Habitat_Restore_V2DataSetTableAdapters.Donations_Per_StoreTableAdapter Donations_Per_StoreTableAdapter;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.DateTimePicker pickDateTo;
    }
}
