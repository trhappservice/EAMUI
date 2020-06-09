<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.BudgetForecast.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h3>Enterprise Asset Management UI</h3>
        <p><b>Budget Forecast Admin - Add</b></p>
        Budget Year: <asp:TextBox ID="budgetYear" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="budgetYear" errormessage="Please enter budget year!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
				ControlToValidate="budgetYear" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Budget: $<asp:TextBox ID="budget" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="budget" errormessage="Please enter budget!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
				ControlToValidate="budget" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="^\d+\.?\d*$"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnCreate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
