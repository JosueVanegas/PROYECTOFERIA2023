using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista.FormInventario
{
    public partial class FormCompras : MaterialForm
    {
        List<Modelos.Producto> lista;
        ControlCompra cCompra = new ControlCompra();
        Modelos.Usuario user;
        public FormCompras(Modelos.Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void limpiarCampos()
        {
            txtNofactura.Text = "";
            txtTotal.Text = "";
            tbDetalles.RowCount = 0;
            txtCodigoDeProducto.Text = "";
        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
            mostrarCompras();
        }
        private void mostrarCompras()
        {
            List<Modelos.Compra> lista = cCompra.listarCompra();
            tbCompras.Rows.Clear();
            foreach (Modelos.Compra c in lista)
            {
                tbCompras.Rows.Add(c.ID, c.USUARIO.NOMBRE, c.SUBTOTAL, c.FECHA_REGISTRO);
            }
        }
        private void mostrarProductosDisponible()
        {
            lista = new ControlProducto().listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Modelos.Producto p in lista)
            {
                tbBusqueda.Rows.Add("", p.ID, p.CODIGO, p.NOMBRE, p.PRECIO_COMPRA, p.STOCK);
            }
        }
        private void tbBusqueda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.ojo.Width;
                var h = CapaPresentacion.Properties.Resources.ojo.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.ojo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tbBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbBusqueda.Columns[e.ColumnIndex].Name == "Añadir")
            {
                if (indice >= 0)
                {
                    txtCodigoDeProducto.Text = tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                }
            }
        }
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string nombre = cbxBuscarProducto.SelectedItem.ToString();
            string columna = "";
            if (nombre == "Nombre")
            {
                columna = "NombreP";
            }
            if (nombre == "Codigo")
            {
                columna = "CodigoP";
            }
            if (tbBusqueda.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbBusqueda.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscarProducto.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscarCompra.SelectedItem.ToString();
            if (tbCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbCompras.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscarCompra.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigoDeProducto.Text != "")
            {
                agregarProducto(txtCodigoDeProducto.Text);
            }
            else
            {
                MessageBox.Show("No se encontro el producto con ese codigo");
            }
        }
        private void agregarProducto(string codigo)
        {
            var producto = lista.FirstOrDefault(p => p.CODIGO == codigo);
            if (producto != null)
            {
                int rowIndex = -1;
                for (int i = 0; i < tbDetalles.Rows.Count; i++)
                {
                    if (tbDetalles.Rows[i].Cells["Codigo"].Value.ToString() != null &&
                        tbDetalles.Rows[i].Cells["Codigo"].Value.ToString() == codigo)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex >= 0)
                {
                    int nuevaCantidad = 1 + Convert.ToInt32(tbDetalles.Rows[rowIndex].Cells["Cantidad"].Value);
                    decimal nuevoSubTotal = nuevaCantidad * producto.PRECIO_COMPRA;
                    tbDetalles.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                    tbDetalles.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                }
                else
                {
                    decimal total = producto.PRECIO_COMPRA * 1;
                    tbDetalles.Rows.Add("", producto.ID, producto.CODIGO, producto.PROVEEDOR.EMPRESA, producto.NOMBRE, 1
                    , producto.PRECIO_COMPRA, total, producto.PROVEEDOR.ID);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el producto con el Codigo de barra ingresado");
            }
            recuentoTotal();
        }
        private void recuentoTotal()
        {
            decimal subTotal = 0;
            decimal descuento = 0;
            decimal total = 0;
            if (tbDetalles.RowCount > 0)
            {
                foreach (DataGridViewRow row in tbDetalles.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        decimal valorCelda = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        subTotal += valorCelda;
                    }
                }
            }
            txtTotal.Text = subTotal.ToString("0.00");
        }
        private void btnCerrarBusqueda_Click(object sender, EventArgs e)
        {
            panelBusqueda.SendToBack();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            panelCompras.SendToBack();
        }
        private void tbDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbDetalles.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (indice >= 0)
                {
                    if (MessageBox.Show("Desea eliminar el producto seleccionado? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tbDetalles.Rows.RemoveAt(indice);
                    }
                    recuentoTotal();
                }
            }
        }
        private void tbDetalles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
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
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            {
                Modelos.Compra compra = new Modelos.Compra
                {
                    USUARIO = new Modelos.Usuario
                    {
                        ID = this.user.ID
                    },
                    SUBTOTAL = Convert.ToDecimal(txtTotal.Text)
                };
                MessageBox.Show(cCompra.procesoCompra(compra, obtenerDetalles()));
                mostrarCompras();
                mostrarProductosDisponible();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("No se ha comprado nada");
            }
        }
        private List<Modelos.DetalleCompra> obtenerDetalles()
        {
            List<Modelos.DetalleCompra> lista = new List<Modelos.DetalleCompra>();

            foreach (DataGridViewRow row in tbDetalles.Rows)
            {
                if (!row.IsNewRow)
                {
                    Modelos.DetalleCompra detalle = new Modelos.DetalleCompra
                    {
                        ID = 0,
                        PRODUCTO = new Modelos.Producto
                        {
                            ID = (int)row.Cells["Id"].Value
                        },
                        CANTIDAD = (int)row.Cells["Cantidad"].Value,
                        ULTIMO_PRECIO = (decimal)row.Cells["PrecioCompra"].Value,
                    };
                    lista.Add(detalle);
                }
            }
            return lista;
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
        private void lblEncabezado_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(lblEncabezado, "Registro de cada una de las compras realizadas a proveeedores");
        }
        private void cbxBuscarCompra_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscarCompra, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }
        private void cbxBuscarProducto_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscarProducto, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }
        private void btnCerrarBusqueda_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnCerrarBusqueda, "Cerrar Busqueda de Productos");
        }
        private void btnAgregarProducto_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnAgregarProducto, "Agregar un producto en la compra ");
        }
        private void btnBuscarProducto_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnBuscarProducto, "Busqueda de Productos");
        }
        private void lblTitulo_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox4, "Bienvenido al area de Compras a Proveedores:\n" +
                                          "Para Agregar un nuevo Producto :\n" +
                                          "1.Debemos haber creado el registro de un producto en el area de productos.\n" +
                                          "2.Debemos haber creado el registro de un proveedor en el area de proveedores\n" +
                                          "Como realizar una compra a proveedor: \n" +
                                          "1.'Buscar Productos' en Productos.\n" +
                                          "2.'Añadir' el producto a la compra.(Genera el codigo del producto)\n" +
                                          "3.'Agregar' Las cantidades necesarias del producto a la compra.\n" +
                                          "4.'Guardar' Registro al finalizar compras a proveedores.\n" +
                                          "Si desea Cancelar Comprar click en 'Limpiar'\n" +
                                          "Si desea eliminar un producto durante la compra click en 'Eliminar'");
        }
        private void txtCodigoDeProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
