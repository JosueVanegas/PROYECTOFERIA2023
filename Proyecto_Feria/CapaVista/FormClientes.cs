using CapaControlador;
using CapaDatos;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormClientes : Form
    {
        ControlCliente controlCliente = new ControlCliente();
        public FormClientes()
        {
            InitializeComponent();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            DateTime fechaNacimientoMaxima = DateTime.Today.AddYears(-10);
            DateTime fechaNacimientomin = DateTime.Today.AddYears(-10);
            dtNacimiento.MaxDate = fechaNacimientoMaxima;
            dtNacimiento.MinDate = fechaNacimientomin;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtId.Text = "2";
            txtTelefono.Text = string.Empty;
        }
        private void mostrarClientes()
        {
            List<Modelos.Cliente> lista = controlCliente.listarClientes();
            tbClientes.Rows.Clear();
            foreach (Modelos.Cliente c in lista)
            {

                tbClientes.Rows.Add("", "", c.ID, c.CEDULA, c.NOMBRES, c.APELLIDOS, c.TELEFONO, c.NACIMIENTO);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtId.Text != "")
            {
                MessageBox.Show(controlCliente.registrarCliente(new Modelos.Cliente
                {
                    ID = Convert.ToInt32(txtId.Text),
                    CEDULA = txtCedula.Text,
                    NOMBRES = txtNombre.Text,
                    APELLIDOS = txtApellido.Text,
                    TELEFONO = txtTelefono.Text,
                    NACIMIENTO = dtNacimiento.Value
                }));
                limpiarCampos();
                mostrarClientes();
            }
            else
            {
                MessageBox.Show("No se ha ingresado el nombre de la categoria", "Advertencia");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void eliminarCliente(int id)
        {
            if (MessageBox.Show("esta seguro de eliminar el cliente seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controlCliente.eliminarCliente(id));
                limpiarCampos();
                mostrarClientes();
            }
        }

        private void tbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int id = (int)tbClientes.Rows[indice].Cells["Id"].Value;
                eliminarCliente(id);
            }
            if (tbClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                txtId.Text = tbClientes.Rows[indice].Cells["Id"].Value.ToString();
                txtCedula.Text = tbClientes.Rows[indice].Cells["Cedula"].Value.ToString();
                txtNombre.Text = tbClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = tbClientes.Rows[indice].Cells["Apellido"].Value.ToString();
                txtTelefono.Text = tbClientes.Rows[indice].Cells["Telefono"].Value.ToString();
                dtNacimiento.Value = Convert.ToDateTime(tbClientes.Rows[indice].Cells["Fecha"].Value);
            }
        }

        private void tbClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.Text;
            if (tbClientes.RowCount > 0)
            {
                foreach (DataGridViewRow i in tbClientes.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Area de Registro de Cliente\n" +
                                            "Si desea Registrar un Cliente:\n" +
                                            "1.Ingrese el nombre del Cliente\n" +
                                            "2.Ingrese el apellido del Cliente\n" +
                                            "3.Ingrese el numero de telefono\n" +
                                            "'Guardar' en los registros\n" +
                                            "Si desea Cancelar la creción del Producto click 'Limpiar'\n" +
                                            "Si desea editar un producto creado click 'Editar'\n" +
                                            "Si desea eliminar un producto creado click 'Eliminar'");
        }

        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
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
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtTelefono.Text.Length >= 15 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
