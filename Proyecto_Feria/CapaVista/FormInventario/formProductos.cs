using CapaControlador;
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
            urlImagen = "";
            txtIdProducto.Text = "0";
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
            string textoActual = txtPrecioCompra.Text.Replace(" ", "");

            // Permitir solo dígitos y las teclas "Backspace" y "Delete"
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si no es un dígito o las teclas "Backspace" o "Delete"
            }

            // Verificar si la longitud del texto es mayor o igual a 9
            if (textoActual.Length >= 9 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si se supera la longitud máxima
            }

            // Validar el punto decimal
            if (keyPressed == '.' && textoActual.Contains("."))
            {
                e.Handled = true; // Ignorar el carácter si ya hay un punto decimal
            }

            // Validar los dos decimales después del punto
            if (textoActual.Contains("."))
            {
                int indexPunto = textoActual.IndexOf(".");
                if (textoActual.Length - indexPunto > 2 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
                {
                    e.Handled = true; // Ignorar el carácter si ya hay dos decimales después del punto
                }
            }


        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            string textoActual = txtPrecioVenta.Text.Replace(" ", "");

            // Permitir solo dígitos y las teclas "Backspace" y "Delete"
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si no es un dígito o las teclas "Backspace" o "Delete"
            }

            // Verificar si la longitud del texto es mayor o igual a 9
            if (textoActual.Length >= 9 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar el carácter si se supera la longitud máxima
            }

            // Validar el punto decimal
            if (keyPressed == '.' && textoActual.Contains("."))
            {
                e.Handled = true; // Ignorar el carácter si ya hay un punto decimal
            }

            // Validar los dos decimales después del punto
            if (textoActual.Contains("."))
            {
                int indexPunto = textoActual.IndexOf(".");
                if (textoActual.Length - indexPunto > 2 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
                {
                    e.Handled = true; // Ignorar el carácter si ya hay dos decimales después del punto
                }
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    string nombre = tbProductos.Rows[indice].Cells["Nombre"].Value.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    string valor = tbProductos.Rows[indice].Cells["Id"].Value.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    eliminarProducto(Convert.ToInt32(valor), nombre);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string columna = cbxBuscar.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (tbProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbProductos.Rows)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es una letra, número, guión o espacio, ni la tecla de retroceso (Backspace)
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox4, "Area de Creación de Productos\n" +
                                            "Como Agregar un Producto:\n" +
                                            "1. Seleccionar una imagen cualquiera del producto\n" +
                                            "2. Ingresar Codigo de Barra\n" +
                                            "3. Ingresar el nombre del producto.\n" +
                                            "4. Ingresar el precio de compra y venta.\n" +
                                            "5. Seleccionar el Proveedor(Se crean en el Area de proveedores)\n" +
                                            "6. Seleccionar la Categoria(Se crean en el Area de Categoria)\n" +
                                            "7. 'Guardar' el producto en los registros.\n" +
                                            "Si desea Cancelar la creción del Producto click 'Limpiar'\n" +
                                            "Si desea editar un producto creado click 'Editar'\n" +
                                            "Si desea eliminar un producto creado click 'Eliminar'");
        }

        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Establecer el texto de la descripción
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }
    }

}

