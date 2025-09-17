<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LAB_05.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login - Modern UI</title>
    
    <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    
    <!-- Font Awesome for Icons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" />
    
    <!-- Custom Styles -->
    <style>
        body {
            background: linear-gradient(135deg, #2c3e50, #4ca1af);
            font-family: 'Arial', sans-serif;
            height: 100vh;
        }

        .login-container {
            width: 350px;
            background: #fff;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.2);
        }

        .form-control {
            border-radius: 50px;
            padding: 12px;
        }

        .input-group-text {
            border-radius: 50px 0 0 50px;
        }

        .btn-login {
            border-radius: 50px;
            font-weight: bold;
            transition: 0.3s;
        }

        .btn-login:hover {
            background: #3498db;
            color: white;
            transform: scale(1.05);
        }

        .error-message {
            font-size: 14px;
        }

        .login-header {
            color: #3498db;
        }
    </style>
</head>
<body class="d-flex justify-content-center align-items-center">
    <form id="form1" runat="server">
        <div class="login-container text-center">
            <h2 class="login-header"><i class="fa fa-user-circle"></i> User Login</h2>
            <p class="text-muted">Sign in to continue</p>

            <!-- Username Field -->
            <div class="mb-3 input-group">
                <span class="input-group-text"><i class="fa fa-user"></i></span>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter your username"></asp:TextBox>
            </div>

            <!-- Password Field -->
            <div class="mb-3 input-group">
                <span class="input-group-text"><i class="fa fa-lock"></i></span>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter your password"></asp:TextBox>
            </div>

            <!-- Login Button -->
            <div class="d-grid">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary btn-login btn-lg" OnClick="btnLogin_Click" />
            </div>

            <!-- Error Message -->
            <asp:Label ID="lblError" runat="server" CssClass="text-danger text-center d-block mt-3 error-message"></asp:Label>

            <!-- Signup Link -->
            <p class="mt-3 text-muted">Don't have an account? <a href="Signup.aspx" class="text-primary">Sign up here</a></p>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
