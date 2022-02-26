using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBDS
{
    public partial class F4_frmR1 : Form
    {
        public F4_frmR1()
        {
            InitializeComponent();
        }
        private void UpdateReport(DateTime StartDate, DateTime EndDate)
        {

            // TODO: This line of code loads data into the 'DMUBoxDataSet.Sproc_ordersBetweenDates' table. You can move, or remove it, as needed.
            this.sproc_R1TableAdapter.Fill(this.Sukhman_Lidder_ConsultantsdBDataSet.sproc_R1, StartDate, EndDate);

            //pass the parameter list to the report
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CBDS.R1.rdlc";
            List<Microsoft.Reporting.WinForms.ReportParameter> listReportParameter = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            listReportParameter.Add(new Microsoft.Reporting.WinForms.ReportParameter("rpStartDate", Convert.ToString(StartDate)));
            listReportParameter.Add(new Microsoft.Reporting.WinForms.ReportParameter("rpEndDate", Convert.ToString(EndDate)));
            this.reportViewer1.LocalReport.SetParameters(listReportParameter);

            this.reportViewer1.RefreshReport();

            
        }
        private void frmR1_Load(object sender, EventArgs e)
        {
            //decalre date variables to use in this form and initialise them
            DateTime StartDate = Convert.ToDateTime("January 1 1900");
            DateTime EndDate = Convert.ToDateTime("December 31 2030");

            //make endDate the day of the last appointment
            EndDate = Convert.ToDateTime("December 31 1997");
            //say a month is 30 days timespan parameter D, H, M, S
            TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
            //make start date 30 days before endDate
            StartDate = EndDate.Subtract(aMonth);

            //asign to date time picker controls
            dtpStartDate.Text = Convert.ToString(StartDate);
            dtpEndDate.Text = Convert.ToString(EndDate);

            this.UpdateReport(StartDate, EndDate);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //decalre date variables to use in this form and initialise them
            DateTime StartDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime EndDate = Convert.ToDateTime(dtpEndDate.Text);

            this.UpdateReport(StartDate, EndDate);


        }
    }
}
