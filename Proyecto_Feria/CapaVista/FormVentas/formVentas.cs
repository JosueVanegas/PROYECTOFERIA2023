using CapaVista.FormConfiguracion;
using CapaVista.FormVentas;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        public static decimal Monto;
        public formVentas(Boolean Mod)
        {
            InitializeComponent();
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                //Modo Dark

            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                //Modo Light


            }



        }

        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDescuento.Checked)
            {
                txtDescuento.Visible = true;
            }
            if (!checkDescuento.Checked)
            {
                txtDescuento.Visible = false;
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

            Monto = 20;
            //Monto = float.Parse(txtTotal.Text);
            FormPagar form = new FormPagar(formConfiguraciones.Mod);
            form.ShowDialog();
        }

        private void btnEntradaManual_Click(object sender, EventArgs e)
        {
            FormBuscarProductos form = new FormBuscarProductos(formConfiguraciones.Mod);
            form.ShowDialog();
        }

        private void txtDescuento_Click(object sender, EventArgs e)
        {

        }
    }
}
