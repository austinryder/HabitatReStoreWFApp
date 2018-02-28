namespace HabitatReStoreWFApp
{
    partial class frmMain
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 87);
            this.label1.TabIndex = 11;
            this.label1.Text = "Habitat for Humanity ReStore Management App";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::HabitatReStoreWFApp.Properties.Resources.logo_2;
            this.picLogo.Location = new System.Drawing.Point(12, 37);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(147, 170);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
