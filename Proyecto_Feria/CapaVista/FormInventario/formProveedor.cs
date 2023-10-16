using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formProveedor : MaterialForm
    {

        ControlProveedor cProv = new ControlProveedor();
        public formProveedor()
        {
            InitializeComponent();

            mostrarProveedores();
        }
        private void mostrarProveedores()
        {
            List<Modelos.Proveedor> lista = cProv.listarProveedores();
            tbProveedores.Rows.Clear();
            foreach (Modelos.Proveedor p in lista)
            {
                tbProveedores.Rows.Add("", "", p.ID, p.EMPRESA, p.CONTACTO, p.TELEFONO, p.PAIS, p.CIUDAD);
            }
        }
        private bool validarCampos()
        {
            bool continuar = false;
            if (txtNombreEmpresa.Text != "" && txtNumeroContacto.Text != "" && txtNombreContacto.Text != "" && txtPais.Text != "" && txtCiudad.Text != "")
            {
                continuar = true;
            }
            return continuar;
        }
        private void limpiarCampos()
        {
            txtId.Text = "0";
            txtNombreEmpresa.Text = "";
            txtNombreContacto.Text = "";
            txtNumeroContacto.Text = "";
            txtPais.Text = "";
            txtCiudad.Text = "";
        }
        private void registrarProveedor()
        {

            if (validarCampos() == true)
            {
                MessageBox.Show(cProv.accionProveedor(new Modelos.Proveedor
                {
                    ID = Convert.ToInt32(txtId.Text),
                    EMPRESA = txtNombreEmpresa.Text,
                    CONTACTO = txtNombreContacto.Text,
                    TELEFONO = txtNumeroContacto.Text,
                    PAIS = txtPais.Text,
                    CIUDAD = txtCiudad.Text
                }));
                limpiarCampos();
                mostrarProveedores();
            }
            else
            {
                MessageBox.Show("llene primero todos los campos");
            }
        }
        private void eliminarProveedor(int id)
        {
            if (MessageBox.Show("Desea eliminar al proveedor seleccionado? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cProv.eliminarProveedor(id));
                mostrarProveedores();
                limpiarCampos();
            }
        }
        private void tbProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbProveedores.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (indice >= 0)
                {
                    txtId.Text = tbProveedores.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombreEmpresa.Text = tbProveedores.Rows[indice].Cells["Empresa"].Value.ToString();
                    txtNombreContacto.Text = tbProveedores.Rows[indice].Cells["Contacto"].Value.ToString();
                    txtNumeroContacto.Text = tbProveedores.Rows[indice].Cells["Numero"].Value.ToString();
                    txtPais.Text = tbProveedores.Rows[indice].Cells["Pais"].Value.ToString();
                    txtCiudad.Text = tbProveedores.Rows[indice].Cells["Ciudad"].Value.ToString();
                }
            }
            if (tbProveedores.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbProveedores.Rows[indice].Cells["Id"].Value.ToString();
                    eliminarProveedor(Convert.ToInt32(valor));
                }
            }
        }
        private void tbProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.pen.Width;
                var h = CapaPresentacion.Properties.Resources.pen.Height;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarProveedor();
        }
        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
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
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox4, "Area de Creación de Proveedores\n" +
                                            "Como Agregar un Proveedor:\n" +
                                            "1. Ingresar el nombre de la Empresa.\n" +
                                            "2. Ingresar el nombre de Contacto.\n" +
                                            "3. Ingresar el numero de Contacto.\n" +
                                            "4. Ingresar el pais y ciudad.\n" +
                                            "5. 'Guardar' el producto en los registros.\n" +
                                            "Si desea Cancelar la creción del Producto click 'Limpiar'\n" +
                                            "Si desea editar un producto creado click 'Editar'\n" +
                                            "Si desea eliminar un producto creado click 'Eliminar'");
        }
        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
