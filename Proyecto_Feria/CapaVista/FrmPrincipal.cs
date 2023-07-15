
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
            OpenFormInPanel(new formCategorias());
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
            toolTip.SetToolTip(btnHerramientas, "Categorias");
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

    }
}
