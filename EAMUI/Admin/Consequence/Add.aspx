<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Add.aspx.cs" Inherits="EAMUI.Admin.Consequence.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Consequence Admin - Add</b></p>
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
        AssetSubType: <asp:DropDownList ID="assetsubtypeList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="assetsubtypeList" errormessage="Please enter Asset Subtype!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        <br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnCreate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>