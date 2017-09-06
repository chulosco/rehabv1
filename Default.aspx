<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Grafico.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <button id="evolucion" style="width: 50%; font-family: Arial, Helvetica, sans-serif; font-size: 12px; visibility: visible;" height:50%;" >Evolucion</button>
        <button id="reputación" style="width: 50%; font-family: Arial, Helvetica, sans-serif; font-size: 12px; visibility: visible;" height:50%;">Reputacion</button>
    <div id="container" style="width: 50%;"/>
    <div id="containerrep" style="width: 50%;"/>
    </form>
</body>
<script src="/scripts/jquery-1.11.3.min.js"></script>
<script src="/scripts/highcharts.js"></script>
   
     <script>
        Highcharts.chart('container', {
            chart: {
                type: 'areaspline'
            },
            title: {
                text: 'Evolución del Paciente en Rehabilitación'
            },
            subtitle:{
                text: 'Grupo Chulos Emojis Corp'
            },
            legend: {
                layout: 'vertical',
                align: 'left',
                verticalAlign: 'top',
                x: 150,
                y: 100,
                floating: true,
                borderWidth: 1,
                backgroundColor: (Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'
            },
            xAxis: {
                categories: [
                    'sesión 1',
                    'sesión 2',
                    'sesión 3',
                    'sesión 4',
                    'sesión 5',
                    'sesión 6',
                    'sesión 7'
                ],
                plotBands: [{ // visualize the weekend
                    from: 4.5,
                    to: 6.5,
                    color: 'rgba(68, 170, 213, .2)'
                }]
            },
            yAxis: {
                title: {
                    text: 'Calificación de la Evolución'
                }
            },
            tooltip: {
                shared: true,
                valueSuffix: ' unidades de evolución'
            },
            credits: {
                enabled: false
            },
            plotOptions: {
                areaspline: {
                    fillOpacity: 0.5
                }
            },
            series: [{
                name: 'Jhonny',
                data: [1, 2, 3, 5.5, 10, 12.5, 15]
            }, {
                name: 'Ideal',
                data: [1, 2.5, 5, 7.5, 10, 12.5, 15]
            }]
        });
    </script>



</html>
