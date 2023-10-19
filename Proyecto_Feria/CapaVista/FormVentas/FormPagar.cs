using Aspose.Pdf.Facades;
using CapaControlador;
using CapaDatos;
using MathNet.Numerics;
using NPOI.SS.UserModel;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace CapaVista.FormVentas
{
    public partial class FormPagar : MaterialForm
    {
        Modelos.Venta resumen;
        Modelos.Cliente cliente = new Modelos.Cliente();
        Modelos.Usuario user;
        List<Modelos.Ofertas> listaOfertas;
        List<Modelos.DetalleVenta> detalles = new List<Modelos.DetalleVenta>();
        ControlVenta cVenta = new ControlVenta();
        int factura;
        public FormPagar(Modelos.Usuario usuario, Modelos.Venta venta, List<Modelos.DetalleVenta> d)
        {
            InitializeComponent();
            resumen = venta;
            detalles = d;
            user = usuario;
        }
        private void FormPagar_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mostrarClientes();
            realizarResumen();
            cargarOfertas();
            this.Cursor = Cursors.Default;
        }
        private void cargarOfertas()
        {
            listaOfertas = new ControlOferta().listarOfertas();
        }
        private void realizarResumen()
        {
            txtDescuento.Text = resumen.DESCUENTO.ToString();
            txtSubTotal.Text = resumen.SUBTOTAL.ToString();
            txtIva.Text = resumen.IVA.ToString();
            decimal sub_antes_descuento = resumen.SUBTOTAL + resumen.IVA;
            txtTotal.Text = sub_antes_descuento.ToString();
            decimal totalFinal = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDescuento.Text);
            txtTotalFinal.Text = totalFinal.ToString("0.00");
        }
        private void mostrarClientes()
        {
            List<Modelos.Cliente> lista = new ControlCliente().listarClientes();
            tbBusqueda.Rows.Clear();
            foreach (Modelos.Cliente c in lista)
            {

                tbBusqueda.Rows.Add("", c.ID, c.CEDULA, c.NOMBRES + " " + c.APELLIDOS);

            }
        }
        private void txtPagoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            string textoActual = txtPago.Text;

            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete && keyPressed != '.')
            {
                e.Handled = true;
                return;
            }

            if (textoActual.Length >= 9 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            if (keyPressed == '.' && string.IsNullOrEmpty(textoActual))
            {
                e.Handled = true;
                return;
            }
            if (keyPressed == '.' && textoActual.Contains("."))
            {
                e.Handled = true;
                return;
            }
            if (textoActual.Contains(".") && textoActual.IndexOf(".") <= textoActual.Length - 3 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            if (keyPressed == '.' && textoActual.Length >= 8)
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
            string mensaje = "Factura generada e impresa con éxito";
            try
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.UseEXDialog = true;
                DialogResult confirmResult = MessageBox.Show("¿Estas seguro de realizar la venta?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Modelos.Venta venta = new Modelos.Venta
                    {
                        USUARIO = new Modelos.Usuario
                        {
                            ID = user.ID
                        },
                        CLIENTE = new Modelos.Cliente
                        {
                            ID = cliente.ID
                        },
                        DESCUENTO = Convert.ToDecimal(txtDescuento.Text),
                        IVA = Convert.ToDecimal(txtIva.Text),
                        SUBTOTAL = Convert.ToDecimal(txtSubTotal.Text)
                    };
                    List<Modelos.DetalleVenta> detalleVenta = new List<Modelos.DetalleVenta>();
                    foreach (Modelos.DetalleVenta d in detalles)
                    {
                        detalleVenta.Add(new Modelos.DetalleVenta
                        {
                            ID_VENTA = venta.ID,
                            PRODUCTO = new Modelos.Producto
                            {
                                ID = d.PRODUCTO.ID,
                                NOMBRE = d.PRODUCTO.NOMBRE
                            },
                            DESCUENTO = d.DESCUENTO,
                            CANTIDAD = d.CANTIDAD,
                            PRECIO = d.PRECIO
                        });
                    }
                    cVenta.procesoDeVenta(venta, detalleVenta);
                    MessageBox.Show(cVenta.retornarMensaje());
                    printdirect(resumen);

                }
                else
                {
                    mensaje = "Venta cancelada";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            return mensaje;
        }
        private void printdirect(Modelos.Venta venta)//metodo para imprimir en la impresora que esta predeterminaad en windows, hay que poner el pOS80 COMO PREDETERMINADA!
        {
            Modelos.Empresa empresa = new ControlEmpresa().datosEmpresa();

            float y = 20;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                // Configura las fuentes y los tamaños adecuados
                Font titleFont = new Font("Arial", 8);
                Font contentFont = new Font("Arial", 8);


                // Definir el margen izquierdo y la posición actual en la página
                int marginLeft = 8;
                int marginTop = 8;
                int yPos = marginTop;

                // Imprimir el encabezado
                string encabezado = $"{empresa.NOMBRE}";
                e.Graphics.DrawString(encabezado, titleFont, Brushes.Black, 100, yPos);
                yPos += (int)titleFont.GetHeight() + 5;//dar un poco mas de enter

                string facturaInfo = $"Factura No : {factura}";
                e.Graphics.DrawString(facturaInfo, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight() + 5;
                string fecha = $"Fecha de facturación: {DateTime.Now}";
                e.Graphics.DrawString(facturaInfo, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight() + 5;

                string direccion = $"Dirección: {empresa.DIRECCION}";
                e.Graphics.DrawString(direccion, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight() + 5;

                string email = $"Email:{empresa.CORREO}";
                e.Graphics.DrawString(email, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string telefono = $"Teléfono: {empresa.TELEFONO}";
                e.Graphics.DrawString(telefono, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string cliente = $"Cliente: {txtCliente.Text}";
                e.Graphics.DrawString(cliente, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string usuario = $"Usuario en turno: {user.NOMBRE}";
                e.Graphics.DrawString(usuario, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                // Separador
                yPos += 10;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 380, yPos);
                yPos += 20;

                // Detalles
                string detallesHeader = "-----------------------------detalles-------------------------------";
                e.Graphics.DrawString(detallesHeader, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();
                yPos += 10;
                e.Graphics.DrawString("Descripcion", contentFont, Brushes.Black, marginLeft, yPos);
                e.Graphics.DrawString($"Subtotal", contentFont, Brushes.Black, 240, yPos);
                yPos += (int)contentFont.GetHeight();
                yPos += 20;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 380, yPos);
                yPos += 20;

                yPos += (int)contentFont.GetHeight();
                foreach (var d in detalles)
                {
                    var oferta = listaOfertas.FirstOrDefault(of =>of.PRODUCTO.ID == d.PRODUCTO.ID);
                    e.Graphics.DrawString($"{d.PRODUCTO.NOMBRE + d.PRODUCTO.MARCA + d.PRODUCTO.UNIDAD}", contentFont, Brushes.Black, marginLeft, yPos);
                    e.Graphics.DrawString($"{d.CANTIDAD * d.PRECIO}", contentFont, Brushes.Black, 240, yPos);
                    yPos += (int)contentFont.GetHeight();
                    e.Graphics.DrawString($"{d.CANTIDAD} x {d.PRECIO}", contentFont, Brushes.Black, 10, yPos);
                    yPos += (int)contentFont.GetHeight();
                    if(oferta != null)
                    {
                        e.Graphics.DrawString($"Oferta aplicada: {oferta.DESCRIPCION}", contentFont, Brushes.Black, 10, yPos);
                        yPos += (int)contentFont.GetHeight();
                    }
                    
                }

                // Separador
                yPos += 10;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 380, yPos);
                yPos += 20;

                // Resumen


                string subtotal = $"Subtotal:";
                e.Graphics.DrawString(subtotal, contentFont, Brushes.Black, 80, yPos);
                e.Graphics.DrawString($"{txtSubTotal.Text}", contentFont, Brushes.Black, 240, yPos);

                yPos += (int)contentFont.GetHeight();

                string iva = $"IVA: ";
                e.Graphics.DrawString($"{txtIva.Text}", contentFont, Brushes.Black, 240, yPos);
                e.Graphics.DrawString(iva, contentFont, Brushes.Black, 80, yPos);
                yPos += (int)contentFont.GetHeight();

                string totalAntesDescuento = $"Total antes de descuento: ";
                e.Graphics.DrawString(totalAntesDescuento, contentFont, Brushes.Black, 80, yPos);
                e.Graphics.DrawString($"{txtTotal.Text}", contentFont, Brushes.Black, 240, yPos);
                yPos += (int)contentFont.GetHeight();

                string descuento = $"Descuento: ";
                e.Graphics.DrawString(descuento, contentFont, Brushes.Black, 80, yPos);
                e.Graphics.DrawString($"{txtDescuento.Text}", contentFont, Brushes.Black, 240, yPos);
                yPos += (int)contentFont.GetHeight();

                string totalDespuesDescuento = $"Total Despues de descuento: ";
                e.Graphics.DrawString(totalDespuesDescuento, contentFont, Brushes.Black, 80, yPos);
                e.Graphics.DrawString($"{txtTotalFinal.Text}", contentFont, Brushes.Black, 240, yPos);
                yPos += (int)contentFont.GetHeight();

                string cambio = $"Cambio: ";
                e.Graphics.DrawString(cambio, contentFont, Brushes.Black, 80, yPos);
                e.Graphics.DrawString($"{txtCambioDeCompra.Text}", contentFont, Brushes.Black, 240, yPos);
                yPos += (int)contentFont.GetHeight();
                yPos += 10;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 380, yPos);
                yPos += 20;

                string nota = "         ******NOTA: No se aceptan devoluciones******";
                e.Graphics.DrawString(nota, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();
                string agradecimiento = "                     Gracias por preferirnos :)";
                e.Graphics.DrawString(agradecimiento, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();
                yPos += 10;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 280, yPos);
            };

            PrintController printController = new StandardPrintController(); // Para evitar la ventana de progreso
            printDocument.PrintController = printController;
            printDocument.Print();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.SelectedItem.ToString();
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
                    cliente = new Modelos.Cliente
                    {
                        ID = idObtenido,
                        NOMBRES = nombreObtenido
                    };
                    txtCliente.Text = nombreObtenido;
                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
