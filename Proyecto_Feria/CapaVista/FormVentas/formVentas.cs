using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;
using CapaVista.FormVentas;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Windows.Forms;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        public static decimal Monto;
        ControlProducto controlProducto = new ControlProducto();
        ControlVenta controlVenta = new ControlVenta();
        List<Producto> lista = null;
        bool Mod;
        public formVentas(bool Dmod)
        {
            InitializeComponent();
            cambiarModo(Dmod);
            this.Mod = Dmod;
        }
        private void cambiarModo(bool modoOscuro)
        {
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
            }
            if (!modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
        private void formVentas_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
        }
        private void mostrarClientes()
        {
            //hay que crear la entidad cliente
        }
        private void mostrarProductosDisponible()
        {
            lista = controlProducto.listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Producto p in lista)
            {
                Image img = null;
                using (MemoryStream memoryStream = new MemoryStream(p.imagen))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    img = imagen;

                }

                tbBusqueda.Rows.Add("", img, p.id, p.codigo, p.nombre, p.PrecioVenta, p.cantidad);
            }
        }
        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDescuento.Checked)
            {
                nbrDescuento.Enabled = true;
            }
            if (!checkDescuento.Checked)
            {
                nbrDescuento.Enabled = false;
                nbrDescuento.Value = 0;
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

            Monto = 20;
            //Monto = float.Parse(txtTotal.Text);
            FormPagar form = new FormPagar(Mod, Convert.ToDecimal(txtTotal));
            form.ShowDialog();
        }
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
            panelDetalleVenta.SendToBack();
        }
        private void btnCerrarBusqueda_Click_1(object sender, EventArgs e)
        {
            panelBusqueda.SendToBack();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = cbxBuscar.SelectedItem.ToString();
            string columna = "";
            if (nombre == "Nombre")
            {
                columna = "NombreP";
            }
            if (nombre == "Codigo")
            {
                columna = "CodigoP";
            }
            if (nombre == "Precio")
            {
                columna = "PrecioP";
            }

            if (tbBusqueda.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbBusqueda.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
        private void tbBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbBusqueda.Columns[e.ColumnIndex].Name == "Añadir")
            {
                if (indice >= 0)
                {
                    limpiarEtiquetas();
                    txtCodigoProducto.Text = tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                    lblCodigo.Text = lblCodigo.Text + " " + tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                    lblNombre.Text = lblNombre.Text + " " + tbBusqueda.Rows[indice].Cells["NombreP"].Value.ToString();
                    lblPrecio.Text = lblPrecio.Text + " " + tbBusqueda.Rows[indice].Cells["PrecioP"].Value.ToString();
                    pktProducto.Image = (Image)tbBusqueda.Rows[indice].Cells["Img"].Value;
                }
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
        //Relacionado con la tabla resumen de cuenta
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                panelBusqueda.SendToBack();
                agregarProducto(txtCodigoProducto.Text);
            }
            else
            {
                MessageBox.Show("ingrese el codigo del producto primero");
            }
        }
        private void agregarProducto(string codigo)
        {
            var producto = lista.FirstOrDefault(p => p.codigo == codigo);
            if (producto != null)
            {
                int rowIndex = -1;
                for (int i = 0; i < tbResumen.Rows.Count; i++)
                {
                    if (tbResumen.Rows[i].Cells["Codigo"].Value != null &&
                        tbResumen.Rows[i].Cells["Codigo"].Value.ToString() == codigo)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex >= 0)
                {
                    int nuevaCantidad = 1 + Convert.ToInt32(tbResumen.Rows[rowIndex].Cells["Cantidad"].Value);
                    decimal nuevoSubTotal = nuevaCantidad * producto.PrecioVenta;
                    tbResumen.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                    tbResumen.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                }
                else
                {
                    tbResumen.Rows.Add("", "", producto.imagen, producto.id, producto.codigo, producto.nombre
                        , producto.PrecioVenta, 1, producto.PrecioVenta);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el producto con el Codigo de barra ingresado");
            }
            recuentoSubTotal();
        }
        private void recuentoSubTotal()
        {
            decimal subTotal = 0;
            decimal iva = 0;
            decimal descuento = 0;
            decimal total = 0;
            if (tbResumen.RowCount > 0)
            {
                foreach (DataGridViewRow row in tbResumen.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        decimal valorCelda = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        subTotal += valorCelda;
                        descuento = (nbrDescuento.Value * Convert.ToDecimal(0.01)) * subTotal;
                        subTotal = subTotal - descuento;
                        iva = Convert.ToDecimal(subTotal) * Convert.ToDecimal(0.15);
                        total = subTotal - iva;
                    }
                }
            }
            txtSubTotal.Text = subTotal.ToString();
            txtIva.Text = iva.ToString();
            txtTotal.Text = total.ToString();
        }
        private void limpiarEtiquetas()
        {
            lblCodigo.Text = "Codigo: ";
            lblNombre.Text = "Nombre: ";
            lblPrecio.Text = "Precio: ";
            lblCantidad.Text = "Cantidad ordenada: ";
            lblSubTotal.Text = "SubTotal: ";
        }
        private void tbResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbResumen.Columns[e.ColumnIndex].Name == "btnQuitar")
            {
                if (indice >= 0)
                {
                    tbResumen.Rows.RemoveAt(indice);
                    limpiarEtiquetas();
                }
            }
            recuentoSubTotal();
            if (tbResumen.Columns[e.ColumnIndex].Name == "btnVer")
            {
                limpiarEtiquetas();
                pktProducto.Image = null;
                if (indice >= 0)
                {
                    lblCodigo.Text = lblCodigo.Text + " " + tbResumen.Rows[indice].Cells["Codigo"].Value.ToString();
                    lblNombre.Text = lblNombre.Text + " " + tbResumen.Rows[indice].Cells["Nombre"].Value.ToString();
                    lblPrecio.Text = lblPrecio.Text + " " + tbResumen.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                    lblCantidad.Text = lblCantidad.Text + " " + tbResumen.Rows[indice].Cells["Cantidad"].Value.ToString();
                    lblSubTotal.Text = lblSubTotal.Text + " " + tbResumen.Rows[indice].Cells["SubTotal"].Value.ToString();
                    byte[] imagenBytes = (byte[])tbResumen.Rows[indice].Cells["Imagen"].Value;
                    using (MemoryStream memoryStream = new MemoryStream(imagenBytes))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        pktProducto.Image = imagen;
                    }
                }
            }
        }
        private void tbResumen_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
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
    }
}
