using CapaControlador;
using CapaDatos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using ReaLTaiizor.Forms;

namespace CapaPresentacion.FormInformes
{
    public partial class FormMovimientoProducto : MaterialForm
    {
        string tituloRango = "Informe realizado el " + DateTime.Now.ToString($"dddd dd MMMM año yyyy");
        Empresa empresa = new ControlEmpresa().datosEmpresa();
        string colorFondoMovimiento = "#97C2BF";
        string fInicio = "";
        string ffin = "";
        public FormMovimientoProducto()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.Default;
        }

        private void crearReporteMovimientoProducto()
        {

            var doc = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);

                    page.DefaultTextStyle(TextStyle.Default.FontSize(12));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(100).Background(colorFondoMovimiento);
                    page.Header().Element(Encabezado);
                    page.Footer().Element(piePagina);
                    page.Content().Element(contenidoMovimiento);
                });
            });
        }
        void Encabezado(QuestPDF.Infrastructure.IContainer content)
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
        void piePagina(QuestPDF.Infrastructure.IContainer content)
        {
            content.AlignCenter().Text(txt =>
            {
                txt.Span("Pagina  ").FontSize(10);
                txt.CurrentPageNumber().FontSize(10);
                txt.Span("  de  ").FontSize(10);
                txt.TotalPages().FontSize(10);

            });
        }
        void contenidoMovimiento(QuestPDF.Infrastructure.IContainer content)
        {
            decimal saldoActual = 0;
            decimal totalCompras = 0;
            decimal totalVentas = 0;
            List<movimientoProducto> lista = new ControlInforme().datosMovientoInventario(1, fInicio, ffin);
            content.PaddingVertical(25).Column(column =>
            {
                column.Item().AlignCenter().Text("Informe de movimientos de producto").FontSize(18);
                column.Item().PaddingLeft(100).AlignLeft().Text("Codigo: ").FontSize(15);
                column.Item().PaddingLeft(100).AlignLeft().Text("Nombre: ").FontSize(15);
                column.Item().LineHorizontal(0.5f);
                column.Item().AlignCenter().Text(txt =>
                {

                    txt.Span(tituloRango).FontSize(15);

                });
                column.Spacing(30);

                column.Item().LineHorizontal(0.5f);
                //nomina
                column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                {
                    tab.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(4);
                        columns.RelativeColumn(6);
                        columns.RelativeColumn(4);
                        columns.RelativeColumn(4);
                        columns.RelativeColumn(4);
                    });

                    tab.Header(het =>
                    {
                        het.Cell().Border(1).Background(colorFondoMovimiento).Padding(1).Text("Fecha").FontSize(14);
                        het.Cell().Border(1).Background(colorFondoMovimiento).Padding(1).Text("Tipo de movimiento").FontSize(14);
                        het.Cell().Border(1).Background(colorFondoMovimiento).Padding(1).Text("Cantidad").FontSize(14);
                        het.Cell().Border(1).Background(colorFondoMovimiento).Padding(1).Text("Precio unitario").FontSize(14);
                        het.Cell().Border(1).Background(colorFondoMovimiento).Padding(1).Text("Total").FontSize(14);
                        foreach (movimientoProducto i in lista)
                        {

                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.fecha).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.tipo).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.cantidad).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.precio.ToString("0.00")).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.total.ToString("0.00")).FontSize(12);
                            if (i.tipo.ToUpper() == "COMPRA")
                            {
                                totalCompras += i.total;
                            }
                            else if (i.tipo.ToUpper() == "VENTA")
                            {
                                totalVentas += i.total;
                            }
                            saldoActual += totalCompras - totalVentas;
                        }
                    });
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Total en compras: " + totalCompras.ToString("0.00")).FontSize(15);
                                txt.Span("      Total en venta: " + totalVentas.ToString("0.00")).FontSize(15);
                                txt.Span("      Saldo actual: " + saldoActual.ToString("0.00")).FontSize(15);
                            });
                        });
                    });
                });
            });
        }
    }
}
