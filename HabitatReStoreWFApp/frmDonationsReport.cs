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
            cboView.SelectedIndex = 0;
            pickDateTo.Value = DateTime.Today;
            pickDateFrom.Value = DateTime.Today;
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
            DateTime dateTo, dateFrom;
            string title;
            string dateLabel = "";

            if (cboView.SelectedIndex == 1)
            {
                dateTo = pickDateTo.Value.Date;
                dateFrom = pickDateFrom.Value.Date;
                title = "Donations Per Store";

                if (Donations_Per_StoreTableAdapter.GetData(dateTo, dateFrom).Count > 0)
                {
                    Donations_Per_StoreBindingSource.DataSource = Donations_Per_StoreTableAdapter.GetData(dateTo, dateFrom);
                    dateLabel = dateFrom.ToString("MM/dd/yyyy") + " - " + dateTo.ToString("MM/dd/yyyy");
                }
                else
                {
                    MessageBox.Show("There were no donations over this time period");
                    nodata = true;
                }
            }
            else
            {
                title = "Donations Per Store - Total";

                //adds year to today - because some donations are scheduled in advance
                Donations_Per_StoreBindingSource.DataSource = Donations_Per_StoreTableAdapter.GetData(DateTime.Today.AddYears(1), null);
                dateLabel = DateTime.Today.ToString("MM/dd/yyyy");
            }

            if (!nodata)
            {
                //refresh report
                reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.DonationsPerStore.rdlc";
                reportViewer.LocalReport.SetParameters(new ReportParameter("Date", dateLabel));
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
                pickDateFrom.Visible = true;
                lblDate2.Visible = true;
                pickDateTo.Visible = true;
            }
            else
            {
                lblDate.Visible = false;
                pickDateFrom.Visible = false;
                lblDate2.Visible = false;
                pickDateTo.Visible = false;
            }
        }
    }
}
