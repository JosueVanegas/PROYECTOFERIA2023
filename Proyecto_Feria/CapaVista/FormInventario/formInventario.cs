using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class formInventario : MaterialForm
    {
        Form formActivo = null;
        Button botonActivo = null;
        public formInventario(Boolean Mod)
        {
            InitializeComponent();
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
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
            abrirFormulario(new formProductos(formConfiguraciones.Mod));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formCategoria(formConfiguraciones.Mod));
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formProveedor(formConfiguraciones.Mod));
        }

        //Descripciones
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
