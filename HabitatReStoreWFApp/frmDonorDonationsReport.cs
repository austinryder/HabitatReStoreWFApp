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
    public partial class frmDonorDonationsReport : HabitatReStoreWFApp.baseForm
    {
        public frmDonorDonationsReport()
        {
            InitializeComponent();
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

        private void frmDonorDonationsReport_Load(object sender, EventArgs e)
        {
            cboView.SelectedIndex = 0;
            pickDateFrom.Value = DateTime.Today;
            pickDateTo.Value = DateTime.Today;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool nodata = false;
            bool completed;
            DateTime dateTo, dateFrom;
            string title;
            string dateLabel = "";

            if (cboView.SelectedIndex == 0)
            {
                dateTo = pickDateTo.Value.Date;
                dateFrom = pickDateFrom.Value.Date;
                completed = true;
                title = "Donations Per Donor - Completed";
            }
            else
            {
                dateTo = pickDateTo.Value.Date;
                dateFrom = pickDateFrom.Value.Date;
                completed = false;
                title = "Donations Per Donor - Not Completed";
            }

            if (Donations_By_Donor_And_DateTableAdapter.GetData(dateTo, dateFrom, completed).Count > 0)
            {
                Donations_By_Donor_And_DateBindingSource.DataSource = Donations_By_Donor_And_DateTableAdapter.GetData(dateTo, dateFrom, completed);
                dateLabel = dateFrom.ToString("MM/dd/yyyy") + " - " + dateTo.ToString("MM/dd/yyyy");
            }
            else
            {
                MessageBox.Show("There were no donations over this time period");
                nodata = true;
            }

            if (!nodata)
            {
                //refresh report
                reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DonorDonations.rdlc";
                reportViewer.LocalReport.SetParameters(new ReportParameter("Date", dateLabel));
                reportViewer.LocalReport.SetParameters(new ReportParameter("ReportTitle", title));
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.RefreshReport();

                btnPrint.Enabled = true;
            }
        }
    }
}
