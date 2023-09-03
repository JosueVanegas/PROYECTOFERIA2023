using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System.Data.Common;

namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            /*
             * Empresa empresa = new ControlEmpresa().datosEmpresa();
            DateTime today = DateTime.Today;

            // Calcular la fecha de inicio de la última semana (hace 7 días)
            DateTime startOfLastWeek = today.AddDays(-7);

            // Calcular la fecha de fin de la última semana (hoy menos un día)
            DateTime endOfLastWeek = today.AddDays(0);
            string fechaInicio = startOfLastWeek.ToString("yyyy-MM-dd");
            string fechaFinal = endOfLastWeek.ToString("yyyy-MM-dd");
            List<informeVentas> lista = new ControlInforme().datosDeVentas(fechaInicio, fechaFinal);
            Document.Create(doc =>
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
                            col
                                .Item()
                                .Image(empresa.imagen).FitArea()
                                .WithCompressionQuality(ImageCompressionQuality.VeryLow);
                        });
                        row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                        {
                            col.Item().AlignCenter().Text(empresa.nombre).FontSize(28).Bold();
                            col.Item().AlignCenter().Text("Teléfono: " + empresa.telefono).FontSize(7);
                            col.Item().AlignCenter().Text("Correo electronico: " + empresa.email).FontSize(7);
                            col.Item().AlignCenter().Text("Direccion: " + empresa.direccion + "/" + empresa.departamento).FontSize(7);
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
                        var entries = new List<ChartEntry>();
                        foreach (var i in lista)
                        {
                            DateTime date = DateTime.Parse(i.fecha);
                            entries.Add(new ChartEntry(1)//// en este van los valor
                            {
                                Label = date.ToString("ddd"),
                                ValueLabel = i.total.ToString("0.00"),
                                Color = SKColor.Parse("#87CEEB")
                            });


                        }
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
                                .Text("Grafico de ventas semanales")
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
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignRight().Text(txt =>
                                {
                                    txt.Span("IVA: 2235").FontSize(15);
                                    txt.Span("      Subtotal: 2235").FontSize(15);
                                    txt.Span("      Descuento: 2235").FontSize(15);
                                    txt.Span("      Total: 2235").FontSize(15);
                                });
                            });
                        });
                    });
                    page.Footer().AlignCenter().Text(txt =>
                    {
                        txt.Span("Pagina  ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span("  de  ").FontSize(10);
                        txt.TotalPages().FontSize(10);

                    });
                });
            }).ShowInPreviewer();
             */
            ApplicationConfiguration.Initialize();
           //Application.Run(new FormPrincipal(null));
           Application.Run(new formLogin());
        }
    }
}
