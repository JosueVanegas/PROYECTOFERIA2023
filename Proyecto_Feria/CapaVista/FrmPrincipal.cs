
using CapaControlador;
using CapaDatos;
using CapaVista.FormConfiguracion;
using CapaVista.FormContabilidad;
using CapaVista.FormPlanilla;
using CapaVista.FormsHerramientas;
using CapaVista.FormVenta;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        Usuario user = null;
        Boolean Mod = true;
        Form formActivo = null;
        Button botonActivo = null;
        //Color fondoOscuro = Color.FromArgb();
        //Color fondoClaro = Color.FromArgb();
        public FrmPrincipal(Usuario usuario, Boolean DMod)
        {

            InitializeComponent();
            Mod = DMod;
            cambioModo.Checked = DMod;
            var controler = new ControlConexion();
            this.user = usuario;
            datosDeUsuarioActual();
        }
        private void datosDeUsuarioActual()
        {
            lblUsuario.Text = "USUARIO ACTUAL: " + this.user.usuario;
            lblRol.Text = "ROL DE USUARIO: " + this.user.oRol.descripcion;
        }

        private void CambioColor(Boolean Mod)
        {
            if (!Mod)
            {
                panelContenedor.BackColor = Color.FromArgb(242, 242, 242);
                panelAbajo.BackColor = Color.FromArgb(138, 138, 138);
                tablepanelPanelContenedor.BackColor = Color.FromArgb(242, 242, 242);
                panel2.BackColor = Color.FromArgb(242, 242, 242);
                this.BackColor = Color.FromArgb(242, 242, 242);

                btnBarraVertical_Admin.BackgroundColor = Color.FromArgb(138, 138, 138);
                btnIniciol_Admin.BackgroundColor = Color.FromArgb(138, 138, 138);
                btnConfiguracionesl_Admin.BackgroundColor = Color.FromArgb(138, 138, 138);
                btnHerramientasl_Admin.BackgroundColor = Color.FromArgb(138, 138, 138);
                btnUsuariosl_Admin.BackgroundColor = Color.FromArgb(138, 138, 138);
                tablePanel_Admin.BackColor = Color.FromArgb(138, 138, 138);

                btnPlanillal_Admin.BackgroundColor = Color.FromArgb(242, 242, 242);
                btnInventoryl_Admin.BackgroundColor = Color.FromArgb(242, 242, 242);
                btnContabilidadl_Admin.BackgroundColor = Color.FromArgb(242, 242, 242);
                btnCalculosl_Admin.BackgroundColor = Color.FromArgb(242, 242, 242);
                btnVentasl_Admin.BackgroundColor = Color.FromArgb(242, 242, 242);
                panelVertical_Admin.BackColor = Color.FromArgb(242, 242, 242);

                btnPlanillal_Admin.ForeColor = Color.Black;
                btnInventoryl_Admin.ForeColor = Color.Black;
                btnContabilidadl_Admin.ForeColor = Color.Black;
                btnCalculosl_Admin.ForeColor = Color.Black;
                btnVentasl_Admin.ForeColor = Color.Black;
            }
            if (Mod)
            {
                tablepanelPanelContenedor.BackColor = Color.FromArgb(21, 25, 31);
                panel2.BackColor = Color.FromArgb(21, 25, 31);
                panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
                panelAbajo.BackColor = Color.FromArgb(63, 63, 70);
                this.BackColor = Color.FromArgb(21, 25, 31);

                btnBarraVertical_Admin.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnIniciol_Admin.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnConfiguracionesl_Admin.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnHerramientasl_Admin.BackgroundColor = Color.FromArgb(63, 63, 70);
                btnUsuariosl_Admin.BackgroundColor = Color.FromArgb(63, 63, 70);

                btnPlanillal_Admin.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnInventoryl_Admin.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnContabilidadl_Admin.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnCalculosl_Admin.BackgroundColor = Color.FromArgb(21, 25, 31);
                btnVentasl_Admin.BackgroundColor = Color.FromArgb(21, 25, 31);

                btnPlanillal_Admin.ForeColor = Color.White;
                btnInventoryl_Admin.ForeColor = Color.White;
                btnContabilidadl_Admin.ForeColor = Color.White;
                btnCalculosl_Admin.ForeColor = Color.White;
                btnVentasl_Admin.ForeColor = Color.White;

                tablePanel_Admin.BackColor = Color.FromArgb(63, 63, 70);
                panelVertical_Admin.BackColor = Color.FromArgb(21, 25, 31);
            }
            /*
                        if (validarAcceso().Equals("Administrador"))
                        {
                            //Rol Administracion
                            btnBarraVertical_Admin.Visible = true;
                            btnIniciol_Admin.Visible = true;
                            btnConfiguracionesl_Admin.Visible = true;
                            btnHerramientasl_Admin.Visible = true;
                            btnUsuariosl_Admin.Visible = true;

                            btnPlanillal_Admin.Visible = true;
                            btnInventoryl_Admin.Visible = true;
                            btnContabilidadl_Admin.Visible = true;
                            btnCalculosl_Admin.Visible = true;
                            btnVentasl_Admin.Visible = true;

                            tablePanel_Admin.Visible = true;
                            panelVertical_Admin.Visible = true;

                            //Rol Vendedor
                            btnBarraVertical_Vendedor.Visible = false;
                            btnInicio_Vendedor.Visible = false;
                            btnHerramientas_Vendedor.Visible = false;

                            btnInventory_Vendedor.Visible = false;
                            btnVentas_Vendedor.Visible = false;
                            panelVertical_Vendedor.Visible = false;

                            //Rol Contador
                            btnBarraVertical_Contador.Visible = false;
                            btnInicio_Contador.Visible = false;
                            btnHerramientas_Contador.Visible = false;
                            tablePanel_Contador.Visible = false;

                            btnPlanillal_Contador.Visible = false;
                            btnContablidad_Contador.Visible = false;
                            btnCalculosl_Contador.Visible = false;
                            panelVertical_Contador.Visible = false;
                        }
                        if (validarAcceso().Equals("Vendedor"))
                        {
                            panel2.Dock = DockStyle.Right;
                            tablePanelNombre_Vendedor.Visible = true;
                            //Rol Administracion
                            btnBarraVertical_Admin.Visible = false;
                            btnIniciol_Admin.Visible = false;
                            btnConfiguracionesl_Admin.Visible = false;
                            btnHerramientasl_Admin.Visible = false;
                            btnUsuariosl_Admin.Visible = false;

                            btnPlanillal_Admin.Visible = false;
                            btnInventoryl_Admin.Visible = false;
                            btnContabilidadl_Admin.Visible = false;
                            btnCalculosl_Admin.Visible = false;
                            btnVentasl_Admin.Visible = false;

                            tablePanel_Admin.Visible = false;
                            panelVertical_Admin.Visible = false;

                            //Rol Vendedor
                            btnBarraVertical_Vendedor.Visible = true;
                            btnInicio_Vendedor.Visible = true;
                            btnHerramientas_Vendedor.Visible = true;

                            btnInventory_Vendedor.Visible = true;
                            btnVentas_Vendedor.Visible = true;
                            panelVertical_Vendedor.Visible = true;


                            //Rol Contador
                            btnBarraVertical_Contador.Visible = false;
                            btnInicio_Contador.Visible = false;
                            btnHerramientas_Contador.Visible = false;
                            tablePanel_Contador.Visible = false;

                            btnPlanillal_Contador.Visible = false;
                            btnContablidad_Contador.Visible = false;
                            btnCalculosl_Contador.Visible = false;
                            panelVertical_Contador.Visible = false;
                        }
                        if (validarAcceso().Equals("Contador"))
                        {
                            //Rol Administracion
                            btnBarraVertical_Admin.Visible = false;
                            btnIniciol_Admin.Visible = false;
                            btnConfiguracionesl_Admin.Visible = false;
                            btnHerramientasl_Admin.Visible = false;
                            btnUsuariosl_Admin.Visible = false;

                            btnPlanillal_Admin.Visible = false;
                            btnInventoryl_Admin.Visible = false;
                            btnContabilidadl_Admin.Visible = false;
                            btnCalculosl_Admin.Visible = false;
                            btnVentasl_Admin.Visible = false;

                            tablePanel_Admin.Visible = false;
                            panelVertical_Admin.Visible = false;

                            //Rol Vendedor
                            btnBarraVertical_Vendedor.Visible = false;
                            btnInicio_Vendedor.Visible = false;
                            btnHerramientas_Vendedor.Visible = false;

                            btnInventory_Vendedor.Visible = false;
                            btnVentas_Vendedor.Visible = false;
                            panelVertical_Vendedor.Visible = false;


                            //Rol Contador
                            btnBarraVertical_Contador.Visible = true;
                            btnInicio_Contador.Visible = true;
                            btnHerramientas_Contador.Visible = true;
                            tablePanel_Contador.Visible = true;

                            btnPlanillal_Contador.Visible = true;
                            btnContablidad_Contador.Visible = true;
                            btnCalculosl_Contador.Visible = true;
                            panelVertical_Contador.Visible = true;
                        }
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
            abrirFormulario(new FrmInicio(this.Mod, user));
            CambioColor(Mod);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formUsuarios(formConfiguraciones.Mod));
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormHerramientas(formConfiguraciones.Mod, user));
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
                btnIniciol_Admin.Visible = false;
                btnHerramientasl_Admin.Visible = false;
                btnConfiguracionesl_Admin.Visible = false;
                btnUsuariosl_Admin.Visible = false;
            }
            else
            {
                btnIniciol_Admin.Visible = true;
                btnHerramientasl_Admin.Visible = true;
                btnConfiguracionesl_Admin.Visible = true;
                btnUsuariosl_Admin.Visible = true;
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
            abrirFormulario(new FrmInicio(formConfiguraciones.Mod, user));
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio(formConfiguraciones.Mod, user));
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
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnIniciol_Admin, "Inicio");

        }
        private void btnHerramientas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnHerramientasl_Admin, "Herramientas");

        }
        private void btnConfiguraciones_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnConfiguracionesl_Admin, "Configuraciones");
        }
        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnUsuariosl_Admin, "Usuarios");
        }
        private void btnInventory_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInventoryl_Admin, "Inventario");
        }
        private void btnPlanilla_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnPlanillal_Admin, "Planilla");
        }
        private void btnContabilidad_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnContabilidadl_Admin, "Contabilidad");
        }

        private void btnCalculos_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCalculosl_Admin, "Calculos");
        }
    }
}
