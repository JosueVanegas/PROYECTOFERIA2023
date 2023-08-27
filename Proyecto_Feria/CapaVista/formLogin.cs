using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formLogin : MaterialForm
    {

        public formLogin()
        {
            InitializeComponent();
            lblConexion.Text = new ControlConexion().verificarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            new conexion().desconectar();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ControlUsuario cUsuarios = new ControlUsuario();
            bool acceder = cUsuarios.validarAcceso(txtUsuario.Text, txtContraseña.Text);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            Usuario user = cUsuarios.listarUsuarios().FirstOrDefault(u => u.usuario == txtUsuario.Text);
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            if (acceder)
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                FormPrincipal principal = new FormPrincipal(user);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                principal.Show();
                this.Hide();
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                principal.FormClosing += frm_closing;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                ckbVerContraseña.Checked = false;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                ckbVerContraseña.Checked = false;
            }
        }
        public void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void ckbVerContraseña_CheckedChanged(object sender)
        {
            if (ckbVerContraseña.Checked == true)
            {
                ckbVerContraseña.Text = "ocultar contraseña";
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                ckbVerContraseña.Text = "ver contraseña";
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}
