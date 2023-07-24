using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formInventario : MaterialForm
    {
        Form formActivo = null;
        Button botonActivo = null;
        public formInventario()
        {
            InitializeComponent();
        }
        private void OpenFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);


            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formCompras());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formCategorias());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formProveedor());
        }

        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnProductos, "Productos");
        }

        private void btnCategorias_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnCategorias, "Categorias");
        }

        private void btnProveedores_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnProveedores, "Proveedores");
        }
    }
}
