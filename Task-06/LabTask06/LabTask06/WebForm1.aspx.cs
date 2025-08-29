using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorLibrary;

namespace LabTask06
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        math2 cal = new math2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsquare_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtNum1.Text);            
                lblResult.Text = "Area of square is " + cal.square(a);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        protected void btnrectangle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtNum1.Text);
                int b = int.Parse(txtNum2.Text);
                lblResult.Text = "Area of rectangle is " + cal.rectangle(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        protected void btntriangle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtNum1.Text);
                int b = int.Parse(txtNum2.Text);
                lblResult.Text = "Area of triangle is " + cal.traingle(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        protected void btncircle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtNum1.Text);
                lblResult.Text = "Area of circle is " + cal.circle(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}