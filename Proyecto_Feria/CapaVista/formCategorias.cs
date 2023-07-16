﻿using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class formCategorias : MaterialForm
    {
        ControlCategoria cCategoria = new ControlCategoria();
        private readonly MaterialSkinManager manager;

        public formCategorias()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
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
                tbCategorias.Rows.Add("", c.id, c.nombre, c.oEstado.descripcion, c.fechaRegistro);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (txtIdCategoria.Text == "")
                {
                    txtIdCategoria.Text = "1";
                }
                MessageBox.Show(cCategoria.registraModificar(new Categoria
                {
                    id = Convert.ToInt32(txtIdCategoria.Text),
                    nombre = txtNombre.Text
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCategoria.Text != "" && txtNombre.Text != "")
            {
                if (MessageBox.Show("esta seguro de elimar la categoria actual?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(cCategoria.eliminar(Convert.ToInt32(txtIdCategoria.Text)));
                    limpiarCampos();
                    mostrarCategorias();
                }
            }
            {
                MessageBox.Show("No se ha seleccionado ninguna categoria para ser eliminada", "Advertencia");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = "nombre";
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

        private void tbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (e.RowIndex >= 0)
                {
                    txtIdCategoria.Text = tbCategorias.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    txtNombre.Text = tbCategorias.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    cbxEstado.Text = tbCategorias.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                }
            }
        }

        private void tbUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.pen_circle.Height;
                var w = Properties.Resources.pen_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }
    }
}
