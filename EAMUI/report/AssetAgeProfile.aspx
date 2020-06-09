<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssetAgeProfile.aspx.cs" Inherits="EAMUI.test1" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <script>
     /**
       * ---------------------------------------
       * This demo was created using amCharts 4.
       *
       * For more information visit:
       * https://www.amcharts.com/
       *
       * Documentation is available at:
       * https://www.amcharts.com/docs/v4/
       * ---------------------------------------
       */
     am4core.useTheme(am4themes_material);
     am4core.useTheme(am4themes_animated);
     // Create chart instance
     var chart = am4core.create("chartdiv", am4charts.XYChart);

     //chart.dataSource.url = "/resources/costForecastResult.json";
     var dataURL = "http://localhost:44384/api/genJson?asset=" +"<%=Request["asset"]%>";
     chart.dataSource.url = dataURL;

     // Create axes
     let categoryAxis = chart.xAxes.push(new am4charts.CategoryAxis());
     categoryAxis.dataFields.category = "costYear";
     categoryAxis.title.text = "Year";
     categoryAxis.renderer.minGridDistance = 60;

     let valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
     valueAxis.title.text = "Total Value of Asset acquired by the City each year";

     // Create series
     var series = chart.series.push(new am4charts.ColumnSeries());
     series.dataFields.valueY = "cost";
     series.dataFields.categoryX = "costYear";
     //series.columns.template.fill = am4core.color("#a38600");
     series.columns.template.tooltipText = "Year: {categoryX}\nCost: ${valueY}";
     series.columns.template.strokeOpacity = 0;
     series.columns.template.column.cornerRadiusTopRight = 10;
     series.columns.template.column.cornerRadiusTopLeft = 10;

     series.columns.template.adapter.add("fill", function (fill, target) {
         return chart.colors.getIndex(target.dataItem.index);
     });

     

    </script>
        
<h3>Enterprise Asset Management UI</h3>
    <p><b>Report - Asset Age (or Installation Year) Profile - Bridges</b></p>
    <p><asp:DropDownList ID="assetTypeDropDown" runat="server">
        <asp:ListItem Value=""> Please select the Asset Typer</asp:ListItem>
        <asp:ListItem Value="Bridges"> Bridges </asp:ListItem>
        <asp:ListItem Value="Road Segment"> Roads </asp:ListItem>
    </asp:DropDownList> <asp:Button ID="Button1" runat="server" OnClick="Submit_Click" Text="Recalculate" /></p>
<div id="chartdiv" style="width: 60%;height: 500px;"></div>
</asp:Content>
