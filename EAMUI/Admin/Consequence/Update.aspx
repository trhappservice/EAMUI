<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Update.aspx.cs" Inherits="EAMUI.Admin.Consequence.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Consequence Admin - Update</b></p>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        Score: <asp:TextBox ID="score" runat="server"></asp:TextBox>
        <br /><br />
        AssetSubType: <asp:DropDownList ID="assetsubtypeSelectList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <br /><br />
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnUpdate"/>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <!--<asp:Label ID="Label1" runat="server" Text=""></asp:Label>-->

</asp:Content>
