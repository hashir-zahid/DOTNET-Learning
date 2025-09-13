<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Lab04.Contact" MasterPageFile="~/Site1.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card p-4">
        <h2>Contact Us</h2>
        <p>Have questions? Reach out to us!</p>

        <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Your Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Your Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblMessage" runat="server" AssociatedControlID="txtMessage" Text="Your Message"></asp:Label>
        <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

        <br />

        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" />

        <br /><br />

        <asp:Label ID="lblResponse" runat="server" ForeColor="Green"></asp:Label>
    </div>
</asp:Content>

