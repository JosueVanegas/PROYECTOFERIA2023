using CapaDatos;
using CapaVista.FormConfiguracion;
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

namespace CapaVista.FormsHerramientas
{
    public partial class FormsHerramientasss : MaterialForm
    {
        public FormsHerramientasss(Boolean Mod, Usuario Rol)
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

            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
            }
            /*
            if (Rol.oRol.descripcion == "Administrador")
            {
                btnbitacora.Visible = true;
                btnCalculadoraBasica.Visible = true;
                btnCalcularDescuento.Visible = true;
                
                btnCalcularNomina.Visible = true;
                btnIR.Visible = true;
                
            }
            if (Rol.oRol.descripcion == "Contador")
            {
                btnbitacora.Visible = true;
                btnCalculadoraBasica.Visible = true;
                btnCalcularDescuento.Visible = true;
                
                btnCalcularNomina.Visible = true;
                btnIR.Visible = true;
                
            }
            if (Rol.oRol.descripcion == "Vendedor")
            {
                btnbitacora.Visible = true;
                btnCalculadoraBasica.Visible = true;
                btnCalcularDescuento.Visible = true;
            
                btnCalcularNomina.Visible = false;
                btnIR.Visible = false;
               
            }*/

        }

        private void btnCalculadoraBasica_Click(object sender, EventArgs e)
        {
            CalculadoraBasica Ca = new CalculadoraBasica(formConfiguraciones.Mod);
            Ca.ShowDialog();
        }

        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            CalcularDescuento Ca = new CalcularDescuento(formConfiguraciones.Mod);
            Ca.ShowDialog();
        }
    }
}
