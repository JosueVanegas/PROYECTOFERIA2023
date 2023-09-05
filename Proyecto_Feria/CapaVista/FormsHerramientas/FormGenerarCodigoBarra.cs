using ReaLTaiizor.Forms;
using BarcodeLib;
using System.Windows.Forms;
using CapaControlador;
using CapaDatos;

namespace CapaVista.FormsHerramientas
{
    public partial class FormGenerarCodigoBarra : MaterialForm
    {
        ControlProducto cP = new ControlProducto();
        public FormGenerarCodigoBarra()
        {
            InitializeComponent();
        }
        private void FormGenerarCodigoBarra_Load(object sender, EventArgs e)
        {
            cbxProductos.DataSource = cP.listarComboProductos();
        }
        private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboProducto combo = cbxProductos.SelectedItem as comboProducto;
            txtCodigo.Text = combo.codigo;
            txtTitulo.Text = combo.nombre;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (imagenCodigo.Image != null)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                guardar.FileName = txtCodigo.Text + ".png";

                if (guardar.ShowDialog() != DialogResult.Cancel)
                {
                    string codigo = guardar.FileName;
                    Bitmap bitmap = new Bitmap(imagenCodigo.Image);
                    bitmap.Save(codigo);
                    MessageBox.Show("Codigo de barras '" + txtCodigo.Text + "' guardado correctamente");
                }
            }
            else
            {
                MessageBox.Show("No se ha generado ningun codigo");
            }
        }
        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtCodigo.Text != "")
            {
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;
                codigo.LabelPosition = LabelPositions.BOTTOMCENTER;
                Image imgCodigo = codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 300, 120);
                Bitmap imagenTitulo = convertirTextoImagen(txtTitulo.Text.Trim(), 300, Color.White);

                int alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;

                Bitmap imagenNueva = new Bitmap(300, alto_imagen_nuevo);
                Graphics dibujar = Graphics.FromImage(imagenNueva);

                dibujar.DrawImage(imagenTitulo, new Point(0, 0));
                dibujar.DrawImage(imgCodigo, new Point(0, imagenTitulo.Height));
                imagenCodigo.Image = imagenNueva;
            }
            else
            {
                imagenCodigo.Image = null;
            }
        }
        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            System.Drawing.Font objFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
            Width = ancho;
            Height = (int)objGraphics.MeasureString(texto, objFont).Height + 5;
            objBitmap = new Bitmap(objBitmap, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBitmap);

            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            StringFormat drawFormat = new StringFormat();
            objGraphics.Clear(color);

            drawFormat.Alignment = StringAlignment.Center;
            objGraphics.DrawString(texto, objFont, new SolidBrush(Color.Black), new RectangleF(0, (objBitmap.Height / 2) - (objBitmap.Height - 10), objBitmap.Width, objBitmap.Height), drawFormat);
            objGraphics.Flush();
            return objBitmap;
        }
    }
}

/*
 * con libreria zen no tiene muchas opciones
 * Zen.Barcode.Code128BarcodeDraw d = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
imagenCodigo.Image = d.Draw(txtCodigo.Text, 70);
 */
