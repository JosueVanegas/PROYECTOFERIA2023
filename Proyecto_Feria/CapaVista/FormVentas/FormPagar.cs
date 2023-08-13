using CapaVista.FormConfiguracion;
using CapaVista.FormVenta;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Text;

namespace CapaVista.FormVentas
{
    public partial class FormPagar : MaterialForm
    {

        public FormPagar(Boolean Mod, decimal total)
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
        private void FormPagar_Load(object sender, EventArgs e)
        {

        }

        private void RealizarPago()
        {

        }
        private void txtPagoTarjeta_Leave(object sender, EventArgs e)
        {
            string textoActual = txtPago.Text.Replace(" ", "");
            StringBuilder formattedText = new StringBuilder();
            for (int i = 0; i < textoActual.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                {
                    formattedText.Append(' '); 
                }
                formattedText.Append(textoActual[i]);
            }
            txtPago.Text = formattedText.ToString();
            txtPago.SelectionStart = txtPago.Text.Length;
        }
        private void txtPagoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            if (Control.ModifierKeys.HasFlag(Keys.Shift) || Control.ModifierKeys.HasFlag(Keys.Control) || Control.ModifierKeys.HasFlag(Keys.Alt))
            {
                e.Handled = false;
            }
            string textoActual = txtPago.Text.Replace(" ", "");
            if (textoActual.Length >= 16 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
        }
        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}





