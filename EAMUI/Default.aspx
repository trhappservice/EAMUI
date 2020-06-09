<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EAMUI.Default" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <script>
        am4core.ready(function() {

        // Themes begin
        am4core.useTheme(am4themes_material);
        am4core.useTheme(am4themes_animated);
        // Themes end


        var chart = am4core.create("mainchartdiv", am4charts.XYChart);

        chart.dataSource.url = "/api/getTotalAssetByAssetClass";

        chart.padding(40, 40, 40, 40);

        var categoryAxis = chart.xAxes.push(new am4charts.CategoryAxis());
        categoryAxis.renderer.grid.template.location = 0;
            categoryAxis.dataFields.category = "name";
        categoryAxis.renderer.minGridDistance = 60;
        categoryAxis.renderer.inversed = true;
        categoryAxis.renderer.grid.template.disabled = true;

        var valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
        valueAxis.min = 0;
        valueAxis.extraMax = 0.1;
        //valueAxis.rangeChangeEasing = am4core.ease.linear;
        //valueAxis.rangeChangeDuration = 1500;

        var series = chart.series.push(new am4charts.ColumnSeries());
            series.dataFields.categoryX = "name";
        series.dataFields.valueY = "count";
        series.tooltipText = "{valueY.value}"
        series.columns.template.strokeOpacity = 0;
        series.columns.template.column.cornerRadiusTopRight = 10;
        series.columns.template.column.cornerRadiusTopLeft = 10;
        //series.interpolationDuration = 1500;
        //series.interpolationEasing = am4core.ease.linear;
        var labelBullet = series.bullets.push(new am4charts.LabelBullet());
        labelBullet.label.verticalCenter = "bottom";
        labelBullet.label.dy = -10;
        labelBullet.label.text = "{values.valueY.workingValue.formatNumber('#.')}";

        chart.zoomOutButton.disabled = true;

        // as by default columns of the same series are of the same color, we add adapter which takes colors from chart.colors color set
        series.columns.template.adapter.add("fill", function (fill, target) {
         return chart.colors.getIndex(target.dataItem.index);
        });

        categoryAxis.sortBySeries = series;

        }); // end am4core.ready()
        
        </script>
        <div class="row">
        <div class="col-md-12">
        <h3>Enterprise Asset Management UI</h3>
        </div>
        </div>
        <div class="row">
        <div class="col-md-2">
        <table border="0" cellpadding="0" cellspacing="0">
        <tr><td><div class="countHeaderText">City Total Asset Count</div></td></tr>
        <tr><td>
            <asp:Label ID="lblTotalAssetCount" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        </table>
        <table border="0" cellpadding="0" cellspacing="0">
        <tr><td><div class="countSubHeaderText">Asset Count by Service</div></td></tr>
        <tr><td><div>Environmental Services</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblEnvServ" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Transportation Services</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblTranServ" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Recreation & Culture Services</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblRecServ" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Protection Services</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblProtServ" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Administration</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblAdminServ" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        </table>
            </div>
            <div class="col-md-8">
    
        <p><b class="countSubHeaderText">Total Asset by Asset Class</b></p>
        <div id="mainchartdiv"></div>
    
            </div>
            <div class="col-md-2">
    
        <p><b class="countHeaderText">Health Check</b></p>
        <table border="0" cellpadding="0" cellspacing="0">
        <tr><td><div>Installation Date Count</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblInstallDateCnt" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Blank Installation Date Count</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblBlkInstallDateCnt" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Condition Count</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblConditionCnt" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        <tr><td><div>Blank Condition Count</div></td></tr>           
        <tr><td>
            <asp:Label ID="lblBlkConditionCnt" runat="server" CssClass="countText" Text="0"></asp:Label></td></tr>
        </table>
        <br /><br />            
    
    </div>
</asp:Content>