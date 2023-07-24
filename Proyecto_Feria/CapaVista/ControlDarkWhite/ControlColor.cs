using CapaVista.FormPlanilla;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVista.ControlDarkWhite
{
    internal class ControlColor 
    {

        public const int MoodDark = 1;
        public const int MoodLight = 0;

        

        public static void CambiarAtributo(int Mood, MaterialForm FrmCambio)
        {
            if (Mood.Equals(ControlColor.MoodLight))
            {
                MaterialSkinManager manager;
                manager = MaterialSkinManager.Instance;
                manager.AddFormToManage(FrmCambio);
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.EnforceBackcolorOnAllComponents = true;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);

            }
            if (Mood.Equals(ControlColor.MoodDark))
            {
                MaterialSkinManager manager;
                manager = MaterialSkinManager.Instance;
                manager.AddFormToManage(FrmCambio);
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.EnforceBackcolorOnAllComponents = true;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);


            }
        }
    }
}
