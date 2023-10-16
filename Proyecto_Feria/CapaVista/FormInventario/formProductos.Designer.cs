namespace CapaVista
{
    partial class formProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtUnidad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMarca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtStockSeguridad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblVenci = new Label();
            dtVencimiento = new DateTimePicker();
            btnCategorias = new RJCodeAdvance.RJControls.RJButton();
            pictureBox4 = new PictureBox();
            imagenProducto = new PictureBox();
            btnSeleccionarImagen = new RJCodeAdvance.RJControls.RJButton();
            txtCodigoBarra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioVenta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            cbxCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdProducto = new TextBox();
            tbProductos = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            StockSeguridad = new DataGridViewTextBoxColumn();
            Vencimiento = new DataGridViewTextBoxColumn();
            ProveedorID = new DataGridViewTextBoxColumn();
            NombreProveedor = new DataGridViewTextBoxColumn();
            CategoriaID = new DataGridViewTextBoxColumn();
            NombreCategoria = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            panelBusqueda = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenProducto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProductos).BeginInit();
            panelBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUnidad);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(txtStockSeguridad);
            panel1.Controls.Add(lblVenci);
            panel1.Controls.Add(dtVencimiento);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(imagenProducto);
            panel1.Controls.Add(btnSeleccionarImagen);
            panel1.Controls.Add(txtCodigoBarra);
            panel1.Controls.Add(txtPrecioVenta);
            panel1.Controls.Add(txtPrecioCompra);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(cbxCategoria);
            panel1.Controls.Add(cbxProveedor);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIdProducto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 569);
            panel1.TabIndex = 20;
            // 
            // txtUnidad
            // 
            txtUnidad.AnimateReadOnly = true;
            txtUnidad.AutoCompleteMode = AutoCompleteMode.None;
            txtUnidad.AutoCompleteSource = AutoCompleteSource.None;
            txtUnidad.BackgroundImageLayout = ImageLayout.None;
            txtUnidad.CharacterCasing = CharacterCasing.Normal;
            txtUnidad.Depth = 0;
            txtUnidad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnidad.HideSelection = true;
            txtUnidad.Hint = "Unidad";
            txtUnidad.LeadingIcon = null;
            txtUnidad.Location = new Point(221, 214);
            txtUnidad.MaxLength = 32767;
            txtUnidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnidad.Name = "txtUnidad";
            txtUnidad.PasswordChar = '\0';
            txtUnidad.PrefixSuffixText = null;
            txtUnidad.ReadOnly = false;
            txtUnidad.RightToLeft = RightToLeft.No;
            txtUnidad.SelectedText = "";
            txtUnidad.SelectionLength = 0;
            txtUnidad.SelectionStart = 0;
            txtUnidad.ShortcutsEnabled = true;
            txtUnidad.Size = new Size(214, 48);
            txtUnidad.TabIndex = 51;
            txtUnidad.TabStop = false;
            txtUnidad.TextAlign = HorizontalAlignment.Center;
            txtUnidad.TrailingIcon = null;
            txtUnidad.UseSystemPasswordChar = false;
            // 
            // txtMarca
            // 
            txtMarca.AnimateReadOnly = true;
            txtMarca.AutoCompleteMode = AutoCompleteMode.None;
            txtMarca.AutoCompleteSource = AutoCompleteSource.None;
            txtMarca.BackgroundImageLayout = ImageLayout.None;
            txtMarca.CharacterCasing = CharacterCasing.Normal;
            txtMarca.Depth = 0;
            txtMarca.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.HideSelection = true;
            txtMarca.Hint = "Marca";
            txtMarca.LeadingIcon = null;
            txtMarca.Location = new Point(221, 160);
            txtMarca.MaxLength = 32767;
            txtMarca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMarca.Name = "txtMarca";
            txtMarca.PasswordChar = '\0';
            txtMarca.PrefixSuffixText = null;
            txtMarca.ReadOnly = false;
            txtMarca.RightToLeft = RightToLeft.No;
            txtMarca.SelectedText = "";
            txtMarca.SelectionLength = 0;
            txtMarca.SelectionStart = 0;
            txtMarca.ShortcutsEnabled = true;
            txtMarca.Size = new Size(214, 48);
            txtMarca.TabIndex = 50;
            txtMarca.TabStop = false;
            txtMarca.TextAlign = HorizontalAlignment.Center;
            txtMarca.TrailingIcon = null;
            txtMarca.UseSystemPasswordChar = false;
            // 
            // txtStockSeguridad
            // 
            txtStockSeguridad.AnimateReadOnly = true;
            txtStockSeguridad.AutoCompleteMode = AutoCompleteMode.None;
            txtStockSeguridad.AutoCompleteSource = AutoCompleteSource.None;
            txtStockSeguridad.BackgroundImageLayout = ImageLayout.None;
            txtStockSeguridad.CharacterCasing = CharacterCasing.Normal;
            txtStockSeguridad.Depth = 0;
            txtStockSeguridad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockSeguridad.HideSelection = true;
            txtStockSeguridad.Hint = "Cantidad minima de seguridad";
            txtStockSeguridad.LeadingIcon = null;
            txtStockSeguridad.Location = new Point(15, 377);
            txtStockSeguridad.MaxLength = 32767;
            txtStockSeguridad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtStockSeguridad.Name = "txtStockSeguridad";
            txtStockSeguridad.PasswordChar = '\0';
            txtStockSeguridad.PrefixSuffixText = null;
            txtStockSeguridad.ReadOnly = false;
            txtStockSeguridad.RightToLeft = RightToLeft.No;
            txtStockSeguridad.SelectedText = "";
            txtStockSeguridad.SelectionLength = 0;
            txtStockSeguridad.SelectionStart = 0;
            txtStockSeguridad.ShortcutsEnabled = true;
            txtStockSeguridad.Size = new Size(263, 48);
            txtStockSeguridad.TabIndex = 49;
            txtStockSeguridad.TabStop = false;
            txtStockSeguridad.TextAlign = HorizontalAlignment.Center;
            txtStockSeguridad.TrailingIcon = null;
            txtStockSeguridad.UseSystemPasswordChar = false;
            txtStockSeguridad.KeyPress += txtStockSeguridad_KeyPress;
            // 
            // lblVenci
            // 
            lblVenci.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVenci.ForeColor = SystemColors.ControlDarkDark;
            lblVenci.Location = new Point(12, 432);
            lblVenci.Name = "lblVenci";
            lblVenci.Size = new Size(162, 22);
            lblVenci.TabIndex = 48;
            lblVenci.Text = "Fecha de vencimiento:";
            lblVenci.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtVencimiento
            // 
            dtVencimiento.Location = new Point(178, 430);
            dtVencimiento.Margin = new Padding(3, 2, 3, 2);
            dtVencimiento.Name = "dtVencimiento";
            dtVencimiento.Size = new Size(256, 23);
            dtVencimiento.TabIndex = 47;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(74, 121, 121);
            btnCategorias.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnCategorias.BackgroundImageLayout = ImageLayout.Center;
            btnCategorias.BorderColor = Color.PaleVioletRed;
            btnCategorias.BorderRadius = 10;
            btnCategorias.BorderSize = 0;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.ImageAlign = ContentAlignment.MiddleRight;
            btnCategorias.Location = new Point(340, 323);
            btnCategorias.Margin = new Padding(3, 2, 3, 2);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(94, 49);
            btnCategorias.TabIndex = 46;
            btnCategorias.Text = " gestionar categorias";
            btnCategorias.TextColor = Color.White;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
            // 
            // imagenProducto
            // 
            imagenProducto.ErrorImage = (Image)resources.GetObject("imagenProducto.ErrorImage");
            imagenProducto.Location = new Point(15, 46);
            imagenProducto.Name = "imagenProducto";
            imagenProducto.Size = new Size(123, 108);
            imagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenProducto.TabIndex = 43;
            imagenProducto.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.BackColor = Color.FromArgb(74, 121, 121);
            btnSeleccionarImagen.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnSeleccionarImagen.BackgroundImageLayout = ImageLayout.Center;
            btnSeleccionarImagen.BorderColor = Color.PaleVioletRed;
            btnSeleccionarImagen.BorderRadius = 10;
            btnSeleccionarImagen.BorderSize = 0;
            btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionarImagen.ForeColor = Color.White;
            btnSeleccionarImagen.ImageAlign = ContentAlignment.MiddleRight;
            btnSeleccionarImagen.Location = new Point(144, 80);
            btnSeleccionarImagen.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(110, 45);
            btnSeleccionarImagen.TabIndex = 42;
            btnSeleccionarImagen.Text = "buscar";
            btnSeleccionarImagen.TextColor = Color.White;
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.AnimateReadOnly = true;
            txtCodigoBarra.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigoBarra.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigoBarra.BackgroundImageLayout = ImageLayout.None;
            txtCodigoBarra.CharacterCasing = CharacterCasing.Normal;
            txtCodigoBarra.Depth = 0;
            txtCodigoBarra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoBarra.HideSelection = true;
            txtCodigoBarra.Hint = "Codigo de barra";
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(12, 160);
            txtCodigoBarra.MaxLength = 32767;
            txtCodigoBarra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.PasswordChar = '\0';
            txtCodigoBarra.PrefixSuffixText = null;
            txtCodigoBarra.ReadOnly = false;
            txtCodigoBarra.RightToLeft = RightToLeft.No;
            txtCodigoBarra.SelectedText = "";
            txtCodigoBarra.SelectionLength = 0;
            txtCodigoBarra.SelectionStart = 0;
            txtCodigoBarra.ShortcutsEnabled = true;
            txtCodigoBarra.Size = new Size(206, 48);
            txtCodigoBarra.TabIndex = 41;
            txtCodigoBarra.TabStop = false;
            txtCodigoBarra.TextAlign = HorizontalAlignment.Center;
            txtCodigoBarra.TrailingIcon = null;
            txtCodigoBarra.UseSystemPasswordChar = false;
            txtCodigoBarra.KeyPress += txtCodigoBarra_KeyPress;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.AnimateReadOnly = true;
            txtPrecioVenta.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecioVenta.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecioVenta.BackgroundImageLayout = ImageLayout.None;
            txtPrecioVenta.CharacterCasing = CharacterCasing.Normal;
            txtPrecioVenta.Depth = 0;
            txtPrecioVenta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.HideSelection = true;
            txtPrecioVenta.Hint = "Precio de Venta";
            txtPrecioVenta.LeadingIcon = null;
            txtPrecioVenta.Location = new Point(14, 323);
            txtPrecioVenta.MaxLength = 32767;
            txtPrecioVenta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PasswordChar = '\0';
            txtPrecioVenta.PrefixSuffixText = null;
            txtPrecioVenta.ReadOnly = false;
            txtPrecioVenta.RightToLeft = RightToLeft.No;
            txtPrecioVenta.SelectedText = "";
            txtPrecioVenta.SelectionLength = 0;
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.ShortcutsEnabled = true;
            txtPrecioVenta.Size = new Size(204, 48);
            txtPrecioVenta.TabIndex = 40;
            txtPrecioVenta.TabStop = false;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Center;
            txtPrecioVenta.TrailingIcon = null;
            txtPrecioVenta.UseSystemPasswordChar = false;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.AnimateReadOnly = true;
            txtPrecioCompra.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecioCompra.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecioCompra.BackgroundImageLayout = ImageLayout.None;
            txtPrecioCompra.CharacterCasing = CharacterCasing.Normal;
            txtPrecioCompra.Depth = 0;
            txtPrecioCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioCompra.HideSelection = true;
            txtPrecioCompra.Hint = "Precio de compra";
            txtPrecioCompra.LeadingIcon = null;
            txtPrecioCompra.Location = new Point(14, 268);
            txtPrecioCompra.MaxLength = 32767;
            txtPrecioCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PasswordChar = '\0';
            txtPrecioCompra.PrefixSuffixText = null;
            txtPrecioCompra.ReadOnly = false;
            txtPrecioCompra.RightToLeft = RightToLeft.No;
            txtPrecioCompra.SelectedText = "";
            txtPrecioCompra.SelectionLength = 0;
            txtPrecioCompra.SelectionStart = 0;
            txtPrecioCompra.ShortcutsEnabled = true;
            txtPrecioCompra.Size = new Size(202, 48);
            txtPrecioCompra.TabIndex = 39;
            txtPrecioCompra.TabStop = false;
            txtPrecioCompra.TextAlign = HorizontalAlignment.Center;
            txtPrecioCompra.TrailingIcon = null;
            txtPrecioCompra.UseSystemPasswordChar = false;
            txtPrecioCompra.KeyPress += txtPrecioDeCompra_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(123, 472);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(200, 81);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(102, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 77);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 77);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseHover += btnGuardar_MouseHover;
            // 
            // cbxCategoria
            // 
            cbxCategoria.AutoResize = false;
            cbxCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cbxCategoria.Depth = 0;
            cbxCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCategoria.DropDownHeight = 174;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.DropDownWidth = 121;
            cbxCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Hint = "Categoria";
            cbxCategoria.IntegralHeight = false;
            cbxCategoria.ItemHeight = 43;
            cbxCategoria.Location = new Point(221, 323);
            cbxCategoria.MaxDropDownItems = 4;
            cbxCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(114, 49);
            cbxCategoria.StartIndex = 0;
            cbxCategoria.TabIndex = 12;
            // 
            // cbxProveedor
            // 
            cbxProveedor.AutoResize = false;
            cbxProveedor.BackColor = Color.FromArgb(255, 255, 255);
            cbxProveedor.Depth = 0;
            cbxProveedor.DrawMode = DrawMode.OwnerDrawVariable;
            cbxProveedor.DropDownHeight = 174;
            cbxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProveedor.DropDownWidth = 121;
            cbxProveedor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxProveedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxProveedor.FormattingEnabled = true;
            cbxProveedor.Hint = "Proveedor";
            cbxProveedor.IntegralHeight = false;
            cbxProveedor.ItemHeight = 43;
            cbxProveedor.Location = new Point(220, 268);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(214, 49);
            cbxProveedor.StartIndex = 0;
            cbxProveedor.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(56, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 40);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Producto";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = true;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(11, 214);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(205, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(373, 3);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(35, 23);
            txtIdProducto.TabIndex = 8;
            txtIdProducto.Text = "0";
            txtIdProducto.Visible = false;
            // 
            // tbProductos
            // 
            tbProductos.AllowUserToAddRows = false;
            tbProductos.AllowUserToOrderColumns = true;
            tbProductos.AllowUserToResizeRows = false;
            tbProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tbProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbProductos.BackgroundColor = Color.White;
            tbProductos.BorderStyle = BorderStyle.None;
            tbProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbProductos.ColumnHeadersHeight = 35;
            tbProductos.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, btnBorrar, Id, Codigo, Marca, Nombre, Unidad, PrecioCompra, PrecioVenta, StockSeguridad, Vencimiento, ProveedorID, NombreProveedor, CategoriaID, NombreCategoria, Imagen });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbProductos.DefaultCellStyle = dataGridViewCellStyle2;
            tbProductos.Dock = DockStyle.Fill;
            tbProductos.EnableHeadersVisualStyles = false;
            tbProductos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductos.GridColor = Color.Gray;
            tbProductos.Location = new Point(453, 54);
            tbProductos.Name = "tbProductos";
            tbProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbProductos.RowHeadersVisible = false;
            tbProductos.RowHeadersWidth = 40;
            tbProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProductos.RowTemplate.Height = 30;
            tbProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProductos.Size = new Size(988, 515);
            tbProductos.TabIndex = 21;
            tbProductos.CellContentClick += tbProductos_CellContentClick;
            tbProductos.CellPainting += tbProductos_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "Editar";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Width = 41;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "eliminar";
            btnBorrar.MinimumWidth = 6;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Width = 52;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 41;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo de barra";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 61;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 71;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            Unidad.ReadOnly = true;
            Unidad.Width = 68;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio-Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioCompra.Width = 86;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio-Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 94;
            // 
            // StockSeguridad
            // 
            StockSeguridad.HeaderText = "Strock de seguridad";
            StockSeguridad.MinimumWidth = 6;
            StockSeguridad.Name = "StockSeguridad";
            StockSeguridad.ReadOnly = true;
            StockSeguridad.Width = 122;
            // 
            // Vencimiento
            // 
            Vencimiento.HeaderText = "Vence";
            Vencimiento.MinimumWidth = 6;
            Vencimiento.Name = "Vencimiento";
            Vencimiento.ReadOnly = true;
            Vencimiento.Width = 60;
            // 
            // ProveedorID
            // 
            ProveedorID.HeaderText = "Proveedor ID";
            ProveedorID.MinimumWidth = 6;
            ProveedorID.Name = "ProveedorID";
            ProveedorID.Visible = false;
            ProveedorID.Width = 88;
            // 
            // NombreProveedor
            // 
            NombreProveedor.HeaderText = "Proveedor";
            NombreProveedor.MinimumWidth = 6;
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.ReadOnly = true;
            NombreProveedor.Width = 82;
            // 
            // CategoriaID
            // 
            CategoriaID.HeaderText = "CategoriaID";
            CategoriaID.MinimumWidth = 6;
            CategoriaID.Name = "CategoriaID";
            CategoriaID.Visible = false;
            CategoriaID.Width = 91;
            // 
            // NombreCategoria
            // 
            NombreCategoria.HeaderText = "Categoria";
            NombreCategoria.MinimumWidth = 6;
            NombreCategoria.Name = "NombreCategoria";
            NombreCategoria.ReadOnly = true;
            NombreCategoria.Width = 80;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "imagen";
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            Imagen.Width = 68;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = true;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.CharacterCasing = CharacterCasing.Normal;
            txtBuscar.Depth = 0;
            txtBuscar.Dock = DockStyle.Left;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(448, 0);
            txtBuscar.MaxLength = 32767;
            txtBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = '\0';
            txtBuscar.PrefixSuffixText = null;
            txtBuscar.ReadOnly = false;
            txtBuscar.RightToLeft = RightToLeft.No;
            txtBuscar.SelectedText = "";
            txtBuscar.SelectionLength = 0;
            txtBuscar.SelectionStart = 0;
            txtBuscar.ShortcutsEnabled = true;
            txtBuscar.Size = new Size(302, 48);
            txtBuscar.TabIndex = 25;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(272, 54);
            lblEncabezado.TabIndex = 24;
            lblEncabezado.Text = "Productos registrados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxBuscar
            // 
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.Dock = DockStyle.Left;
            cbxBuscar.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscar.DropDownHeight = 174;
            cbxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscar.DropDownWidth = 121;
            cbxBuscar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Hint = "buscar por";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "Codigo", "Nombre", "Proveedor", "Categoria" });
            cbxBuscar.Location = new Point(272, 0);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(176, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 26;
            cbxBuscar.MouseHover += cbxBuscar_MouseHover;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(cbxBuscar);
            panelBusqueda.Controls.Add(lblEncabezado);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(453, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(988, 54);
            panelBusqueda.TabIndex = 27;
            // 
            // formProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 572);
            Controls.Add(tbProductos);
            Controls.Add(panelBusqueda);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formProductos";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formCompras";
            Load += formProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenProducto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbProductos).EndInit();
            panelBusqueda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView tbProductos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioVenta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioCompra;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedor;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdProducto;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigoBarra;
        private RJCodeAdvance.RJControls.RJButton btnSeleccionarImagen;
        private PictureBox imagenProducto;
        private Panel panelBusqueda;
        private PictureBox pictureBox4;
        private RJCodeAdvance.RJControls.RJButton btnCategorias;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtStockSeguridad;
        private Label lblVenci;
        private DateTimePicker dtVencimiento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMarca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnidad;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn StockSeguridad;
        private DataGridViewTextBoxColumn Vencimiento;
        private DataGridViewTextBoxColumn ProveedorID;
        private DataGridViewTextBoxColumn NombreProveedor;
        private DataGridViewTextBoxColumn CategoriaID;
        private DataGridViewTextBoxColumn NombreCategoria;
        private DataGridViewTextBoxColumn Imagen;
    }
}