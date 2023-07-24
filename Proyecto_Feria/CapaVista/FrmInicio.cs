using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class FrmInicio : MaterialForm
    {
        ControlEstadistica cEstat = new ControlEstadistica();
        public FrmInicio()
        {
            InitializeComponent();
            //MessageBox.Show("la cantidad de categorias es de: " + cEstat.cantidadCategorias());
            mostrarCantidades();
        }
        private void mostrarCantidades()
        {
            txtDataEmpleado.Text = "Cantidad de empleados : " + cEstat.cantidadCategorias("EMPLEADO");
            txtDataCategoria.Text = "Cantidad de categorias: " + cEstat.cantidadCategorias("CATEGORIA");
            txtDataProveedor.Text = "Cantidad de empleados : " + cEstat.cantidadCategorias("PROVEEDOR");
            txtDataProducto.Text = "Cantidad de categorias: " + cEstat.cantidadCategorias("PRODUCTO");
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
