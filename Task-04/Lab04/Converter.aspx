<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="Lab04.Converter" MasterPageFile="~/Site1.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card p-4">
        <h2>Temperature Converter</h2>

        <asp:Label ID="lblConversionType" runat="server" Text="Select Conversion Type:"></asp:Label>
        <asp:DropDownList ID="ddlConversionType" runat="server" CssClass="form-control">
            <asp:ListItem Text="Fahrenheit to Celsius" Value="FtoC"></asp:ListItem>
            <asp:ListItem Text="Celsius to Fahrenheit" Value="CtoF"></asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Label ID="lblInput" runat="server" Text="Enter Temperature:"></asp:Label>
        <asp:TextBox ID="txtTemperature" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Button ID="btnConvert" runat="server" CssClass="btn btn-primary" Text="Convert" OnClick="btnConvert_Click" />

        <br /><br />

        <asp:Label ID="lblResult" runat="server" CssClass="text-success"></asp:Label>
    </div>
</asp:Content>

