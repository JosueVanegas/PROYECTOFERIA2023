﻿using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

namespace CapaVista
{
    public partial class formProductos : MaterialForm
    {
        ControlProducto cProd = new ControlProducto();
        string urlImagen = "";
        public formProductos()
        {
            InitializeComponent();

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
                    p.oProveedor.nombreProveedor, p.oCategoria.nombre, p.imagen);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarProducto();

        }
        private bool validarCampos()
        {
            bool permitir = true;
            if (txtNombre.Text == "" && txtPrecioCompra.Text == "" &&
                txtPrecioVenta.Text == "")
            {
                permitir = false;
            }
            return permitir;
        }
        private void limpiarCampos()
        {
            urlImagen = "--";
            txtIdProducto.Text = "1";
            txtNombre.Text = "";
            txtCodigoBarra.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            imagenProducto.Image = null;
        }
        private void leerImage(Byte[] img)
        {
            using (MemoryStream memoryStream = new MemoryStream(img))
            {
                Image imagen = Image.FromStream(memoryStream);
                imagenProducto.Image = imagen;
            }
        }
        private void eliminarProducto(int id, string nombre)
        {
            if (MessageBox.Show("Desea eliminar el producto '" + nombre + "' seleccionado? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(cProd.eliminarProducto(id));
                mostrarProductos();
                limpiarCampos();
            }
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
                            if (txtCodigoBarra.Text != "")
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
                                    codigo = txtCodigoBarra.Text,
                                    nombre = txtNombre.Text,
                                    PrecioCompra = pc,
                                    PrecioVenta = pv,
                                    oProveedor = prov,
                                    oCategoria = cat
                                };

                                MessageBox.Show(cProd.accionesProducto(prod));
                                mostrarProductos();
                                limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("Por favor ingresar o escanear el codigo de barras del producto");
                            }
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
            limpiarCampos();
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
                    urlImagen = "--";
                    int categoriaID = (int)tbProductos.Rows[indice].Cells["CategoriaID"].Value;
                    int categoriaIndex = -1;
                    for (int i = 0; i < cbxCategoria.Items.Count; i++)
                    {
                        Categoria categoria = (Categoria)cbxCategoria.Items[i];
                        if (categoria.id == categoriaID)
                        {
                            categoriaIndex = i;
                            break;
                        }
                    }
                    if (categoriaIndex >= 0)
                    {
                        cbxCategoria.SelectedIndex = categoriaIndex;
                    }
                    int proveedorID = (int)tbProductos.Rows[indice].Cells["proveedorID"].Value;
                    int provIndex = -1;
                    for (int i = 0; i < cbxProveedor.Items.Count; i++)
                    {
                        Proveedor proveedor = (Proveedor)cbxProveedor.Items[i];
                        if (proveedor.id == proveedorID)
                        {
                            provIndex = i;
                            break;
                        }
                    }
                    if (provIndex >= 0)
                    {
                        cbxProveedor.SelectedIndex = provIndex;
                    }
                }
            }
            if (tbProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string nombre = tbProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    string valor = tbProductos.Rows[indice].Cells["Id"].Value.ToString();
                    eliminarProducto(Convert.ToInt32(valor), nombre);
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
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.SelectedItem.ToString();

            if (tbProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbProductos.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
    }

}

