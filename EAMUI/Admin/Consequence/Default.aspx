<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="Default.aspx.cs" Inherits="EAMUI.Admin.Consequence.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Consequence Admin</b></p>
    <div>  
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <a href="./Add">Add New</a>
        <br /><br />
        <a href="../Default.aspx">Back to main admin</a>
    </div>  

</asp:Content>

