<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Asset Registry Admin</b></p>
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Batch Update by Excel" OnClick="BatchUpdate_Click"></asp:Button>
        <br /><br />
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Update indiviual Asset" OnClick="SearchAsset_Click"></asp:Button>
        <br /><br />
        <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Update by Asset Class/Type/Subtype" OnClick="Updateby_Click"></asp:Button>
        <br /><br />
        <a href="../Default.aspx">Back to main admin</a>
</asp:Content>