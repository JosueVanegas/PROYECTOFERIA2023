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
            List<Cliente> lista = controlCliente.listarClientes();
            tbClientes.Rows.Clear();
            foreach (Cliente c in lista)
            {
                if (c.id != 1)
                {
                    tbClientes.Rows.Add("", "", c.id, c.nombre, c.apellido, c.telefono, c.fechaRegistro);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtId.Text != "")
            {
                MessageBox.Show(controlCliente.registrarCliente(new Cliente
                {
                    id = Convert.ToInt32(txtId.Text),
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    telefono = txtTelefono.Text
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
                txtNombre.Text = tbClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = tbClientes.Rows[indice].Cells["Apellido"].Value.ToString();
                txtTelefono.Text = tbClientes.Rows[indice].Cells["Telefono"].Value.ToString();
            }
        }

        private void tbClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.eliminar.Width;
                var h = CapaPresentacion.Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.eliminar, new Rectangle(x, y, w, h));
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
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                }
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
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
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
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
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es un número o la tecla de retroceso (Backspace)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }

            // Limitar la longitud del texto a 6 dígitos
            if (txtNombre.Text.Length >= 6 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter si ya hay 6 dígitos
            }
        }
    }
}
