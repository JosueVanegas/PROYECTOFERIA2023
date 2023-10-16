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
#pragma warning disable CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
        List<Modelos.Producto> lista = null;
#pragma warning restore CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
        Modelos.Usuario user;
        public formVentas(Modelos.Usuario user)
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
            foreach (Modelos.Producto p in lista)
            {
                Image img = null;
                using (MemoryStream memoryStream = new MemoryStream(p.IMAGEN))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    img = imagen;

                }
                tbBusqueda.Rows.Add("", img, p.ID, p.CODIGO, p.NOMBRE, p.PRECIO_VENTA,p.STOCK);
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
#pragma warning disable CS8601 // Posible asignación de referencia nula
                    DetalleVenta detalle = new DetalleVenta
                    {
                        ID_VENTA = 0,
                        ID_PRODUCTO = (int)row.Cells["Id"].Value,
                        NOMBRE = row.Cells["Nombre"].Value.ToString(),
                        CANTIDAD = (int)row.Cells["Cantidad"].Value,
                        PRECIO = (decimal)row.Cells["PrecioVenta"].Value,
                        SUBTOTAL = Convert.ToDecimal(row.Cells["SubTotal"].Value),
                    };
#pragma warning restore CS8601 // Posible asignación de referencia nula
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string nombre = cbxBuscar.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
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
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
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
                var w = CapaPresentacion.Properties.Resources.ojo.Width;
                var h = CapaPresentacion.Properties.Resources.ojo.Height;
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
            var producto = lista.FirstOrDefault(p => p.CODIGO == codigo);
            if (producto.STOCK != 0)
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

                    if (producto.STOCK >= nuevaCantidad)
                    {
                        decimal nuevoSubTotal = nuevaCantidad * producto.PRECIO_VENTA;
                        tbResumen.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                        tbResumen.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                        lblCantidad.Text = nuevaCantidad.ToString();
                        limpiarEtiquetas();
                        lblCantidad.Text = lblCantidad.Text + " " + nuevaCantidad;
                        lblSubTotal.Text = lblSubTotal.Text + " " + nuevoSubTotal;
                    }
                    else
                    {
                        MessageBox.Show("El producto '" + producto.NOMBRE + "' no dispone de la cantidad requerida\n" +
                                    "Cantidad del producto en inventario: " + producto.STOCK + " cantidad requeridad: " + nuevaCantidad);
                        limpiarEtiquetas();
                        lblCantidad.Text = "Cantidad ordenada: " + (nuevaCantidad - 1).ToString();
                        lblSubTotal.Text = "SubTotal: " + (producto.PRECIO_VENTA * (nuevaCantidad - 1));
                    }
                }
                else
                {
                    tbResumen.Rows.Add("", "", producto.IMAGEN, producto.ID, producto.CODIGO, producto.NOMBRE
                    , producto.PRECIO_VENTA, 1, producto.PRECIO_VENTA, producto.STOCK);
                    limpiarEtiquetas();
                    lblCantidad.Text = lblCantidad.Text + " " + 1;
                    lblSubTotal.Text = lblSubTotal.Text + " " + producto.PRECIO_VENTA;
                }
                lblCodigo.Text = lblCodigo.Text + " " + producto.CODIGO;
                lblNombre.Text = lblNombre.Text + " " + producto.NOMBRE;
                lblPrecio.Text = lblPrecio.Text + " " + producto.PRECIO_VENTA;
                lblStock.Text = lblStock.Text + " " + producto.STOCK;
                txtSubTotal.Visible = true;
                using (MemoryStream memoryStream = new MemoryStream(producto.IMAGEN))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    pktProducto.Image = imagen;
                }
            }
            else
            {
                MessageBox.Show("El producto no dispone de stock suficiente");
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
                var w = CapaPresentacion.Properties.Resources.delete.Width;
                var h = CapaPresentacion.Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
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
        private void nbrDescuento_ValueChanged(object sender, EventArgs e)
        {
            recuentoTotal();
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es un número ni la tecla de retroceso (Backspace)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es una letra, número, guión o espacio, ni la tecla de retroceso (Backspace)
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }

        }

        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }

        private void btnCerrarBusqueda_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnCerrarBusqueda, "Cerrar Busqueda de Productos");
        }

        private void btnAgregarProducto_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnAgregarProducto, "Agregar un producto en la compra ");
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnBuscar, "Busqueda de Productos");
        }

        private void checkDescuento_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(checkDescuento, "Si desea aplicar descuento a esta factura has\n" +
                                               "click y pon el cuanto sera el descuento");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox4, "Bienvenido al area de Ventas:\n" +
                                          "Para realizar una venta :\n" +
                                          "1.'Buscar Productos' en Inventario.\n" +
                                          "2.'Añadir' el producto a la compra.(Genera el codigo del producto)\n" +
                                          "3.'Agregar' Las cantidades necesarias del producto a la compra.\n" +
                                          "4. Una termines de seleccionar los productos para realizar la venta a 'facturar'.\n" +
                                          "Si desea Cancelar la venta click en 'Limpiar'\n" +
                                          "Si desea eliminar un producto durante la venta click en 'Eliminar'");
        }

        private void btnFacturar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnFacturar, "Se desea finalizar la venta y desea pagar click 'Facturar'");
        }
    }
}


