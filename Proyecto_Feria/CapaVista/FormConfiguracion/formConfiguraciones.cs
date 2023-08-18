using CapaVista.FormPrimerAcceso;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormConfiguracion
{
    public partial class formConfiguraciones : MaterialForm
    {
     
        public formConfiguraciones()
        {
            InitializeComponent();
          
        }
       
        private void btnEntidadEmpresa_Click(object sender, EventArgs e)
        {
            FormaAjustesEntidad form = new FormaAjustesEntidad(false);
            form.ShowDialog();
        }
    }
}

