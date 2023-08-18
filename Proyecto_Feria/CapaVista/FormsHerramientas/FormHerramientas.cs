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
       
        public FormHerramientas( Usuario Rol)
        {
            InitializeComponent();
            
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
        private void cambiarModo(bool modoOscuro)
        {
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
            }
            if (!modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void btnCalculadoraBasica_Click(object sender, EventArgs e)
        {
            FormCalculadoraBasica Ca = new FormCalculadoraBasica();
            Ca.ShowDialog();
        }

        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            FormCalcularDescuento Ca = new FormCalcularDescuento();
            Ca.ShowDialog();
        }

        private void btnGenerarCodigoBarra_Click(object sender, EventArgs e)
        {
            FormGenerarCodigoBarra GeneradorCodigo = new FormGenerarCodigoBarra();
            GeneradorCodigo.ShowDialog();
        }
    }
}
