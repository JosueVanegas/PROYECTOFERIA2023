using CapaVista.FormConfiguracion;
using CapaVista.FormVentas;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormVenta
{
    public partial class formVentas : MaterialForm
    {
        public static decimal Monto;
        public formVentas(Boolean Mod)
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
                //Modo Dark

            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                //Modo Light


            }



        }

        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDescuento.Checked)
            {
                txtDescuento.Visible = true;
            }
            if (!checkDescuento.Checked)
            {
                txtDescuento.Visible = false;
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

            Monto = 20;
            //Monto = float.Parse(txtTotal.Text);
            FormPagar form = new FormPagar(formConfiguraciones.Mod);
            form.ShowDialog();
        }

        private void btnEntradaManual_Click(object sender, EventArgs e)
        {
            FormBuscarProductos form = new FormBuscarProductos(formConfiguraciones.Mod);
            form.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el caracter presionado es una tecla de control, como Enter, Tab, etc.
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permitir teclas de control
                return;
            }

            // Verificar si el caracter presionado es un dígito numérico
            if (char.IsDigit(e.KeyChar))
            {
                // Obtener el valor actual del textbox
                string currentText = txtDescuento.Text;

                // Concatenar el dígito presionado al valor actual del textbox
                string newText = currentText + e.KeyChar;

                // Convertir el nuevo texto a un número entero
                if (int.TryParse(newText, out int number))
                {
                    // Verificar si el número está dentro del rango permitido (1 a 100)
                    if (number >= 1 && number <= 100)
                    {
                        e.Handled = false; // Permitir el dígito
                    }
                    else
                    {
                        e.Handled = true; // No permitir el dígito si está fuera del rango
                    }
                }
                else
                {
                    e.Handled = true; // No permitir el dígito si no se puede convertir a número
                }
            }
            else
            {
                e.Handled = true; // No permitir caracteres no numéricos
            }
        }

        private void AddPercentageSign(object sender, EventArgs e)
        {
            // Obtener el contenido actual del control de texto.
            string currentText = txtDescuento.Text;

            // Verificar si el texto ya contiene un símbolo de porcentaje (%). Si no, agregarlo al final.
            if (!currentText.EndsWith("%"))
            {
                txtDescuento.Text = currentText + "%";
            }
        }



    }
}
