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
            tbProductos = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Cantidades = new DataGridViewTextBoxColumn();
            ProveedorID = new DataGridViewTextBoxColumn();
            CategoriaID = new DataGridViewTextBoxColumn();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            txtIdCategoria = new TextBox();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new Label();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            txtPrecioDeCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioVenta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProductos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPrecioVenta);
            panel1.Controls.Add(txtPrecioDeCompra);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(cbxCategoria);
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
            tbProductos.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Nombre, rol, fecha, Cantidades, ProveedorID, CategoriaID });
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
            tbProductos.Location = new Point(300, 83);
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
            tbProductos.Size = new Size(581, 389);
            tbProductos.TabIndex = 21;
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
            txtBuscar.Location = new Point(521, 9);
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
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(300, 9);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(215, 48);
            lblEncabezado.TabIndex = 24;
            lblEncabezado.Text = "Productos registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(227, 25);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(35, 23);
            txtIdCategoria.TabIndex = 8;
            txtIdCategoria.Visible = false;
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
            txtNombre.KeyPress += txtNombre_KeyPress;
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
            cbxProveedor.Location = new Point(12, 229);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(154, 49);
            cbxProveedor.StartIndex = 0;
            cbxProveedor.TabIndex = 11;
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
            cbxCategoria.Location = new Point(12, 284);
            cbxCategoria.MaxDropDownItems = 4;
            cbxCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(154, 49);
            cbxCategoria.StartIndex = 0;
            cbxCategoria.TabIndex = 12;
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
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
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
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseHover += btnEliminar_MouseHover;
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
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseHover += btnGuardar_MouseHover;
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
            tableLayoutPanel1.Location = new Point(16, 350);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(234, 80);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // txtPrecioDeCompra
            // 
            txtPrecioDeCompra.AnimateReadOnly = true;
            txtPrecioDeCompra.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecioDeCompra.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecioDeCompra.BackgroundImageLayout = ImageLayout.None;
            txtPrecioDeCompra.CharacterCasing = CharacterCasing.Normal;
            txtPrecioDeCompra.Depth = 0;
            txtPrecioDeCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioDeCompra.HideSelection = true;
            txtPrecioDeCompra.Hint = "Ingrese el Precio de Compra $";
            txtPrecioDeCompra.LeadingIcon = null;
            txtPrecioDeCompra.Location = new Point(12, 118);
            txtPrecioDeCompra.MaxLength = 32767;
            txtPrecioDeCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioDeCompra.Name = "txtPrecioDeCompra";
            txtPrecioDeCompra.PasswordChar = '\0';
            txtPrecioDeCompra.PrefixSuffixText = null;
            txtPrecioDeCompra.ReadOnly = false;
            txtPrecioDeCompra.RightToLeft = RightToLeft.No;
            txtPrecioDeCompra.SelectedText = "";
            txtPrecioDeCompra.SelectionLength = 0;
            txtPrecioDeCompra.SelectionStart = 0;
            txtPrecioDeCompra.ShortcutsEnabled = true;
            txtPrecioDeCompra.Size = new Size(263, 48);
            txtPrecioDeCompra.TabIndex = 39;
            txtPrecioDeCompra.TabStop = false;
            txtPrecioDeCompra.TextAlign = HorizontalAlignment.Center;
            txtPrecioDeCompra.TrailingIcon = null;
            txtPrecioDeCompra.UseSystemPasswordChar = false;
            txtPrecioDeCompra.KeyPress += txtPrecioDeCompra_KeyPress;
            txtPrecioDeCompra.Leave += txtPrecioDeCompra_Leave;
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
            txtPrecioVenta.Hint = "Ingrese el Precio de Venta $";
            txtPrecioVenta.LeadingIcon = null;
            txtPrecioVenta.Location = new Point(13, 172);
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
            txtPrecioVenta.Size = new Size(263, 48);
            txtPrecioVenta.TabIndex = 40;
            txtPrecioVenta.TabStop = false;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Center;
            txtPrecioVenta.TrailingIcon = null;
            txtPrecioVenta.UseSystemPasswordChar = false;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            txtPrecioVenta.Leave += txtPrecioVenta_Leave;
            // 
            // formCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 492);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbProductos);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formCompras";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formCompras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProductos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView tbProductos;
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioVenta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioDeCompra;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedor;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
    }
}