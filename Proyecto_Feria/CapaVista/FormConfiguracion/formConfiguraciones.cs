using CapaVista.FormPrimerAcceso;
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
                {
                    manager.Theme = MaterialSkinManager.Themes.LIGHT;
                    manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);

                }

            }

        }

            private void btnEntidadEmpresa_Click(object sender, EventArgs e)
            {
                FormaAjustesEntidad form = new FormaAjustesEntidad(formConfiguraciones.Mod, false);
                form.ShowDialog();
            }
        }
    } 

