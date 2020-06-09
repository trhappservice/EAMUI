<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="genCostForecast.aspx.cs" Inherits="EAMUI.test" %>

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

           chart.dataSource.url = "/resources/costForecastResult.json";
            
           // Create axes
           let categoryAxis = chart.xAxes.push(new am4charts.CategoryAxis());
           categoryAxis.dataFields.category = "costYear";
           categoryAxis.title.text = "Year";
           categoryAxis.renderer.minGridDistance = 60;

           let valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
           valueAxis.title.text = "Cost per Year";

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

           var series2 = chart.series.push(new am4charts.LineSeries());
           series2.name = "Units";
           series2.stroke = am4core.color("#CDA2AB");
           series2.strokeWidth = 3;
           series2.dataFields.valueY = "cost";
           series2.dataFields.categoryX = "costYear";

    </script>

<!-- HTML -->
    <h3>Enterprise Asset Management UI</h3>
    <p><b>Cost Forcasting</b></p>
    <asp:DropDownList ID="yearOfForecase" runat="server">
        <asp:ListItem Value="0"> Please select the year</asp:ListItem>
        <asp:ListItem Value="5"> 5 </asp:ListItem>
        <asp:ListItem Value="6"> 6 </asp:ListItem>
        <asp:ListItem Value="7"> 7 </asp:ListItem>
        <asp:ListItem Value="8"> 8 </asp:ListItem>
        <asp:ListItem Value="9"> 9 </asp:ListItem>
        <asp:ListItem Value="10"> 10 </asp:ListItem>
        <asp:ListItem Value="15"> 15 </asp:ListItem>
        <asp:ListItem Value="20"> 20 </asp:ListItem>
    </asp:DropDownList> 
    <asp:DropDownList ID="newUnitCost" runat="server">
        <asp:ListItem Value="0"> Please select the unit cost</asp:ListItem>
        <asp:ListItem Value="60"> 60 </asp:ListItem>
        <asp:ListItem Value="70"> 70 </asp:ListItem>
        <asp:ListItem Value="80"> 80 </asp:ListItem>
        <asp:ListItem Value="90"> 90 </asp:ListItem>
        <asp:ListItem Value="100"> 100 </asp:ListItem>
        <asp:ListItem Value="110"> 110 </asp:ListItem>
        <asp:ListItem Value="120"> 120 </asp:ListItem>
        <asp:ListItem Value="130"> 130 </asp:ListItem>
    </asp:DropDownList> 
    <asp:DropDownList ID="StartTrigger" runat="server">
        <asp:ListItem Value="0"> Please select the start trigger</asp:ListItem>
        <asp:ListItem Value="70"> 70 </asp:ListItem>
        <asp:ListItem Value="60"> 60 </asp:ListItem>
        <asp:ListItem Value="50"> 50 </asp:ListItem>
    </asp:DropDownList> 
    <asp:Button ID="Button1" runat="server" OnClick="Submit_Click" Text="Recalculate" />
    <div id="chartdiv" style="width: 60%;height: 500px;"></div>
</asp:Content>