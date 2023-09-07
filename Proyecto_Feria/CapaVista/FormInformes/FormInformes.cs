using CapaControlador;
using CapaDatos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using NPOI.SS.Formula.Functions;
using Aspose.Pdf;
using MathNet.Numerics;

namespace CapaPresentacion.FormInformes
{
    public partial class FormInformes : MaterialForm
    {
        ControlInforme cInforme = new ControlInforme();
        ReportesTipo reportes = new ReportesTipo();
        bool excel = false;
        bool Ventas = false;
        bool Inventario = false;
        bool Compras = false;
        bool Nomina = false;
        bool movimiento = false;
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            tgExcel.Checked = true;
        }

        private void ReporteHoy_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string hoy = now.ToString("yyyy-MM-dd");
            if (Ventas)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(hoy, hoy);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(hoy, hoy, "Informe de ventas del dia de hoy " + now.ToString($"dddd dd MMMM año yyyy"), false, false);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(hoy, hoy);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(hoy, hoy, "Informe de ventas del dia de hoy " + now.ToString($"dddd dd MMMM año yyyy"), false, false);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(hoy, hoy, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;

            PanelRangoreport.Visible = panelVisible;



        }
        private void ReporteAyer_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime date = now.Date.AddDays(-1);
            string ayer = date.ToString("yyyy-MM-dd");

            if (Ventas)
            {

                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(ayer, ayer);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(ayer, ayer, "Informe de ventas de ayer " + date.ToString($"dddd dd MMMM año yyyy"), false, false);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(ayer, ayer);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(ayer, ayer, "Informe de Compras de ayer " + date.ToString($"dddd dd MMMM año yyyy"), false, false);
                    }
                    Compras = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(ayer, ayer, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;
            PanelRangoreport.Visible = panelVisible;
        }
        private void ReporteMesActual_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            string inicio = firstDayOfMonth.ToString("yyyy-MM-dd");
            string fin = now.ToString("yyyy-MM-dd");
            CultureInfo cultureInfo = new CultureInfo("es-ES");
            if (Ventas)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(inicio, fin);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(inicio, fin, "Informe de ventas del mes de " + now.ToString("MMMM") + " del " + now.Year, false, false);

                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(inicio, fin);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(inicio, fin, "Informe de compras del mes de " + now.ToString("MMMM") + " del " + now.Year, false, false);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(inicio, fin, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel

        }
        private void ReporteAñoActual_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfYear = new DateTime(now.Year, 1, 1);
            DateTime lastDayOfYear = new DateTime(now.Year, 12, 31).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            string inicio = firstDayOfYear.ToString("yyyy-MM-dd");
            string final = lastDayOfYear.ToString("yyyy-MM-dd");
            if (Ventas)
            {

                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(inicio, final);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(inicio, final, "", true, true);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(inicio, final);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(inicio, final, "", true, true);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(inicio, final, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;
            PanelRangoreport.Visible = panelVisible;
        }
        private void ReporteFechaPersonaizado_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = pkrFechaInicio.Value;
            DateTime FechaFinal = pkrFechaFin.Value;
            string fi = FechaInicio.ToString("yyyy-MM-dd");
            string ff = FechaFinal.ToString("yyyy-MM-dd");
            if (Ventas)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(fi, ff);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(fi, ff, "", false, false);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(fi, ff);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(fi, ff, "", false, false);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(fi, ff, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;

            PanelRangoreport.Visible = panelVisible;

        }
        private void FechaUltimaSemana_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime startOfLastWeek = today.AddDays(-7);
            DateTime endOfLastWeek = today.AddDays(0);
            string fInicio = startOfLastWeek.ToString("yyyy-MM-dd");
            string ffin = endOfLastWeek.ToString("yyyy-MM-dd");
            if (Ventas)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(fInicio, ffin);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteVentas(fInicio, ffin, "", true, false);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(fInicio, ffin);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(fInicio, ffin, "", true, false);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(fInicio, ffin, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;

            PanelRangoreport.Visible = panelVisible;
        }
        private void btn15Dias_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime last15Days = now.AddDays(-15);
            string inicio = last15Days.ToString("yyyy-MM-dd");
            string final = now.ToString("yyyy-MM-dd");
            if (Ventas)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelVentas(inicio, final);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;

                        reportes.crearReporteVentas(inicio, final, "", false, false);
                    }
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    if (excel == true)
                    {
                        reportes.exportarAExcelCompras(inicio, final);
                    }
                    else
                    {
                        QuestPDF.Settings.License = LicenseType.Community;
                        reportes.crearReporteCompras(inicio, final, "", true, false);
                    }
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (movimiento)
            {
                try
                {

                    FormMovimientoProducto form = new FormMovimientoProducto(inicio, final, excel);
                    form.ShowDialog();
                    movimiento = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible;
            PanelRangoreport.Visible = panelVisible;
        }

        private bool panelVisible = false;

        private void PanelRangoreport_Click(object sender, EventArgs e)
        {
            panelVisible = !panelVisible;
            PanelRangoreport.Visible = panelVisible;
            Button boton = sender as Button;
            Ventas = false;
            Compras = false;
            Nomina = false;
            movimiento = false;
            if (boton != null && boton == btnInforVentas)
            {
                Ventas = true;
            }
            if (boton != null && boton == btninfoCompras)
            {
                Compras = true;
            }
            if (boton != null && boton == btnNomina)
            {
                Nomina = true;
            }
            if (boton != null && boton == btnMovimientoProductos)
            {
                movimiento = true;
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            //kerlint campia el tooltip de esto que ya no tiene nada que ver con el contenido del form
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Generacion de Informes\n" +
                                            "Informes que se pueden Generar:\n" +
                                            "1.Informe de las Ventas a detalles \n" +
                                            "2.Informe de Compras realizadas a Proveedores\n" +
                                            "3.Informe de Inventario de los Productos\n" +
                                            "4.Informe de Nomina de los Empleados\n" +
                                            "5.Informe de Movimiento de productos\n" +
                                            "Como Generarlos: \n" +
                                            "1. Seleccione con un click el informe que sea generar.\n" +
                                            "2. Seleccione con un click el periodo deseado\n" +
                                            "3. Seleccione con un click el tipo de informe ( Excel o PDF) \n" +
                                            "En el periodo Personalizado Seleccionar Fecha de \n" +
                                            "inicio y Fecha de finalizacion del Periodo\n");
        }



        private void pkrFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            pkrFechaFin.MinDate = pkrFechaInicio.Value;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (excel == true)
                {
                    reportes.exportarAExcelInventario();
                }
                else
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    reportes.crearReporteInventario();
                }
                Inventario = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tgExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (tgExcel.Checked == true)
            {
                tgPdf.Checked = false;
                excel = true;
            }
            else
            {
                tgPdf.Checked = true;
                excel = false;
            }
        }

        private void tgPdf_CheckedChanged(object sender, EventArgs e)
        {
            if (tgPdf.Checked == true)
            {
                tgExcel.Checked = false;
                excel = false;
            }
            else
            {
                tgExcel.Checked = true;
                excel = true;
            }
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            FormRealizarNomina frn = new FormRealizarNomina(excel);
            frn.ShowDialog();
        }
    }
}