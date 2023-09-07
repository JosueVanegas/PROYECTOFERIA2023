﻿using CapaControlador;
using CapaDatos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Infrastructure;
using IContainer = QuestPDF.Infrastructure.IContainer;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace CapaPresentacion.FormInformes
{
    public partial class FormRealizarNomina : MaterialForm
    {
        ControlEmpleados cEmp = new ControlEmpleados();
        ControlInforme cInformes = new ControlInforme();
        Empresa empresa = new ControlEmpresa().datosEmpresa();
        List<nomina> nominas;
        string tituloRango = "Nómina realizada el " + DateTime.Now.ToString($"dddd dd MMMM año yyyy");
        string colorFondoNomina = "#CCCAFE ";
        bool excel;
        public FormRealizarNomina(bool exl)
        {
            InitializeComponent();
            this.excel = exl;
        }

        private void FormRealizarNomina_Load(object sender, EventArgs e)
        {
            mostrarEmpleado();
        }
        private void mostrarEmpleado()
        {
            List<Empleado> lista = cEmp.listarEmpleados();
            tbEmpleados.Rows.Clear();
            foreach (Empleado e in lista)
            {
                tbEmpleados.Rows.Add("", e.id, e.nombres + " " + e.apellidos, e.salarioHora, "", "");
            }
        }

        private void tbEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                lblId.Text = tbEmpleados.Rows[indice].Cells[1].Value.ToString();
                txtEmpleado.Text = tbEmpleados.Rows[indice].Cells[2].Value.ToString();
            }
        }
        private void btnRealizarNomina_Click(object sender, EventArgs e)
        {
            if (validarEntradas() != true)
            {
                nominas = new List<nomina>();
                foreach (DataGridViewRow fila in tbEmpleados.Rows)
                {
                    int id = Convert.ToInt32(fila.Cells[1].Value);
                    int cantidadHoras = Convert.ToInt32(fila.Cells[4].Value);
                    int cantidadHorasExtras = Convert.ToInt32(fila.Cells[5].Value);
                    List<Empleado> empleados = cEmp.listarEmpleados();
                    Empleado empleadoEncontrado = empleados.Find(empleado => empleado.id == id);

                    if (empleadoEncontrado != null)
                    {
                        nomina n = cInformes.calcularnomina(empleadoEncontrado, cantidadHoras, cantidadHorasExtras);
                        nominas.Add(n);
                    }
                }
                if (nominas.Count > 0)
                {
                    if (excel == true)
                    {
                        exportarAExcelInventario();
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        crearPdf();
                    }
                }
                else
                {
                    MessageBox.Show("error al cargar las nominas de los trabajadores");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Tienes que llenar las horas trabajadas de todos los trabajadores");
            }
        }
        private bool validarEntradas()
        {
            bool hayVacia = false;

            foreach (DataGridViewRow fila in tbEmpleados.Rows)
            {
                if (fila.Cells[4].Value.ToString() == "")
                {
                    hayVacia = true;
                    break;
                }
            }

            return hayVacia;
        }
        private void crearPdf()
        {

            var dox = QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(100).Background(colorFondoNomina);
                    page.Foreground().AlignBottom().ExtendHorizontal().Height(50).Background(colorFondoNomina);
                    //estructura ordenada el heater y footer se repite en todos los reportes
                    page.Header().Element(Encabezado);
                    page.Footer().Element(piePagina);
                    page.Content().Element(contenidoNomina);
                });
            });
            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
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
                    col.Item().AlignCenter().Text(empresa.nombre).FontSize(15).Bold();
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
        void contenidoNomina(IContainer content)
        {
            decimal totalPagarNomina = 0;
            content.PaddingVertical(25).Column(column =>
            {
                column.Item().AlignCenter().Text("Nómina de pago al personal").FontSize(15);
                column.Item().AlignCenter().Text("Expresada en Cordobas(C$)").FontSize(15);
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
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(3);
                    });

                    tab.Header(het =>
                    {
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Nombre del trabajador").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Cargo").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Salario por hora").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Horas trabajadas").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Monto horas trabajadas").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Horas extras trabajadas ").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Monto horas extras").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Salario devengado").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Inss laboral").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("IR laboral").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Total deducciones").FontSize(10);
                        het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Neto a recibir").FontSize(10);
                    });

                    foreach (nomina i in nominas)
                    {

                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.trabajador).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.cargo).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.salarioHora.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.horastrabajadas).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.montoHorasTrabajadas.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.horasExtras).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.montoHorasExtras.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.salarioDevengado.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.inss.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.ir.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.totalDeducciones.ToString("0.00")).FontSize(9);
                        tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.salarioNeto.ToString("0.00")).FontSize(9);
                        totalPagarNomina += i.salarioNeto;
                    }
                });
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Total a pagar en nómina: " + totalPagarNomina.ToString("0.00") + " C$").FontSize(15);
                        });
                    });
                });
            });
        }
        public void exportarAExcelInventario()
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet hoja = workbook.CreateSheet("Nómina periodo " + DateTime.Now.ToString("dd_MM_yyyy"));
            IRow filaEncabezados = hoja.CreateRow(0);
            filaEncabezados.CreateCell(0).SetCellValue("Nombre del trabajador");
            filaEncabezados.CreateCell(1).SetCellValue("Cargo");
            filaEncabezados.CreateCell(2).SetCellValue("Salario hora");
            filaEncabezados.CreateCell(3).SetCellValue("Horas trabajadas");
            filaEncabezados.CreateCell(4).SetCellValue("Monto horas trabajadas");
            filaEncabezados.CreateCell(5).SetCellValue("Horas extras trabajadas");
            filaEncabezados.CreateCell(6).SetCellValue("Monto horas extras");
            filaEncabezados.CreateCell(7).SetCellValue("Salario devengado");
            filaEncabezados.CreateCell(8).SetCellValue("INNS laboral");
            filaEncabezados.CreateCell(9).SetCellValue("IR laboral");
            filaEncabezados.CreateCell(10).SetCellValue("Total en deducción");
            filaEncabezados.CreateCell(11).SetCellValue("Salario neto a recibir");
            for (int i = 0; i < nominas.Count; i++)
            {
                IRow fila = hoja.CreateRow(i + 1);
                fila.CreateCell(0).SetCellValue(nominas[i].trabajador);
                fila.CreateCell(1).SetCellValue(nominas[i].cargo);
                fila.CreateCell(2).SetCellValue((double)nominas[i].salarioHora);
                fila.CreateCell(3).SetCellValue((int)nominas[i].horastrabajadas);
                fila.CreateCell(4).SetCellValue((double)nominas[i].montoHorasTrabajadas);
                fila.CreateCell(5).SetCellValue((int)nominas[i].horasExtras);
                fila.CreateCell(6).SetCellValue((double)nominas[i].montoHorasExtras);
                fila.CreateCell(7).SetCellValue((double)nominas[i].salarioDevengado);
                fila.CreateCell(8).SetCellValue((double)nominas[i].inss);
                fila.CreateCell(9).SetCellValue((double)nominas[i].ir);
                fila.CreateCell(10).SetCellValue((double)nominas[i].totalDeducciones);
                fila.CreateCell(11).SetCellValue((double)nominas[i].salarioNeto);
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tbEmpleados.Rows)
            {
                if (fila.Cells[1].Value != null && Convert.ToInt32(fila.Cells[1].Value) == Convert.ToInt32(lblId.Text))
                {
                    if (txtHorasTrabajadas.Text != "")
                    {
                        fila.Cells[4].Value = txtHorasTrabajadas.Text;
                        fila.Cells[5].Value = txthorasExtras.Text;
                    }
                    break;
                }
            }
        }

        private void btnCerrarBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void txtHorasTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txthorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}