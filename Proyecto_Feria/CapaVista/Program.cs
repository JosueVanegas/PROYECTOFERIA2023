using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;

namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //documento para poder modificar
            /*
             * 
             * ControlInforme cInformes = new ControlInforme();
            string fechaInicio = "15/08/2023";
            string fechaFinal = "27/08/2023";
            Document.Create(doc =>
             {
                 doc.Page(page =>
                 {
                     page.Margin(10);
                     page.Header().Row(row =>
                  {
                      row.RelativeItem().Border(0).Background(Colors.White).Height(80).Column(col =>
                      {
                          col.Spacing(10);

                      });
                      row.RelativeItem().Border(0).Background(Colors.White).Height(80).Column(col =>
                      {
                          col.Item().AlignCenter().Text("La empresa S.A").FontSize(28).Bold();
                          col.Item().AlignCenter().Text("Teléfono: +505 8394-3523").FontSize(10);
                          col.Item().AlignCenter().Text("Correo electronico: MiEmpresa@gmail.com").FontSize(10);
                      });
                      row.RelativeItem().Border(0).Background(Colors.White).Height(80);
                  });
                     page.Content().PaddingVertical(10).Column(col =>
                     {

                         col.Item().AlignCenter().Text("Reporte de ventas").FontSize(25);

                         col.Item().AlignCenter().Text(txt =>
                         {
                             txt.Span("Desde: ").FontSize(15);
                             txt.Span(fechaInicio).FontSize(15);
                             txt.Span(" hasta: ").FontSize(15);
                             txt.Span(fechaFinal).FontSize(15);
                         });
                         col.Item().LineHorizontal(0.5f);
                         //configuracion del grafico
                         var entries = new[]
                         {
                          new ChartEntry(22)
                            {
                            Label = "cliente ejemplo 1",
                            ValueLabel = "34",
                            Color = SKColor.Parse("#2c3e50")
                            },
                            new ChartEntry(32)
                          {
                             Label = "cliente ejemplo 2",
                            ValueLabel = "32",
                            Color = SKColor.Parse("#77d065")
                         }
                         };
                         //dibujando el grafico en el pdf
                         col.Item().Column(column =>
                         {
                             var titleStyle = TextStyle
                               .Default
                              .FontSize(20)
                              .SemiBold()
                                .FontColor(Colors.Blue.Medium);

                             column
                                 .Item()
                                 .PaddingBottom(10)
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
                         //tabla
                         col.Item().Table(tab =>
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
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("No.Factura").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Cliente").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Atendido por").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("IVA").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Subtotal").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Descuento").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Total").FontSize(10);
                                 het.Cell().Border(1).Background(Colors.Green.Medium).Padding(1).Text("Fecha").FontSize(10);

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
             }).ShowInPreviewer();
             */

            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(null));
            //Application.Run(new formLogin());
        }
    }
}
