<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab04.Home" MasterPageFile="~/Site1.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5 text-center">
        <h1 class="display-4">We Are a Branding Agency</h1>
        <p class="lead">Love <strong>Design</strong> With <span class="text-danger">Your Soul</span></p>
        <p>For service design and interactive design projects, we will always validate our design ideas with user testing and research.</p>

        <div class="input-group mt-4 mx-auto" style="max-width: 500px;">
            <input type="text" class="form-control" placeholder="Search all services" aria-label="Search">
            <div class="input-group-append">
                <button class="btn btn-danger" type="button">🔍</button>
            </div>
        </div>

        <!-- ✅ ADD MISSING CONTROLS HERE -->
        <div class="mt-4">
            <asp:TextBox ID="txtInput" runat="server" CssClass="form-control" Placeholder="Enter text"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary mt-2" Text="Submit" OnClick="btnSubmit_Click"/>
            <asp:Label ID="lblMessage" runat="server" CssClass="text-success mt-2"></asp:Label>
        </div>

        <div class="row mt-5 mb-5">
            <div class="col-md-4">
                <img src="images/premium_photo-1663089947516-e1576ff3ed95.jpeg" class="img-fluid rounded" alt="VR">
            </div>
            <div class="col-md-4">
                <img src="images/12innovation-print-videoSixteenByNine3000.jpg" class="img-fluid rounded" alt="Innovation">
            </div>
            <div class="col-md-4">
                <img src="images/66976f87a4c70b556b5ab6c08f1553177a8cab27-3000x1687.jpg" class="img-fluid rounded" alt="Security">
            </div>
        </div>
    </div>
</asp:Content>

