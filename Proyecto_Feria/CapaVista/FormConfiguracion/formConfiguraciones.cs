using CapaVista.FormPrimerAcceso;
using ReaLTaiizor.Forms;

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

