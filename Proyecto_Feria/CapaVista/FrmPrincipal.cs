
using CapaControlador;
using CapaDatos;
using CapaVista.FormPlanilla;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        Usuario user = null;
        Form formActivo = null;
        Button botonActivo = null;
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            var controler = new ControlConexion();
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
        private void abrirFormulario(Form form)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            form.Show();
        }
        private void rjButton9_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {

        }
        //Descripciones
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnInicio, "Inicio");
        }

        private void btnHerramientas_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnHerramientas, "Herramientas");
        }

        private void btnConfiguraciones_MouseEnter(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnConfiguraciones, "Configuraciones");
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnUsuarios, "Usuarios");
        }

        bool EstadoDeBarraVertical = true;
        private void btnBarraVertical_Button_Click(object sender, EventArgs e)
        {

            if (EstadoDeBarraVertical)
            {
                btnInicio.Visible = false;
                btnHerramientas.Visible = false;
                btnConfiguraciones.Visible = false;
                btnUsuarios.Visible = false;
            }
            else
            {
                btnInicio.Visible = true;
                btnHerramientas.Visible = true;
                btnConfiguraciones.Visible = true;
                btnUsuarios.Visible = true;
            }
            EstadoDeBarraVertical = !EstadoDeBarraVertical;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formInventario());
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formPlanilla());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio());
        }

        private void btnInventory_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnInventory, "Inventario");
        }

        private void btnPlanilla_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnPlanilla, "Planilla");
        }

        private void btnContabilidad_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnContabilidad, "Contabilidad");
        }

        private void btnCalculos_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnCalculos, "Calculos");
        }
    }
}
