using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_05
{
    public partial class SignUP : System.Web.UI.Page
    {
        DBConnection db = new DBConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                ddlAccessLevel.SelectedValue == "Select" ||
                ddlStatus.SelectedValue == "Select")
             {
                 lblMessage.Text = "All Fields are Required";
                 return;
             }

             string username = txtUserName.Text;
             string password = txtPassword.Text;
             int access = int.Parse(ddlAccessLevel.SelectedValue);
             int status = int.Parse(ddlStatus.SelectedValue);

             bool success = db.SignUP(username, password, access, status);

             if (success)
             {
                 lblMessage.Text = "SuccessFully SignUP -----------";
             }
             else
             {
                 lblMessage.Text = "UnSuccesFull SignUP--------";
             }

    }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Login Button Clicked";  
            Response.Redirect("~/Login.aspx", true);
        }
    }
}