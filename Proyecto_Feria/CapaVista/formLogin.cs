using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formLogin : MaterialForm
    {

        public formLogin()
        {
            this.Cursor = Cursors.WaitCursor;
            InitializeComponent();
            lblConexion.Text = new ControlConexion().verificarConexion();
            cargarLogoEmpresa();
            this.Cursor = Cursors.Default;

        }
        private void cargarLogoEmpresa()
        {
            Empresa empresa = new ControlEmpresa().datosEmpresa();
            if (empresa != null)
            {
                if (empresa.imagen != null)
                {
                    txtNombreEmpresa.Text = empresa.nombre;
                    using (MemoryStream ms = new MemoryStream(empresa.imagen))
                    {
                        Image imagen = Image.FromStream(ms);
                        imgLogoEmpresa.Image = imagen;
                    }
                }
            }
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
            Usuario user = cUsuarios.listarUsuarios().FirstOrDefault(u => u.usuario == txtUsuario.Text);
            this.Cursor = Cursors.WaitCursor;
            if (acceder)
            {
                FormPrincipal principal = new FormPrincipal(user);
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
            this.Cursor = Cursors.Default;
        }
        public void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            cargarLogoEmpresa();
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
