using CapaVista.FormPrimerAcceso;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormConfiguracion
{
    public partial class formConfiguraciones : MaterialForm
    {
        bool Dmod;
        public formConfiguraciones(bool Mod)
        {
            InitializeComponent();
            cambiarModo(Mod);
            Dmod = Mod;
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
        private void btnEntidadEmpresa_Click(object sender, EventArgs e)
        {
            FormaAjustesEntidad form = new FormaAjustesEntidad(Dmod, false);
            form.ShowDialog();
        }
    }
}

