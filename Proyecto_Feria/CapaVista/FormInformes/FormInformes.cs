using CapaControlador;
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

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetVentas ventasDataSet = new DataSetVentas();
                DataTable ventasDataTable = cInforme.datosDeVentas("15/08/2023", "25/08/2023"); // Llama a tu método para obtener el DataTable

                // Agrega el DataTable al conjunto de datos
                ventasDataSet.Tables[0].Merge(ventasDataTable);

                // Paso 2: Configurar el ReportViewer
                this.reportViewer1.LocalReport.ReportPath = "InformeVentas.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ventasDataSet.Tables[0]));

                // Paso 3: Mostrar el ReportViewer
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}
/*
 * reportViewer1.LocalReport.ReportEmbeddedResource = "InformeVentas.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
 */
