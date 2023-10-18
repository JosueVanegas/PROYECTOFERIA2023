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
using System.Collections;
using Aspose.Pdf.Operators;

namespace CapaPresentacion.FormInformes
{
    public partial class FormMovimientoProducto : MaterialForm
    {
        Modelos.Empresa empresa = new ControlEmpresa().datosEmpresa();
        string colorFondoMovimiento = "#97C2BF";
        int idProducto = 0;
        DateTime fechaInicio;
        DateTime fechaFinal;
        bool excel = false;
        public FormMovimientoProducto(DateTime fechaInicio, DateTime fechaFinal, bool excel)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.excel = excel;
            mostrarProductosDisponible();
            this.Cursor = Cursors.Default;
            txtFechaInicio.Text = fechaInicio.ToString();
            txtFechaFin.Text = fechaFinal.ToString();
        }
        private void mostrarProductosDisponible()
        {
            List<Modelos.Producto> lista = new ControlProducto().listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Modelos.Producto p in lista)
            {
                tbBusqueda.Rows.Add("", p.ID, p.CODIGO, p.NOMBRE);
            }
        }
        private void btnRealizarInforme_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "0" && txtCodigo.Text != "")
            {
                try
                {
                    if (excel == true)
                    {
                        exportarExcel();
                    }
                    else
                    {
                        crearReporteMovimientoProducto();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto a realizar los movimiento en el periodo");
            }
        }
        private void exportarExcel()
        {
            List<Modelos.Movimiento> lista = new ControlInforme().datosMovientoInventario(idProducto, fechaInicio, fechaFinal);
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("movimiento_producto");
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("Fecha");
            filaEncabezados.CreateCell(1).SetCellValue("Tipo de movimiento");
            filaEncabezados.CreateCell(2).SetCellValue("cantidad");
            filaEncabezados.CreateCell(3).SetCellValue("precio unitario");
            filaEncabezados.CreateCell(4).SetCellValue("Total");

            for (int i = 0; i < lista.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(lista[i].FECHA);
                fila.CreateCell(1).SetCellValue(lista[i].TIPO);
                fila.CreateCell(2).SetCellValue(lista[i].CANTIDAD);
                fila.CreateCell(3).SetCellValue((double)lista[i].PRECIO);
                double total = lista[i].CANTIDAD * (double)lista[i].PRECIO;
                fila.CreateCell(4).SetCellValue(total);
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
        private void crearReporteMovimientoProducto()
        {

            try
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
                QuestPDF.Settings.License = LicenseType.Community;
                var filePath = "invoice.pdf";
                doc.GeneratePdf(filePath);
                Process.Start("explorer.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        .Image(empresa.IMAGEN).FitArea()
                        .WithCompressionQuality(ImageCompressionQuality.VeryLow);
                });
                row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                {
                    col.Item().ScaleToFit().AlignCenter().Text(empresa.NOMBRE).FontSize(15).Bold();
                    col.Item().AlignCenter().Text("Teléfono: " + empresa.TELEFONO).FontSize(7);
                    col.Item().AlignCenter().Text("Correo electronico: " + empresa.CORREO).FontSize(7);
                    col.Item().AlignCenter().Text("Direccion: " + empresa.DIRECCION).FontSize(7);
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
            string tituloRango = "Informe realizado desde " + fechaInicio + " hasta " + fechaFinal;
            decimal saldoActual = 0;
            decimal totalCompras = 0;
            decimal totalVentas = 0;
            List<Modelos.Movimiento> lista = new ControlInforme().datosMovientoInventario(Convert.ToInt32(txtId.Text), fechaInicio, fechaFinal);
            content.PaddingVertical(25).Column(column =>
            {
                column.Item().AlignCenter().Text("Informe de movimientos de producto").FontSize(18);
                column.Item().PaddingLeft(100).AlignLeft().Text("Codigo: " + txtCodigo.Text).FontSize(15);
                column.Item().PaddingLeft(100).AlignLeft().Text("Nombre: " + txtNombre.Text).FontSize(15);
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
                        foreach (Modelos.Movimiento i in lista)
                        {

                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.FECHA).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.TIPO).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CANTIDAD).FontSize(12);
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.PRECIO.ToString("0.00")).FontSize(12);
                            decimal total = i.PRECIO * i.CANTIDAD;
                            tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(total.ToString("0.00")).FontSize(12);
                            if (i.TIPO.ToUpper() == "COMPRA")
                            {
                                totalCompras += total;
                            }
                            else if (i.TIPO.ToUpper() == "VENTA")
                            {
                                totalVentas += total;
                            }
                            saldoActual += totalVentas - totalCompras;
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

        private void tbBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbBusqueda.Columns[e.ColumnIndex].Name == "Añadir")
            {
                if (indice >= 0)
                {
                    txtId.Text = tbBusqueda.Rows[indice].Cells[1].Value.ToString();
                    txtCodigo.Text = tbBusqueda.Rows[indice].Cells[2].Value.ToString();
                    txtNombre.Text = tbBusqueda.Rows[indice].Cells[3].Value.ToString();
                }
            }
        }

        private void tbBusqueda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.ojo.Width;
                var h = CapaPresentacion.Properties.Resources.ojo.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.ojo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string nombre = cbxBuscarProducto.SelectedItem.ToString();
            string columna = "";
            if (nombre == "Nombre")
            {
                columna = "NombreP";
            }
            if (nombre == "Codigo")
            {
                columna = "CodigoP";
            }
            if (tbBusqueda.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbBusqueda.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscarProducto.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
    }
}
