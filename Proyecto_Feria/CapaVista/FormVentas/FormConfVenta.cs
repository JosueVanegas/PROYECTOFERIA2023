using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormVentas
{
    public partial class FormConfVenta : MaterialForm
    {
        public FormConfVenta(Boolean Mod, Boolean ConVenta, String Mensaje)

        {
            InitializeComponent();
            lblTxt.Text = Mensaje;
            if (ConVenta)
            {
                pictureVentaConfirmada.Visible = true;
                PictureVentaNoConfirmada.Visible = false;
            }
            if (!ConVenta)
            {
                pictureVentaConfirmada.Visible = false;
                PictureVentaNoConfirmada.Visible = true;
            }
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
        }


    }
}
