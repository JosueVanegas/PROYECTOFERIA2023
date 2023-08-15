using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CapaVista.FormInventario
{
    public partial class FormCompras : MaterialForm
    {
        public FormCompras(bool Mod)
        {
            InitializeComponent();
            cambiarModo(Mod);
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
    }
}
