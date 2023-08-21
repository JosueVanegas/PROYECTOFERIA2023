using CapaDatos;
using CapaPresentacion;
using CapaPresentacion.FormInformes;
using CapaVista.FormConfiguracion;
using CapaVista.FormContabilidad;
using CapaVista.FormPlanilla;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FormPrincipal : Form
    {
        public Usuario user = null;

        Form formActivo = null;
        Button botonActivo = null;
        bool EstadoDeBarraVertical = true;
        public FormPrincipal() { }
        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.user = usuario;
            reloj.Start();
            panelVertical_Admin.BackColor = Color.FromArgb(74, 121, 121);
            //datosDeUsuarioActual();
        }


        private void datosDeUsuarioActual()
        {
            lblUsuario.Text = "USUARIO ACTUAL: " + this.user.usuario;
            lblRol.Text = "ROL DE USUARIO: " + this.user.oRol.descripcion;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormHerramientas(user));
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formConfiguraciones());
        }
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
            abrirFormulario(new FormInicio(user));
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio(user));
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formVentas(user));
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContabilidads());
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormInformes());
        }
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInicio, "Inicio");

        }
        private void btnHerramientas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnHerramientas, "Herramientas");

        }
        private void btnConfiguraciones_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnConfiguraciones, "Configuraciones");
        }
        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnUsuarios, "Usuarios");
        }
        private void btnInventory_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInventario, "Inventario");
        }
        private void btnPlanilla_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnPlanilla, "Planilla");
        }
        private void btnContabilidad_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnContabilidad, "Contabilidad");
        }

        private void btnCalculos_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInformes, "Calculos");
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblReloj.Text = dateTime.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormClientes());
        }
    }
}
