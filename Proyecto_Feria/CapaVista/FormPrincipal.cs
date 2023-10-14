using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using CapaPresentacion.FormInformes;
using CapaVista.FormConfiguracion;
using CapaVista.FormPlanilla;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FormPrincipal : Form
    {
        public Modelos.Usuario user = null;
        Form formActivo = null;
        bool EstadoDeBarraVertical = true;
        bool[] permisos = new bool[8];
        public FormPrincipal() { }
        public FormPrincipal(Modelos.Usuario usuario)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.user = usuario;
            reloj.Start();
            datosDeUsuarioActual(user);
            this.Cursor = Cursors.Default;
           // permisos = new bool[] { true, true, true, true, true, true, true, true };
            //activarPermisos(permisos);
        }
        private void datosDeUsuarioActual(Modelos.Usuario u)
        {
            lblUsuario.Text = "Usuario actual: " + u.NOMBRE;
            lblRol.Text = "Rol del usuario: " + u.ROL.NOMBRE;
            validarPermisos(u);
        }
        private void validarPermisos(Modelos.Usuario u)
        {
            ControlRolesyAccesos cRol = new ControlRolesyAccesos();
            permisos = cRol.accesaccesoUsuarios(u.ROL.ID);
            activarPermisos(permisos);
        }
        private void activarPermisos(bool[] permisos)
        {
            if (permisos[0] == true)
                btnVentas.Visible = true;
            if (permisos[1] == true)
                btnInventario.Visible = true;
            if (permisos[2] == true)
                btnHerramientas.Visible = true;
            if (permisos[3] == true)
                btnUsuarios.Visible = true;
            if (permisos[4] == true)
                btnClientes.Visible = true;
            if (permisos[5] == true)
                btnInformes.Visible = true;
            if (permisos[6] == true)
                btnPlanilla.Visible = true;
            if (permisos[7] == true)
                btnConfiguraciones.Visible = true;
        }
        private void abrirFormulario(Form form)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            form.MaximizeBox = false; // Desactivar la opción de cambiar el tamaño
            form.MinimizeBox = false; // Desactivar la opción de minimizar
            panelContenedor.Controls.Add(form);
            form.Show();
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
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            // abrirFormulario(new FormHerramientas(user));
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formConfiguraciones());
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new formInventario(this.user));
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContenedorEmpleados());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // abrirFormulario(new FormInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // abrirFormulario(new FormInicio());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            // abrirFormulario(new formVentas(user));
        }
        private void btnCalculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormInformes());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormClientes());
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
        private void btnCalculos_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInformes, "Calculos");
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblReloj.Text = dateTime.ToString("dddd dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
