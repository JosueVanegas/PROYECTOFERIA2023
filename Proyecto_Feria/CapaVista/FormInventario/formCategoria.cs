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
        }
        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
            txtIdCategoria.Text = "0";
        }
        private void mostrarCategorias()
        {
            List<Modelos.Categoria> list = cCategoria.listarCategorias();
            tbCategorias.Rows.Clear();
            foreach (Modelos.Categoria c in list)
            {
                tbCategorias.Rows.Add("", "", c.ID, c.NOMBRE);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                MessageBox.Show(cCategoria.registraModificar(new Modelos.Categoria
                {
                    ID = Convert.ToInt32(txtIdCategoria.Text),
                    NOMBRE = txtNombre.Text,
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
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(info, "Area de Categoria del Producto\n" +
                                            "Como Agregar una categoria:\n" +
                                            "1.Ingrese Nombre de la categoria\n" +
                                            "2.Seleccione el estado de la categoria\n" +
                                            "3.'Guardar' Categoria.\n" +
                                            "Si desea Cancelar creacion de categaria click 'Limpiar'\n" +
                                            "Si desea Editar una categoria registrada click en 'Editar' en la tabla");
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnLimpiar, "Limpiar");
        }
        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
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
                }
            }
            if (tbCategorias.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbCategorias.Rows[indice].Cells["id"].Value.ToString();
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
                var h = CapaPresentacion.Properties.Resources.pen.Height;
                var w = CapaPresentacion.Properties.Resources.pen.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.delete.Width;
                var h = CapaPresentacion.Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(info, "Area de Categoria del Producto\n" +
                                            "Como Agregar una categoria:\n" +
                                            "1.Ingrese Nombre de la categoria\n" +
                                            "2.Seleccione el estado de la categoria\n" +
                                            "3.'Guardar' Categoria.\n" +
                                            "Si desea Cancelar creacion de categaria click 'Limpiar'\n" +
                                            "Si desea Editar una categoria registrada click en 'Editar' en la tabla");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
