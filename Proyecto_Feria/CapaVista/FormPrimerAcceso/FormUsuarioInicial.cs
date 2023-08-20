using ReaLTaiizor.Forms;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormUsuarioInicial : MaterialForm
    {
        public FormUsuarioInicial()
        {
            InitializeComponent();

        }
        private void ckbVerContraseña_CheckedChanged(object sender)
        {
            if (ckbVerContraseña.Checked == true)
            {
                ckbVerContraseña.Text = "ocultar contraseña";
                txtClave.PasswordChar = '\0';
                txtConfirmarClave.PasswordChar = '\0';
            }
            else
            {
                ckbVerContraseña.Text = "ver contraseña";
                txtClave.PasswordChar = '*';
                txtConfirmarClave.PasswordChar = '*';
            }
        }
    }
}
