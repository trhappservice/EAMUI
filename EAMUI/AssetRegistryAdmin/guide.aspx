<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="guide.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.guide" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>  
        <h3>Enterprise Asset Management UI</h3>
        <p><b>Batch Update Guide</b></p>
        <ol>
            <li>The excel has to be at least two column. The first column must be the EAM ID</li>
            <li>The column is the parameter you would like to update, e.g. Conditions, Construction Install Date...etc</li>
            <li>We have some standard <a href="#">template</a> to help us get started.</li>
        </ol>
        <p><a href="BatchUpdate.aspx">Back to Batch Update</a></p>
    </div>  

</asp:Content>
