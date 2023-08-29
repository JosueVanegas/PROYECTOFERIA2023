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
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {

        }

        private void ReporteHoy_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Establecer la hora a las 00:00:00 (medianoche) de hoy
            DateTime startOfToday = now.Date;

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
            string startOfTodayFormatted = startOfToday.ToString("dd/MM/yyyy");
            string endOfTodayFormatted = now.ToString("dd/MM/yyyy");
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(startOfTodayFormatted.ToString(), endOfTodayFormatted.ToString());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void ReporteAyer_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            // Restar un día a la fecha y establecer la hora a las 00:00:00
            DateTime startOfYesterday = now.Date.AddDays(-1);

            // Formatear las fechas en el formato "dd/MM/yyyy "
            string startOfYesterdayFormatted = startOfYesterday.ToString("dd/MM/yyyy");
            string endOfYesterdayFormatted = now.ToString("dd/MM/yyyy");
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(startOfYesterdayFormatted.ToString(), endOfYesterdayFormatted.ToString());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void ReporteMesActual_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            // Obtener el primer día del mes actual
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);

            // Formatear las fechas en el formato "dd/MM/yyyy HH:mm:ss"
            string startOfMonthFormatted = firstDayOfMonth.ToString("dd/MM/yyyy 00:00:00");
            string endOfMonthFormatted = now.ToString("dd/MM/yyyy HH:mm:ss");
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(startOfMonthFormatted.ToString(), endOfMonthFormatted.ToString());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }

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

            ;

            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(startOfYearFormatted.ToString(), endOfYearFormatted.ToString());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ReporteFechaPersonaizado_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = pkrFechaInicio.Value;

            DateTime FechaFinal = pkrFechaFin.Value;

            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(FechaInicio.ToString("dd/MM/yyyy"), FechaFinal.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }

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


            try
            {
                QuestPDF.Settings.License = LicenseType.Community;
                crearInforme(startOfLastWeek.ToString(), endOfLastWeek.ToString());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PanelRangoreport_MouseLeave(object sender, EventArgs e)
        {
            PanelRangoreport.Visible = false;
        }
        private void btnEleccionTipoReport_MouseHover(object sender, EventArgs e)
        {
            PanelRangoreport.Visible = true;
        }

        private void crearInforme(string fechaInicio_, string fechaFinal_)
        {


            ControlInforme cInformes = new ControlInforme();
            string fechaInicio = fechaInicio_;
            string fechaFinal = fechaFinal_;
            var dox = QuestPDF.Fluent.Document.Create(doc =>
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
                        /*
                         *   //configuracion del grafico
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
                            })   ;
                    });
                        */

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
            });

            var filePath = "invoice.pdf";
            dox.GeneratePdf(filePath);


            Process.Start("explorer.exe", filePath);
        }

        private void PanelRangoreport_MouseEnter(object sender, EventArgs e)
        {
            PanelRangoreport.Visible = true;
        }
    }
}

