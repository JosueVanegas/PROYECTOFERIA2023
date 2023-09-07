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
        ResumenVenta resumen;
        Cliente cliente = new Cliente();
        Usuario user = new Usuario();
        List<DetalleVenta> detalles;
        ControlVenta cVenta = new ControlVenta();
        string impresora = "";
        string factura = "";
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

            // Permitir solo dígitos y las teclas "Backspace" y "Delete"
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si no es un dígito o las teclas "Backspace" o "Delete"
            }

            // Verificar si la longitud del texto es mayor o igual a 9
            if (textoActual.Length >= 9 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si se supera la longitud máxima
            }

            // Validar el punto decimal
            if (keyPressed == '.' && textoActual.Contains("."))
            {
                e.Handled = true; // Ignorar el carácter si ya hay un punto decimal
            }

            // Validar los dos decimales después del punto
            if (textoActual.Contains("."))
            {
                int indexPunto = textoActual.IndexOf(".");
                if (textoActual.Length - indexPunto > 2 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
                {
                    e.Handled = true; // Ignorar el carácter si ya hay dos decimales después del punto
                }
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
            factura = "";
            try
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.UseEXDialog = true;
                DialogResult confirmResult = MessageBox.Show("¿Estas seguro de realizar la venta?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                        infoVenta v = new infoVenta
                        {
                            ID_CLIENTE = cliente.id,
                            ID_USUARIO = user.id,
                            DESCUENTO = resumen.descuento,
                            IVA = resumen.iva,
                            SUBTOTAL = resumen.subtotal,
                            TOTAL = resumen.total,
                        };
                        factura = cVenta.procesoDeVenta(v, detalles);
                        MessageBox.Show(cVenta.retornarMensaje());

                    printdirect(v);
                    //if (!string.IsNullOrEmpty(factura))
                    //{
                    //    if (impresora != "")
                    //    {

                    //        ////Aqui es donde me falta es lo del tamaño como lo ajusto aqui donde tambien tenia dudas  
                    //        ///
                    //        string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    //        string nombreArchivo = Path.Combine(carpetaDocumentos, "Factura_" + factura);
                    //       //string nombreArchivo = Path.Combine(carpetaDocumentos, "Factura_" + factura + ".pdf");
                    //        ////////  la linea de abajo era lo que estaba probando ahora del 80mm ahora en la tarde
                    //    //    System.Drawing.Printing.PaperSize paperSize = new System.Drawing.Printing.PaperSize("Custom", Convert.ToInt32(80 / 25.4) * 100, Convert.ToInt32(210 / 25.4) * 100);
                    //        ///////////pero estaba probando lo del 80mm xd y ahi si no se xd
                    //        ///no toques porfa
                    //        ///
                    //        pdImprimir = new PrintDocument();
                    //        pdImprimir.PrinterSettings.PrinterName = impresora;
                    //         // si esta linea puedo generar
                    //        ////////////////
                    //     //   pdImprimir.DefaultPageSettings.PaperSize = paperSize;
                    //        ///////////////
                    //        pdImprimir.PrinterSettings.PrintToFile = true;
                    //        pdImprimir.PrinterSettings.PrintFileName = nombreArchivo;

                    //        pdImprimir.PrintPage += imprimir;

                    //        for (int i = 0; i < 1; i++)
                    //        {
                    //            pdImprimir.Print();
                    //        }
                    //        mensaje = "Factura generada e impresa con éxito se guardo en en: "+nombreArchivo;
                    //    }
                    //    else
                    //    {
                    //        mensaje = "No se ha seleccionado ninguna impresora";
                    //    }
                    //}
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



      public void d()
        {/*
            Empresa empresa = new ControlEmpresa().datosEmpresa();
            Font font = new Font("Courier New", 12);
            float y = 20;

            e.Graphics.DrawString($"        {empresa.nombre}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Factura No: {new DataVenta().noFactura}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Dirección: {empresa.direccion + " " + empresa.departamento}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Email: {empresa.email}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Teléfono: {empresa.telefono}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Cliente:{txtCliente.Text}", font, Brushes.Black, 20, y);
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
            e.HasMorePages = false;*/
        }



        //TODO
        //el select de las impresoras ya no seria necesario supongo PORQUE SE ESTA IMPRIMIENDO POR DEFECTO LA PREDETERMINADA
        //AJUSTAR EL TEXTO PARA QUE SE AJUSTE AL VOUCHER DE LA HOJA (ESTO VAS A TENER QUE HACERLO A MANO NO HAY DE OTRA, A MENOS QUE SE CAMBIE A CRYSTAL REPORT PERO NO HAY TIEMPO)
        //EN ESTA LINEA PODES DARLE MAS ESPACIO PARA QUE SE SEPAREN UNA ABAJO DE LA LINEA ANTERIOR yPos += (int) titleFont.GetHeight()+5;//dar un poco mas de enter SUMANDOLE +5 O +10 ETC
        //NOTA LAS CLASES SE DEBEN NOMBRAR EN MAYUSCULA infoVenta ->InfoVenta

        private void printdirect(infoVenta venta)//metodo para imprimir en la impresora que esta predeterminaad en windows, hay que poner el pOS80 COMO PREDETERMINADA!
        {
            Empresa empresa = new ControlEmpresa().datosEmpresa();
           
            float y = 20;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => {
                // Configura las fuentes y los tamaños adecuados
                Font titleFont = new Font("Arial", 8);
                Font contentFont = new Font("Arial", 8);


                // Definir el margen izquierdo y la posición actual en la página
                int marginLeft = 8;
                int marginTop = 8;
                int yPos = marginTop;

                // Imprimir el encabezado
                string encabezado = $"{empresa.nombre}";
                e.Graphics.DrawString(encabezado, titleFont, Brushes.Black, 100, yPos);
                yPos += (int)titleFont.GetHeight()+5;//dar un poco mas de enter

                string facturaInfo = $"Factura No: {new DataVenta().noFactura}";
                e.Graphics.DrawString(facturaInfo, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight()+5;

                string direccion = $"Dirección: {empresa.direccion + " " + empresa.departamento}";
                e.Graphics.DrawString(direccion, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight()+5;

                string email = $"Email:{empresa.email}";
                e.Graphics.DrawString(email, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string telefono = $"Teléfono: {empresa.telefono}";
                e.Graphics.DrawString(telefono, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string cliente = $"Cliente: {txtCliente.Text}";
                e.Graphics.DrawString(cliente, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                string usuario = $"Usuario en turno: {user.usuario}";
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
                e.Graphics.DrawString("Descripcion" ,contentFont, Brushes.Black, marginLeft, yPos);
                e.Graphics.DrawString($"Subtotal", contentFont, Brushes.Black, 230, yPos);
                e.Graphics.DrawString($"Cantidad x Precio", contentFont, Brushes.Black, 110, yPos);
                yPos += (int)contentFont.GetHeight();
                yPos += 20;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 380, yPos);
                yPos += 20;

                yPos += (int)contentFont.GetHeight();
                foreach (var d in detalles)
                {

                    e.Graphics.DrawString($"{d.NOMBRE}", contentFont, Brushes.Black, marginLeft, yPos);
                    e.Graphics.DrawString($"{d.SUBTOTAL}", contentFont, Brushes.Black, 240, yPos);
                    e.Graphics.DrawString($"{d.CANTIDAD} x {d.PRECIO}", contentFont, Brushes.Black, 130, yPos);

                    /*    e.Graphics.DrawString($"{d.NOMBRE}", font, Brushes.Black, 20, y);
                        e.Graphics.DrawString($"{d.SUBTOTAL}", font, Brushes.Black, 700, y);
                        y += 20;
                        e.Graphics.DrawString($"{d.CANTIDAD} x {d.PRECIO}", font, Brushes.Black, 20, y);*/
                    yPos += (int)contentFont.GetHeight();
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

                // Mensaje de agradecimiento
                string agradecimiento = "                     Gracias por preferirnos :)";
                e.Graphics.DrawString(agradecimiento, contentFont, Brushes.Black, marginLeft, yPos);
                yPos += (int)contentFont.GetHeight();

                // Línea divisoria final
                yPos += 10;
                e.Graphics.DrawLine(new Pen(Brushes.Black), marginLeft, yPos, 280, yPos);
            };

            PrintController printController = new StandardPrintController(); // Para evitar la ventana de progreso
            printDocument.PrintController = printController;
            printDocument.Print();
        }

     
        
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Empresa empresa = new ControlEmpresa().datosEmpresa();
            Font font = new Font("Courier New", 12);
            float y = 20;

            e.Graphics.DrawString($"                               {empresa.nombre}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Factura No: {new DataVenta().noFactura}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Dirección: {empresa.direccion + " " + empresa.departamento}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Email: {empresa.email}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Teléfono: {empresa.telefono}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Cliente:{txtCliente.Text}", font, Brushes.Black, 20, y);
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
        private void CargarImpresorasDisponibles()
        {
            PrinterSettings.StringCollection impresoras = PrinterSettings.InstalledPrinters;

            foreach (string impresora in impresoras)
            {
                cbxImpresoras.Items.Add(impresora);
            }
            cbxImpresoras.SelectedIndex = 3;
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

        private void cbxImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            impresora = cbxImpresoras.SelectedItem.ToString();
        }
    }
}





