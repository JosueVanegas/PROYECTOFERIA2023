
using CapaVista.FormPlanilla;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void OpenFormInPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);


            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }
        private void rjButton9_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formUsuarios());
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
            OpenFormInPanel(new formInventario());
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formPlanilla());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmInicio());
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
