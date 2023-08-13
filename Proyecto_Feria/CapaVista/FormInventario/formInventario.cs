using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class formInventario : MaterialForm
    {
        bool Mod;
        Form formActivo = null;
        Button botonActivo = null;
        public formInventario(Boolean Dmod)
        {
            InitializeComponent();
            Mod = Dmod;
            cambiarModo(Dmod);
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

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formProductos(Mod));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formCategoria(Mod));
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formProveedor(Mod));
        }
        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnProductos, "Productos");
        }

        private void btnCategorias_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnServicios, "Categorias");
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
