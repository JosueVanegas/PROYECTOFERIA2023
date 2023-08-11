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
            Nombre = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ProveedorID = new DataGridViewTextBoxColumn();
            CategoriaID = new DataGridViewTextBoxColumn();
            NombreProveedor = new DataGridViewTextBoxColumn();
            NombreCategoria = new DataGridViewTextBoxColumn();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenProducto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel1.Size = new Size(286, 489);
            panel1.TabIndex = 20;
            // 
            // imagenProducto
            // 
            imagenProducto.Location = new Point(12, 46);
            imagenProducto.Name = "imagenProducto";
            imagenProducto.Size = new Size(96, 94);
            imagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenProducto.TabIndex = 43;
            imagenProducto.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Anchor = AnchorStyles.Left;
            btnSeleccionarImagen.BackColor = Color.FromArgb(63, 63, 70);
            btnSeleccionarImagen.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnSeleccionarImagen.BackgroundImageLayout = ImageLayout.Center;
            btnSeleccionarImagen.BorderColor = Color.PaleVioletRed;
            btnSeleccionarImagen.BorderRadius = 10;
            btnSeleccionarImagen.BorderSize = 0;
            btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionarImagen.ForeColor = Color.White;
            btnSeleccionarImagen.ImageAlign = ContentAlignment.MiddleRight;
            btnSeleccionarImagen.Location = new Point(114, 106);
            btnSeleccionarImagen.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(145, 34);
            btnSeleccionarImagen.TabIndex = 42;
            btnSeleccionarImagen.Text = "seleccionar imagen";
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
            txtCodigoBarra.Hint = "ingrese el codigo de barra";
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(14, 146);
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
            txtCodigoBarra.Size = new Size(244, 48);
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
            txtPrecioVenta.Hint = "Ingrese el Precio de Venta";
            txtPrecioVenta.LeadingIcon = null;
            txtPrecioVenta.Location = new Point(12, 308);
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
            txtPrecioVenta.Size = new Size(249, 48);
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
            txtPrecioCompra.Hint = "Ingrese el Precio de Compra";
            txtPrecioCompra.LeadingIcon = null;
            txtPrecioCompra.Location = new Point(12, 254);
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
            txtPrecioCompra.Size = new Size(249, 48);
            txtPrecioCompra.TabIndex = 39;
            txtPrecioCompra.TabStop = false;
            txtPrecioCompra.TextAlign = HorizontalAlignment.Center;
            txtPrecioCompra.TrailingIcon = null;
            txtPrecioCompra.UseSystemPasswordChar = false;
            txtPrecioCompra.KeyPress += txtPrecioDeCompra_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(60, 416);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(156, 70);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(81, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 66);
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
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(71, 66);
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
            cbxCategoria.Anchor = AnchorStyles.Left;
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
            cbxCategoria.Location = new Point(147, 362);
            cbxCategoria.MaxDropDownItems = 4;
            cbxCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(114, 49);
            cbxCategoria.StartIndex = 0;
            cbxCategoria.TabIndex = 12;
            // 
            // cbxProveedor
            // 
            cbxProveedor.Anchor = AnchorStyles.Left;
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
            cbxProveedor.Location = new Point(12, 362);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(118, 49);
            cbxProveedor.StartIndex = 0;
            cbxProveedor.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(12, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
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
            txtNombre.Hint = "Ingrese el nombre del Producto";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(14, 200);
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
            txtNombre.Size = new Size(247, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(223, 22);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(35, 23);
            txtIdProducto.TabIndex = 8;
            txtIdProducto.Text = "1";
            txtIdProducto.Visible = false;
            // 
            // tbProductos
            // 
            tbProductos.AllowUserToAddRows = false;
            tbProductos.AllowUserToOrderColumns = true;
            tbProductos.AllowUserToResizeRows = false;
            tbProductos.Anchor = AnchorStyles.Left;
            tbProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbProductos.BackgroundColor = Color.FromArgb(50, 50, 50);
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
            tbProductos.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, btnBorrar, Id, Codigo, Nombre, PrecioCompra, PrecioVenta, Cantidad, ProveedorID, CategoriaID, NombreProveedor, NombreCategoria });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbProductos.DefaultCellStyle = dataGridViewCellStyle2;
            tbProductos.EnableHeadersVisualStyles = false;
            tbProductos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductos.GridColor = Color.Gray;
            tbProductos.Location = new Point(323, 89);
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
            tbProductos.Size = new Size(617, 421);
            tbProductos.TabIndex = 21;
            tbProductos.CellContentClick += tbProductos_CellContentClick;
            tbProductos.CellPainting += tbProductos_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "Editar";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Width = 50;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "eliminar";
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Width = 50;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 10;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo de barra";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 120;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioCompra.Width = 50;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 50;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 30;
            // 
            // ProveedorID
            // 
            ProveedorID.HeaderText = "Proveedor ID";
            ProveedorID.Name = "ProveedorID";
            ProveedorID.Width = 10;
            // 
            // CategoriaID
            // 
            CategoriaID.HeaderText = "CategoriaID";
            CategoriaID.Name = "CategoriaID";
            CategoriaID.Width = 10;
            // 
            // NombreProveedor
            // 
            NombreProveedor.HeaderText = "Proveedor";
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.ReadOnly = true;
            // 
            // NombreCategoria
            // 
            NombreCategoria.HeaderText = "Categoria";
            NombreCategoria.Name = "NombreCategoria";
            NombreCategoria.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = true;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.CharacterCasing = CharacterCasing.Normal;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(616, 11);
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
            txtBuscar.Size = new Size(324, 48);
            txtBuscar.TabIndex = 25;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(323, 10);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(153, 49);
            lblEncabezado.TabIndex = 24;
            lblEncabezado.Text = "Productos registrados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxBuscar
            // 
            cbxBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
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
            cbxBuscar.Location = new Point(482, 10);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(128, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 26;
            // 
            // formProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 492);
            Controls.Add(cbxBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbProductos);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formProductos";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formCompras";
            Load += formProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenProducto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbProductos).EndInit();
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
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ProveedorID;
        private DataGridViewTextBoxColumn CategoriaID;
        private DataGridViewTextBoxColumn NombreProveedor;
        private DataGridViewTextBoxColumn NombreCategoria;
        private PictureBox imagenProducto;
    }
}