﻿using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class FrmInicio : MaterialForm
    {
        ControlEstadistica cEstat = new ControlEstadistica();
        public FrmInicio(Boolean Mod, Usuario Rol)
        {
            InitializeComponent();

            //MessageBox.Show("la cantidad de categorias es de: " + cEstat.cantidadCategorias());
            mostrarCantidades();

            MaterialSkinManager manager;

            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                RelojInicio.HexagonColor = Color.FromArgb(60, 60, 70);
                RelojInicio.UnfilledHourColor = Color.FromArgb(60, 60, 70);
                RelojInicio.UnfilledMinuteColor = Color.FromArgb(60, 60, 70);
                RelojInicio.UnfilledSecondColor = Color.FromArgb(60, 60, 70);
                RelojInicio.TimeColor = Color.White;
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                RelojInicio.HexagonColor = Color.FromArgb(242, 242, 242);
                RelojInicio.UnfilledHourColor = Color.FromArgb(242, 242, 242);
                RelojInicio.UnfilledMinuteColor = Color.FromArgb(242, 242, 242);
                RelojInicio.UnfilledSecondColor = Color.FromArgb(242, 242, 242);
                RelojInicio.TimeColor = Color.Black;

            }
            /*    if (Rol.oRol.descripcion == "Administrador" || Rol.oRol.descripcion == "Contador")
                {
                    parrotGroupBox1.Visible = true;
                }

                if (Rol.oRol.descripcion == "Vendedor")
                {
                    parrotGroupBox1.Visible = false;
                }*/

            RelojInicio.Font = new Font("Impact", 36);
            lblEncabezado.Font = new Font(" Microsoft Sans Serif", 24);

        }

        private void mostrarCantidades()
        {
            txtDataEmpleado.Text = "Cantidad de empleados : " + cEstat.cantidadCategorias("EMPLEADO");
            txtDataCategoria.Text = "Cantidad de categorias: " + cEstat.cantidadCategorias("CATEGORIA");
            txtDataProveedor.Text = "Cantidad de empleados : " + cEstat.cantidadCategorias("PROVEEDOR");
            txtDataProducto.Text = "Cantidad de categorias: " + cEstat.cantidadCategorias("PRODUCTO");
        }

    }
}