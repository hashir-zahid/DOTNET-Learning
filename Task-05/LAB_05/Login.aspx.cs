using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_05
{
    public partial class Login : System.Web.UI.Page
    {
        DBConnection db = new DBConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool success = db.Login(username, password);

            if(success)
            {
                     Response.Redirect("~/HodPage.aspx", true);
            }
            else
            {
                lblError.Text = "Error!!!!!!!!";
            }
        }
    }
}