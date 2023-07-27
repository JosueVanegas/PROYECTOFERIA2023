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

namespace CapaVista.FormConfiguracion
{
    public partial class formConfiguraciones : MaterialForm
    {
        public static Boolean Mod = true;
        public formConfiguraciones()
        {
            InitializeComponent();
           switchModd.Checked = Mod;
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (switchModd.Checked)
            {
                LunaPicture.Visible = true;
                SolPicture.Visible = false;

                lblEncabezado3.Text = "OSCURO";


                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);


            }
            if (!switchModd.Checked)
            {
                LunaPicture.Visible = false;
                SolPicture.Visible = true;
                lblEncabezado3.Text = "CLARO";


                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);

            }
            lblEncabezado3.Font = new Font("Segoe UI", 36);
            lblEncabezado2.Font = new Font("Segoe UI", 36);
        }

        private void cyberSwitch2_CheckedChanged()
        {

            Mod = switchModd.Checked;
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (switchModd.Checked)
            {
                LunaPicture.Visible = true;
                SolPicture.Visible = false;

                lblEncabezado3.Text = "OSCURO";
               

                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                switchModd.ColorValue = Color.FromArgb(29, 200, 238);
                switchModd.ColorBackground = Color.FromArgb(21, 25, 31);
            }
            if (!switchModd.Checked)
            {
                LunaPicture.Visible = false;
                SolPicture.Visible = true;
                lblEncabezado3.Text = "CLARO";


                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                switchModd.ColorValue = Color.FromArgb(175, 238, 238);
                switchModd.ColorBackground = Color.FromArgb(224, 255, 255);
            }
            lblEncabezado3.Font = new Font("Segoe UI", 36);
            lblEncabezado2.Font = new Font("Segoe UI", 36);

        }
    }
}

