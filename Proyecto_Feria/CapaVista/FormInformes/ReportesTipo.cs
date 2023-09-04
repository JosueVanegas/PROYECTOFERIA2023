﻿using CapaControlador;
using CapaDatos;
using Microcharts;
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
        Empresa empresa = new ControlEmpresa().datosEmpresa();
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
        void contenidoVentas(IContainer content)
        {
            decimal subTotal = 0;
            decimal descuento = 0;
            decimal iva = 0;
            decimal Total = 0;
            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
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
                        foreach (var venta in lista)
                        {
                            DateTime fechaVenta = DateTime.Parse(venta.fecha);
                            int month = fechaVenta.Month;

                            // Sumar el monto total de la venta al mes correspondiente en el diccionario.
                            totalsByMonth[month] += venta.total;
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
                            DateTime date = DateTime.Parse(i.fecha);
                            DayOfWeek dayOfWeek = date.DayOfWeek;

                            // Sumar el monto total de la venta al día correspondiente en el diccionario.
                            totalesPorDiaSemana[dayOfWeek] += i.total;
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
                        subTotal += i.subtotal;
                        iva += i.iva;
                        descuento += i.descuento;
                        Total += i.total;
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
        public void crearReporteCompras()
        {

        }
        public void crearReporteNomina()
        {

        }
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
            List<informeInventario> lista = cInformes.datosInventario();
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("inventario " + DateTime.Now.ToString("dd/MM/yyyy"));
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("Codigo");
            filaEncabezados.CreateCell(1).SetCellValue("Producto");
            filaEncabezados.CreateCell(2).SetCellValue("Categoria");
            filaEncabezados.CreateCell(3).SetCellValue("Proveedor");
            filaEncabezados.CreateCell(4).SetCellValue("Precio de compra");
            filaEncabezados.CreateCell(5).SetCellValue("Precio de venta");
            filaEncabezados.CreateCell(6).SetCellValue("cantidad en inventario");
            filaEncabezados.CreateCell(7).SetCellValue("Fecha de registro");
            for (int i = 0; i < lista.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(lista[i].codigo);
                fila.CreateCell(1).SetCellValue(lista[i].producto);
                fila.CreateCell(2).SetCellValue(lista[i].categoria);
                fila.CreateCell(3).SetCellValue(lista[i].proveedor);
                fila.CreateCell(4).SetCellValue((double)lista[i].precioCompra);
                fila.CreateCell(5).SetCellValue((double)lista[i].precioVenta);
                fila.CreateCell(6).SetCellValue((double)lista[i].cantidad);
                fila.CreateCell(7).SetCellValue(lista[i].fecha);
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
        public void exportarAExcelCompras()
        {

        }
        public void exportarAExcelNomina()
        {

        }
        public void exportarAExcelVentas(string fechaInicio,string fechaFinal)
        {
            List<informeVentas> lista = cInformes.datosDeVentas(fechaInicio, fechaFinal);
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
                fila.CreateCell(0).SetCellValue(lista[i].noFactura);
                fila.CreateCell(1).SetCellValue(lista[i].nombreCliente);
                fila.CreateCell(2).SetCellValue(lista[i].nombreEmpleado);
                fila.CreateCell(3).SetCellValue((int)lista[i].iva);
                fila.CreateCell(4).SetCellValue((double)lista[i].subtotal);
                fila.CreateCell(5).SetCellValue((double)lista[i].descuento);
                fila.CreateCell(6).SetCellValue((double)lista[i].total);
                fila.CreateCell(7).SetCellValue(lista[i].fecha);
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
