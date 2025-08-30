using LAB_007.EmployeesDataSetTableAdapters;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_007
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ReportViewer1.Visible = true;
            }
        }

        protected void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesTableAdapter tableAdapter = new EmployeesTableAdapter();
                DataTable dataTable = tableAdapter.GetData();

                if (dataTable.Rows.Count > 0)
                {
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);
                    ReportViewer1.LocalReport.DataSources.Add(rds);
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Employees.rdlc");

                    ReportViewer1.Visible = true;
                }
                else
                {
                    Response.Write("else");
                }
            }
            catch (Exception ex)
            {
                Response.Write("catch");
            }
        }
    }
}