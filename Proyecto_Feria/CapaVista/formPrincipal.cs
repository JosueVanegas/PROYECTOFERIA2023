using CapaControlador;
using CapaDatos;

namespace CapaVista
{
    public partial class formPrincipal : Form
    {
        Usuario user = null;
        Form formActivo = null;
        Button botonActivo = null;
        public formPrincipal(Usuario usuario)
        {
            InitializeComponent();
            var controler = new Controles();
            this.user = usuario;
            validarAcceso();
        }
        void validarAcceso()
        {
            /*
             * string tipoAcceso = "";
            if (user.rol == 1)
            {
                tipoAcceso = "Administrador";
            }
            else
            {
                tipoAcceso = "Empleado";
            }
            lblUsuarioActual.Text = "Usuario: " + user.usuario + "\nTipo de acceso: " + tipoAcceso;
             */
        }
        private void abrirFormulario(Button b, Form form)
        {
            if (botonActivo != null)
            {
                botonActivo.Size = new Size(118, 33);
            }
            botonActivo = b;
            botonActivo.Size = new Size(160, 33);

            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            form.TopLevel = false;
            panelContenedor.Controls.Add(form);
            form.Show();
        }
        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
        private void btnCompras_Click(object sender, EventArgs e)
        {

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnUsuarios, new formUsuarios());
        }
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnInventario, new formInventario());
        }
    }
}
