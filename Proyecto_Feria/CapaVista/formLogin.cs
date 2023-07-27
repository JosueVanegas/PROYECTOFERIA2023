using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class formLogin : MaterialForm
    {
        private readonly MaterialSkinManager manager;
        public formLogin()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
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
            Usuario usuarioValido = cUsuarios.listarUsuarios().FirstOrDefault(u => u.usuario == txtUsuario.Text && u.clave == txtContraseña.Text);

            if (usuarioValido != null)
            {
                FrmPrincipal principal = new FrmPrincipal(null, formConfiguraciones.Mod);
                principal.Show();
                this.Hide();
                principal.FormClosing += frm_closing;
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
