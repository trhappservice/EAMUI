<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.TLOS.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Technical Level of Service (TLOS) Admin - Add</b></p>
        Name: <asp:TextBox ID="name" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="name" errormessage="Please enter the name!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <br /><br />
        Target: <asp:TextBox ID="target" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="target" errormessage="Please enter target score!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
				ControlToValidate="target" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Failure: <asp:TextBox ID="failure" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" 
            controltovalidate="failure" errormessage="Please enter the failure score!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
				ControlToValidate="failure" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnCreate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
