using CapaControlador;
using CapaDatos;
using Microcharts;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Org.BouncyCastle.Utilities.Collections;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.FormInformes
{
    public class ReportesTipo

    {
        public ReportesTipo() { }
        ControlInforme cInformes = new ControlInforme();
        Modelos.Empresa empresa = new ControlEmpresa().datosEmpresa();
        const string colorFondoInventario = "#FA523B";
        const string transparentBlue = "#662196f3";
        bool grafica = false;
        bool anual = false;
        string fechaInicio = "";
        string fechaFinal = "";
        string tituloRango = "";

        //kerlint el pie de pagina y el encabezado es igual en todos los reportes asi que es mejor hacerlos en metodos para solo llamarlos enves de copiar todo
        void Encabezado(IContainer content)
        {
            content.Row(row =>
            {
                row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                {
                    col.Spacing(10);
                    col
                        .Item()
                        .Image(empresa.IMAGEN).FitArea()
                        .WithCompressionQuality(ImageCompressionQuality.VeryLow);
                });
                row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                {
                    col.Item().AlignCenter().Text(empresa.NOMBRE).FontSize(14).Bold();
                    col.Item().AlignCenter().Text("Teléfono: " + empresa.TELEFONO).FontSize(5);
                    col.Item().AlignCenter().Text("Correo electronico: " + empresa.CORREO).FontSize(5);
                    col.Item().AlignCenter().Text("Direccion: " + empresa.DIRECCION).FontSize(5);
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
        void contenidoVentas(IContainer content)
        {
            decimal subTotal = 0;
            decimal descuento = 0;
            decimal iva = 0;
            decimal Total = 0;
            List<Modelos.Venta> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
            content.PaddingVertical(25).Column(column =>
            {
                column.Item().AlignCenter().Text("Reporte de Ventas").FontSize(25);

                column.Item().AlignCenter().Text(txt =>
                {
                    if (tituloRango != "")
                    {
                        txt.Span(tituloRango).FontSize(15);
                    }
                    else
                    {
                        txt.Span("Desde: ").FontSize(15);
                        txt.Span(fechaInicio).FontSize(15);
                        txt.Span(" hasta: ").FontSize(15);
                        txt.Span(fechaFinal).FontSize(15);
                    }
                });
                column.Spacing(30);
                column.Item().LineHorizontal(0.5f);
                if (grafica == true)
                {
                    var entries = new List<ChartEntry>();
                    CultureInfo cultureInfo = new CultureInfo("es-ES");
                    if (anual == true)
                    {
                        Dictionary<int, decimal> totalsByMonth = new Dictionary<int, decimal>();
                        for (int month = 1; month <= 12; month++)
                        {
                            totalsByMonth[month] = 0.0m;
                        }
                        foreach (var venta in lista)
                        {
                            DateTime fechaVenta = venta.FECHA_REGISTRO;
                            int month = fechaVenta.Month;
                            totalsByMonth[month] += venta.SUBTOTAL;
                        }
                        foreach (var kvp in totalsByMonth)
                        {
                            string nombreMes = cultureInfo.DateTimeFormat.GetMonthName(kvp.Key);
                            entries.Add(new ChartEntry((float)kvp.Value)
                            {
                                Label = nombreMes,
                                ValueLabel = kvp.Value.ToString("0.00"),
                                Color = SKColor.Parse("#87CEEB")
                            });
                        }
                    }
                    else
                    {
                        Dictionary<DayOfWeek, decimal> totalesPorDiaSemana = new Dictionary<DayOfWeek, decimal>
                        {
                            { DayOfWeek.Sunday, 0.0m },
                            { DayOfWeek.Monday, 0.0m },
                            { DayOfWeek.Tuesday, 0.0m },
                            { DayOfWeek.Wednesday, 0.0m },
                            { DayOfWeek.Thursday, 0.0m },
                            { DayOfWeek.Friday, 0.0m },
                            { DayOfWeek.Saturday, 0.0m }
                        };

                        foreach (var i in lista)
                        {
                            DateTime date = i.FECHA_REGISTRO;
                            DayOfWeek dayOfWeek = date.DayOfWeek;
                            totalesPorDiaSemana[dayOfWeek] += i.SUBTOTAL;
                        }
                        foreach (var td in totalesPorDiaSemana)
                        {
                            entries.Add(new ChartEntry((float)td.Value)
                            {
                                Label = td.Key.ToString(),
                                ValueLabel = td.Value.ToString("0.00"),
                                Color = SKColor.Parse("#87CEEB")
                            });
                        }
                    }
                    column.Item().Column(column =>
                    {
                        var titleStyle = TextStyle
                          .Default
                         .FontSize(20)
                         .SemiBold()
                           .FontColor(Colors.Blue.Medium);
                        string rango = "semanales";
                        if (anual == true)
                        { rango = "anuales"; }
                        column
                            .Item()
                            .PaddingBottom(1)
                            .Text("Grafica de ventas " + rango)
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
                }
                column.Item().AlignCenter().Text("Detalles de las Ventas").FontSize(15);
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
                    foreach (Modelos.Venta i in lista)
                    {
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.ID).FontSize(10);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CLIENTE.NOMBRES).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.USUARIO.NOMBRE).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.IVA).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.SUBTOTAL).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.DESCUENTO).FontSize(12);
                        decimal subtotal_descuento = i.SUBTOTAL - i.DESCUENTO;
                        decimal total = subtotal_descuento - i.IVA;
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(total).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.FECHA_REGISTRO).FontSize(10);
                        subTotal += i.SUBTOTAL;
                        iva += i.IVA;
                        descuento += i.DESCUENTO;
                        Total += total;
                    }
                });
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignRight().Text(txt =>
                        {
                            txt.Span("IVA: " + iva + " C$").FontSize(15);
                            txt.Span("      Subtotal: " + subTotal + " C$").FontSize(15);
                            txt.Span("      Descuento: " + descuento + " C$").FontSize(15);
                            txt.Span("      Total: " + Total + " C$").FontSize(15);
                        });
                    });
                });
            });
        }
        void contenidoInventario(IContainer content)
        {
            decimal valorRealInventario = 0;
            decimal valorDeseadoInventario = 0;
            decimal utilidadEsperada = 0;
            List<Modelos.Producto> lista = new ControlProducto().listarProductos();
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
                        het.Cell().Border(1).Background(colorFondoInventario).Padding(1).Text("Fecha de vencimiento").FontSize(10);

                    });
                    foreach (Modelos.Producto i in lista)
                    {

                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CODIGO).FontSize(10);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.NOMBRE).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CATEGORIA.NOMBRE).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.PROVEEDOR.EMPRESA).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.PRECIO_COMPRA).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.PRECIO_VENTA).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.STOCK).FontSize(12);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.VENCIMIENTO).FontSize(10);
                        valorRealInventario += i.PRECIO_COMPRA * Convert.ToDecimal(i.STOCK);
                        valorDeseadoInventario += i.PRECIO_VENTA * Convert.ToDecimal(i.STOCK);
                    }
                });
                utilidadEsperada = valorDeseadoInventario - valorRealInventario;
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
        void contenidoCompras(IContainer content)
        {
            List<Modelos.Compra> lista = cInformes.datosCompras(fechaInicio, fechaFinal);
            decimal Total = 0;
            content.PaddingVertical(25).Column(column =>
            {
                column.Item().AlignCenter().Text("Reporte de Compras").FontSize(25);
                column.Item().AlignCenter().Text(txt =>
                {
                    if (tituloRango != "")
                    {
                        txt.Span(tituloRango).FontSize(15);
                    }
                    else
                    {
                        txt.Span("Desde: ").FontSize(15);
                        txt.Span(fechaInicio).FontSize(15);
                        txt.Span(" hasta: ").FontSize(15);
                        txt.Span(fechaFinal).FontSize(15);
                    }
                });
                column.Spacing(30);

                column.Item().LineHorizontal(0.5f);
                //configuracion del grafico
                if (grafica == true)
                {
                    var entries = new List<ChartEntry>();
                    CultureInfo cultureInfo = new CultureInfo("es-ES");
                    if (anual == true)
                    {
                        Dictionary<int, decimal> totalsByMonth = new Dictionary<int, decimal>();

                        // Inicializar el diccionario con todos los meses del año.
                        for (int month = 1; month <= 12; month++)
                        {
                            totalsByMonth[month] = 0.0m;
                        }
                        foreach (var compra in lista)
                        {
                            DateTime fechaCompra = compra.FECHA_REGISTRO;
                            int month = fechaCompra.Month;

                            // Sumar el monto total de la venta al mes correspondiente en el diccionario.
                            totalsByMonth[month] += compra.SUBTOTAL;
                        }
                        foreach (var kvp in totalsByMonth)
                        {
                            string nombreMes = cultureInfo.DateTimeFormat.GetMonthName(kvp.Key);
                            entries.Add(new ChartEntry((float)kvp.Value)
                            {
                                Label = nombreMes,
                                ValueLabel = kvp.Value.ToString("0.00"),
                                Color = SKColor.Parse("#87CEEB")
                            });
                        }
                    }
                    else
                    {
                        Dictionary<DayOfWeek, decimal> totalesPorDiaSemana = new Dictionary<DayOfWeek, decimal>
                        {
                            { DayOfWeek.Sunday, 0.0m },
                            { DayOfWeek.Monday, 0.0m },
                            { DayOfWeek.Tuesday, 0.0m },
                            { DayOfWeek.Wednesday, 0.0m },
                            { DayOfWeek.Thursday, 0.0m },
                            { DayOfWeek.Friday, 0.0m },
                            { DayOfWeek.Saturday, 0.0m }
                        };

                        foreach (var i in lista)
                        {
                            DateTime date = i.FECHA_REGISTRO;
                            DayOfWeek dayOfWeek = date.DayOfWeek;

                            // Sumar el monto total de la venta al día correspondiente en el diccionario.
                            totalesPorDiaSemana[dayOfWeek] += i.SUBTOTAL;
                        }
                        foreach (var td in totalesPorDiaSemana)
                        {
                            entries.Add(new ChartEntry((float)td.Value)
                            {
                                Label = td.Key.ToString(),
                                ValueLabel = td.Value.ToString("0.00"),
                                Color = SKColor.Parse("#87CEEB")
                            });
                        }
                    }

                    //dibujando el grafico en el pdf
                    column.Item().Column(column =>
                    {
                        var titleStyle = TextStyle
                          .Default
                         .FontSize(20)
                         .SemiBold()
                           .FontColor(Colors.Blue.Medium);
                        string rango = "semanales";
                        if (anual == true)
                        { rango = "anuales"; }
                        column
                            .Item()
                            .PaddingBottom(1)
                            .Text("Grafica de compras " + rango)
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
                }

                column.Item().AlignCenter().Text("Detalles de las compras").FontSize(15);

                //tabla
                column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                {
                    tab.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(4);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(7);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                    });

                    tab.Header(het =>
                    {
                        het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("No.Factura").FontSize(10);
                        het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Usuario en turno").FontSize(10);
                        het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total").FontSize(10);
                        het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha").FontSize(10);

                    });
                    foreach (Modelos.Compra i in lista)
                    {

                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.ID).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.USUARIO.NOMBRE).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.SUBTOTAL).FontSize(11);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.FECHA_REGISTRO).FontSize(11);
                        Total += i.SUBTOTAL;
                    }
                });
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignRight().Text(txt =>
                        {
                            txt.Span("      Total: " + Total + " C$").FontSize(15);
                        });
                    });
                });
            });
        }
        public void crearReporteCompras(string desde, string hasta, string tituloRango, bool conGrafica, bool anualreporteAnual)
        {
            this.fechaInicio = desde;
            fechaFinal = hasta;
            this.tituloRango = tituloRango;
            grafica = conGrafica;
            anual = anualreporteAnual;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(100).Background(transparentBlue);
                    page.Foreground().AlignBottom().ExtendHorizontal().Height(50).Background(transparentBlue);
                    //estructura ordenada el heater y footer se repite en todos los reportes
                    page.Header().Element(Encabezado);
                    page.Content().Element(contenidoCompras);
                    page.Footer().Element(piePagina);
                });
            });
            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }

        //para reportes de ventas
        public void crearReporteVentas(string desde, string hasta, string tituloRango, bool conGrafica, bool anualreporteAnual)
        {
            this.fechaInicio = desde;
            fechaFinal = hasta;
            this.tituloRango = tituloRango;
            grafica = conGrafica;
            anual = anualreporteAnual;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(100).Background(transparentBlue);
                    page.Foreground().AlignBottom().ExtendHorizontal().Height(50).Background(transparentBlue);
                    //estructura ordenada el heater y footer se repite en todos los reportes
                    page.Header().Element(Encabezado);
                    page.Content().Element(contenidoVentas);
                    page.Footer().Element(piePagina);
                });
            });
            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }
        //para compras
       public void crearReporteInventario()
        {
            var dox = QuestPDF.Fluent.Document.Create(doc =>
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
                    page.Content().Element(contenidoInventario);
                });
            });
            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);

        }

        public void exportarAExcelInventario()
        {
            List<Modelos.Producto> lista = new ControlProducto().listarProductos();
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("inventario " + DateTime.Now.ToString("dd_MM_yyyy"));
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("Codigo");
            filaEncabezados.CreateCell(1).SetCellValue("Producto");
            filaEncabezados.CreateCell(2).SetCellValue("Categoria");
            filaEncabezados.CreateCell(3).SetCellValue("Proveedor");
            filaEncabezados.CreateCell(4).SetCellValue("Precio de compra");
            filaEncabezados.CreateCell(5).SetCellValue("Precio de venta");
            filaEncabezados.CreateCell(6).SetCellValue("cantidad en inventario");
            filaEncabezados.CreateCell(7).SetCellValue("Fecha de vencimiento");
            for (int i = 0; i < lista.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(lista[i].CODIGO);
                fila.CreateCell(1).SetCellValue(lista[i].NOMBRE);
                fila.CreateCell(2).SetCellValue(lista[i].CATEGORIA.NOMBRE);
                fila.CreateCell(3).SetCellValue(lista[i].PROVEEDOR.EMPRESA);
                fila.CreateCell(4).SetCellValue((double)lista[i].PRECIO_COMPRA);
                fila.CreateCell(5).SetCellValue((double)lista[i].PRECIO_VENTA);
                fila.CreateCell(6).SetCellValue((double)lista[i].STOCK);
                fila.CreateCell(7).SetCellValue(lista[i].VENCIMIENTO);
            }
            for (int i = 0; i < 3; i++)
            {
                hoja.AutoSizeColumn(i);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    workbook.Write(fs);
                }

                MessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exportarAExcelCompras(string fechaInicio, string fechaFinal)
        {
            List<Modelos.Compra> lista = cInformes.datosCompras(fechaInicio, fechaFinal);
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("Compras");
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("No.factura");
            filaEncabezados.CreateCell(1).SetCellValue("Usuario en turno");
            filaEncabezados.CreateCell(3).SetCellValue("Total (C$)");
            filaEncabezados.CreateCell(7).SetCellValue("fecha");
            for (int i = 0; i < lista.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(lista[i].ID);
                fila.CreateCell(1).SetCellValue(lista[i].USUARIO.NOMBRE);
                fila.CreateCell(3).SetCellValue((double)lista[i].SUBTOTAL);
                fila.CreateCell(7).SetCellValue(lista[i].FECHA_REGISTRO);
            }
            for (int i = 0; i < 3; i++)
            {
                hoja.AutoSizeColumn(i);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    workbook.Write(fs);
                }

                MessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exportarAExcelVentas(string fechaInicio,string fechaFinal)
        {
            List<Modelos.Venta> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("Ventas");
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("No de factura");
            filaEncabezados.CreateCell(1).SetCellValue("Nombre del cliente");
            filaEncabezados.CreateCell(2).SetCellValue("usuario en turno");
            filaEncabezados.CreateCell(3).SetCellValue("IVA");
            filaEncabezados.CreateCell(4).SetCellValue("Subtotal");
            filaEncabezados.CreateCell(5).SetCellValue("Descuento(c$)");
            filaEncabezados.CreateCell(6).SetCellValue("Total");
            filaEncabezados.CreateCell(7).SetCellValue("fecha");
            for (int i = 0; i < lista.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(lista[i].ID);
                fila.CreateCell(1).SetCellValue(lista[i].CLIENTE.NOMBRES);
                fila.CreateCell(2).SetCellValue(lista[i].USUARIO.NOMBRE);
                fila.CreateCell(3).SetCellValue((int)lista[i].IVA);
                fila.CreateCell(4).SetCellValue((double)lista[i].SUBTOTAL);
                fila.CreateCell(5).SetCellValue((double)lista[i].DESCUENTO);
                fila.CreateCell(6).SetCellValue((double)(lista[i].SUBTOTAL * lista[i].DESCUENTO));
                fila.CreateCell(7).SetCellValue(lista[i].FECHA_REGISTRO);
            }
            for (int i = 0; i < 3; i++)
            {
                hoja.AutoSizeColumn(i);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    workbook.Write(fs);
                }

                MessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
