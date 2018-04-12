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
            this.label1 = new System.Windows.Forms.Label();
            this.lstPickups = new System.Windows.Forms.ListView();
            this.donationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.store = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialInstructions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPickups)).BeginInit();
            this.SuspendLayout();
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
            // lstPickups
            // 
            this.lstPickups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.donationID,
            this.store,
            this.address,
            this.address2,
            this.city,
            this.state,
            this.zipcode,
            this.pickupDate,
            this.pickupStart,
            this.pickupEnd,
            this.specialInstructions});
            this.lstPickups.Location = new System.Drawing.Point(12, 165);
            this.lstPickups.Name = "lstPickups";
            this.lstPickups.Size = new System.Drawing.Size(919, 307);
            this.lstPickups.TabIndex = 34;
            this.lstPickups.UseCompatibleStateImageBehavior = false;
            this.lstPickups.View = System.Windows.Forms.View.Details;
            // 
            // donationID
            // 
            this.donationID.Text = "Donation ID";
            this.donationID.Width = 70;
            // 
            // store
            // 
            this.store.Text = "Store";
            this.store.Width = 110;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 100;
            // 
            // address2
            // 
            this.address2.Text = "Address 2";
            this.address2.Width = 100;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 80;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.Width = 50;
            // 
            // zipcode
            // 
            this.zipcode.Text = "Zip";
            // 
            // pickupDate
            // 
            this.pickupDate.Text = "Date";
            this.pickupDate.Width = 80;
            // 
            // pickupStart
            // 
            this.pickupStart.Text = "Window Start";
            this.pickupStart.Width = 80;
            // 
            // pickupEnd
            // 
            this.pickupEnd.Text = "Window End";
            this.pickupEnd.Width = 80;
            // 
            // specialInstructions
            // 
            this.specialInstructions.Text = "Special Instructions";
            this.specialInstructions.Width = 110;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(685, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 53);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(77, 92);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(241, 28);
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
            this.label3.Location = new System.Drawing.Point(340, 92);
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
            this.pickDate.Location = new System.Drawing.Point(399, 92);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(150, 26);
            this.pickDate.TabIndex = 39;
            this.pickDate.Value = new System.DateTime(2018, 4, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "No. of Pickups:";
            // 
            // nudNumPickups
            // 
            this.nudNumPickups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumPickups.Location = new System.Drawing.Point(154, 133);
            this.nudNumPickups.Name = "nudNumPickups";
            this.nudNumPickups.Size = new System.Drawing.Size(69, 26);
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
            this.cboDriver.Location = new System.Drawing.Point(399, 132);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(150, 28);
            this.cboDriver.TabIndex = 44;
            this.cboDriver.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboDriverFormat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Driver:";
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSchedule.Location = new System.Drawing.Point(596, 92);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(103, 64);
            this.btnGenerateSchedule.TabIndex = 45;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(857, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(596, 478);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(83, 53);
            this.btnAccept.TabIndex = 47;
            this.btnAccept.Text = "Accept?";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // frmDailyPickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(943, 543);
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
            this.Controls.Add(this.lstPickups);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDailyPickups";
            this.Text = "Daily Pickups";
            this.Load += new System.EventHandler(this.frmDailyPickups_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lstPickups, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPickups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstPickups;
        private System.Windows.Forms.ColumnHeader donationID;
        private System.Windows.Forms.ColumnHeader store;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader address2;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader zipcode;
        private System.Windows.Forms.ColumnHeader pickupDate;
        private System.Windows.Forms.ColumnHeader pickupStart;
        private System.Windows.Forms.ColumnHeader pickupEnd;
        private System.Windows.Forms.ColumnHeader specialInstructions;
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
    }
}