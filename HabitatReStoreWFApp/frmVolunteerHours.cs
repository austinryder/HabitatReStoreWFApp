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
    public partial class frmVolunteerHours : baseForm
    {
        public frmVolunteerHours()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalTime1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp = 0;
            try
            {
                if (txtTotalTime1.Text != "")
                    temp = double.Parse(txtTotalTime1.Text);
                if (txtTotalTime2.Text != "")
                    temp += double.Parse(txtTotalTime2.Text);
                if (txtTotalTime3.Text != "")
                    temp += double.Parse(txtTotalTime3.Text);
                if (txtTotalTime4.Text != "")
                    temp += double.Parse(txtTotalTime4.Text);
                if (txtTotalTime5.Text != "")
                    temp += double.Parse(txtTotalTime5.Text);
                if (txtTotalTime6.Text != "")
                    temp += double.Parse(txtTotalTime6.Text);
                if (txtTotalTime7.Text != "")
                    temp += double.Parse(txtTotalTime7.Text);
                if (txtTotalTime8.Text != "")
                    temp += double.Parse(txtTotalTime8.Text);
                if (txtTotalTime9.Text != "")
                    temp += double.Parse(txtTotalTime9.Text);
                if (txtTotalTime10.Text != "")
                    temp += double.Parse(txtTotalTime10.Text);
                if (txtTotalTime11.Text != "")
                    temp += double.Parse(txtTotalTime11.Text);

                txtTotalHours.Text = temp.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("You must enter a number");
            }
        }

            private void txtTotalHours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
