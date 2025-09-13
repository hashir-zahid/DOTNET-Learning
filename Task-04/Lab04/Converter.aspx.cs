using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab04
{
    public partial class Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTemperature.Text, out double inputTemp))
            {
                double resultTemp = 0;
                string conversionType = ddlConversionType.SelectedValue;

                if (conversionType == "FtoC")
                {
                    resultTemp = (inputTemp - 32) * 5 / 9;
                    lblResult.Text = $"Temperature in Celsius: {resultTemp:F2}°C";
                }
                else if (conversionType == "CtoF")
                {
                    resultTemp = (inputTemp * 9 / 5) + 32;
                    lblResult.Text = $"Temperature in Fahrenheit: {resultTemp:F2}°F";
                }
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }
    }
}