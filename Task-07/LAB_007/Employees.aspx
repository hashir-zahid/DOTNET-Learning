<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="LAB_007.Employees" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" 
Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %> 
<!DOCTYPE html> 
<html> 
<head runat="server"> 
<title>Employee Report</title> 
</head> 
<body> 
<form id="form1" runat="server"> 
<asp:ScriptManager ID="ScriptManager1" 
runat="server"></asp:ScriptManager> 
<div> 
<asp:Button ID="btnViewReport" runat="server" Text="View Report" 
OnClick="btnViewReport_Click" /> 
<asp:Button ID="btnPrint" runat="server" Text="Print Report" 
OnClientClick="printReport(); return false;" /> 
</div> 
<rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
Height="600px" ProcessingMode="Local"> 
        </rsweb:ReportViewer> 
    </form> 
 
    <script> 
        function printReport() {
            var reportFrame = document.getElementById('<%= 
ReportViewer1.ClientID %>');
            if (reportFrame) {
                var printWindow =
                    reportFrame.getElementsByTagName("iframe")[0].contentWindow;
                printWindow.focus();
                printWindow.print();
            } else {
                alert("Report Viewer not found!");
            }
        }
    </script> 
</body> 
</html>

