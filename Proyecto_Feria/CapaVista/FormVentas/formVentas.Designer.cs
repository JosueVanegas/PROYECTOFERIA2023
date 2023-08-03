namespace CapaVista.FormVenta
{
    partial class formVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVentas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtPrecioVenta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioDeCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            txtDescuento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSubTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCash = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            panel2 = new Panel();
            txtIva = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            checkDescuento = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ProductosDataGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            Eliminar = new DataGridViewImageColumn();
            DescripcionData = new DataGridViewTextBoxColumn();
            PrecioVentaDataGrid = new DataGridViewTextBoxColumn();
            StockDataGrid = new DataGridViewTextBoxColumn();
            CantidadDataGrid = new DataGridViewTextBoxColumn();
            TotalDataGrid = new DataGridViewTextBoxColumn();
            IncrementoCantidadDataGrid = new DataGridViewImageColumn();
            DecrementoCantidadDataGrid = new DataGridViewImageColumn();
            ImageProducto = new DataGridViewImageColumn();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtCodigoProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAgregarProducto = new RJCodeAdvance.RJControls.RJButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            btnEntradaManual = new RJCodeAdvance.RJControls.RJButton();
            btnEntradaLaser = new RJCodeAdvance.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPrecioVenta);
            panel1.Controls.Add(txtPrecioDeCompra);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
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
            btnGuardar.Location = new Point(3, 12);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(60, 76);
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
            btnEliminar.Location = new Point(135, 12);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(62, 76);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = true;
            txtDescuento.AutoCompleteMode = AutoCompleteMode.None;
            txtDescuento.AutoCompleteSource = AutoCompleteSource.None;
            txtDescuento.BackgroundImageLayout = ImageLayout.None;
            txtDescuento.CharacterCasing = CharacterCasing.Normal;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.HideSelection = true;
            txtDescuento.Hint = "Ingrese cantidad del Descuento";
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(24, 177);
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PrefixSuffixText = null;
            txtDescuento.ReadOnly = false;
            txtDescuento.RightToLeft = RightToLeft.No;
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.ShortcutsEnabled = true;
            txtDescuento.Size = new Size(263, 48);
            txtDescuento.TabIndex = 49;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
            txtDescuento.Visible = false;
            txtDescuento.KeyPress += textBox1_KeyPress;
            txtDescuento.TextChanged += AddPercentageSign;
            // 
            // txtSubTotal
            // 
            txtSubTotal.AnimateReadOnly = true;
            txtSubTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtSubTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtSubTotal.BackgroundImageLayout = ImageLayout.None;
            txtSubTotal.CharacterCasing = CharacterCasing.Normal;
            txtSubTotal.Depth = 0;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.HideSelection = true;
            txtSubTotal.Hint = "Subtotal";
            txtSubTotal.LeadingIcon = null;
            txtSubTotal.Location = new Point(24, 56);
            txtSubTotal.MaxLength = 32767;
            txtSubTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PasswordChar = '\0';
            txtSubTotal.PrefixSuffixText = null;
            txtSubTotal.ReadOnly = true;
            txtSubTotal.RightToLeft = RightToLeft.No;
            txtSubTotal.SelectedText = "";
            txtSubTotal.SelectionLength = 0;
            txtSubTotal.SelectionStart = 0;
            txtSubTotal.ShortcutsEnabled = true;
            txtSubTotal.Size = new Size(263, 48);
            txtSubTotal.TabIndex = 48;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Center;
            txtSubTotal.TrailingIcon = null;
            txtSubTotal.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel2.Controls.Add(btnCash, 0, 0);
            tableLayoutPanel2.Location = new Point(21, 447);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(266, 83);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.FromArgb(63, 63, 70);
            btnCash.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnCash.BackgroundImageLayout = ImageLayout.Center;
            btnCash.BorderColor = Color.PaleVioletRed;
            btnCash.BorderRadius = 10;
            btnCash.BorderSize = 0;
            btnCash.Dock = DockStyle.Fill;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.ForeColor = Color.White;
            btnCash.Image = (Image)resources.GetObject("btnCash.Image");
            btnCash.Location = new Point(3, 2);
            btnCash.Margin = new Padding(3, 2, 3, 2);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(260, 79);
            btnCash.TabIndex = 12;
            btnCash.Text = "Finalizar compra ";
            btnCash.TextAlign = ContentAlignment.BottomCenter;
            btnCash.TextColor = Color.White;
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(24, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "En Venta";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(txtIva);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(checkDescuento);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(txtDescuento);
            panel2.Controls.Add(txtSubTotal);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(790, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 542);
            panel2.TabIndex = 50;
            // 
            // txtIva
            // 
            txtIva.AnimateReadOnly = true;
            txtIva.AutoCompleteMode = AutoCompleteMode.None;
            txtIva.AutoCompleteSource = AutoCompleteSource.None;
            txtIva.BackgroundImageLayout = ImageLayout.None;
            txtIva.CharacterCasing = CharacterCasing.Normal;
            txtIva.Depth = 0;
            txtIva.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIva.HideSelection = true;
            txtIva.Hint = "Iva";
            txtIva.LeadingIcon = null;
            txtIva.Location = new Point(21, 331);
            txtIva.MaxLength = 32767;
            txtIva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIva.Name = "txtIva";
            txtIva.PasswordChar = '\0';
            txtIva.PrefixSuffixText = null;
            txtIva.ReadOnly = true;
            txtIva.RightToLeft = RightToLeft.No;
            txtIva.SelectedText = "";
            txtIva.SelectionLength = 0;
            txtIva.SelectionStart = 0;
            txtIva.ShortcutsEnabled = true;
            txtIva.Size = new Size(263, 48);
            txtIva.TabIndex = 52;
            txtIva.TabStop = false;
            txtIva.TextAlign = HorizontalAlignment.Center;
            txtIva.TrailingIcon = null;
            txtIva.UseSystemPasswordChar = false;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = true;
            txtTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "Total a pagar";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(21, 385);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(263, 48);
            txtTotal.TabIndex = 51;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // checkDescuento
            // 
            checkDescuento.AutoSize = true;
            checkDescuento.Depth = 0;
            checkDescuento.Location = new Point(24, 126);
            checkDescuento.Margin = new Padding(0);
            checkDescuento.MouseLocation = new Point(-1, -1);
            checkDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkDescuento.Name = "checkDescuento";
            checkDescuento.ReadOnly = false;
            checkDescuento.Ripple = true;
            checkDescuento.Size = new Size(110, 37);
            checkDescuento.TabIndex = 50;
            checkDescuento.Text = "Descuento";
            checkDescuento.UseAccentColor = false;
            checkDescuento.UseVisualStyleBackColor = true;
            checkDescuento.CheckedChanged += checkDescuento_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ProductosDataGrid, 0, 1);
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 21.955719F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 78.04428F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(787, 542);
            tableLayoutPanel3.TabIndex = 52;
            // 
            // ProductosDataGrid
            // 
            ProductosDataGrid.AllowUserToResizeRows = false;
            ProductosDataGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            ProductosDataGrid.BorderStyle = BorderStyle.None;
            ProductosDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductosDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDataGrid.Columns.AddRange(new DataGridViewColumn[] { Eliminar, DescripcionData, PrecioVentaDataGrid, StockDataGrid, CantidadDataGrid, TotalDataGrid, IncrementoCantidadDataGrid, DecrementoCantidadDataGrid, ImageProducto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductosDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            ProductosDataGrid.Dock = DockStyle.Fill;
            ProductosDataGrid.EnableHeadersVisualStyles = false;
            ProductosDataGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            ProductosDataGrid.GridColor = Color.FromArgb(255, 255, 255);
            ProductosDataGrid.Location = new Point(3, 122);
            ProductosDataGrid.Name = "ProductosDataGrid";
            ProductosDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductosDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ProductosDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProductosDataGrid.RowTemplate.Height = 25;
            ProductosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductosDataGrid.Size = new Size(781, 417);
            ProductosDataGrid.TabIndex = 54;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Image = Properties.Resources.eliminar;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            // 
            // DescripcionData
            // 
            DescripcionData.HeaderText = "Descripción";
            DescripcionData.Name = "DescripcionData";
            // 
            // PrecioVentaDataGrid
            // 
            PrecioVentaDataGrid.HeaderText = "Precio Venta";
            PrecioVentaDataGrid.Name = "PrecioVentaDataGrid";
            // 
            // StockDataGrid
            // 
            StockDataGrid.HeaderText = "Stock";
            StockDataGrid.Name = "StockDataGrid";
            // 
            // CantidadDataGrid
            // 
            CantidadDataGrid.HeaderText = "Cantidad";
            CantidadDataGrid.Name = "CantidadDataGrid";
            // 
            // TotalDataGrid
            // 
            TotalDataGrid.HeaderText = "Total";
            TotalDataGrid.Name = "TotalDataGrid";
            // 
            // IncrementoCantidadDataGrid
            // 
            IncrementoCantidadDataGrid.HeaderText = "";
            IncrementoCantidadDataGrid.Name = "IncrementoCantidadDataGrid";
            IncrementoCantidadDataGrid.Resizable = DataGridViewTriState.True;
            // 
            // DecrementoCantidadDataGrid
            // 
            DecrementoCantidadDataGrid.HeaderText = "";
            DecrementoCantidadDataGrid.Name = "DecrementoCantidadDataGrid";
            // 
            // ImageProducto
            // 
            ImageProducto.HeaderText = "";
            ImageProducto.Name = "ImageProducto";
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel2);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(781, 113);
            panel3.TabIndex = 53;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtCodigoProducto);
            flowLayoutPanel2.Controls.Add(btnAgregarProducto);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel2.Location = new Point(0, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(781, 54);
            flowLayoutPanel2.TabIndex = 53;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.AnimateReadOnly = true;
            txtCodigoProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigoProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigoProducto.BackgroundImageLayout = ImageLayout.None;
            txtCodigoProducto.CharacterCasing = CharacterCasing.Normal;
            txtCodigoProducto.Depth = 0;
            txtCodigoProducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProducto.HideSelection = true;
            txtCodigoProducto.Hint = " ";
            txtCodigoProducto.LeadingIcon = null;
            txtCodigoProducto.Location = new Point(3, 3);
            txtCodigoProducto.MaxLength = 32767;
            txtCodigoProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.PasswordChar = '\0';
            txtCodigoProducto.PrefixSuffixText = null;
            txtCodigoProducto.ReadOnly = false;
            txtCodigoProducto.RightToLeft = RightToLeft.No;
            txtCodigoProducto.SelectedText = "";
            txtCodigoProducto.SelectionLength = 0;
            txtCodigoProducto.SelectionStart = 0;
            txtCodigoProducto.ShortcutsEnabled = false;
            txtCodigoProducto.Size = new Size(654, 48);
            txtCodigoProducto.TabIndex = 49;
            txtCodigoProducto.TabStop = false;
            txtCodigoProducto.Text = "#";
            txtCodigoProducto.TextAlign = HorizontalAlignment.Left;
            txtCodigoProducto.TrailingIcon = null;
            txtCodigoProducto.UseSystemPasswordChar = false;
            txtCodigoProducto.KeyPress += txtCodigoProducto_KeyPress;
            txtCodigoProducto.TextChanged += AddNumeralSign;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(63, 63, 70);
            btnAgregarProducto.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.None;
            btnAgregarProducto.BorderColor = Color.PaleVioletRed;
            btnAgregarProducto.BorderRadius = 10;
            btnAgregarProducto.BorderSize = 0;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Image = (Image)resources.GetObject("btnAgregarProducto.Image");
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(663, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 49);
            btnAgregarProducto.TabIndex = 50;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarProducto.TextColor = Color.White;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Controls.Add(cbxBuscar);
            flowLayoutPanel1.Controls.Add(btnEntradaManual);
            flowLayoutPanel1.Controls.Add(btnEntradaLaser);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(781, 61);
            flowLayoutPanel1.TabIndex = 52;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(63, 63, 70);
            btnBuscar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.BorderColor = Color.PaleVioletRed;
            btnBuscar.BorderRadius = 10;
            btnBuscar.BorderSize = 0;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(3, 9);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 39);
            btnBuscar.TabIndex = 54;
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextColor = Color.White;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbxBuscar
            // 
            cbxBuscar.Anchor = AnchorStyles.Left;
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
            cbxBuscar.Hint = "Buscar producto";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "" });
            cbxBuscar.Location = new Point(50, 4);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(448, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 53;
            cbxBuscar.SelectedIndexChanged += cbxBuscar_SelectedIndexChanged;
            // 
            // btnEntradaManual
            // 
            btnEntradaManual.Anchor = AnchorStyles.Left;
            btnEntradaManual.BackColor = Color.FromArgb(63, 63, 70);
            btnEntradaManual.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEntradaManual.BackgroundImage = (Image)resources.GetObject("btnEntradaManual.BackgroundImage");
            btnEntradaManual.BackgroundImageLayout = ImageLayout.Center;
            btnEntradaManual.BorderColor = Color.PaleVioletRed;
            btnEntradaManual.BorderRadius = 10;
            btnEntradaManual.BorderSize = 0;
            btnEntradaManual.FlatAppearance.BorderSize = 0;
            btnEntradaManual.FlatStyle = FlatStyle.Flat;
            btnEntradaManual.ForeColor = Color.White;
            btnEntradaManual.ImageAlign = ContentAlignment.MiddleRight;
            btnEntradaManual.Location = new Point(504, 2);
            btnEntradaManual.Margin = new Padding(3, 2, 3, 2);
            btnEntradaManual.Name = "btnEntradaManual";
            btnEntradaManual.Size = new Size(60, 54);
            btnEntradaManual.TabIndex = 55;
            btnEntradaManual.TextAlign = ContentAlignment.BottomCenter;
            btnEntradaManual.TextColor = Color.White;
            btnEntradaManual.UseVisualStyleBackColor = false;
            btnEntradaManual.Click += btnEntradaManual_Click;
            // 
            // btnEntradaLaser
            // 
            btnEntradaLaser.Anchor = AnchorStyles.Left;
            btnEntradaLaser.BackColor = Color.FromArgb(63, 63, 70);
            btnEntradaLaser.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEntradaLaser.BackgroundImage = (Image)resources.GetObject("btnEntradaLaser.BackgroundImage");
            btnEntradaLaser.BackgroundImageLayout = ImageLayout.Center;
            btnEntradaLaser.BorderColor = Color.PaleVioletRed;
            btnEntradaLaser.BorderRadius = 10;
            btnEntradaLaser.BorderSize = 0;
            btnEntradaLaser.FlatAppearance.BorderSize = 0;
            btnEntradaLaser.FlatStyle = FlatStyle.Flat;
            btnEntradaLaser.ForeColor = Color.White;
            btnEntradaLaser.ImageAlign = ContentAlignment.MiddleRight;
            btnEntradaLaser.Location = new Point(570, 2);
            btnEntradaLaser.Margin = new Padding(3, 2, 3, 2);
            btnEntradaLaser.Name = "btnEntradaLaser";
            btnEntradaLaser.Size = new Size(60, 54);
            btnEntradaLaser.TabIndex = 56;
            btnEntradaLaser.TextAlign = ContentAlignment.BottomCenter;
            btnEntradaLaser.TextColor = Color.White;
            btnEntradaLaser.UseVisualStyleBackColor = false;
            // 
            // formVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 569);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel2);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "formVentas";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "formVentas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioVenta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioDeCompra;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btnCash;
        private Label lblTitulo;
        private TextBox txtIdCategoria;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private RJCodeAdvance.RJControls.RJButton btnEntradaManual;
        private RJCodeAdvance.RJControls.RJButton btnEntradaLaser;
        private ReaLTaiizor.Controls.MaterialCheckBox checkDescuento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private ReaLTaiizor.Controls.PoisonDataGridView ProductosDataGrid;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn DescripcionData;
        private DataGridViewTextBoxColumn PrecioVentaDataGrid;
        private DataGridViewTextBoxColumn StockDataGrid;
        private DataGridViewTextBoxColumn CantidadDataGrid;
        private DataGridViewTextBoxColumn TotalDataGrid;
        private DataGridViewImageColumn IncrementoCantidadDataGrid;
        private DataGridViewImageColumn DecrementoCantidadDataGrid;
        private DataGridViewImageColumn ImageProducto;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigoProducto;
        private RJCodeAdvance.RJControls.RJButton btnAgregarProducto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIva;
    }
}