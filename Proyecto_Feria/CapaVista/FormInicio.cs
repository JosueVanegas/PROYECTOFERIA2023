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
        public FormInicio(Usuario Rol)
        {
            InitializeComponent();
            mostrarCantidades();
            mostrarTopProductos();
            mostrarVentasSemanaActual();
            mostrarDatosEmpresa();
            mostrarStockProductos();
            mostrarValorInventario();
            dtFechaFinal.Enabled = true;
        }
        private void mostrarCantidades()
        {
            txtEmpleados.Text = cDash.cantidadCategorias("EMPLEADO").ToString();
            txtCategorias.Text = cDash.cantidadCategorias("CATEGORIA").ToString();
            txtProveedores.Text = cDash.cantidadCategorias("PROVEEDOR").ToString();
            txtProductos.Text = cDash.cantidadCategorias("PRODUCTO").ToString();
            txtClientes.Text = cDash.cantidadCategorias("CLIENTE").ToString();
            txtUsuarios.Text = cDash.cantidadCategorias("USUARIO").ToString();
        }
        private void mostrarTopProductos()
        {
            List<graficaProductos> productosVendidos = cDash.datosGraficaProductos();

            foreach (var productoVendido in productosVendidos)
            {
                chartTopProductos.Series["Ventas"].Points.AddXY(productoVendido.nombre, productoVendido.cantidad);
            }
            chartTopProductos.Series["Ventas"]["PieLabelStyle"] = "Disabled";
            chartTopProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTopProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        private void mostrarStockProductos()
        {
            List<Producto> lista = cProducto.listarProductos();
            tbStock.Rows.Clear();
            foreach (Producto p in lista)
            {
                tbStock.Rows.Add(p.codigo, p.nombre, p.cantidad);
            }
        }
        private void mostrarVentas(string fechaI, string fechaF)
        {
            int cantidadVentas = 0;
            decimal totalVentas = 0;
            List<graficaVentas> ventas = cDash.datosGraficaVentas(fechaI, fechaF);
            lblTituloGraficaVentas.Text = "Ventas ordenadas por fecha";
            lblTituloGraficaVentas.Text += " Del: " + fechaI + " al " + fechaF;
            chartTopUsuario.Series["Ventas"].Points.Clear();
            foreach (graficaVentas v in ventas)
            {
                cantidadVentas++;
                totalVentas += v.total;
                DateTime date = DateTime.ParseExact(v.fecha, "dd/MM/yyyy", null);
                string nombreMes = date.ToString("MMM");
                string dia = date.ToString("ddd");
                string fecha = nombreMes + "-" + dia;
                chartTopUsuario.Series["Ventas"].Points.AddXY(fecha, v.total);
            }

            lblCantidadVentas.Text = cantidadVentas.ToString();
            lblTotalVentas.Text = totalVentas.ToString("0.00");
            if (cantidadVentas == 0 && totalVentas == 0)
            {
                MessageBox.Show("No se realizaron ventas en el periodo seleccionado");
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
            Empresa emp = new ControlEmpresa().datosEmpresa();
            if (emp != null)
            {
                if (emp.imagen != null)
                {
                    lblNombreEmpresa.Text = emp.nombre;
                    using (MemoryStream memoryStream = new MemoryStream(emp.imagen))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        pictureLogoEmpresa.Image = imagen;
                    }
                }
            }
        }
    }
}
