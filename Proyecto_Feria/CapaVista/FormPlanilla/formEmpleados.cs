using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace CapaVista
{
    public partial class formEmpleados : MaterialForm
    {


        public formEmpleados()
        {
            InitializeComponent();

        }


        private void txtNumeroCedula_TextChanged(object sender, EventArgs e)
        {
            string allowedPattern = @"^\d{0,3}(\d{0,6}(\d{0,4}[A-Za-z]?)?)?$"; // Patrón para validar la entrada parcial

            string input = this.Text; // Obtiene el texto actual del control

            if (!Regex.IsMatch(input, allowedPattern))
            {
                // Elimina cualquier carácter no válido
                input = Regex.Replace(input, @"[^0-9A-Za-z]", "");

                // Aplica el formato deseado
                if (input.Length >= 3)
                {
                    input = input.Insert(3, "-");
                }
                if (input.Length >= 10)
                {
                    input = input.Insert(10, "-");
                }
                if (input.Length >= 15)
                {
                    input = input.Insert(15, "-");
                }

                this.Text = input; // Actualiza el texto del control

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }

            // Verificar la longitud de la entrada
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void materialTextBoxEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar la entrada solo al presionar la tecla de retorno
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
                    // Utilizar una expresión regular para validar el formato del correo electrónico
                    string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                    Regex regex = new Regex(pattern);
                    return regex.IsMatch(email);
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }
        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnLimpiar, "Limpiar");
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnEliminar, "Eliminar");
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Mostrar el MonthCalendar y ajustarlo a la posición del PictureBox
            FechaNacimientoCalendario.Visible = true;

        }


        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Ocultar el MonthCalendar cuando se selecciona una fecha
            FechaNacimientoCalendario.Visible = false;
            DateTime selectedDate = e.Start;
            // Pasar la fecha seleccionada al TextBox
            txtFechadeNacimiento.Text = selectedDate.ToString("dd/MM/yyyy");
        }

        private void FechaNacimientoCalendario_MouseLeave(object sender, EventArgs e)
        {
            FechaNacimientoCalendario.Visible = false;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el valor de la tecla presionada
            char keyPressed = e.KeyChar;

            // Verificar si la tecla presionada es diferente de Eliminar o Suprimir
            if (keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que se procese el carácter
            }
        }
    }
}
