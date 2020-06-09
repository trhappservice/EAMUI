<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.Likelihood.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Likelihood Admin - Add</b></p>
        Score: <asp:TextBox ID="score" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="score" errormessage="Please enter score!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
				ControlToValidate="score" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Critical Start: <asp:TextBox ID="criticalstart" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="criticalstart" errormessage="Please enter critial start!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
				ControlToValidate="criticalstart" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Critial End: <asp:TextBox ID="criticalend" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" 
            controltovalidate="criticalend" errormessage="Please enter critical end!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
				ControlToValidate="criticalend" runat="server"
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
