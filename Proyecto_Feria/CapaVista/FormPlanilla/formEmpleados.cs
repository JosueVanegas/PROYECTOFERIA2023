using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formEmpleados : MaterialForm
    {

        ControlEmpleados cEmp = new ControlEmpleados();
        public formEmpleados()
        {
            InitializeComponent();
            DateTime fechaNacimientoMaxima = DateTime.Today.AddYears(-18);
            FechaNacimientoCalendario.MaxDate = fechaNacimientoMaxima;
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true; // Evita que se procese el carácter
            }

            if (txtNumeroContacto != null && txtNumeroContacto.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
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
            toolTip.SetToolTip(pictureBox4, "Area de Regsitro de Empleados\n" +
                                            "Como Agregar un Empleado:\n" +
                                            "1. Ingresar el Nombre.\n" +
                                            "2. Ingresar el Apellido.\n" +
                                            "3. Ingresar el Numero de Cedula.\n" +
                                            "4. Seleccione el Sexo.\n" +
                                            "3. Ingresar el Numero Telefonico.\n" +
                                            "3. Ingresar el Correo Electronico Personal.\n" +
                                            "3. Ingresar el cargo del Empleado.\n" +
                                            "3. Ingresar el Dirrecion de Vivienda.\n" +
                                            "3. Ingresar el Salario.\n" +
                                            "3. Ingresar el seleccione fecha de nacimiento.\n" +
                                            ". 'Guardar' el producto en los registros.\n" +
                                            "Si desea Cancelar la creción del Producto click 'Limpiar'\n" +
                                            "Si desea editar un producto creado click 'Editar'\n" +
                                            "Si desea eliminar un producto creado click 'Eliminar'");
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
        private void txtFechadeNacimiento_MouseHover(object sender, EventArgs e)
        {
            FechaNacimientoCalendario.Visible = true;
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNumeroContacto != null && txtNumeroContacto.Text.Length >= 8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleado();
        }
        private void mostrarEmpleado()
        {
            List<Empleado> lista = cEmp.listarEmpleados();

        }
    }
}
