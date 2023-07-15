namespace CapaVista
{
    partial class formCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompras));
            panel1 = new Panel();
            lblcantidad = new Label();
            lblPrecioVenta = new Label();
            lblPrecioCompra = new Label();
            metroNumeric3 = new ReaLTaiizor.Controls.MetroNumeric();
            metroNumeric2 = new ReaLTaiizor.Controls.MetroNumeric();
            metroNumeric1 = new ReaLTaiizor.Controls.MetroNumeric();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdCategoria = new TextBox();
            tbUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Cantidades = new DataGridViewTextBoxColumn();
            ProveedorID = new DataGridViewTextBoxColumn();
            CategoriaID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblcantidad);
            panel1.Controls.Add(lblPrecioVenta);
            panel1.Controls.Add(lblPrecioCompra);
            panel1.Controls.Add(metroNumeric3);
            panel1.Controls.Add(metroNumeric2);
            panel1.Controls.Add(metroNumeric1);
            panel1.Controls.Add(materialComboBox1);
            panel1.Controls.Add(cbxProveedor);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIdCategoria);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 489);
            panel1.TabIndex = 20;
            // 
            // lblcantidad
            // 
            lblcantidad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcantidad.ForeColor = SystemColors.ControlDarkDark;
            lblcantidad.Location = new Point(18, 204);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(148, 48);
            lblcantidad.TabIndex = 26;
            lblcantidad.Text = "Cantidades";
            lblcantidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.ForeColor = SystemColors.ControlDarkDark;
            lblPrecioVenta.Location = new Point(18, 156);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(148, 48);
            lblPrecioVenta.TabIndex = 25;
            lblPrecioVenta.Text = "Precio de Venta";
            lblPrecioVenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCompra.ForeColor = SystemColors.ControlDarkDark;
            lblPrecioCompra.Location = new Point(18, 115);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(148, 48);
            lblPrecioCompra.TabIndex = 24;
            lblPrecioCompra.Text = "Precio de Compra";
            lblPrecioCompra.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // metroNumeric3
            // 
            metroNumeric3.BackColor = Color.Transparent;
            metroNumeric3.BackgroundColor = Color.Empty;
            metroNumeric3.BorderColor = Color.FromArgb(110, 110, 110);
            metroNumeric3.Decrement = 1;
            metroNumeric3.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroNumeric3.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            metroNumeric3.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroNumeric3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroNumeric3.HoldInterval = 10;
            metroNumeric3.Increment = 1;
            metroNumeric3.IsDerivedStyle = true;
            metroNumeric3.Location = new Point(175, 126);
            metroNumeric3.Maximum = 100;
            metroNumeric3.Minimum = 0;
            metroNumeric3.Name = "metroNumeric3";
            metroNumeric3.Size = new Size(75, 26);
            metroNumeric3.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroNumeric3.StyleManager = null;
            metroNumeric3.SymbolsColor = Color.FromArgb(0, 162, 204);
            metroNumeric3.TabIndex = 23;
            metroNumeric3.Text = "metroNumeric3";
            metroNumeric3.ThemeAuthor = "Taiizor";
            metroNumeric3.ThemeName = "MetroDark";
            metroNumeric3.Value = 0;
            // 
            // metroNumeric2
            // 
            metroNumeric2.BackColor = Color.Transparent;
            metroNumeric2.BackgroundColor = Color.Empty;
            metroNumeric2.BorderColor = Color.FromArgb(110, 110, 110);
            metroNumeric2.Decrement = 1;
            metroNumeric2.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroNumeric2.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            metroNumeric2.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroNumeric2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroNumeric2.HoldInterval = 10;
            metroNumeric2.Increment = 1;
            metroNumeric2.IsDerivedStyle = true;
            metroNumeric2.Location = new Point(175, 215);
            metroNumeric2.Maximum = 100;
            metroNumeric2.Minimum = 0;
            metroNumeric2.Name = "metroNumeric2";
            metroNumeric2.Size = new Size(75, 26);
            metroNumeric2.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroNumeric2.StyleManager = null;
            metroNumeric2.SymbolsColor = Color.FromArgb(0, 162, 204);
            metroNumeric2.TabIndex = 22;
            metroNumeric2.Text = "metroNumeric2";
            metroNumeric2.ThemeAuthor = "Taiizor";
            metroNumeric2.ThemeName = "MetroDark";
            metroNumeric2.Value = 0;
            // 
            // metroNumeric1
            // 
            metroNumeric1.BackColor = Color.Transparent;
            metroNumeric1.BackgroundColor = Color.Empty;
            metroNumeric1.BorderColor = Color.FromArgb(110, 110, 110);
            metroNumeric1.Decrement = 1;
            metroNumeric1.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroNumeric1.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            metroNumeric1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroNumeric1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroNumeric1.HoldInterval = 10;
            metroNumeric1.Increment = 1;
            metroNumeric1.IsDerivedStyle = true;
            metroNumeric1.Location = new Point(175, 171);
            metroNumeric1.Maximum = 100;
            metroNumeric1.Minimum = 0;
            metroNumeric1.Name = "metroNumeric1";
            metroNumeric1.Size = new Size(75, 26);
            metroNumeric1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroNumeric1.StyleManager = null;
            metroNumeric1.SymbolsColor = Color.FromArgb(0, 162, 204);
            metroNumeric1.TabIndex = 21;
            metroNumeric1.Text = "metroNumeric1";
            metroNumeric1.ThemeAuthor = "Taiizor";
            metroNumeric1.ThemeName = "MetroDark";
            metroNumeric1.Value = 0;
            // 
            // materialComboBox1
            // 
            materialComboBox1.Anchor = AnchorStyles.Left;
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Categoria";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(12, 314);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(154, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 12;
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
            cbxProveedor.Location = new Point(12, 259);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(154, 49);
            cbxProveedor.StartIndex = 0;
            cbxProveedor.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(28, 13);
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
            txtNombre.Location = new Point(12, 64);
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
            txtNombre.Size = new Size(263, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(227, 25);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(35, 23);
            txtIdCategoria.TabIndex = 8;
            txtIdCategoria.Visible = false;
            // 
            // tbUsuarios
            // 
            tbUsuarios.AllowUserToAddRows = false;
            tbUsuarios.AllowUserToOrderColumns = true;
            tbUsuarios.AllowUserToResizeRows = false;
            tbUsuarios.Anchor = AnchorStyles.Left;
            tbUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbUsuarios.BackgroundColor = Color.FromArgb(50, 50, 50);
            tbUsuarios.BorderStyle = BorderStyle.None;
            tbUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbUsuarios.ColumnHeadersHeight = 35;
            tbUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Nombre, rol, fecha, Cantidades, ProveedorID, CategoriaID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            tbUsuarios.EnableHeadersVisualStyles = false;
            tbUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuarios.GridColor = Color.Gray;
            tbUsuarios.Location = new Point(300, 83);
            tbUsuarios.Name = "tbUsuarios";
            tbUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbUsuarios.RowHeadersVisible = false;
            tbUsuarios.RowHeadersWidth = 40;
            tbUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbUsuarios.RowTemplate.Height = 30;
            tbUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbUsuarios.Size = new Size(581, 389);
            tbUsuarios.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Location = new Point(16, 380);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(234, 80);
            tableLayoutPanel1.TabIndex = 32;
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
            btnGuardar.Size = new Size(71, 76);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.BorderColor = Color.PaleVioletRed;
            btnEliminar.BorderRadius = 10;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(158, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 76);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnLimpiar.Location = new Point(80, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 76);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
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
            txtBuscar.Location = new Point(548, 29);
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
            txtBuscar.Size = new Size(299, 48);
            txtBuscar.TabIndex = 25;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(302, 29);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(215, 48);
            lblEncabezado.TabIndex = 24;
            lblEncabezado.Text = "Productos registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "Editar";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // rol
            // 
            rol.HeaderText = "Precio Compra";
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            fecha.HeaderText = "Precio Venta";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 200;
            // 
            // Cantidades
            // 
            Cantidades.HeaderText = "Cantidad";
            Cantidades.Name = "Cantidades";
            // 
            // ProveedorID
            // 
            ProveedorID.HeaderText = "Proveedor ID";
            ProveedorID.Name = "ProveedorID";
            // 
            // CategoriaID
            // 
            CategoriaID.HeaderText = "CategoriaID";
            CategoriaID.Name = "CategoriaID";
            // 
            // formCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 492);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbUsuarios);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formCompras";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formCompras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedor;
        private ReaLTaiizor.Controls.MetroNumeric metroNumeric2;
        private ReaLTaiizor.Controls.MetroNumeric metroNumeric1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MetroNumeric metroNumeric3;
        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuarios;
        private Label lblcantidad;
        private Label lblPrecioVenta;
        private Label lblPrecioCompra;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Cantidades;
        private DataGridViewTextBoxColumn ProveedorID;
        private DataGridViewTextBoxColumn CategoriaID;
    }
}