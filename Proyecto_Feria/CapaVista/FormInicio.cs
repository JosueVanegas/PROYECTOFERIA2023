using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;
using System;
using System.Globalization;

namespace CapaVista
{
    public partial class FormInicio : MaterialForm
    {
        ControlDashboard cDash = new ControlDashboard();
        ControlProducto cProducto = new ControlProducto();
        public FormInicio()
        {
            this.Cursor = Cursors.WaitCursor;
            InitializeComponent();
            mostrarCantidades();
            mostrarTopProductos();
            mostrarVentasSemanaActual();
            mostrarDatosEmpresa();
            mostrarStockProductos();
            mostrarValorInventario();
            dtFechaFinal.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        private void mostrarCantidades()
        {
            txtEmpleados.Text = cDash.cantidadCategorias("SALES.EMPLOYEES").ToString();
            txtCategorias.Text = cDash.cantidadCategorias("INVENTORY.CATEGORYS").ToString();
            txtProveedores.Text = cDash.cantidadCategorias("INVENTORY.SUPPLIERS").ToString();
            txtProductos.Text = cDash.cantidadCategorias("INVENTORY.PRODUCTS").ToString();
            txtClientes.Text = cDash.cantidadCategorias("SALES.CLIENTS").ToString();
            txtUsuarios.Text = cDash.cantidadCategorias("SALES.USERS").ToString();
        }
        private void mostrarTopProductos()
        {
            Dictionary<string, int> productosVendidos = cDash.datosGraficaProductos();

            foreach (var productoVendido in productosVendidos)
            {
                chartTopProductos.Series["Ventas"].Points.AddXY(productoVendido.Key, productoVendido.Value);
            }
            chartTopProductos.Series["Ventas"]["PieLabelStyle"] = "Disabled";
            chartTopProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTopProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        private void mostrarStockProductos()
        {
            List<Modelos.Producto> lista = cProducto.listarProductos();
            tbStock.Rows.Clear();
            foreach (Modelos.Producto p in lista)
            {
                tbStock.Rows.Add(p.CODIGO, p.NOMBRE, p.STOCK);
            }
        }
        private void mostrarVentas(string fechaI, string fechaF)
        {
            int cantidadVentas = 0;
            decimal totalVentas = 0;
            Dictionary<DateTime, decimal> ventas = cDash.datosGraficaVentas(fechaI, fechaF);
            lblTituloGraficaVentas.Text = "Ventas ordenadas por fecha";
            lblTituloGraficaVentas.Text += " Del: " + fechaI + " al " + fechaF;
            chartTopUsuario.Series["Ventas"].Points.Clear();
            foreach (KeyValuePair<DateTime, decimal> v in ventas)
            {
                cantidadVentas++;
                totalVentas += v.Value;
                chartTopUsuario.Series["Ventas"].Points.AddXY(v.Key, v.Value);
            }

            lblCantidadVentas.Text = cantidadVentas.ToString();
            lblTotalVentas.Text = totalVentas.ToString("0.00");
            if (cantidadVentas == 0 && totalVentas == 0)
            {
                lblTituloGraficaVentas.Text = "No se realizaron ventas en el periodo seleccionado";
            }
            else
            {
                lblTituloGraficaVentas.Text = "Ventas ordenadas por fecha";
            }
        }
        private void mostrarValorInventario()
        {
            lblValorInvetario.Text = cDash.valorInventario();
        }
        private void mostrarVentasSemanaActual()
        {
            DateTime dateTime = DateTime.Now;
            DateTime ultimoDiaSemanaAnterior = dateTime.AddDays(-7);
            string fechaInicio = ultimoDiaSemanaAnterior.ToString("yyyy-MM-dd");
            string fechaFinal = dateTime.ToString("yyyy-MM-dd");
            mostrarVentas(fechaInicio, fechaFinal);
        }
        private void dpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFechaFinal.MinDate = dpFechaInicio.Value;
        }
        private void dtFechaFinal_ValueChanged(object sender, EventArgs e)
        {


        }
        private void btnSeleccionarRango_Click(object sender, EventArgs e)
        {
            string fechaInicio = dpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaFinal = dtFechaFinal.Value.ToString("yyyy-MM-dd");
            mostrarVentas(fechaInicio, fechaFinal);
        }
        private void mostrarDatosEmpresa()
        {
            Modelos.Empresa emp = new ControlEmpresa().datosEmpresa();
            if (emp != null)
            {
                if (emp.IMAGEN != null)
                {
                    lblNombreEmpresa.Text = emp.NOMBRE;
                    using (MemoryStream memoryStream = new MemoryStream(emp.IMAGEN))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        pictureLogoEmpresa.Image = imagen;
                    }
                }
            }
        }
    }
}
