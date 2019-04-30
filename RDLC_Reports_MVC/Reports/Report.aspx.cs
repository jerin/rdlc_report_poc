using Microsoft.Reporting.WebForms;
using RDLC_Reports_MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RDLC_Reports_MVC.Reports
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report.rdlc");
                NorthwindEntities entities = new NorthwindEntities();
                ReportDataSource datasource = new ReportDataSource("Customers", (from customer in entities.Customers.Take(10)
                                                                                 select customer));
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
            }
        }
    }
}