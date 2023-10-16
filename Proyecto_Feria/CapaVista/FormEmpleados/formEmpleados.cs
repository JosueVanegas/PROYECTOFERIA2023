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
            DateTime fechaNacimientoMinima = DateTime.Today.AddYears(-60);
            dtNacimiento.MaxDate = fechaNacimientoMaxima;
            dtNacimiento.MinDate = fechaNacimientoMinima;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (txtTelefono != null && txtTelefono.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
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
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }
        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnLimpiar, "Limpiar");
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
                char sex = '?';
                if (cbxSexo.SelectedIndex == 0)
                {
                    sex = 'M';
                }
                else if (cbxSexo.SelectedIndex == 1)
                {
                    sex = 'F';
                }
                Modelos.Empleado emp = new Modelos.Empleado
                {
                    ID = Convert.ToInt32(txtId.Text),
                    DNI = txtNumeroCedula.Text,
                    NOMBRE = txtNombre.Text,
                    APELLIDO = txtApellido.Text,
                    SEXO = sex,
                    NACIMIENTO = dtNacimiento.Value,
                    CORREO = txtCorreo.Text,
                    DIRECCION = txtDireccion.Text,
                    CARGO = txtCargo.Text,
                    SALARIOPH = Convert.ToDecimal(txtSalario.Text),
                    TELEFONO = txtTelefono.Text
                };
                MessageBox.Show(cEmp.registrarEmpleados(emp));
                mostrarEmpleado();
                limpiarCampos();
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
            List<Modelos.Empleado> lista = cEmp.listarEmpleados();
            tbEmpleados.Rows.Clear();
            foreach (Modelos.Empleado e in lista)
            {
                tbEmpleados.Rows.Add("", "", e.ID, e.DNI, e.NOMBRE, e.APELLIDO, e.SEXO, e.NACIMIENTO, e.TELEFONO
                    , e.DIRECCION, e.CORREO, e.CARGO, e.SALARIOPH);
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
                int id = (int)tbEmpleados.Rows[indice].Cells["Id"].Value;
                eliminarEmpleado(id);
            }
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                txtId.Text = tbEmpleados.Rows[indice].Cells["Id"].Value.ToString();
                txtNumeroCedula.Text = tbEmpleados.Rows[indice].Cells["Cedula"].Value.ToString();
                txtNombre.Text = tbEmpleados.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = tbEmpleados.Rows[indice].Cells["Apellido"].Value.ToString();
                char sexo = Convert.ToChar(tbEmpleados.Rows[indice].Cells["Sexo"].Value);
                if (sexo == 'M')
                {
                    cbxSexo.SelectedIndex = 0;
                }
                else if (sexo == 'F')
                {
                    cbxSexo.SelectedIndex = 1;
                }
                txtTelefono.Text = tbEmpleados.Rows[indice].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = tbEmpleados.Rows[indice].Cells["Direccion"].Value.ToString();
                txtCorreo.Text = tbEmpleados.Rows[indice].Cells["Correo"].Value.ToString();
                txtCargo.Text = tbEmpleados.Rows[indice].Cells["Cargo"].Value.ToString();
                txtSalario.Text = tbEmpleados.Rows[indice].Cells["Salario"].Value.ToString();
                dtNacimiento.Value = Convert.ToDateTime(tbEmpleados.Rows[indice].Cells["Nacimiento"].Value);
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
            txtId.Text = "0";
            txtCorreo.Text = "";
            txtCargo.Text = "";
            txtDireccion.Text = "";
        }

        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
