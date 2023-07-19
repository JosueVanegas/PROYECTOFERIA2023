using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class formProveedor : MaterialForm
    {
        private readonly MaterialSkinManager manager;
        ControlProveedor cProv = new ControlProveedor();
        public formProveedor()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
            mostrarProveedores();
        }
        private void mostrarProveedores()
        {
            List<Proveedor> lista = cProv.listarProveedores();
            tbProveedores.Rows.Clear();
            foreach (Proveedor p in lista)
            {
                tbProveedores.Rows.Add("", "", p.id, p.nombreProveedor, p.nombreContacto, p.numeroContacto, p.pais, p.ciudad);
            }
        }
        private bool validarCampos()
        {
            bool continuar = false;
            if (txtNombreEmpresa.Text != "" && txtNumeroContacto.Text != "" && txtNombreContacto.Text != "" && txtPais.Text != "" && txtCiudad.Text != "")
            {
                continuar = true;
            }
            return continuar;
        }
        private void limpiarCampos()
        {

        }
        private void registrarUsuario()
        {
            int rolU = 0;
            if (validarCampos() == true)
            {
                MessageBox.Show(cProv.accionProveedor(new Proveedor
                {
                    id = Convert.ToInt32(txtId.Text),
                    nombreProveedor = txtNombreEmpresa.Text,
                    nombreContacto = txtNombreContacto.Text,
                    numeroContacto = txtNumeroContacto.Text,
                    pais = txtPais.Text,
                    ciudad = txtCiudad.Text
                }));
                limpiarCampos();
                mostrarProveedores();
            }
            else
            {
                MessageBox.Show("llene primero todos los campos");
            }
        }
        private void eliminarProveedor(int id)
        {
            if (MessageBox.Show("Desea eliminar al proveedor seleccionado? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(cProv.eliminarProveedor(id));
                mostrarProveedores();
                limpiarCampos();
            }
        }

        private void tbProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbProveedores.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (indice >= 0)
                {
                    txtId.Text = tbProveedores.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombreEmpresa.Text = tbProveedores.Rows[indice].Cells["Empresa"].Value.ToString();
                    txtNombreContacto.Text = tbProveedores.Rows[indice].Cells["Contacto"].Value.ToString();
                    txtNumeroContacto.Text = tbProveedores.Rows[indice].Cells["Numero"].Value.ToString();
                    txtPais.Text = tbProveedores.Rows[indice].Cells["Pais"].Value.ToString();
                    txtCiudad.Text = tbProveedores.Rows[indice].Cells["Ciudad"].Value.ToString();
                }
            }

            if (tbProveedores.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbProveedores.Rows[indice].Cells["Id"].Value.ToString();
                    eliminarProveedor(Convert.ToInt32(valor));
                }
            }
        }

        private void tbProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.pen_circle.Width;
                var h = Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.eliminar.Width;
                var h = Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarUsuario();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            ToolTip toolTip = new ToolTip();

            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
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
    }
}
