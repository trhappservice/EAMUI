<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EAMUI.Admin.BudgetForecast.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Budget Forecast Admin</b></p>
    <div>  
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <a href="./Add">Add New</a>
        <br /><br />
        <a href="../Default.aspx">Back to main admin</a>
    </div>  

</asp:Content>