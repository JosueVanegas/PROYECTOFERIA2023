using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;
using System.Drawing.Printing;

namespace CapaVista.FormVentas
{
    public partial class FormPagar : MaterialForm
    {
        ResumenVenta resumen;
        Cliente cliente = new Cliente();
        Usuario user = new Usuario();
        List<DetalleVenta> detalles;
        ControlVenta cVenta = new ControlVenta();
        string impresoraSeleccionada = string.Empty;
        public FormPagar(Usuario u, ResumenVenta r, List<DetalleVenta> d)
        {
            InitializeComponent();
            resumen = r;
            detalles = d;
            user = u;

        }

        private void FormPagar_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mostrarClientes();
            realizarResumen();
            CargarImpresorasDisponibles();
            this.Cursor = Cursors.Default;
        }
        private void realizarResumen()
        {
            txtDescuento.Text = resumen.descuento.ToString();
            txtSubTotal.Text = resumen.subtotal.ToString();
            txtIva.Text = resumen.iva.ToString();
            txtTotal.Text = resumen.total.ToString();
            decimal totalFinal = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDescuento.Text);
            txtTotalFinal.Text = totalFinal.ToString("0.00");
        }
        private void mostrarClientes()
        {
            List<Cliente> lista = new ControlCliente().listarClientes();
            tbBusqueda.Rows.Clear();
            foreach (Cliente c in lista)
            {
                if (c.id != 1)
                {
                    tbBusqueda.Rows.Add("", c.id, c.nombre + " " + c.apellido);
                }
            }
        }


        private void txtPagoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            string textoActual = txtPago.Text.Replace(" ", "");
            if (!char.IsDigit(keyPressed) && textoActual.Length >= 9 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private bool calcularCambio()
        {
            bool continuar = false;
            decimal total = Convert.ToDecimal(txtTotalFinal.Text);
            decimal pago = Convert.ToDecimal(txtPago.Text);
            if (pago >= total)
            {
                decimal cambio = pago - total;
                txtCambioDeCompra.Text = cambio.ToString("0.00");
                continuar = true;
            }
            else
            {
                MessageBox.Show("El pago no cubre la deuda");
            }
            return continuar;
        }
        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (txtPago.Text != "")
            {
                RealizarPago();
            }
            else
            {
                MessageBox.Show("Ingrese el pago del cliente");
            }
        }
        private void RealizarPago()
        {
            if (txtCliente.Text != "" && cliente != null)
            {
                if (calcularCambio() == true)
                {
                    try
                    {
                        MessageBox.Show(imprimirFactura());
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("seleccione el cliente de la lista de clientes o seleccione cliente comun");
            }

        }
        private string imprimirFactura()
        {
            this.Cursor = Cursors.WaitCursor;
            string mensaje = "Factura generada e impresa con éxito";
            try
            {
                int numeroPaginas = 2;
                infoVenta v = new infoVenta
                {
                    ID_CLIENTE = cliente.id,
                    ID_USUARIO = user.id,
                    DESCUENTO = resumen.descuento,
                    IVA = resumen.iva,
                    SUBTOTAL = resumen.subtotal,
                    TOTAL = resumen.total,
                };
                MessageBox.Show(cVenta.procesoDeVenta(v, detalles));
                string factura = cVenta.tomarNoFactura();

                if (factura != "")
                {
                    if (impresoraSeleccionada != "")
                    {
                        string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string nombreArchivo = Path.Combine(carpetaDocumentos, "Factura_" + factura + ".pdf");


                        pdImprimir = new PrintDocument();
                        pdImprimir.PrinterSettings.PrinterName = impresoraSeleccionada;
                        pdImprimir.PrinterSettings.PrintToFile = true;
                        pdImprimir.PrinterSettings.PrintFileName = nombreArchivo;

                        pdImprimir.PrintPage += imprimir;

                        for (int i = 0; i < numeroPaginas; i++)
                        {
                            pdImprimir.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
            this.Cursor = Cursors.Default;
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Empresa empresa = new ControlEmpresa().datosEmpresa();
            Font font = new Font("Courier New", 12);
            float y = 20;

            e.Graphics.DrawString($"                        {empresa.nombre}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Factura No: {new DataVenta().noFactura}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Dirección: {empresa.direccion +" " +empresa.departamento}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Email: {empresa.email}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Teléfono: {empresa.telefono}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Cliente:{cliente.nombre}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Usuario en turno: {user.usuario}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("------------------------------------detalles-------------------------------", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("Descripcion", font, Brushes.Black, 20, y);
            e.Graphics.DrawString("Subtotal", font, Brushes.Black, 700, y);
            y += 20;
            foreach (var d in detalles)
            {
                e.Graphics.DrawString($"{d.NOMBRE}", font, Brushes.Black, 20, y);
                e.Graphics.DrawString($"{d.SUBTOTAL}", font, Brushes.Black, 700, y);
                y += 20;
                e.Graphics.DrawString($"{d.CANTIDAD} x {d.PRECIO}", font, Brushes.Black, 20, y);
                y += 20;
            }
            e.Graphics.DrawString("------------------------------------resumen--------------------------------", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Subtotal:{txtSubTotal.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"IVA: {txtIva.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Total antes de descuento: {txtTotal.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Descuento: {txtDescuento.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Total despues de descuento y deducciones: {txtTotalFinal.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Cambio: {txtCambioDeCompra.Text}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("                     ******NOTA: No se aceptan devoluciones*****", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("                           Gracias por preferirnos :)", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("----------------------------------------------------------------------------", font, Brushes.Black, 20, y);
            y += 20;
            e.HasMorePages = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string columna = cbxBuscar.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
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

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.ojo, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tbBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbBusqueda.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                if (indice >= 0)
                {
                    int idObtenido = (int)tbBusqueda.Rows[indice].Cells["Id"].Value;
                    string nombreObtenido = tbBusqueda.Rows[indice].Cells["Nombre"].Value.ToString(); 
                    cliente = new Cliente
                    {
                        id = idObtenido,
                        nombre = nombreObtenido
                    };
                    txtCliente.Text = nombreObtenido;
                }
            }
        }

        private void ckbClienteComun_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbClienteComun.Checked == true)
            {
                cliente.id = 1;
                txtCliente.Text = "CLIENTE COMUN";
            }
            else
            {
                txtCliente.Text = "";
            }
        }

        private void cbxImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            impresoraSeleccionada = cbxImpresoras.SelectedItem.ToString();
        }
        private void CargarImpresorasDisponibles()
        {
            PrinterSettings.StringCollection impresoras = PrinterSettings.InstalledPrinters;

            foreach (string impresora in impresoras)
            {
                cbxImpresoras.Items.Add(impresora);
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox4, "Datos de los totales de la facturar");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Para continuar con la Facturación\n" +
                                            "-Ingrese los datos del Cliente Si es un Cliente X\n" +
                                            "-Ingrese una cantidad mayor o igual al total de la factura\n" +
                                            " y asi poder cancelar la deuda\n");
        }

        private void ckbClienteComun_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(ckbClienteComun, "Es una Cliente Anomino o comun cuando no se quiere poner el nombre del Cliente");
        }

        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; 
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox3, "Si deseas usar un cliente que esta registrado puede seleccionar desde la tabla");
        }
    }
}





