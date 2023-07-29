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

namespace CapaVista.FormsHerramientas
{
    public partial class CalcularDescuento : MaterialForm
    {
        public CalcularDescuento(Boolean Mod)
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



        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            // Manejar el clic del botón para calcular el descuento
            if (double.TryParse(txtPrecioOriginal.Text, out double precioOriginal) && double.TryParse(txtPorcentajeDescuento.Text, out double porcentajeDescuento))
            {
                if (porcentajeDescuento >= 0 && porcentajeDescuento <= 100)
                {
                    double descuento = precioOriginal * (porcentajeDescuento / 100);
                    double precioFinal = precioOriginal - descuento;

                    txtDescuento.Text = $"Descuento: {descuento:C2}";
                    txtPrecioFinal.Text = $"Precio final: {precioFinal:C2}";
                }
                else
                {
                    MessageBox.Show("El porcentaje de descuento debe estar entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
