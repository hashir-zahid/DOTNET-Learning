<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUP.aspx.cs" Inherits="LAB_05.SignUP" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup - Modern WebApp</title>
    <!-- Bootstrap 5 CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="Content/StyleSheet.css" />
    <!-- Font Awesome for Icons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" />
    
    <script>
        function validateForm() {
            let isValid = true;

            let username = document.getElementById('<%= txtUserName.ClientID %>').value.trim();
            let password = document.getElementById('<%= txtPassword.ClientID %>').value.trim();
            let accessLevel = document.getElementById('<%= ddlAccessLevel.ClientID %>').value;
            let status = document.getElementById('<%= ddlStatus.ClientID %>').value;
            let errorMsg = "";

            if (username === "") {
                errorMsg += "Username is required.<br>";
                isValid = false;
            }

            if (password === "") {
                errorMsg += "Password is required.<br>";
                isValid = false;
            }

            if (accessLevel === "Select") {
                errorMsg += "Please select an access level.<br>";
                isValid = false;
            }

            if (status === "Select") {
                errorMsg += "Please select account status.<br>";
                isValid = false;
            }

            document.getElementById("errorMessages").innerHTML = errorMsg;
            return isValid;
        }
    </script>
</head>
<body class="d-flex justify-content-center align-items-center vh-100 bg-light">
    <form id="form1" runat="server" onsubmit="return validateForm();">
        <div class="card shadow-lg p-4 rounded" style="width: 400px;">
            <h2 class="text-center text-primary"><i class="fa fa-user-plus"></i> Create an Account</h2>
            <p class="text-muted text-center">Signup to get started</p>

            <!-- Error Messages -->
            <div id="errorMessages" class="text-danger text-center"></div>

            <!-- Username -->
            <div class="mb-3 input-group">
                <span class="input-group-text"><i class="fa fa-user"></i></span>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter your username"></asp:TextBox>
            </div>

            <!-- Password -->
            <div class="mb-3 input-group">
                <span class="input-group-text"><i class="fa fa-lock"></i></span>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter your password"></asp:TextBox>
            </div>

            <!-- Access Level -->
            <div class="mb-3">
                <label class="form-label"><i class="fa fa-key"></i> Access Level</label>
                <asp:DropDownList ID="ddlAccessLevel" runat="server" CssClass="form-select">
                    <asp:ListItem Value="Select">-- Select Access Level --</asp:ListItem>
                    <asp:ListItem Value="0">Admin</asp:ListItem>
                    <asp:ListItem Value="1">HOD</asp:ListItem>
                    <asp:ListItem Value="2">Coordinator</asp:ListItem>
                    <asp:ListItem Value="3">Faculty</asp:ListItem>
                    <asp:ListItem Value="4">Student</asp:ListItem>
                </asp:DropDownList>
            </div>

            <!-- Status -->
            <div class="mb-3">
                <label class="form-label"><i class="fa fa-toggle-on"></i> Account Status</label>
                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-select">
                    <asp:ListItem Value="Select">-- Select Status --</asp:ListItem>
                    <asp:ListItem Value="0">Inactive</asp:ListItem>
                    <asp:ListItem Value="1">Active</asp:ListItem>
                </asp:DropDownList>
            </div>

            <!-- Signup Button -->
            <div class="d-grid">
                <asp:Button ID="btnSignup" runat="server" Text="Sign Up" CssClass="btn btn-success btn-lg fw-bold" OnClick="btnSignup_Click" />
            </div>

            <!-- Login Button -->
            <div class="d-grid mt-2">
                <asp:Button ID="btnLogin" runat="server" Text="Already have an account? Login" CssClass="btn btn-outline-primary" OnClick="btnLogin_Click" CausesValidation="false"/>
            </div>

            <!-- Server-Side Error Message -->
            <asp:Label ID="lblMessage" runat="server" CssClass="text-danger text-center d-block mt-3"></asp:Label>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>


