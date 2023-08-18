using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class FormInicio : MaterialForm
    {
        ControlDashboard cEstat = new ControlDashboard();
        public FormInicio(Usuario Rol)
        {
            InitializeComponent();
            mostrarCantidades();
            mostrarTopProductos();

            /*    if (Rol.oRol.descripcion == "Administrador" || Rol.oRol.descripcion == "Contador")
                {
                    parrotGroupBox1.Visible = true;
                }

                if (Rol.oRol.descripcion == "Vendedor")
                {
                    parrotGroupBox1.Visible = false;
                }*/
            lblEncabezado.Font = new Font(" Microsoft Sans Serif", 24);
            panelGraficosBarra.BackColor = Color.White;
        }
        private void mostrarCantidades()
        {
            txtDataEmpleado.Text = "Empleados registrados: " + cEstat.cantidadCategorias("EMPLEADO");
            txtDataCategoria.Text = "Categorias registrados: " + cEstat.cantidadCategorias("CATEGORIA");
            txtDataProveedor.Text = "Proveedores registrados: " + cEstat.cantidadCategorias("PROVEEDOR");
            txtDataProducto.Text = "Productos registrados: " + cEstat.cantidadCategorias("PRODUCTO");
            txtDataClientes.Text = "Clientes registrados: " + cEstat.cantidadCategorias("CLIENTE");
            txtDataUsuarios.Text = "Usuarios registrados: " + cEstat.cantidadCategorias("USUARIO");
        }
        private void mostrarTopProductos()
        {
            List<productosMasVendidos> productosVendidos = cEstat.productosTop();

            foreach (var productoVendido in productosVendidos)
            {
                chartTopProductos.Series["Ventas"].Points.AddXY(productoVendido.nombre, productoVendido.cantidad);
                chartTopUsuario.Series["Ventas"].Points.AddXY(productoVendido.nombre, productoVendido.cantidad);
            }
            chartTopProductos.Series["Ventas"]["PieLabelStyle"] = "Disabled";
            chartTopProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTopProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void lblEncabezado_Click(object sender, EventArgs e)
        {

        }
    }
}
