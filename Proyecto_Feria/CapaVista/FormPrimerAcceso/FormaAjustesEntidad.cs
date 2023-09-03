using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormaAjustesEntidad : MaterialForm
    {
        bool Acceso = true;
        string urlImagen = "";
        ControlEmpresa cEmp = new ControlEmpresa();
        public FormaAjustesEntidad(Boolean Acceso)
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
                Empresa empresa = new Empresa
                {
                    nombre = txtNombreEmpresa.Text,
                    rubro = txtRubro.Text,
                    departamento = cbxDepartamento.SelectedItem.ToString(),
                    direccion = txtDireccion.Text,
                    email = txtCorreo.Text,
                    telefono = txtTelefono.Text,
                    fechaFundacion = pickerFecha.Value.ToString("dd/MM/yyyy"),
                    imagen = imageBytes
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
            if (txtNombreEmpresa.Text != "" && txtRubro.Text != "" && txtDireccion.Text != "" &&
                txtTelefono.Text != "" && txtCorreo.Text != "")
            {
                permitir = true;
            }
            return permitir;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void materialTextBoxEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
                if (textBox != null)
                {
                    string input = textBox.Text.Trim();
                    if (IsValidEmail(input))
                    {
                        MessageBox.Show("Correo electrónico válido.");
                    }
                    else
                    {
                        MessageBox.Show("Correo electrónico inválido.");
                    }
                }
                bool IsValidEmail(string email)
                {
                    string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                    Regex regex = new Regex(pattern);
                    return regex.IsMatch(email);
                }
            }
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
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 15 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*";
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
            Empresa emp = cEmp.datosEmpresa();
            if (emp != null)
            {
                txtNombreEmpresa.Text = emp.nombre;
                txtCorreo.Text = emp.email;
                txtDireccion.Text = emp.direccion;
                txtRubro.Text = emp.rubro;
                txtTelefono.Text = emp.telefono;
                DateTime date = DateTime.Parse(emp.fechaFundacion);
                pickerFecha.Value = date;
                string valorABuscar = emp.departamento;

                int indice = cbxDepartamento.FindStringExact(valorABuscar.ToLower());

                if (indice != -1)
                {
                    cbxDepartamento.SelectedIndex = indice;
                }
                if (emp.imagen != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(emp.imagen))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        pictureEmpresa.Image = imagen;
                    }
                }
            }
        }
    }
}
