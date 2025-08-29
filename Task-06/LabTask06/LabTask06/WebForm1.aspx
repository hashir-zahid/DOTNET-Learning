<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LabTask06.WebForm1" %>





<!DOCTYPE html>
<html>
<head runat="server">
    <title>Calculator</title>
    <!-- Bootstrap 5 CDN -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css">
</head>
<body class="bg-light">

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow-lg p-4">
                    <h2 class="text-center text-primary mb-4">Area Calculator</h2>

                    <form id="form1" runat="server">
                        <!-- Input for Number 1 -->
                        <div class="mb-3">
                            <label for="txtNum1" class="form-label">Number 1</label>
                            <asp:TextBox ID="txtNum1" runat="server" CssClass="form-control" placeholder="Enter first number"></asp:TextBox>
                        </div>

                        <!-- Input for Number 2 -->
                        <div class="mb-3">
                            <label for="txtNum2" class="form-label">Number 2</label>
                            <asp:TextBox ID="txtNum2" runat="server" CssClass="form-control" placeholder="Enter second number"></asp:TextBox>
                        </div>

                        <!-- Calculator Buttons -->
                        <div class="d-grid gap-2 d-md-flex justify-content-center">
                            <asp:Button ID="btnAdd" runat="server" Text="Square" CssClass="btn btn-primary" OnClick="btnsquare_Click" />
                            <asp:Button ID="btnSubtract" runat="server" Text="Rectangle" CssClass="btn btn-danger" OnClick="btnrectangle_Click" />
                            <asp:Button ID="btnMultiply" runat="server" Text="Triangle" CssClass="btn btn-warning" OnClick="btntriangle_Click" />
                            <asp:Button ID="btnDivide" runat="server" Text="Circle" CssClass="btn btn-success" OnClick="btncircle_Click" />                    
                        </div>

                        <!-- Result Display -->
                        <div class="mt-4 text-center">
                            <asp:Label ID="lblResult" runat="server" CssClass="h4 text-dark"></asp:Label>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap JavaScript (Optional for advanced features) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>






</body>
</html>


                                        


