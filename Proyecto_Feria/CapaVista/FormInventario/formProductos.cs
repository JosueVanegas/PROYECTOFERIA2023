using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class formProductos : MaterialForm
    {
        ControlProducto cProd = new ControlProducto();
        string urlImagen = "";
        public formProductos(Boolean Mod)
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
                tbProductos.BackgroundColor = Color.FromArgb(50, 50, 50);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                tbProductos.BackgroundColor = Color.White;

            }
        }
        private void formProductos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            mostrarCategoria();
            mostrarProveedores();
        }
        private void mostrarCategoria()
        {
            cbxCategoria.DataSource = cProd.listarCategoria();
        }
        private void mostrarProveedores()
        {
            cbxProveedor.DataSource = cProd.listarProveedores();
        }
        private void mostrarProductos()
        {
            List<Producto> lista = cProd.listarProductos();
            tbProductos.Rows.Clear();
            foreach (Producto p in lista)
            {
                tbProductos.Rows.Add("", "", p.id, p.codigo, p.nombre, p.PrecioCompra,
                    p.PrecioVenta, p.cantidad, p.oProveedor.id, p.oCategoria.id,
                    p.oProveedor.nombreProveedor, p.oCategoria.nombre,p.imagen);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarProducto();

        }
        private bool validarCampos()
        {
            bool permitir = true;
            if (txtCodigoBarra.Text.Equals("") && txtNombre.Text.Equals("") && txtPrecioCompra.Text.Equals("") &&
                txtPrecioVenta.Text.Equals("") && urlImagen == "")
            {
                permitir = false;
            }
            return permitir;
        }
        private void leerImage(Byte[] img)
        {
            using (MemoryStream memoryStream = new MemoryStream(img))
            {
                Image imagen = Image.FromStream(memoryStream);
                imagenProducto.Image = imagen;
            }
        }
        private void eliminarProducto(int id)
        {
            cProd.eliminarProducto(id);
        }
        private void registrarProducto()
        {
            if (validarCampos())
            {
                if (cbxProveedor.SelectedItem is Proveedor prov && cbxCategoria.SelectedItem is Categoria cat)
                {
                    try
                    {
                        if (urlImagen != "")
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            imagenProducto.Image.Save(memoryStream, imagenProducto.Image.RawFormat);
                            byte[] imageBytes = memoryStream.ToArray();
                            decimal pc = Convert.ToDecimal(txtPrecioCompra.Text);
                            decimal pv = Convert.ToDecimal(txtPrecioVenta.Text);
                            Producto prod = new Producto
                            {

                                imagen = imageBytes,
                                id = Convert.ToInt32(txtIdProducto.Text),
                                codigo = Convert.ToInt32(txtCodigoBarra.Text),
                                nombre = txtNombre.Text,
                                PrecioCompra = pc,
                                PrecioVenta = pv,
                                oProveedor = prov,
                                oCategoria = cat
                            };

                            MessageBox.Show(cProd.accionesProducto(prod));
                            mostrarProductos();
                        }
                        else
                        {
                            MessageBox.Show("Primero seleccione la imagen del producto");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor y una categoría válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos primero (incluida la imagen).");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

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
        private void txtPrecioDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (!char.IsDigit(keyPressed) && keyPressed != '.' && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back && !char.IsControl(keyPressed))
            {
                e.Handled = true;
            }
            /*
             * if ((keyPressed == '.' && (txtPrecioCompra.Text.Contains(".") || txtPrecioCompra.Text.Length == 10)))
            {
                e.Handled = true;
            }
            if ((keyPressed == '.' && (txtPrecioVenta.Text.Contains(".") || txtPrecioVenta.Text.Length == 10)))
            {
                e.Handled = true;
            }
             */

        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (!char.IsDigit(keyPressed) && keyPressed != '.' && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back && !char.IsControl(keyPressed))
            {
                e.Handled = true;
            }

        }
        private void tbProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbProductos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                if (indice >= 0)
                {
                    txtCodigoBarra.Text = tbProductos.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = tbProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtIdProducto.Text = tbProductos.Rows[indice].Cells["Id"].Value.ToString();
                    txtPrecioCompra.Text = tbProductos.Rows[indice].Cells["PrecioCompra"].Value.ToString();
                    txtPrecioVenta.Text = tbProductos.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                    byte[] imagenBytes = (byte[])tbProductos.Rows[indice].Cells["Imagen"].Value;
                    leerImage(imagenBytes);
                }
            }
            if (tbProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbProductos.Rows[indice].Cells["Id"].Value.ToString();
                    eliminarProducto(Convert.ToInt32(valor));
                }
            }
        }
        private void tbProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*";
            openFileDialog.Title = "Selecciona una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                urlImagen = openFileDialog.FileName;
                imagenProducto.Image = Image.FromFile(urlImagen);
            }

        }
    }

}

