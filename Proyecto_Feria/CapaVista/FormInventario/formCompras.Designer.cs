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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            hopeNumeric1 = new ReaLTaiizor.Controls.HopeNumeric();
            NumberPrecioCompra = new ReaLTaiizor.Controls.HopeNumeric();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            lblPrecioVenta = new Label();
            lblPrecioCompra = new Label();
            cbxCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdCategoria = new TextBox();
            tbUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(hopeNumeric1);
            panel1.Controls.Add(NumberPrecioCompra);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblPrecioVenta);
            panel1.Controls.Add(lblPrecioCompra);
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
            // hopeNumeric1
            // 
            hopeNumeric1.BackColor = Color.White;
            hopeNumeric1.BaseColor = Color.FromArgb(50, 50, 50);
            hopeNumeric1.BorderColorA = Color.FromArgb(192, 196, 204);
            hopeNumeric1.BorderColorB = Color.FromArgb(192, 196, 204);
            hopeNumeric1.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            hopeNumeric1.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            hopeNumeric1.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            hopeNumeric1.EnterKey = true;
            hopeNumeric1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeNumeric1.ForeColor = Color.Black;
            hopeNumeric1.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            hopeNumeric1.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            hopeNumeric1.Location = new Point(187, 165);
            hopeNumeric1.MaxNum = 10F;
            hopeNumeric1.MinNum = 0F;
            hopeNumeric1.Name = "hopeNumeric1";
            hopeNumeric1.Precision = 0;
            hopeNumeric1.Size = new Size(101, 32);
            hopeNumeric1.Step = 1F;
            hopeNumeric1.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            hopeNumeric1.TabIndex = 36;
            hopeNumeric1.Text = "hopeNumeric1";
            hopeNumeric1.ValueNumber = 0F;
            // 
            // NumberPrecioCompra
            // 
            NumberPrecioCompra.BackColor = Color.White;
            NumberPrecioCompra.BaseColor = Color.FromArgb(50, 50, 50);
            NumberPrecioCompra.BorderColorA = Color.FromArgb(192, 196, 204);
            NumberPrecioCompra.BorderColorB = Color.FromArgb(192, 196, 204);
            NumberPrecioCompra.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            NumberPrecioCompra.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            NumberPrecioCompra.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            NumberPrecioCompra.EnterKey = true;
            NumberPrecioCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumberPrecioCompra.ForeColor = Color.Black;
            NumberPrecioCompra.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            NumberPrecioCompra.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            NumberPrecioCompra.Location = new Point(187, 125);
            NumberPrecioCompra.MaxNum = 10F;
            NumberPrecioCompra.MinNum = 0F;
            NumberPrecioCompra.Name = "NumberPrecioCompra";
            NumberPrecioCompra.Precision = 0;
            NumberPrecioCompra.Size = new Size(101, 32);
            NumberPrecioCompra.Step = 1F;
            NumberPrecioCompra.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            NumberPrecioCompra.TabIndex = 35;
            NumberPrecioCompra.Text = "hopeNumeric1";
            NumberPrecioCompra.ValueNumber = 0F;
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
            // lblPrecioVenta
            // 
            lblPrecioVenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.ForeColor = SystemColors.ControlDarkDark;
            lblPrecioVenta.Location = new Point(18, 156);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(148, 48);
            lblPrecioVenta.TabIndex = 25;
            lblPrecioVenta.Text = "Precio de Venta    $";
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
            lblPrecioCompra.Text = "Precio de Compra $";
            lblPrecioCompra.TextAlign = ContentAlignment.MiddleLeft;
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
            txtNombre.KeyPress += txtNombre_KeyPress;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategoria;
        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuarios;
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
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedor;
        private ReaLTaiizor.Controls.HopeNumeric NumberPrecioCompra;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumeric1;
        private PictureBox pictureBox1;
    }
}