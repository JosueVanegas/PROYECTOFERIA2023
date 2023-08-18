using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor;
using CapaDatos;
using CapaControlador;

namespace CapaVista.FormInventario
{
    public partial class FormCompras : MaterialForm
    {
        Producto productoBuscado;
        List<Producto> lista;
        public FormCompras()
        {
            InitializeComponent();

        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
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

        }
        private void agregarProducto(string codigo)
        {
            var producto = lista.FirstOrDefault(p => p.codigo == codigo);
            if (producto != null)
            {
                int rowIndex = -1;
                for (int i = 0; i < tbDetalles.Rows.Count; i++)
                {
                    if (tbDetalles.Rows[i].Cells["Codigo"].Value != null &&
                        tbDetalles.Rows[i].Cells["Codigo"].Value.ToString() == codigo)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex >= 0)
                {
                    int nuevaCantidad = 1 + Convert.ToInt32(tbDetalles.Rows[rowIndex].Cells["Cantidad"].Value);

                    if (producto.cantidad >= nuevaCantidad)
                    {
                        decimal nuevoSubTotal = nuevaCantidad * producto.PrecioVenta;
                        tbDetalles.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                        tbDetalles.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                    }
                    else
                    {
                        MessageBox.Show("El producto '" + producto.nombre + "' no dispone de la cantidad requerida\n" +
                                    "Cantidad del producto en inventario: " + producto.cantidad + " cantidad requeridad: " + nuevaCantidad);
                    }
                }
                else
                {
                    tbDetalles.Rows.Add("", "", producto.imagen, producto.id, producto.codigo, producto.nombre
                    , producto.PrecioVenta, 1, producto.PrecioVenta);
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
    }
}
