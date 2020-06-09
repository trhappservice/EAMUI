<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BizLogic.aspx.cs" Inherits="EAMUI._Default" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>  
        <h3>Enterprise Asset Management UI</h3>
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Gen Cost Forcasting" OnClick="genCostForcasting_Click"></asp:Button>
        <br /><br />
        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Gen Risk Forcasting" OnClick="genRiskForcasting_Click"></asp:Button>
        <br /><br />
        <asp:Button ID="Button3" class="btn btn-primary" runat="server" Text="Gen Prioritization" OnClick="genPriority_Click"></asp:Button>
        <br /><br />
        <asp:Button ID="Button5" class="btn btn-primary" runat="server" Text="Refresh Data in Reporting Database" OnClick="refreshReporting_Click"></asp:Button>
        <br /><br />
        <b><asp:Label ID="tsList" runat="server"></asp:Label></b>
    </div>  

</asp:Content>
