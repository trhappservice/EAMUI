<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="EAMUI.Admin.Likelihood.Delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Likelihood Admin - Delete</b></p>
    <b>Please confirm if you want to delete this record:</b><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br /><br />
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Delete" onClick="btnDelete_Click"/>
    <br /><br />
        <a href="./Default.aspx">Back to admin</a>
</asp:Content>
