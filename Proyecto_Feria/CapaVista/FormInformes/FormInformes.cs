using CapaControlador;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ReaLTaiizor.Forms;
using System.Data;
using CapaPresentacion;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using CapaDatos;

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
                //  this.proC_ordenaR_fechA_ventaTableAdapter1.Fill(, "15/08/2023", "25/08/2023");
                reportViewer1.RefreshReport();
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
