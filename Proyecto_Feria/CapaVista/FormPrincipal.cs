using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using CapaPresentacion.FormInformes;
using CapaVista.FormConfiguracion;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FormPrincipal : Form
    {
        public Modelos.Usuario user = null;
        Form formActivo = null;
        bool[] permisos;
        Size tamInicial = new Size(204, 51);
        Size tamExtendido = new Size(260, 51);
        public FormPrincipal() { }
        public FormPrincipal(Modelos.Usuario usuario)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.user = usuario;
            reloj.Start();
            datosDeUsuarioActual(user);
            this.Cursor = Cursors.Default;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio());
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
            if (permisos[0] != true)
                btnVentas.Visible = false;
            if (permisos[1] != true)
                btnInventario.Visible = false;
            if (permisos[2] != true)
                btnHerramientas.Visible = false;
            if (permisos[3] != true)
                btnUsuarios.Visible = false;
            if (permisos[4] != true)
                btnClientes.Visible = false;
            if (permisos[5] != true)
                btnInformes.Visible = false;
            if (permisos[6] != true)
                btnPlanilla.Visible = false;
            if (permisos[7] != true)
                btnConfiguraciones.Visible = false;
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

            form.MaximizeBox = false;
            form.MinimizeBox = false;
            panelContenedor.Controls.Add(form);
            form.Show();
        }
        private void reloj_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblReloj.Text = dateTime.ToString("dddd dd/MM/yyyy hh:mm:ss tt");
        }

        private void crearToolTip(Control obj, string tip)
        {
            /*
             * ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(obj, tip);
             */
        }
        private void clicks(object sender, EventArgs e)
        {
            if (sender.Equals(btnInicio))
                abrirFormulario(new FormInicio());
            if (sender.Equals(btnInventario))
                abrirFormulario(new formInventario(this.user));
            if (sender.Equals(btnPlanilla))
                abrirFormulario(new formEmpleados());
            if (sender.Equals(btnHerramientas))
                abrirFormulario(new FormHerramientas());
            if (sender.Equals(btnInformes))
                abrirFormulario(new FormInformes());
            if (sender.Equals(btnUsuarios))
                abrirFormulario(new formUsuarios());
            if (sender.Equals(btnClientes))
                abrirFormulario(new FormClientes());
            if (sender.Equals(btnConfiguraciones))
                abrirFormulario(new formConfiguraciones());
            if (sender.Equals(btnVentas))
                abrirFormulario(new formVentas(this.user));
        }
        private void MouseEnters(object sender, EventArgs e)
        {
            /*
             * if (sender.Equals(btnInicio))
            {
                crearToolTip(btnInicio, "inicio");
                btnInicio.BackColor = Color.FromArgb(67, 156, 189);
                btnInicio.Size = tamExtendido;
            }
            if (sender.Equals(btnInventario))
            {
                crearToolTip(btnInventario, "inventario");
                btnInventario.BackColor = Color.FromArgb(67, 156, 189);
                btnInventario.Size = tamExtendido;
            }
            if (sender.Equals(btnConfiguraciones))
            {
                crearToolTip(btnConfiguraciones, "empresa");
                btnConfiguraciones.BackColor = Color.FromArgb(67, 156, 189);
                btnConfiguraciones.Size = tamExtendido;
            }
            if (sender.Equals(btnClientes))
            {
                crearToolTip(btnClientes, "clientes");
                btnClientes.BackColor = Color.FromArgb(67, 156, 189);
                btnClientes.Size = tamExtendido;
            }
            if (sender.Equals(btnPlanilla))
            {
                crearToolTip(btnPlanilla, "empleados");
                btnPlanilla.BackColor = Color.FromArgb(67, 156, 189);
                btnPlanilla.Size = tamExtendido;
            }
            if (sender.Equals(btnHerramientas))
            {
                crearToolTip(btnHerramientas, "herramientas");
                btnHerramientas.BackColor = Color.FromArgb(67, 156, 189);
                btnHerramientas.Size = tamExtendido;
            }
            if (sender.Equals(btnVentas))
            {
                crearToolTip(btnVentas, "venta");
                btnVentas.BackColor = Color.FromArgb(67, 156, 189);
                btnVentas.Size = tamExtendido;
            }
            if (sender.Equals(btnInformes))
            {
                crearToolTip(btnInformes, "informes");
                btnInformes.BackColor = Color.FromArgb(67, 156, 189);
                btnInformes.Size = tamExtendido;
            }
            if (sender.Equals(btnUsuarios))
            {
                crearToolTip(btnUsuarios, "usuarios");
                btnUsuarios.BackColor = Color.FromArgb(67, 156, 189);
                btnUsuarios.Size = tamExtendido;
            }
             */
        }

        private void MouseLeaves(object sender, EventArgs e)
        {
            /*
             * if (sender.Equals(btnInicio))
                btnInicio.BackColor = Color.Silver;
            btnInicio.Size = tamInicial;
            if (sender.Equals(btnInventario))
                btnInventario.BackColor = Color.Silver;
            btnInventario.Size = tamInicial;
            if (sender.Equals(btnConfiguraciones))
                btnConfiguraciones.BackColor = Color.Silver;
            btnConfiguraciones.Size = tamInicial;
            if (sender.Equals(btnClientes))
                btnClientes.BackColor = Color.Silver;
            btnClientes.Size = tamInicial;
            if (sender.Equals(btnPlanilla))
                btnPlanilla.BackColor = Color.Silver;
            btnPlanilla.Size = tamInicial;
            if (sender.Equals(btnHerramientas))
                btnHerramientas.BackColor = Color.Silver;
            btnHerramientas.Size = tamInicial;
            if (sender.Equals(btnVentas))
                btnVentas.BackColor = Color.Silver;
            btnVentas.Size = tamInicial;
            if (sender.Equals(btnInformes))
                btnInformes.BackColor = Color.Silver;
            btnInformes.Size = tamInicial;
            if (sender.Equals(btnUsuarios))
                btnUsuarios.BackColor = Color.Silver;
            btnUsuarios.Size = tamInicial;
             */
        }
    }
}

