<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EAMUI.Admin.Likelihood.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Likelihood Admin - Update</b></p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        Score: <asp:TextBox ID="score" runat="server"></asp:TextBox>
        <br /><br />
        Critical Start: <asp:TextBox ID="criticalstart" runat="server"></asp:TextBox>
        <br /><br />
        Critical End: <asp:TextBox ID="criticalend" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnUpdate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <!--<asp:Label ID="Label1" runat="server" Text=""></asp:Label>-->

</asp:Content>
