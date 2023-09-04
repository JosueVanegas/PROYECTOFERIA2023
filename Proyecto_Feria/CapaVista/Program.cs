using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System.Data.Common;
using System.Globalization;

namespace CapaVista
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
           Application.Run(new FormPrincipal(null));
          // Application.Run(new formLogin());
        }

    }
}
/*
 * 
            ControlInforme cInformes = new ControlInforme();
            
            bool grafica = false;
            bool anual = false;
            string fechaInicio = DateTime.Now.ToString("yyyy-MM-dd");
            string fechaFinal = fechaInicio;
            string tituloRango = "Informe del dia de hoy "+ DateTime.Now.ToString($"dddd dd MMMM año yyyy");
            Empresa empresa = new ControlEmpresa().datosEmpresa();
            
            
             QuestPDF.Fluent.Document.Create(doc =>
            {
                    doc.Page(page =>
                    {
                        page.Size(PageSizes.Letter);
                        page.Margin(10);
                        page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                        page.PageColor(Colors.White);
                        page.Background().AlignTop().ExtendHorizontal().Height(100).Background(colorFondoInventario);
                        page.Header().Element(Encabezado);
                        page.Footer().Element(piePagina);
                        page.Content().Element(contenidoVentas);
                    });
             }).ShowInPreviewer();
            void Encabezado(IContainer content)
            {
                content.Row(row =>
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
            }
            void piePagina(IContainer content)
            {
                content.AlignCenter().Text(txt =>
                {
                    txt.Span("Pagina  ").FontSize(10);
                    txt.CurrentPageNumber().FontSize(10);
                    txt.Span("  de  ").FontSize(10);
                    txt.TotalPages().FontSize(10);

                });
            }
            void contenidoInventario(IContainer content)
            {
                valorRealInventario = 0;
                utilidadEsperada = 0;
                valorDeseadoInventario = 0;
                List<informeInventario> lista = cInformes.datosInventario();
                content.PaddingVertical(25).Column(column =>
                {
                    column.Item().AlignCenter().Text("Reporte de inventario").FontSize(25);
                    column.Item().AlignCenter().Text(txt =>
                    {
                        
                            txt.Span(tituloRango).FontSize(15);
                        
                    });
                    column.Spacing(30);

                    column.Item().LineHorizontal(0.5f);
                    column.Item().AlignCenter().Text("Detalles del inventario").FontSize(15);

                    //tabla
                    column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                    {
                        tab.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(5);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(2);
                        });

                        tab.Header(het =>
                        {
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Codigo").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Producto").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Categoria").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Proveedor").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Precio de compra").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Precio de    venta").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Stock").FontSize(10);
                            het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Fecha de registro").FontSize(10);

                        });
                        foreach (informeInventario i in lista)
                        {

                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.codigo).FontSize(10);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.producto).FontSize(11);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.categoria).FontSize(11);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.proveedor).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.precioCompra).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.precioVenta).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.cantidad).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(10);
                            valorRealInventario += i.precioCompra * Convert.ToDecimal(i.cantidad);
                            valorDeseadoInventario += i.precioVenta * Convert.ToDecimal(i.cantidad);
                        }
                    });
                    utilidadEsperada = valorDeseadoInventario - valorRealInventario ;
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Valor en inventario: " + valorRealInventario + " C$").FontSize(15);
                                txt.Span("      Valor potencial: " + valorDeseadoInventario + " C$").FontSize(15);
                                txt.Span("      Ganancia potencial: " + utilidadEsperada + " C$").FontSize(15);
                            });
                        });
                    });
                });
            }
 */
