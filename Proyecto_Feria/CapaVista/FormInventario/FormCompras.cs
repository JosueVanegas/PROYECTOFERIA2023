using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista.FormInventario
{
    public partial class FormCompras : MaterialForm
    {
#pragma warning disable CS0169 // El campo 'FormCompras.productoBuscado' nunca se usa
        Producto productoBuscado;
#pragma warning restore CS0169 // El campo 'FormCompras.productoBuscado' nunca se usa
        List<Producto> lista;
        ControlCompra cCompra = new ControlCompra();
        Usuario user;
        public FormCompras(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
            mostrarCompras();
        }
        private void mostrarCompras()
        {
            List<compra> lista = cCompra.listarCompra();
            tbCompras.Rows.Clear();
            foreach (compra c in lista)
            {
                tbCompras.Rows.Add(c.id, c.factura, c.idUsuario, c.nombreUsuario, c.total);
            }
        }
        private void mostrarProductosDisponible()
        {
            lista = new ControlProducto().listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Producto p in lista)
            {
                tbBusqueda.Rows.Add("", p.id, p.codigo, p.nombre, p.PrecioVenta, p.cantidad);
            }
        }
        private void tbBusqueda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
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
            var producto = lista.FirstOrDefault(p => p.codigo == codigo);
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
                    decimal nuevoSubTotal = nuevaCantidad * producto.PrecioVenta;
                    tbDetalles.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                    tbDetalles.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                }
                else
                {
                    decimal total = producto.PrecioCompra * 1;
                    tbDetalles.Rows.Add("", producto.id, producto.codigo, producto.oProveedor.nombreProveedor, producto.nombre, 1
                    , producto.PrecioCompra, total, producto.oProveedor.id);
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
            decimal iva = 0;
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
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            {
                realizarCompra compra = new realizarCompra
                {
                    ID_USUARIO = user.id,
                    TOTAL = Convert.ToDecimal(txtTotal.Text)
                };
                MessageBox.Show(cCompra.procesoCompra(compra, obtenerDetalles()));
                mostrarCompras();
                mostrarProductosDisponible();
            }
            else
            {
                MessageBox.Show("No se ha comprado nada");
            }
        }
        private List<detalleCompra> obtenerDetalles()
        {
            List<detalleCompra> lista = new List<detalleCompra>();

            foreach (DataGridViewRow row in tbDetalles.Rows)
            {
                if (!row.IsNewRow)
                {
                    detalleCompra detalle = new detalleCompra
                    {
                        idCompra = 0,
                        idProducto = (int)row.Cells["Id"].Value,
                        cantidad = (int)row.Cells["Cantidad"].Value,
                        total = (decimal)row.Cells["Subtotal"].Value,
                    };
                    lista.Add(detalle);
                }
            }
            return lista;
        }
    }
}
