<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.ActivityCost.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Activity Cost Admin - Add</b></p>
        Name: <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="reqName" 
            controltovalidate="name" errormessage="Please enter activity name!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <br /><br />
        Description: <asp:TextBox ID="description" runat="server"></asp:TextBox><br /><br />
        Start Trigger: <asp:TextBox ID="starttrigger" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="starttrigger" errormessage="Please enter start trigger!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
				ControlToValidate="starttrigger" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        End Trigger: <asp:TextBox ID="endtrigger" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="endtrigger" errormessage="Please enter end trigger!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
				ControlToValidate="endtrigger" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Reset: <asp:TextBox ID="reset" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" 
            controltovalidate="reset" errormessage="Please enter reset value!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3"
				ControlToValidate="reset" runat="server"
				ErrorMessage="Only Numbers allowed"
				ValidationExpression="\d+"
                SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000">
		</asp:RegularExpressionValidator><br /><br />
        Unit Cost: <asp:TextBox ID="unitcost" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator4" 
            controltovalidate="unitcost" errormessage="Please enter unit cost!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4"
				ControlToValidate="unitcost" runat="server"
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
