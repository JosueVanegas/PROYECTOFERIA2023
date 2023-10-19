﻿using CapaControlador;
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
            ajustarFechas();
            mostrarCantidades();
            mostrarVentasSemanaActual();
            mostrarDatosEmpresa();
            mostrarStockProductos();
            mostrarValorInventario();
            dtFechaFinal.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        private void ajustarFechas()
        {
            dpFechaInicio.Value = DateTime.Now;
            dtFechaFinal.MinDate = dpFechaInicio.Value;
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
        private void mostrarTopProductos(DateTime fechaInicio, DateTime fechafinal)
        {
            Dictionary<string, int> productosVendidos = cDash.datosGraficaProductos(fechaInicio, fechafinal);

            if (productosVendidos.Count != 0)
            {
                chartTopProductos.Visible = true;
                foreach (var productoVendido in productosVendidos)
                {
                    chartTopProductos.Series["Ventas"].Points.AddXY(productoVendido.Key, productoVendido.Value);
                }
                chartTopProductos.Series["Ventas"]["PieLabelStyle"] = "Disabled";
                chartTopProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartTopProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }
        private void mostrarStockProductos()
        {
            List<Modelos.Producto> lista = new ControlProducto().listarProductos();
            tbStock.Rows.Clear();
            foreach (Modelos.Producto p in lista)
            {
                string error1 = "", error2 = "";
                bool e1 = false, e2 = false;
                DateTime hoy = DateTime.Now.Date;

                if (p.STOCK <= p.STOCK_SEGURIDAD || p.STOCK == 0)
                {
                    error1 = "Revisar el stock del producto ";
                    e1 = true;
                }
                else
                {
                    error1 = "Todo en orden";
                    e1 = false;
                }

                // Calcular la diferencia entre la fecha de vencimiento y la fecha actual
                TimeSpan diferencia = p.VENCIMIENTO.Date - hoy;

                if (diferencia.Days > 0)
                {
                    error2 = $"El producto vence en {diferencia.Days} días";
                    e2 = false;
                }
                else if (diferencia.Days == 0)
                {
                    error2 = "El producto vence hoy";
                    e2 = true;
                }
                else
                {
                    error2 = "El producto ya venció";
                    e2 = true;
                }

                int index = tbStock.Rows.Add(p.CODIGO, p.NOMBRE, p.STOCK, p.STOCK_SEGURIDAD, error1 + " " + error2);
                if (e1 == true || e2 == true)
                {
                    tbStock.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (e1 == false || e2 == false)
                {
                    tbStock.Rows[index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        private void mostrarVentas(DateTime fechaI, DateTime fechaF)
        {
            int cantidadVentas = 0;
            decimal totalVentas = 0;
            Dictionary<string, decimal> ventas = cDash.datosGraficaVentas(fechaI, fechaF);
            lblTituloGraficaVentas.Text = "Ventas ordenadas por fecha";
            lblTituloGraficaVentas.Text += " Del: " + fechaI + " al " + fechaF;
            chartTopUsuario.Series["Ventas"].Points.Clear();
            foreach (KeyValuePair<string, decimal> v in ventas)
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
            DateTime fechaInicio = dateTime.AddDays(-7);
            DateTime fechaFinal = dateTime;
            mostrarVentas(fechaInicio, fechaFinal);
            mostrarTopProductos(fechaInicio, fechaFinal);
        }
        private void dpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFechaFinal.MinDate = dpFechaInicio.Value;
        }
        private void btnSeleccionarRango_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dpFechaInicio.Value;
            DateTime fechaFinal = dtFechaFinal.Value;
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
