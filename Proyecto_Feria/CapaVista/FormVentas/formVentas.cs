using CapaControlador;
using CapaDatos;
using CapaVista.FormVentas;
using ReaLTaiizor.Forms;
using System.Diagnostics.Eventing.Reader;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        ControlProducto controlProducto = new ControlProducto();
        ControlVenta controlVenta = new ControlVenta();
        List<Modelos.Producto> listaProductos = null;
        List<Modelos.Ofertas> listaOfertas = null;
        Modelos.Usuario user;
        public formVentas(Modelos.Usuario user)
        {
            InitializeComponent();
            this.user = user;
            panelBusqueda.SendToBack();
            timerEscanner.Interval = 300;
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
            cargarOfertas();
        }
        private void cargarOfertas()
        {
            listaOfertas = new ControlOferta().listarOfertas();
        }
        private void mostrarProductosDisponible()
        {
            listaProductos = controlProducto.listarProductos();
            tbBusqueda.Rows.Clear();
            foreach (Modelos.Producto p in listaProductos)
            {
                Image img = null;
                using (MemoryStream memoryStream = new MemoryStream(p.IMAGEN))
                {
                    Image imagen = Image.FromStream(memoryStream);
                    img = imagen;

                }
                tbBusqueda.Rows.Add("", img, p.ID, p.CODIGO, p.NOMBRE + " " + p.MARCA + " " + p.UNIDAD, p.PRECIO_VENTA, p.STOCK, p.STOCK_SEGURIDAD, 0,0);
            }
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            {
                Modelos.Venta resumen = new Modelos.Venta
                {
                    DESCUENTO = Convert.ToDecimal(txtDescuento.Text),
                    SUBTOTAL = Convert.ToDecimal(txtSubTotal.Text),
                    IVA = Convert.ToDecimal(txtIva.Text),
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
        private List<Modelos.DetalleVenta> obtenerDetalleDeVenta()
        {
            List<Modelos.DetalleVenta> lista = new List<Modelos.DetalleVenta>();

            foreach (DataGridViewRow row in tbResumen.Rows)
            {
                if (!row.IsNewRow)
                {
                    Modelos.DetalleVenta detalle = new Modelos.DetalleVenta
                    {
                        PRODUCTO = new Modelos.Producto
                        {
                            ID = Convert.ToInt32(row.Cells["Id"].Value),
                            NOMBRE = row.Cells["Nombre"].Value.ToString(),
                        },
                        CANTIDAD = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        PRECIO = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                        DESCUENTO = Convert.ToDecimal(row.Cells["Descuento"].Value),
                        ID_OFERTA = Convert.ToInt32(row.Cells["IdOferta"].Value)
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
                    int stock = Convert.ToInt32(tbBusqueda.Rows[indice].Cells["CantidadP"].Value);
                   if(stock > 0)
                    {
                        txtCodigoProducto.Text = tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                        lblCodigo.Text = lblCodigo.Text + " " + tbBusqueda.Rows[indice].Cells["CodigoP"].Value.ToString();
                        lblNombre.Text = lblNombre.Text + " " + tbBusqueda.Rows[indice].Cells["NombreP"].Value.ToString();
                        lblPrecio.Text = lblPrecio.Text + " " + tbBusqueda.Rows[indice].Cells["PrecioP"].Value.ToString();
                        lblStock.Text = lblStock.Text + " " + tbBusqueda.Rows[indice].Cells["CantidadP"].Value.ToString();
                        pktProducto.Image = (Image)tbBusqueda.Rows[indice].Cells["Img"].Value;
                    }
                    else
                    {
                        MessageBox.Show("No hay stock disponible del producto seleccionado");
                    }
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
            var producto = listaProductos.FirstOrDefault(p => p.CODIGO == codigo);
            if (producto != null)
            {
                    var oferta = listaOfertas.FirstOrDefault(of => of.PRODUCTO.ID == producto.ID);

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
                        decimal descuentoPorProducto = 0;
                        if (oferta != null)
                        {
                            descuentoPorProducto = (producto.PRECIO_VENTA * oferta.CANTIDAD) * (oferta.PORCENTAJE_DESCUENTO / 100m) * (nuevaCantidad / oferta.CANTIDAD);
                            tbResumen.Rows[rowIndex].Cells["IdOferta"].Value = oferta.ID;
                        }

                        if (producto.STOCK >= nuevaCantidad)
                        {
                            decimal nuevoSubTotal = nuevaCantidad * producto.PRECIO_VENTA;
                            tbResumen.Rows[rowIndex].Cells["Cantidad"].Value = nuevaCantidad;
                            tbResumen.Rows[rowIndex].Cells["Descuento"].Value = descuentoPorProducto;
                            tbResumen.Rows[rowIndex].Cells["SubTotal"].Value = nuevoSubTotal;
                        }
                        else
                        {
                            MessageBox.Show("El producto '" + producto.NOMBRE + "' no dispone de la cantidad requerida\n" +
                                            "Cantidad del producto en inventario: " + producto.STOCK + " cantidad requeridad: " + nuevaCantidad);
                        }
                    }
                    else
                    {
                        decimal descuentoPorProducto = 0;
                        if (oferta != null)
                        {
                            descuentoPorProducto = (producto.PRECIO_VENTA * oferta.CANTIDAD) * (oferta.PORCENTAJE_DESCUENTO / 100m);
                        }
                        tbResumen.Rows.Add("", "", producto.IMAGEN, producto.ID, producto.CODIGO, producto.NOMBRE, producto.PRECIO_VENTA, 1, producto.PRECIO_VENTA, producto.STOCK, descuentoPorProducto);
                    }
            }
            recuentoTotal();
        }
        private void recuentoTotal()
        {
            decimal subTotal = 0;
            decimal iva = 0;
            decimal descuentoTotal = 0;
            decimal total = 0;
            if (tbResumen.RowCount >= 0)
            {
                foreach (DataGridViewRow row in tbResumen.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null || row.Cells["Descuento"].Value != null)
                    {
                        decimal valorCelda = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        decimal valorDescuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        subTotal += valorCelda;
                        descuentoTotal += valorDescuento;
                    }
                }
            }
            iva = subTotal * 0.15m;
            total = subTotal + iva;
            txtDescuento.Text = descuentoTotal.ToString("0.00");
            txtSubTotal.Text = subTotal.ToString("0.00");
            txtIva.Text = iva.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
            txtTotalFinal.Text = (total - descuentoTotal).ToString("0.00");
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
            if (tbResumen.Columns[e.ColumnIndex].Name == "btnVer")
            {
                limpiarEtiquetas();
                pktProducto.Image = null;
                if (indice >= 0)
                {
                    rellenarEtiquetas(indice);
                }
            }
            recuentoTotal();
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

        private void timerEscanner_Tick(object sender, EventArgs e)
        {
            timerEscanner.Stop();
            if (txtCodigoProducto.Text != "")
            {
                panelBusqueda.SendToBack();
                agregarProducto(txtCodigoProducto.Text);
                recuentoTotal();
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            if(ckEscanner.Checked)
            {
                timerEscanner.Stop();
                timerEscanner.Start();
            }
        }
    }
}


