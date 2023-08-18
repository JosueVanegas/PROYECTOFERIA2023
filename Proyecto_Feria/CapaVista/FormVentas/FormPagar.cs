using CapaVista.FormConfiguracion;
using CapaVista.FormVenta;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Text;
using CapaControlador;
using CapaDatos;
using System.Drawing.Printing;
using System.Reflection;
using System.Drawing;

namespace CapaVista.FormVentas
{
    public partial class FormPagar : MaterialForm
    {
        ResumenVenta resumen;
        Cliente cliente = new Cliente();
        Usuario user = new Usuario();
        List<DetalleVenta> detalles;
        ControlVenta cVenta = new ControlVenta();
        public FormPagar(Usuario u,  ResumenVenta r, List<DetalleVenta> d)
        {
            InitializeComponent();
            resumen = r;
            detalles = d;
            user = u;
            
        }
        
        private void FormPagar_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            realizarResumen();
        }
        private void realizarResumen()
        {
            txtDescuento.Text = resumen.descuento.ToString();
            txtSubTotal.Text = resumen.subtotal.ToString();
            txtIva.Text = resumen.iva.ToString();
            txtTotal.Text = resumen.total.ToString();
            decimal totalFinal = Convert.ToDecimal(txtTotal.Text)-Convert.ToDecimal(txtDescuento.Text);
            txtTotalFinal.Text = totalFinal.ToString("0.00") ;
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
            decimal total = Convert.ToDecimal(txtTotal.Text);
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
            if (txtCliente.Text != "" && cliente != null && calcularCambio() == true)
            {
                try
                {
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
                    MessageBox.Show(imprimirFactura());
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("seleccione el cliente de la lista de clientes o seleccione cliente comun");
            }

        }
        private string imprimirFactura()
        {
            string mensaje = "Factura realizada con exito";
            try
            {
                pdImprimir = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                pdImprimir.PrinterSettings = ps;
                pdImprimir.PrintPage += imprimir;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pdImprimir;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    pdImprimir.Print();
                    Console.WriteLine("Factura impresa exitosamente.");
                }
                else
                {
                    Console.WriteLine("Impresión cancelada.");
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 12);
            float y = 20;

            e.Graphics.DrawString($"-------------------Factura No:{new DataVenta().noFactura}-----------------", font, Brushes.Black, 100, y);
            y += 20;
            e.Graphics.DrawString($"Cliente:{cliente.nombre}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString($"Usuario en turno: {user.usuario}", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("------------------------------------detalles-------------------------------", font, Brushes.Black, 20, y);
            y += 20;
            e.Graphics.DrawString("Descripcion                                                      Subtotal", font, Brushes.Black, 20, y);
            y += 20;
            foreach (var d in detalles)
            {
                e.Graphics.DrawString($"{d.ID_PRODUCTO} - {d.NOMBRE}   |   {d.SUBTOTAL}", font, Brushes.Black, 20, y);
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
    }
}





