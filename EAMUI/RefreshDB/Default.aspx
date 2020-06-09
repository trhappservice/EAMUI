<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EAMUI.RefreshDB.Default" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>  
        <h3>Enterprise Asset Management UI - Refresh DB</h3>
        <p>Pkease confirm if you would like to copy data from the Asset Registry to the Reporting Database</p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <p><asp:Button ID="Button5" class="btn btn-primary" runat="server" Text="Would you like to proceed?" OnClick="Confirm_Clicked"></asp:Button></p>
        <p><a href="../BizLogic.aspx">Back to main admin</a></p>
    </div>  
</asp:Content>
