<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EAMUI.Admin.ActivityCost.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
    <p><b>Activity Cost Admin - Update</b></p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        Name: <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br /><br />
        Description: <asp:TextBox ID="description" runat="server"></asp:TextBox>
        <br /><br />
        Start Trigger: <asp:TextBox ID="starttrigger" runat="server"></asp:TextBox>
        <br /><br />
        End Trigger: <asp:TextBox ID="endtrigger" runat="server"></asp:TextBox>
        <br /><br />
        Reset: <asp:TextBox ID="reset" runat="server"></asp:TextBox>
        <br /><br />
        Unit Cost: <asp:TextBox ID="unitcost" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnUpdate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <!--<asp:Label ID="Label1" runat="server" Text=""></asp:Label>-->

</asp:Content>
