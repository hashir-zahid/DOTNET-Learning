using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_05
{
    public partial class HodPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable dt = new DataTable();
            dt = db.LoadUser();

            if(dt.Rows.Count == 0 || dt == null)
            {
                return;
            }

            rptUsers.DataSource = dt;
            rptUsers.DataBind();
        }
    }
}