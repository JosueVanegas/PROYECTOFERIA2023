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

namespace CapaPresentacion.FormInformes
{
    public partial class FormInformes : MaterialForm
    {
        ControlInforme cInforme = new ControlInforme();
        ReportesTipo reportes = new ReportesTipo();
        bool excel = false;
        Boolean Ventas = false;
        Boolean Inventario = false;
        Boolean Compras = false;
        Boolean Nomina = false;
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
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Nomina = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel



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
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Nomina = false;
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

            // Obtener el primer día del mes actual
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
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
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Nomina = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel

        }
        private void ReporteAñoActual_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            // Obtener el primer día del año (1 de enero)
            DateTime firstDayOfYear = new DateTime(now.Year, 1, 1);

            // Obtener el último día del año (31 de diciembre)
            DateTime lastDayOfYear = new DateTime(now.Year, 12, 31).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
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
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    Nomina = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel

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
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Nomina = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel

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
                    QuestPDF.Settings.License = LicenseType.Community;
                    Compras = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    Nomina = false;
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
            Inventario = false;
            Compras = false;
            Nomina = false;
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
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Generacion de Informes\n" +
                                            "Informes que se pueden Generar:\n" +
                                            "1.Informe de las Ventas a detalles \n" +
                                            "2.Informe de Compras realizadas a Proveedores\n" +
                                            "3.Informe de Inventario de los Productos\n" +
                                            "4.Informe de Nomina de los Empleados\n" +
                                            "Como Generarlos: \n" +
                                            "1. Seleccione con un click el informe que sea generar.\n" +
                                            "2. Seleccione con un click el periodo deseado\n" +
                                            "En el periodo Personalizado Seleccionar Fecha de \n" +
                                            "inicio y Fecha de finalizacion del Periodo\n");
        }

        private void btn15Dias_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // Obtener la fecha actual menos 15 días
            DateTime last15Days = now.AddDays(-15);

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
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
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Compras)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    Compras = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            if (Nomina)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    Nomina = false;
                }

                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel
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
    }
}