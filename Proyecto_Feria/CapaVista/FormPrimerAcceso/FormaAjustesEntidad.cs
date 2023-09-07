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
            // Verificar si el texto actual tiene más de 16 caracteres
            if (txtNombreEmpresa.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                // Si ya tiene 16 caracteres y no es la tecla de "Eliminar", no permitir más entrada
                e.Handled = true;
                return;
            }

            // Permitir solo caracteres alfabéticos y la tecla de "Eliminar"
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si ya hay un '@' en el texto
            if (txtCorreo.Text.Contains("@"))
            {
                // Si ya hay un '@', no permitir otro
                if (e.KeyChar == '@' || char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Ignorar el caracter
                }
                else if (txtCorreo.Text.Length >= 27 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Ignorar el caracter si se supera la longitud máxima
                }
            }
            else
            {
                // Permitir solo un '@', no más de 27 caracteres y la tecla de "Eliminar"
                if (e.KeyChar == '@' || char.IsControl(e.KeyChar) || txtCorreo.Text.Length >= 27)
                {
                    e.Handled = true; // Ignorar el caracter
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
            // Permitir solo caracteres alfanuméricos y / . - espacio y la tecla de "Eliminar"
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter si no es uno de los permitidos
                return;
            }

            // Obtener el texto actual del cuadro de texto
            string textoActual = ((TextBox)sender).Text;

            // Verificar si la longitud del texto más el carácter presionado es igual a 41
            if (textoActual.Length + 1 > 41 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter si la longitud es mayor a 41 y no es la tecla de "Eliminar"
            }
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o el guión "-"
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Ignorar el evento de tecla presionada
            }

            // Verificar si el guión "-" ya está presente
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true; // Ignorar el evento de tecla presionada
            }

            // Verificar si se han ingresado más de 9 caracteres
            if ((sender as TextBox).Text.Length >= 9 && e.KeyChar != 8) // 8 es el código ASCII para la tecla "Backspace"
            {
                e.Handled = true; // Ignorar el evento de tecla presionada
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

        private void txtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres alfabéticos y la tecla de "Eliminar"
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el caracter si no es uno de los permitidos
            }

            // Verificar si el texto actual tiene más de 16 caracteres y permitir la tecla de "Eliminar"
            if (txtRubro.Text.Length >= 25 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el caracter si se supera la longitud máxima
            }
        }

    }
}
