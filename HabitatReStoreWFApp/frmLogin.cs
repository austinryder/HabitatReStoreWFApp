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
    public partial class frmLogin : Form
    {
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool authorized = false;

            string user = txtUser.Text;
            string password = txtPassword.Text;

            var manager = from ml in db.Manager_LogIns
                          where ml.UserName == user && ml.Password == password
                          select ml;

            try
            {
                if (manager.Count() == 0)
                {
                    authorized = false;
                    MessageBox.Show("Incorrect Username and Password");
                }
                else
                {
                    authorized = true;
                }

                if (authorized)
                {
                    frmMain main = new frmMain();
                    this.Hide();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database");
                Console.WriteLine(ex);
            }
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
