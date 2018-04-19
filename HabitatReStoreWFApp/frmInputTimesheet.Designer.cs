namespace HabitatReStoreWFApp
{
    partial class frmInputTimesheet : baseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboVolunteerCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVolunteerID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pickTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pickTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Volunteer Timesheets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStore);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboVolunteerCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboVolunteerID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.pickTimeOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pickTimeIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(990, 552);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Items.AddRange(new object[] {
            "Winston-Salem ReStore",
            "Kernersville ReStore",
            "Lewisville ReStore",
            "King ReStore"});
            this.cboStore.Location = new System.Drawing.Point(447, 354);
            this.cboStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(325, 37);
            this.cboStore.TabIndex = 18;
            this.cboStore.SelectedIndexChanged += new System.EventHandler(this.cboStore_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Store: ";
            // 
            // cboVolunteerCategory
            // 
            this.cboVolunteerCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolunteerCategory.FormattingEnabled = true;
            this.cboVolunteerCategory.Location = new System.Drawing.Point(51, 223);
            this.cboVolunteerCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVolunteerCategory.Name = "cboVolunteerCategory";
            this.cboVolunteerCategory.Size = new System.Drawing.Size(178, 37);
            this.cboVolunteerCategory.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Volunteer Type: ";
            // 
            // cboVolunteerID
            // 
            this.cboVolunteerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolunteerID.FormattingEnabled = true;
            this.cboVolunteerID.Location = new System.Drawing.Point(51, 86);
            this.cboVolunteerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVolunteerID.Name = "cboVolunteerID";
            this.cboVolunteerID.Size = new System.Drawing.Size(133, 37);
            this.cboVolunteerID.TabIndex = 1;
            this.cboVolunteerID.SelectedIndexChanged += new System.EventHandler(this.cboVolunteerID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Volunteer Id: ";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(447, 123);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(325, 35);
            this.txtLName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Name: ";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(447, 46);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(325, 35);
            this.txtFName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(530, 443);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 66);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeOut.Location = new System.Drawing.Point(447, 277);
            this.pickTimeOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.ShowUpDown = true;
            this.pickTimeOut.Size = new System.Drawing.Size(325, 35);
            this.pickTimeOut.TabIndex = 7;
            this.pickTimeOut.Value = new System.DateTime(2018, 2, 25, 12, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time Out: ";
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(447, 200);
            this.pickTimeIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.ShowUpDown = true;
            this.pickTimeIn.Size = new System.Drawing.Size(325, 35);
            this.pickTimeIn.TabIndex = 6;
            this.pickTimeIn.Value = new System.DateTime(2018, 2, 25, 12, 0, 0, 0);
            this.pickTimeIn.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time In: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HabitatReStoreWFApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(894, 57);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmInputTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1026, 709);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmInputTimesheet";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickTimeIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pickTimeOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboVolunteerID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboVolunteerCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.Label label9;
    }
}
