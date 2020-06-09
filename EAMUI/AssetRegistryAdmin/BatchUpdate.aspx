<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BatchUpdate.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.BatchUpdate" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>  
        <h3>Enterprise Asset Management UI</h3>
        <p><b>Batch Update</b></p>
        <p>Please check the format of the Excel file following this this <a href="guide.aspx">guide</a></p>
        <p><asp:FileUpload ID="FileUpload1" runat="server" /></p>
        <p><asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Upload" /></p>
        <p><a href="Default.aspx">Back to Asset Registry Admin</a></p>
    </div>  
</asp:Content>
