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
    public partial class frmVolunteerHoursReport : HabitatReStoreWFApp.baseForm
    {
        public frmVolunteerHoursReport()
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

        private void frmVolunteerHoursReport_Load(object sender, EventArgs e)
        {
            pickDateFrom.Value = DateTime.Today;
            pickDateTo.Value = DateTime.Today;
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool nodata = false;
            DateTime dateTo, dateFrom;
            string dateLabel = "";

            dateTo = pickDateTo.Value.Date;
            dateFrom = pickDateFrom.Value.Date;

            if (Volunteer_Hours_Category_By_DateTableAdapter.GetData(dateFrom, dateTo).Count > 0)
            {
                Volunteer_Hours_Category_By_DateBindingSource.DataSource = Volunteer_Hours_Category_By_DateTableAdapter.GetData(dateFrom, dateTo);
                dateLabel = dateFrom.ToString("MM/dd/yyyy") + " - " + dateTo.ToString("MM/dd/yyyy");
            }
            else
            {
                MessageBox.Show("There were no volunteer hours reported over this time period");
                nodata = true;
            }

            if (!nodata)
            {
                //refresh report
                reportViewer.LocalReport.ReportEmbeddedResource = "HabitatReStoreWFApp.Reports.VolunteerHours.rdlc";
                reportViewer.LocalReport.SetParameters(new ReportParameter("Date", dateLabel));
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.RefreshReport();

                btnPrint.Enabled = true;
            }
        }
    }
}
