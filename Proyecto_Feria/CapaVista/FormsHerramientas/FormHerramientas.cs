using CapaDatos;
using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormsHerramientas
{
    public partial class FormHerramientas : MaterialForm
    {
        public FormHerramientas(Boolean Mod, Usuario Rol)
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
            btnbitacora.Visible = true;
            btnCalculadoraBasica.Visible = true;
            btnCalcularDescuento.Visible = true;

            btnCalcularNomina.Visible = true;
            btnIR.Visible = true;
            btnGenerarCodigoBarra.Visible = true;
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
            FormCalculadoraBasica Ca = new FormCalculadoraBasica(formConfiguraciones.Mod);
            Ca.ShowDialog();
        }

        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            FormCalcularDescuento Ca = new FormCalcularDescuento(formConfiguraciones.Mod);
            Ca.ShowDialog();
        }

        private void btnGenerarCodigoBarra_Click(object sender, EventArgs e)
        {
            FormGenerarCodigoBarra GeneradorCodigo = new FormGenerarCodigoBarra();
            GeneradorCodigo.ShowDialog();
        }
    }
}
