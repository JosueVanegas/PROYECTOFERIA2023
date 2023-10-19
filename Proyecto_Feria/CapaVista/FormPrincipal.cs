using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using CapaPresentacion.FormInformes;
using CapaVista.FormConfiguracion;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using FontAwesome.Sharp;
using ReaLTaiizor.Forms;
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
        //
        private IconButton currentBtn;


        public FormPrincipal() { }
        public FormPrincipal(Modelos.Usuario usuario)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.user = usuario;
            reloj.Start();
            //datosDeUsuarioActual(user);
            this.Cursor = Cursors.Default;
            cargarLogoEmpresa();

            currentBtn = btnInicio;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = RGBColors.Color1;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = RGBColors.Color1;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            label1.Text = currentBtn.Text;
            iconform.IconChar = currentBtn.IconChar;
            iconform.IconColor = RGBColors.Color1;

            leftBorderBtn.BackColor = Color.FromArgb(172, 126, 241);
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

        }
        private struct RGBColors
        {
            public static Color Color1 = Color.FromArgb(172, 126, 241);

        }
        private void ActivarBotones(object sender, Color color)
        {
            if (sender != null)
            {
                DesactivarBotones();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                iconform.IconChar = currentBtn.IconChar;
                iconform.IconColor = color;
                label1.Text = currentBtn.Text;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }

        }
        private void DesactivarBotones()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void cargarLogoEmpresa()
        {
            Modelos.Empresa empresa = new ControlEmpresa().datosEmpresa();
            if (empresa != null)
            {
                if (empresa.IMAGEN != null)
                {

                    using (MemoryStream ms = new MemoryStream(empresa.IMAGEN))
                    {
                        Image imagen = Image.FromStream(ms);
                        imgLogoEmpresa.Image = imagen;
                    }
                }
            }
        }
        //

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrir(new FormInicio());
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
        private void abrir(Form childForm)
        {
            panelContenedor.Controls.Clear();

            // Establece las propiedades del formulario hijo
            childForm.TopLevel = false;  // Importante para que el formulario actúe como un control
            childForm.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
            childForm.Dock = DockStyle.Fill;  // Ocupa todo el espacio del panel

            // Agrega el formulario al panel y muestra el formulario
            panelContenedor.Controls.Add(childForm);
            childForm.Show();
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

                abrir(new FormInicio());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnInventario))
                abrir(new formInventario(this.user));
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnPlanilla))
                abrir(new formEmpleados());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnHerramientas))
                abrir(new FormHerramientas());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnInformes))
                abrir(new FormInformes());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnUsuarios))
                abrir(new formUsuarios());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnClientes))
                abrir(new FormClientes());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnConfiguraciones))
                abrir(new formConfiguraciones());
            ActivarBotones(sender, RGBColors.Color1);
            if (sender.Equals(btnVentas))
                abrir(new formVentas(this.user));
            ActivarBotones(sender, RGBColors.Color1);
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

