namespace CapaVista
{
    public partial class formInventario : Form
    {
        Form formActivo = null;
        Button botonActivo = null;
        public formInventario()
        {
            InitializeComponent();
        }
        private void abrirFormulario(Button b, Form form)
        {
            if (botonActivo != null)
            {
                botonActivo.Size = new Size(118, 33);
            }
            botonActivo = b;
            botonActivo.Size = new Size(160, 33);

            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            form.TopLevel = false;
            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(btnCategorias, new formCategorias());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }
    }
}
