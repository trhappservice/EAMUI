<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EAMUI.Admin.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>  
        <h3>Enterprise Asset Management UI</h3>
        <ul>
            <li><a href="ActivityCost/Default.aspx">Activity Cost Admin</a></li>
            <li><a href="BudgetForecast/Default.aspx">Budget Forecast Admin</a></li>
            <li><a href="Consequence/Default.aspx">Consequence Admin</a></li>
            <li><a href="Lifecycle/Default.aspx">Lifecycle Admin</a></li>
            <li><a href="Likelihood/Default.aspx">Likelihood Admin</a></li>
            <li><a href="TLOS/Default.aspx">Technical Level of Service (TLOS) Admin</a></li>
        </ul>
        <a href="../Default.aspx">Back to main admin</a>
    </div>  

</asp:Content>

