using HabitatReStoreWFApp.AppData;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace HabitatReStoreWFApp
{
    public partial class frmDonationsReport : HabitatReStoreWFApp.baseForm
    {
        HabitatDataClassesDataContext db = new HabitatDataClassesDataContext();

        public frmDonationsReport()
        {
            InitializeComponent();
        }

        private void frmDonationsReport_Load(object sender, EventArgs e)
        {
            /*
            Donations_Per_StoreTableAdapter.Fill(Habitat_Restore_V2DataSet.Donations_Per_Store);
            Donations_Per_StoreBindingSource.DataSource = Donations_Per_StoreTableAdapter.GetData();

            //refresh report
            reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DonationsPerStore.rdlc";
            reportViewer.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Today.ToString("MM/dd/yyyy")));
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.RefreshReport();

            btnPrint.Enabled = true;
            */

            cboView.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportViewer.SetPageSettings(new PageSettings()
            {
                Landscape = true,
                Color = false,
                Margins = new Margins(50, 50, 50, 50)
            });
            reportViewer.PrintDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool nodata = false;
            DateTime date;
            string title;

            Donations_Per_StoreTableAdapter.Fill(Habitat_Restore_V2DataSet.Donations_Per_Store);

            if (cboView.SelectedIndex == 1)
            {
                date = pickDate.Value.Date;
                title = "Donations Per Store - Daily";

                if (Donations_Per_StoreTableAdapter.GetDataByDate(date).Count > 0)
                {
                    Donations_Per_StoreBindingSource.DataSource = Donations_Per_StoreTableAdapter.GetDataByDate(date);
                }
                else
                {
                    MessageBox.Show("There were no donations for this day.");
                    nodata = true;
                }
            }
            else
            {
                date = DateTime.Today;
                title = "Donations Per Store - Total";

                Donations_Per_StoreBindingSource.DataSource = Donations_Per_StoreTableAdapter.GetData();
            }

            if (!nodata)
            {
                //refresh report
                reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DonationsPerStore.rdlc";
                reportViewer.LocalReport.SetParameters(new ReportParameter("Date", date.ToString("MM/dd/yyyy")));
                reportViewer.LocalReport.SetParameters(new ReportParameter("ReportTitle", title));
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.RefreshReport();

                btnPrint.Enabled = true;
            }
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboView.SelectedIndex == 1)
            {
                lblDate.Visible = true;
                pickDate.Visible = true;
            }
            else
            {
                lblDate.Visible = false;
                pickDate.Visible = false;
            }
        }
    }
}
