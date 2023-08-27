using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formCategoria : MaterialForm
    {
        ControlCategoria cCategoria = new ControlCategoria();


        public formCategoria()
        {
            InitializeComponent();

        }
        private void formCategorias_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
            mostrarEstados();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
            txtIdCategoria.Text = "1";
        }
        private void mostrarEstados()
        {
            cbxEstado.DataSource = cCategoria.listarEstados();
        }
        private void mostrarCategorias()
        {
            List<Categoria> list = cCategoria.listarCategorias();
            tbCategorias.Rows.Clear();
            foreach (Categoria c in list)
            {
                tbCategorias.Rows.Add("", "", c.id, c.nombre, c.oEstado.descripcion, c.fechaRegistro);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                MessageBox.Show(cCategoria.registraModificar(new Categoria
                {
                    id = Convert.ToInt32(txtIdCategoria.Text),
                    nombre = txtNombre.Text,
                    oEstado = (Estado)cbxEstado.SelectedItem
                }));

                limpiarCampos();
                mostrarCategorias();
            }
            else
            {
                MessageBox.Show("No se ha ingresado el nombre de la categoria", "Advertencia");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void eliminarCategoria(int id)
        {
            if (MessageBox.Show("esta seguro de eliminar la categoria seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cCategoria.eliminar(id));
                limpiarCampos();
                mostrarCategorias();
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.Text;
            if (tbCategorias.RowCount > 0)
            {
                foreach (DataGridViewRow i in tbCategorias.Rows)
                {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                }
            }
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnLimpiar, "Limpiar");
        }
        private void tbCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (indice >= 0)
                {
                    txtIdCategoria.Text = tbCategorias.Rows[indice].Cells["id"].Value.ToString();
                    txtNombre.Text = tbCategorias.Rows[indice].Cells["nombre"].Value.ToString();
                    cbxEstado.Text = tbCategorias.Rows[indice].Cells["estado"].Value.ToString();
                }
            }
            if (tbCategorias.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    string valor = tbCategorias.Rows[indice].Cells["id"].Value.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    eliminarCategoria(Convert.ToInt32(valor));
                }
            }
        }

        private void tbCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.eliminar.Width;
                var h = CapaPresentacion.Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
