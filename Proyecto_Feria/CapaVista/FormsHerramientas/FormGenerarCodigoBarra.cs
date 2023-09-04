using ReaLTaiizor.Forms;

namespace CapaVista.FormsHerramientas
{
    public partial class FormGenerarCodigoBarra : MaterialForm
    {
        public FormGenerarCodigoBarra()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            guardar.FileName = txtCodigo.Text + ".png";

            if (guardar.ShowDialog() != DialogResult.Cancel)
            {
                string codigo = guardar.FileName;
                Bitmap bitmap = new Bitmap(imagenCodigo.Image);
                bitmap.Save(codigo);
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtCodigo.Text != "")
            {
                Zen.Barcode.Code128BarcodeDraw d = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                imagenCodigo.Image = d.Draw(txtCodigo.Text, 70);

            }
            else
            {
                imagenCodigo.Image = null;
            }
        }
    }
}
