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
                //Modo Dark
                btnCategorias.BackColor = Color.FromArgb(63, 63, 70);
                btnProductos.BackColor = Color.FromArgb(63, 63, 70);
                btnProveedores.BackColor = Color.FromArgb(63, 63, 70);

                tableLayoutPanel1.BackColor = Color.FromArgb(21, 25, 31);
                panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                //Modo Light
                btnCategorias.BackColor = Color.FromArgb(242, 242, 242);
                btnProductos.BackColor = Color.FromArgb(242, 242, 242);
                btnProveedores.BackColor = Color.FromArgb(242, 242, 242);

                tableLayoutPanel1.BackColor = Color.FromArgb(242, 242, 242);
                panelContenedor.BackColor = Color.FromArgb(242, 242, 242);

            }



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
        // Clicks
        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formCompras(formConfiguraciones.Mod));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formCategorias(formConfiguraciones.Mod));
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formProveedor(formConfiguraciones.Mod));
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
