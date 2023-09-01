using CapaControlador;
using CapaDatos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ReaLTaiizor.Forms;
using System.Diagnostics;

namespace CapaPresentacion.FormInformes
{
    public partial class FormInformes : MaterialForm
    {
        ControlInforme cInforme = new ControlInforme();

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
            pkrFechaFin.MaxDate = DateTime.Now;
            pkrFechaInicio.MaxDate = DateTime.Now;
        }

        private void ReporteHoy_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            // Establecer la hora a las 00:00:00 (medianoche) de hoy
            DateTime startOfToday = now.Date;

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
            string startOfTodayFormatted = startOfToday.ToString("dd/MM/yyyy");
            string endOfTodayFormatted = now.ToString("dd/MM/yyyy");


            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfTodayFormatted.ToString(), endOfTodayFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(startOfTodayFormatted.ToString(), endOfTodayFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfTodayFormatted.ToString(), endOfTodayFormatted.ToString());
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
                    ReportesTipo.NominaCrearReporte_Hoy_Ayer_Mes_15Dias(startOfTodayFormatted.ToString(), endOfTodayFormatted.ToString());
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

            // Restar un día a la fecha y establecer la hora a las 00:00:00
            DateTime startOfYesterday = now.Date.AddDays(-1);

            // Formatear las fechas en el formato "dd/MM/yyyy "
            string startOfYesterdayFormatted = startOfYesterday.ToString("dd/MM/yyyy");
            string endOfYesterdayFormatted = now.ToString("dd/MM/yyyy");

            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfYesterdayFormatted.ToString(), endOfYesterdayFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(startOfYesterdayFormatted.ToString(), endOfYesterdayFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfYesterdayFormatted.ToString(), endOfYesterdayFormatted.ToString());
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
                    ReportesTipo.NominaCrearReporte_Hoy_Ayer_Mes_15Dias(startOfYesterdayFormatted.ToString(), endOfYesterdayFormatted.ToString());
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
        private void ReporteMesActual_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            // Obtener el primer día del mes actual
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
            string startOfMonthFormatted = firstDayOfMonth.ToString("dd/MM/yyyy");
            string endOfMonthFormatted = now.ToString("dd/MM/yyyy");

            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfMonthFormatted.ToString(), endOfMonthFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(startOfMonthFormatted.ToString(), endOfMonthFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(startOfMonthFormatted.ToString(), endOfMonthFormatted.ToString());
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
                    ReportesTipo.NominaCrearReporte_Hoy_Ayer_Mes_15Dias(startOfMonthFormatted.ToString(), endOfMonthFormatted.ToString());
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
            string startOfYearFormatted = firstDayOfYear.ToString("dd/MM/yyyy");
            string endOfYearFormatted = lastDayOfYear.ToString("dd/MM/yyyy");


            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporteAnual(startOfYearFormatted.ToString(), endOfYearFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporteAnual(startOfYearFormatted.ToString(), endOfYearFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporteAnual(startOfYearFormatted.ToString(), endOfYearFormatted.ToString());
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
                    ReportesTipo.NominaReporteAnual(startOfYearFormatted.ToString(), endOfYearFormatted.ToString());
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


            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporte_Hoy_Ayer_Mes_15Dias(FechaInicio.ToString(), FechaFinal.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(FechaInicio.ToString(), FechaFinal.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(FechaInicio.ToString(), FechaFinal.ToString());
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
                    ReportesTipo.NominaCrearReporte_Hoy_Ayer_Mes_15Dias(FechaInicio.ToString(), FechaFinal.ToString());
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

        //"15/08/2023", "27/08/2023"
        private void FechaUltimaSemana_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Calcular la fecha de inicio de la última semana (hace 7 días)
            DateTime startOfLastWeek = today.AddDays(-7);

            // Calcular la fecha de fin de la última semana (hoy menos un día)
            DateTime endOfLastWeek = today.AddDays(-1);

            // Formatear las fechas en el formato "dd/MM/yyyy"
            string startOfLastWeekFormatted = startOfLastWeek.ToString("dd/MM/yyyy");
            string endOfLastWeekFormatted = endOfLastWeek.ToString("dd/MM/yyyy");



            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporteSemanalActual(startOfLastWeekFormatted.ToString(), endOfLastWeekFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporteSemanalActual(startOfLastWeekFormatted.ToString(), endOfLastWeekFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporteSemanalActual(startOfLastWeekFormatted.ToString(), endOfLastWeekFormatted.ToString());
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
                    ReportesTipo.NominaCrearReporteSemanalActual(startOfLastWeekFormatted.ToString(), endOfLastWeekFormatted.ToString());
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

        private bool panelVisible = false; // Variable para realizar un seguimiento de la visibilidad del panel

        private void PanelRangoreport_Click(object sender, EventArgs e)
        {
            panelVisible = !panelVisible; // Cambiar el estado de la visibilidad

            PanelRangoreport.Visible = panelVisible; // Aplicar el estado de visibilidad actual al panel

            Button boton = sender as Button;

            // Supongamos que btnventas es otro botón que quieres comparar
            if (boton != null && boton == btnInforVentas)
            {
                Ventas = true;
                Inventario = false;
                Compras = false;
                Nomina = false;

            }
            if (boton != null && boton == btnInventario)
            {
                Ventas = false;
                Inventario = true;
                Compras = false;
                Nomina = false;

            }

            if (boton != null && boton == btninfoCompras)
            {
                Ventas = false;
                Inventario = false;
                Compras = true;
                Nomina = false;

            }
            if (boton != null && boton == btnNomina)
            {
                Ventas = false;
                Inventario = false;
                Compras = false;
                Nomina = true;

            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
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
            string startFormatted = last15Days.ToString("dd/MM/yyyy");
            string endFormatted = now.ToString("dd/MM/yyyy");


            if (Ventas)
            {

                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    MessageBox.Show("Error: Esta operación solo es válida para el botón btnventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReportesTipo.VentasCrearReporte_Hoy_Ayer_Mes_15Dias(startFormatted.ToString(), endFormatted.ToString());
                    Ventas = false;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (Inventario)
            {
                try
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    ReportesTipo.InventarioCrearReporte_Hoy_Ayer_Mes_15Dias(startFormatted.ToString(), endFormatted.ToString());
                    Inventario = false;

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
                    ReportesTipo.ComprasCrearReporte_Hoy_Ayer_Mes_15Dias(startFormatted.ToString(), endFormatted.ToString());
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
                    ReportesTipo.NominaCrearReporte_Hoy_Ayer_Mes_15Dias(startFormatted.ToString(), endFormatted.ToString());
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
    }
}

