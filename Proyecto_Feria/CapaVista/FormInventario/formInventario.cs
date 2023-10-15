using CapaDatos;
using CapaVista.FormInventario;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formInventario : MaterialForm
    {
        Form formActivo = null;
        Button botonActivo = null;
        Modelos.Usuario user;
        public formInventario(Modelos.Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void abrirFormulario(Form form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

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
        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCompras(user));
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formProductos());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formCategoria());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formProveedor());
        }
        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnProductos, "Productos");
        }
        private void btnProveedores_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnProveedores, "Proveedores");
        }
        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnCompras, "Compras");
        }

        private void formInventario_Load(object sender, EventArgs e)
        {
            abrirFormulario(new formProductos());
        }
    }
}
