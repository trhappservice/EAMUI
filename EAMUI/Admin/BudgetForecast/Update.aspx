<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EAMUI.Admin.BudgetForecast.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Budget Forecast Admin - Update</b></p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        Budget Year: <asp:TextBox ID="budgetyear" runat="server"></asp:TextBox>
        <br /><br />
        Budget: <asp:TextBox ID="budget" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnUpdate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <!--<asp:Label ID="Label1" runat="server" Text=""></asp:Label>-->

</asp:Content>
