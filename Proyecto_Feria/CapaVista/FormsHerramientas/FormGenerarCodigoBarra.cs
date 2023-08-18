using ReaLTaiizor.Forms;


namespace CapaVista.FormsHerramientas
{
    public partial class FormGenerarCodigoBarra : MaterialForm
    {
        public FormGenerarCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // no me funciono la libreria BarcodeLib, Zxing,Barcode
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
