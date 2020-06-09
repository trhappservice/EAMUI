<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.Lifecycle.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Lifecycle Admin - Add</b></p>
        C_1: <asp:TextBox ID="c1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="c1" errormessage="Please enter C1 value!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnCreate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
