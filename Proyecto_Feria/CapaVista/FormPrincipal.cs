
using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;
using CapaVista.FormContabilidad;
using CapaVista.FormPlanilla;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FormPrincipal : MaterialForm
    {
        Usuario user = null;
        Boolean Mod;
        Form formActivo = null;
        Button botonActivo = null;
        //Color fondoOscuro = Color.FromArgb();
        //Color fondoClaro = Color.FromArgb();
        public FormPrincipal(Usuario usuario, Boolean DMod)
        {
            InitializeComponent();
            this.user = usuario;
            cambiarModo(DMod);
            this.Mod = DMod;
            // datosDeUsuarioActual();
        }
        private void cambiarModo(bool modoOscuro)
        {
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
            }
            if (!modoOscuro)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
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
        public void cyberSwitch2_CheckedChanged()
        {

            Mod = cambioModo.Checked;
            if (cambioModo.Checked)
            {
                imagenModo.Visible = true;
                SolPicture.Visible = false;
            }
            if (!cambioModo.Checked)
            {
                imagenModo.Visible = false;
                SolPicture.Visible = true;
            }
            cambiarModo(Mod);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios(Mod));
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormHerramientas(Mod, user));
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formConfiguraciones(Mod));
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
            abrirFormulario(new formInventario(Mod));
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formPlanilla(Mod));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio(Mod, user));
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio(Mod, user));
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formVentas(Mod));
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContabilidads(Mod));
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCalculos.FormCalculos(Mod));
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
            toolTip.SetToolTip(btnCalculos, "Calculos");
        }
    }
}
