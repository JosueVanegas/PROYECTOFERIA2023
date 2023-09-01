using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.FormInformes
{
    static class  ReportesTipo
   
    {
        // Los unicos metods que estan Funcionado a como son los de ventas y
        // el resto ctrl C y P de los ventas a adaptalos al modo de tabla que quieres mostrar


        //Ventas

        public static void VentasCrearReporteSemanalActual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                    doc.Page(page =>
                    {
                        page.Size(PageSizes.Letter);
                        page.Margin(10);
                        page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                        page.PageColor(Colors.White);

                        const string transparentBlue = "#662196f3";

                        page.Background()
                            .AlignTop()
                            .ExtendHorizontal()
                            .Height(100)
                            .Background(transparentBlue);

                        page.Foreground()
                            .AlignBottom()
                            .ExtendHorizontal()
                            .Height(50)
                            .Background(transparentBlue);

                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                            {
                                col.Spacing(10);

                            });
                            row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                            {
                                col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                                col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                                col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                            });
                            row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                        });

                        page.Content().PaddingVertical(25).Column(column =>
                        {
                            column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                            column.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Desde: ").FontSize(15);
                                txt.Span(fechaInicio).FontSize(15);
                                txt.Span(" hasta: ").FontSize(15);
                                txt.Span(fechaFinal).FontSize(15);
                            });
                            column.Spacing(50);

                            column.Item().LineHorizontal(0.5f);
                            //configuracion del grafico
                            var entries = new[]
                            {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Lun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Jue",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "Vie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Sab",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(30)
                         {
                            Label = "Dom",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }
                            };
                            //dibujando el grafico en el pdf
                            column.Item().Column(column =>
                            {
                                var titleStyle = TextStyle
                                  .Default
                                 .FontSize(20)
                                 .SemiBold()
                                   .FontColor(Colors.Blue.Medium);

                                column
                                    .Item()
                                    .PaddingBottom(1)
                                    .Text("Chart example")
                                 .Style(titleStyle);

                                column
                              .Item()
                           .Border(1)
                           .ExtendHorizontal()
                           .Height(300)
                              .Canvas((canvas, size) =>
                              {
                                  var chart = new BarChart
                                  {
                                      Entries = entries,

                                      LabelOrientation = Microcharts.Orientation.Horizontal,
                                      ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                      IsAnimated = false,
                                  };

                                  chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                              });
                            });
                            column.Spacing(10);

                            column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                            //tabla
                            column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                            {
                                tab.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(6);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(3);
                                });
                                tab.Header(het =>
                                {
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                                });
                                List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                                foreach (informeVentas i in lista)
                                {

                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                                }
                            });
                        });
                        page.Footer().AlignCenter().Text(txt =>
                        {
                            txt.Span("Pagina  ").FontSize(20);
                            txt.CurrentPageNumber().FontSize(20);
                            txt.Span("  de  ").FontSize(20);
                            txt.TotalPages().FontSize(20);

                        });
                    });


                });

                var filePath = "invoice.pdf";
                dox.GeneratePdf(filePath);


                Process.Start("explorer.exe", filePath);

        }

        public static void VentasCrearReporte_Hoy_Ayer_Mes_15Dias(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(25);


                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void VentasCrearReporteAnual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Ene",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Feb",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Abr",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "May",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Jun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(25)
                         {
                            Label = "Jul",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(20)
                         {
                            Label = "Ago",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Sep",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Oct",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        },
                         new ChartEntry(10)
                         {
                            Label = "Nov",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(5)
                         {
                            Label = "Dic",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }


                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        //Inventario
        //Lo que se encuentra en inventario de producto

        public static void InventarioCrearReporteSemanalActual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de Inventario").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Lun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Jue",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "Vie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Sab",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(30)
                         {
                            Label = "Dom",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }
                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de Inventario").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(25);


                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void InventarioCrearReporteAnual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Ene",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Feb",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Abr",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "May",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Jun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(25)
                         {
                            Label = "Jul",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(20)
                         {
                            Label = "Ago",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Sep",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Oct",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        },
                         new ChartEntry(10)
                         {
                            Label = "Nov",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(5)
                         {
                            Label = "Dic",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }


                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        //Compras
        //Las cantidades de lo que se vendio

        public static void ComprasCrearReporteSemanalActual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Lun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Jue",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "Vie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Sab",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(30)
                         {
                            Label = "Dom",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }
                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(25);


                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void ComprasCrearReporteAnual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Ene",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Feb",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Abr",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "May",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Jun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(25)
                         {
                            Label = "Jul",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(20)
                         {
                            Label = "Ago",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Sep",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Oct",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        },
                         new ChartEntry(10)
                         {
                            Label = "Nov",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(5)
                         {
                            Label = "Dic",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }


                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        //Nomina
        //En las graficas del anual y semanal refleja lo que se pago en nomina

        public static void NominaCrearReporteSemanalActual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Lun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Jue",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "Vie",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Sab",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(30)
                         {
                            Label = "Dom",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }
                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void NominaCrearReporte_Hoy_Ayer_Mes_15Dias(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(25);


                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        public static void NominaReporteAnual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Ene",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Feb",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Mar",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Abr",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "May",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Jun",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(25)
                         {
                            Label = "Jul",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(20)
                         {
                            Label = "Ago",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Sep",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(15)
                         {
                            Label = "Oct",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        },
                         new ChartEntry(10)
                         {
                            Label = "Nov",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }, new ChartEntry(5)
                         {
                            Label = "Dic",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }


                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

        //Contabilidad
        //Las grafica varian por el numero de cuentas que vamos a tener en el momento hay para 7 cuentas

        public static void ContabilidadCrearReporteSemanalActual(string fechaInicio_, string fechaFinal_)
        {
            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);

                    const string transparentBlue = "#662196f3";

                    page.Background()
                        .AlignTop()
                        .ExtendHorizontal()
                        .Height(100)
                        .Background(transparentBlue);

                    page.Foreground()
                        .AlignBottom()
                        .ExtendHorizontal()
                        .Height(50)
                        .Background(transparentBlue);

                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Spacing(10);

                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                            col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                    });

                    page.Content().PaddingVertical(25).Column(column =>
                    {
                        column.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                        column.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Desde: ").FontSize(15);
                            txt.Span(fechaInicio).FontSize(15);
                            txt.Span(" hasta: ").FontSize(15);
                            txt.Span(fechaFinal).FontSize(15);
                        });
                        column.Spacing(50);

                        column.Item().LineHorizontal(0.5f);
                        //configuracion del grafico
                        var entries = new[]
                        {
                         new ChartEntry(5)//// en este van los valor
                           {
                           Label = "Cuenta 1",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(10)
                           {
                           Label = "Cuenta 2",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(15)
                           {
                           Label = "Cuenta 3",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(20)
                           {
                           Label = "Cuenta 4",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(25)
                           {
                           Label = "Cuenta 5",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                         new ChartEntry(30)
                           {
                           Label = "Cuenta 6",
                           ValueLabel = "34",
                           Color = SKColor.Parse("#87CEEB")
                           },
                           new ChartEntry(25)
                         {
                            Label = "Cuenta 7",
                           ValueLabel = "3",
                           Color = SKColor.Parse("#87CEEB")
                        }
                            };
                        //dibujando el grafico en el pdf
                        column.Item().Column(column =>
                        {
                            var titleStyle = TextStyle
                              .Default
                             .FontSize(20)
                             .SemiBold()
                               .FontColor(Colors.Blue.Medium);

                            column
                                .Item()
                                .PaddingBottom(1)
                                .Text("Chart example")
                             .Style(titleStyle);

                            column
                          .Item()
                       .Border(1)
                       .ExtendHorizontal()
                       .Height(300)
                          .Canvas((canvas, size) =>
                          {
                              var chart = new BarChart
                              {
                                  Entries = entries,

                                  LabelOrientation = Microcharts.Orientation.Horizontal,
                                  ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                  IsAnimated = false,
                              };

                              chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                          });
                        });
                        column.Spacing(10);

                        column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);

                        //tabla
                        column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                        {
                            tab.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(6);
                                columns.RelativeColumn(4);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(3);
                            });
                            tab.Header(het =>
                            {
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Atendido por").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IVA").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Descuento").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                                het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                            });
                            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
                            foreach (informeVentas i in lista)
                            {

                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.noFactura).FontSize(10);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreCliente).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombreEmpleado).FontSize(11);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.iva).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.subtotal).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.descuento).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total).FontSize(12);
                                tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);

                            }
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(20);
                        txt.CurrentPageNumber().FontSize(20);
                        txt.Span("  de  ").FontSize(20);
                        txt.TotalPages().FontSize(20);

                    });
                });


            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);

        }

    }

}
