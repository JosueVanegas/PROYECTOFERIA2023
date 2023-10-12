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

            if (txtTelefono != null && txtTelefono.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
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
            if (txtTelefono != null && txtTelefono.Text.Length >= 8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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
            if (validarEntradas() == true)
            {
                string sex = "";
                if (cbxSexo.SelectedIndex == 0)
                {
                    sex = "M";
                }
                else if (cbxSexo.SelectedIndex == 1)
                {
                    sex = "F";
                }
                Empleado emp = new Empleado
                {
                    id = Convert.ToInt32(txtId.Text),
                    cedula = txtNumeroCedula.Text,
                    nombres = txtNombre.Text,
                    apellidos = txtApellido.Text,
                    sexo = sex,
                    nacimiento = txtFechadeNacimiento.Text,
                    correo = txtCorreo.Text,
                    direccion = txtDireccion.Text,
                    cargo = txtCargo.Text,
                    salarioHora = Convert.ToDecimal(txtSalario.Text),
                    telefono = txtTelefono.Text

                };
                MessageBox.Show(cEmp.registrarEmpleados(emp));
                mostrarEmpleado();
            }
        }
        private bool validarEntradas()
        {
            bool permitir = false;
            if (txtTelefono.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" &&
                txtSalario.Text != "" && txtDireccion.Text != "" && txtCorreo.Text != ""
                 && txtNumeroCedula.Text != "" && txtId.Text != "")
            {
                permitir = true;
            }

            return permitir;
        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleado();
        }
        private void mostrarEmpleado()
        {
            List<Empleado> lista = cEmp.listarEmpleados();
            tbEmpleados.Rows.Clear();
            foreach (Empleado e in lista)
            {
                tbEmpleados.Rows.Add("", "", e.id, e.cedula, e.nombres, e.apellidos, e.sexo, e.nacimiento, e.telefono
                    , e.direccion, e.correo, e.cargo, e.salarioHora, e.fechaRegistro);
            }
        }
        private void eliminarEmpleado(int id)
        {
            if (MessageBox.Show("esta seguro de eliminar el empleado seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cEmp.eliminarEmpleado(id));
                limpiarCampos();
                mostrarEmpleado();
            }
        }
        private void tbEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int id = (int)tbEmpleados.Rows[indice].Cells[3].Value;
                eliminarEmpleado(id);
            }
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                txtId.Text = tbEmpleados.Rows[indice].Cells[2].Value.ToString();
                txtNumeroCedula.Text = tbEmpleados.Rows[indice].Cells[3].Value.ToString();
                txtNombre.Text = tbEmpleados.Rows[indice].Cells[4].Value.ToString();
                txtApellido.Text = tbEmpleados.Rows[indice].Cells[5].Value.ToString();
                string sexo = tbEmpleados.Rows[indice].Cells[6].Value.ToString();
                if (sexo == "M")
                {
                    cbxSexo.SelectedIndex = 0;
                }
                else if (sexo == "F")
                {
                    cbxSexo.SelectedIndex = 1;
                }
                txtFechadeNacimiento.Text = tbEmpleados.Rows[indice].Cells[7].Value.ToString();
                txtTelefono.Text = tbEmpleados.Rows[indice].Cells[8].Value.ToString();
                txtDireccion.Text = tbEmpleados.Rows[indice].Cells[9].Value.ToString();
                txtCorreo.Text = tbEmpleados.Rows[indice].Cells[10].Value.ToString();
                txtCargo.Text = tbEmpleados.Rows[indice].Cells[11].Value.ToString();
                txtSalario.Text = tbEmpleados.Rows[indice].Cells[12].Value.ToString();
                txtFechadeNacimiento.Text = tbEmpleados.Rows[indice].Cells[13].Value.ToString();
            }
        }

        private void tbEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen.Height;
                var w = CapaPresentacion.Properties.Resources.pen.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.delete.Width;
                var h = CapaPresentacion.Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNumeroCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSalario.Text = "0.00";
            txtTelefono.Text = "";
            txtId.Text = "1";
            txtCorreo.Text = "";
            txtCargo.Text = "";
            txtDireccion.Text = "";
            txtFechadeNacimiento.Text = "";
        }
    }
}
