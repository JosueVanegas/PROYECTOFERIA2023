using CapaControlador;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ReaLTaiizor.Forms;
using System.Data;

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
            this.reportViewer1.RefreshReport();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //DataTable dt = cInforme.datosDeVentas("15/08/2023", "25/08/2023");
            //dataGridView1.DataSource = dt;
          try
            {
                DataTable dt = cInforme.datosDeVentas("15/08/2023", "25/08/2023");
                reportViewer1.LocalReport.DataSources.Clear();
                //volver a hacer el dataset y el reporte y probar de nuevo
                ReportDataSource source = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Personal\\Source\\Repos\\JosueVanegas\\PROYECTOFERIA2023\\Proyecto_Feria\\CapaVista\\FormInformes\\InformeVentas.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos de ventas: " + ex.Message);
            }
           
        }
    }
}
