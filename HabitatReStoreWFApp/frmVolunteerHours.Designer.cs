namespace HabitatReStoreWFApp
{
    partial class frmVolunteerHours
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
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbxStore = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::HabitatReStoreWFApp.Properties.Resources.habitat_for_humanity_restore_logo2;
            this.imgLogo.Location = new System.Drawing.Point(13, 55);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(450, 79);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 134);
            this.label1.TabIndex = 12;
            this.label1.Text = "Habitat for Humanity ReStore Volunteer Hours";
            // 
            // lsbxStore
            // 
            this.lsbxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbxStore.FormattingEnabled = true;
            this.lsbxStore.ItemHeight = 26;
            this.lsbxStore.Items.AddRange(new object[] {
            "Winston Salem ReStore",
            "Kernersville ReStore",
            "Lewisville ReStore",
            "King ReStore"});
            this.lsbxStore.Location = new System.Drawing.Point(600, 242);
            this.lsbxStore.Name = "lsbxStore";
            this.lsbxStore.ScrollAlwaysVisible = true;
            this.lsbxStore.Size = new System.Drawing.Size(400, 56);
            this.lsbxStore.TabIndex = 13;
            // 
            // frmVolunteerHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1026, 709);
            this.Controls.Add(this.lsbxStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLogo);
            this.Name = "frmVolunteerHours";
            this.Text = "ReStore Volunteer Hours";
            this.Controls.SetChildIndex(this.imgLogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lsbxStore, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbxStore;
    }
}