using CapaControlador;
using CapaDatos;
using Microsoft.VisualBasic.Devices;
using NPOI.SS.Formula.Functions;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormaAjustesEntidad : MaterialForm
    {
        string urlImagen = "";
        ControlEmpresa cEmp = new ControlEmpresa();
        public FormaAjustesEntidad()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureEmpresa.Image.Save(memoryStream, pictureEmpresa.Image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                Modelos.Empresa empresa = new Modelos.Empresa
                {
                    NOMBRE = txtNombreEmpresa.Text,
                    DIRECCION = txtDireccion.Text,
                    CORREO = txtCorreo.Text,
                    TELEFONO = txtTelefono.Text,
                    IMAGEN = imageBytes
                };
                MessageBox.Show(cEmp.actualizarDatosEmpresa(empresa));
            }
            else
            {
                MessageBox.Show("LLene todos los campos para actualizar los datos");
            }
        }
        private bool validarCampos()
        {
            bool permitir = false;
            if (txtNombreEmpresa.Text != "" && txtDireccion.Text != "" &&
                txtTelefono.Text != "" && txtCorreo.Text != "" && pictureEmpresa.Image != null)
            {
                permitir = true;
            }
            return permitir;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox4, "Bienvenido a la configuracion de la empresa\n" +
                                            "Para Configurar la entidad de la empresa:\n" +
                                            "1. Seleccionar el logotipo de la identidad\n" +
                                            "2. Ingresar los datos de la misma\n" +
                                            "3.seleccione 'Guardar' para realizar los cambios en la informacion de la Entidad\n" +
                                            "Estos datos se usan para las cabezeras de los reportes y diseño de la aplicacion en general ");
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;";
            openFileDialog.Title = "Selecciona una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                urlImagen = openFileDialog.FileName;
                pictureEmpresa.Image = Image.FromFile(urlImagen);
            }
        }

        private void FormaAjustesEntidad_Load(object sender, EventArgs e)
        {
            extraerDatos();
        }
        private void extraerDatos()
        {
            Modelos.Empresa emp = cEmp.datosEmpresa();
            if (emp != null)
            {
                txtNombreEmpresa.Text = emp.NOMBRE;
                txtCorreo.Text = emp.CORREO;
                txtDireccion.Text = emp.DIRECCION;
                txtTelefono.Text = emp.TELEFONO;
                if (emp.IMAGEN != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(emp.IMAGEN))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        pictureEmpresa.Image = imagen;
                    }
                }
            }
        }
    }
}
