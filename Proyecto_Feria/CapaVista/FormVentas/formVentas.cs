using CapaControlador;
using CapaDatos;
using CapaVista.FormVentas;
using ReaLTaiizor.Forms;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        ControlProducto controlProducto = new ControlProducto();
        ControlVenta controlVenta = new ControlVenta();
        List<Producto> lista = null;
        Usuario user = new Usuario();
        public formVentas(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void limpiarTodo()
        {
            txtBuscar.Text = "";
            txtIva.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtTotalFinal.Text = "";
            txtDescuento.Text = "";
            txtCodigoProducto.Text = "";
            tbResumen.Rows.Clear();
            limpiarEtiquetas();
            mostrarProductosDisponible();
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponible();
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
            if (txtTotal.Text != "")
            {
                ResumenVenta resumen = new ResumenVenta
                {
                    descuento = Convert.ToDecimal(txtDescuento.Text),
                    subtotal = Convert.ToDecimal(txtSubTotal.Text),
                    iva = Convert.ToDecimal(txtIva.Text),
                    total = Convert.ToDecimal(txtTotal.Text)
                };
                FormPagar form = new FormPagar(user, resumen, obtenerDetalleDeVenta());
                form.ShowDialog();
                limpiarTodo();
            }
            else
            {
                MessageBox.Show("No se puede facturar porque aun no se ha vendido nada");
            }
        }
        private List<DetalleVenta> obtenerDetalleDeVenta()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            foreach (DataGridViewRow row in tbResumen.Rows)
            {
                if (!row.IsNewRow)
                {
                    DetalleVenta detalle = new DetalleVenta
                    {
                        ID_VENTA = 0,
                        ID_PRODUCTO = (int)row.Cells["Id"].Value,
                        NOMBRE = row.Cells["Nombre"].Value.ToString(),
                        CANTIDAD = (int)row.Cells["Cantidad"].Value,
                        PRECIO = (decimal)row.Cells["PrecioVenta"].Value,
                        SUBTOTAL = Convert.ToDecimal(row.Cells["SubTotal"].Value),
                    };
                    lista.Add(detalle);
                }
            }
            return lista;
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
                    lblStock.Text = lblStock.Text + " " + tbBusqueda.Rows[indice].Cells["CantidadP"].Value.ToString();
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

                    if (producto.cantidad >= nuevaCantidad)
                    {
                        decimal nuevoSubTotal = nuevaCantidad * producto.PrecioVenta;
                        tbResumen.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                        tbResumen.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                        lblCantidad.Text = nuevaCantidad.ToString();
                        limpiarEtiquetas();
                        lblCantidad.Text = lblCantidad.Text + " " + nuevaCantidad;
                        lblSubTotal.Text = lblSubTotal.Text + " " + nuevoSubTotal;
                    }
                    else
                    {
                        MessageBox.Show("El producto '" + producto.nombre + "' no dispone de la cantidad requerida\n" +
                                    "Cantidad del producto en inventario: " + producto.cantidad + " cantidad requeridad: " + nuevaCantidad);
                        limpiarEtiquetas();
                        lblCantidad.Text = "Cantidad ordenada: " + (nuevaCantidad - 1).ToString();
                        lblSubTotal.Text = "SubTotal: " + (producto.PrecioVenta * (nuevaCantidad - 1));
                    }
                }
                else
                {
                    tbResumen.Rows.Add("", "", producto.imagen, producto.id, producto.codigo, producto.nombre
                    , producto.PrecioVenta, 1, producto.PrecioVenta,producto.cantidad);
                    limpiarEtiquetas();
                    lblCantidad.Text = lblCantidad.Text + " " + 1;
                    lblSubTotal.Text = lblSubTotal.Text + " " + producto.PrecioVenta;
                }
                lblCodigo.Text = lblCodigo.Text + " " + producto.codigo;
                lblNombre.Text = lblNombre.Text + " " + producto.nombre;
                lblPrecio.Text = lblPrecio.Text + " " + producto.PrecioVenta;
                lblStock.Text = lblStock.Text + " " + producto.cantidad;
                txtSubTotal.Visible = true;
                using (MemoryStream memoryStream = new MemoryStream(producto.imagen))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    pktProducto.Image = imagen;
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
            if (tbResumen.RowCount > 0)
            {
                foreach (DataGridViewRow row in tbResumen.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        decimal valorCelda = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        subTotal += valorCelda;
                        descuento = (nbrDescuento.Value * Convert.ToDecimal(0.01)) * subTotal;
                        subTotal = subTotal;
                        iva = Convert.ToDecimal(subTotal) * Convert.ToDecimal(0.15);
                        total = subTotal + iva;
                    }
                }
            }
            txtDescuento.Text = descuento.ToString("0.00");
            txtSubTotal.Text = subTotal.ToString("0.00");
            txtIva.Text = iva.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
            txtTotalFinal.Text = (total - descuento).ToString("0.00");
        }
        private void limpiarEtiquetas()
        {
            lblCodigo.Text = "Codigo: ";
            lblNombre.Text = "Nombre: ";
            lblPrecio.Text = "Precio: ";
            lblCantidad.Text = "Cantidad ordenada: ";
            lblSubTotal.Text = "SubTotal: ";
            lblStock.Text = "Cantidad en inventario: ";
            pktProducto.Image = null;
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
            recuentoTotal();
            if (tbResumen.Columns[e.ColumnIndex].Name == "btnVer")
            {
                limpiarEtiquetas();
                pktProducto.Image = null;
                if (indice >= 0)
                {
                    rellenarEtiquetas(indice);
                }
            }
        }
        private void rellenarEtiquetas(int indice)
        {
            lblCodigo.Text = lblCodigo.Text + " " + tbResumen.Rows[indice].Cells["Codigo"].Value.ToString();
            lblNombre.Text = lblNombre.Text + " " + tbResumen.Rows[indice].Cells["Nombre"].Value.ToString();
            lblPrecio.Text = lblPrecio.Text + " " + tbResumen.Rows[indice].Cells["PrecioVenta"].Value.ToString();
            lblCantidad.Text = lblCantidad.Text + " " + tbResumen.Rows[indice].Cells["Cantidad"].Value.ToString();
            lblSubTotal.Text = lblSubTotal.Text + " " + tbResumen.Rows[indice].Cells["SubTotal"].Value.ToString();
            lblStock.Text = lblStock.Text + " " + tbResumen.Rows[indice].Cells["Stock"].Value.ToString();
            byte[] imagenBytes = (byte[])tbResumen.Rows[indice].Cells["Imagen"].Value;
            using (MemoryStream memoryStream = new MemoryStream(imagenBytes))
            {
                Image imagen = Image.FromStream(memoryStream);
                pktProducto.Image = imagen;
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
        private void nbrDescuento_ValueChanged(object sender, EventArgs e)
        {
            recuentoTotal();
        }
    }
}

