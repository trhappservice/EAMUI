<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchAsset.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.SearchAsset" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Asset Registry Admin</b></p>
        <p>
            <b>Asset ID:</b> <asp:TextBox ID="txtAssetID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="txtAssetID" errormessage="Please enter Asset ID!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
            <br /><br />
            <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnSearch"/>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <p><a href="./Default.aspx">Back to Asset Registry Admin</a></p>
        
</asp:Content>
