
using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;

using CapaVista.FormPlanilla;
using CapaVista.FormVenta;
using ToolTip = System.Windows.Forms.ToolTip;

using CapaVista.FormsHerramientas;
using CapaVista.FormContabilidad;

namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        Usuario user = null;
        Form formActivo = null;
        Button botonActivo = null;
        public FrmPrincipal(Usuario usuario, Boolean Mod)
        {
            InitializeComponent();
            var controler = new ControlConexion();
            this.user = usuario;
            validarAcceso();
            CambioColor(Mod);

        }


        private void CambioColor(Boolean Mod)
        {//Mood Light
            if (!Mod)
            {
                btnBarraVertical.BackgroundColor = Color.FromArgb(175, 238, 238);
                btnInicio.BackgroundColor = Color.FromArgb(175, 238, 238);
                btnConfiguraciones.BackgroundColor = Color.FromArgb(175, 238, 238);
                btnHerramientas.BackgroundColor = Color.FromArgb(175, 238, 238);
                btnUsuarios.BackgroundColor = Color.FromArgb(175, 238, 238);

                btnPlanilla.BackgroundColor = Color.FromArgb(224, 255, 255);
                btnInventory.BackgroundColor = Color.FromArgb(224, 255, 255);
                btnContabilidad.BackgroundColor = Color.FromArgb(224, 255, 255);
                btnCalculos.BackgroundColor = Color.FromArgb(224, 255, 255);
                btnVentas.BackgroundColor = Color.FromArgb(224, 255, 255);

                tableLayoutPanel1.BackColor = Color.FromArgb(175, 238, 238);
                tableLayoutPanel2.BackColor = Color.FromArgb(224, 255, 255);
                tableLayoutPanel3.BackColor = Color.FromArgb(224, 255, 255);

                panelContenedor.BackColor = Color.FromArgb(224, 255, 255);
                panel1.BackColor = Color.FromArgb(175, 238, 238);

            }
            if (Mod)
            {//Mood Dark
                btnBarraVertical.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnInicio.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnConfiguraciones.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnHerramientas.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnUsuarios.BackgroundColor = Color.FromArgb(63, 63, 70);

                btnPlanilla.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnInventory.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnContabilidad.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnCalculos.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnVentas.BackgroundColor = Color.FromArgb(21, 25, 31);

                tableLayoutPanel1.BackColor = Color.FromArgb(63, 63, 70);
                tableLayoutPanel2.BackColor = Color.FromArgb(21, 25, 31);
                tableLayoutPanel3.BackColor = Color.FromArgb(21, 25, 31);

                panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
                panel1.BackColor = Color.FromArgb(63, 63, 70);

            }
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
        //eventos Click
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios(formConfiguraciones.Mod));
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormsHerramientasss(formConfiguraciones.Mod));
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formConfiguraciones());

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
            abrirFormulario(new formInventario(formConfiguraciones.Mod));
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formPlanilla(formConfiguraciones.Mod));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio(formConfiguraciones.Mod));
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio(formConfiguraciones.Mod));



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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            formVentas frmVenta = new formVentas(formConfiguraciones.Mod);
            frmVenta.ShowDialog();
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContabilidads(formConfiguraciones.Mod));
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCalculos.FormCalculos(formConfiguraciones.Mod));
        }
    }
}
