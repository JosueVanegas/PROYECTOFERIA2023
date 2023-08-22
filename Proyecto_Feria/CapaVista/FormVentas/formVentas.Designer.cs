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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtPrecioVenta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioDeCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            txtSubTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnFacturar = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            panelContenedorIzquierdo = new Panel();
            panelBusqueda = new Panel();
            btnCerrarBusqueda = new Button();
            lblBuscar = new Label();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            tbBusqueda = new ReaLTaiizor.Controls.PoisonDataGridView();
            Añadir = new DataGridViewButtonColumn();
            Img = new DataGridViewImageColumn();
            IdP = new DataGridViewTextBoxColumn();
            CodigoP = new DataGridViewTextBoxColumn();
            NombreP = new DataGridViewTextBoxColumn();
            PrecioP = new DataGridViewTextBoxColumn();
            CantidadP = new DataGridViewTextBoxColumn();
            panelDetalleVenta = new Panel();
            nbrDescuento = new NumericUpDown();
            txtTotalFinal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescuento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEcabezadoIzquierdo = new Label();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIva = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            checkDescuento = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtCodigoProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAgregarProducto = new RJCodeAdvance.RJControls.RJButton();
            btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelContenedor = new Panel();
            tbResumen = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnVer = new DataGridViewButtonColumn();
            btnQuitar = new DataGridViewButtonColumn();
            Imagen = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblStock = new Label();
            lblSubTotal = new Label();
            label1 = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            pktProducto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelContenedorIzquierdo.SuspendLayout();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).BeginInit();
            panelDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrDescuento).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbResumen).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pktProducto).BeginInit();
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
            // txtSubTotal
            // 
            txtSubTotal.AnimateReadOnly = true;
            txtSubTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtSubTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtSubTotal.BackgroundImageLayout = ImageLayout.None;
            txtSubTotal.CharacterCasing = CharacterCasing.Normal;
            txtSubTotal.Depth = 0;
            txtSubTotal.Enabled = false;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.HideSelection = true;
            txtSubTotal.Hint = "Subtotal";
            txtSubTotal.LeadingIcon = null;
            txtSubTotal.Location = new Point(15, 105);
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
            tableLayoutPanel2.Controls.Add(btnFacturar, 0, 0);
            tableLayoutPanel2.Location = new Point(21, 436);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(263, 83);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(63, 63, 70);
            btnFacturar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnFacturar.BackgroundImageLayout = ImageLayout.Center;
            btnFacturar.BorderColor = Color.PaleVioletRed;
            btnFacturar.BorderRadius = 10;
            btnFacturar.BorderSize = 0;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Image = (Image)resources.GetObject("btnFacturar.Image");
            btnFacturar.Location = new Point(3, 2);
            btnFacturar.Margin = new Padding(3, 2, 3, 2);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(257, 79);
            btnFacturar.TabIndex = 12;
            btnFacturar.Text = "Facturar";
            btnFacturar.TextAlign = ContentAlignment.BottomCenter;
            btnFacturar.TextColor = Color.White;
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnCash_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(63, 63, 70);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(758, 58);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Vender productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenedorIzquierdo
            // 
            panelContenedorIzquierdo.BackColor = Color.White;
            panelContenedorIzquierdo.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenedorIzquierdo.Controls.Add(panelDetalleVenta);
            panelContenedorIzquierdo.Controls.Add(panelBusqueda);
            panelContenedorIzquierdo.Dock = DockStyle.Right;
            panelContenedorIzquierdo.Location = new Point(773, 0);
            panelContenedorIzquierdo.Name = "panelContenedorIzquierdo";
            panelContenedorIzquierdo.Size = new Size(319, 566);
            panelContenedorIzquierdo.TabIndex = 50;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(btnCerrarBusqueda);
            panelBusqueda.Controls.Add(lblBuscar);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(cbxBuscar);
            panelBusqueda.Controls.Add(tbBusqueda);
            panelBusqueda.Dock = DockStyle.Fill;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(319, 566);
            panelBusqueda.TabIndex = 55;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = Color.Red;
            btnCerrarBusqueda.Dock = DockStyle.Bottom;
            btnCerrarBusqueda.Image = (Image)resources.GetObject("btnCerrarBusqueda.Image");
            btnCerrarBusqueda.Location = new Point(0, 30);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(319, 41);
            btnCerrarBusqueda.TabIndex = 62;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
            btnCerrarBusqueda.Click += btnCerrarBusqueda_Click_1;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Bottom;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, 71);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(319, 59);
            lblBuscar.TabIndex = 42;
            lblBuscar.Text = "Buscar";
            lblBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.CharacterCasing = CharacterCasing.Normal;
            txtBuscar.Depth = 0;
            txtBuscar.Dock = DockStyle.Bottom;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(0, 130);
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
            txtBuscar.Size = new Size(319, 48);
            txtBuscar.TabIndex = 63;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cbxBuscar
            // 
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.Dock = DockStyle.Bottom;
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
            cbxBuscar.Items.AddRange(new object[] { "Codigo", "Nombre", "Precio" });
            cbxBuscar.Location = new Point(0, 178);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(319, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 60;
            // 
            // tbBusqueda
            // 
            tbBusqueda.AllowUserToAddRows = false;
            tbBusqueda.AllowUserToOrderColumns = true;
            tbBusqueda.AllowUserToResizeRows = false;
            tbBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbBusqueda.BackgroundColor = Color.White;
            tbBusqueda.BorderStyle = BorderStyle.None;
            tbBusqueda.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbBusqueda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbBusqueda.ColumnHeadersHeight = 35;
            tbBusqueda.Columns.AddRange(new DataGridViewColumn[] { Añadir, Img, IdP, CodigoP, NombreP, PrecioP, CantidadP });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            tbBusqueda.Dock = DockStyle.Bottom;
            tbBusqueda.EnableHeadersVisualStyles = false;
            tbBusqueda.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBusqueda.GridColor = Color.Gray;
            tbBusqueda.Location = new Point(0, 227);
            tbBusqueda.Name = "tbBusqueda";
            tbBusqueda.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbBusqueda.RowHeadersVisible = false;
            tbBusqueda.RowHeadersWidth = 40;
            tbBusqueda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbBusqueda.RowTemplate.Height = 30;
            tbBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbBusqueda.Size = new Size(319, 339);
            tbBusqueda.TabIndex = 55;
            tbBusqueda.CellContentClick += tbBusqueda_CellContentClick;
            tbBusqueda.CellPainting += tbBusqueda_CellPainting;
            // 
            // Añadir
            // 
            Añadir.HeaderText = "Añadir";
            Añadir.Name = "Añadir";
            Añadir.Width = 50;
            // 
            // Img
            // 
            Img.HeaderText = "Imagen";
            Img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Img.Name = "Img";
            Img.ReadOnly = true;
            Img.Resizable = DataGridViewTriState.False;
            Img.Visible = false;
            Img.Width = 50;
            // 
            // IdP
            // 
            IdP.HeaderText = "Id";
            IdP.Name = "IdP";
            IdP.ReadOnly = true;
            IdP.Visible = false;
            IdP.Width = 10;
            // 
            // CodigoP
            // 
            CodigoP.HeaderText = "Codigo";
            CodigoP.Name = "CodigoP";
            CodigoP.ReadOnly = true;
            CodigoP.Width = 120;
            // 
            // NombreP
            // 
            NombreP.HeaderText = "producto";
            NombreP.Name = "NombreP";
            NombreP.ReadOnly = true;
            // 
            // PrecioP
            // 
            PrecioP.HeaderText = "Precio";
            PrecioP.Name = "PrecioP";
            PrecioP.ReadOnly = true;
            PrecioP.Width = 80;
            // 
            // CantidadP
            // 
            CantidadP.HeaderText = "Cantidad";
            CantidadP.Name = "CantidadP";
            CantidadP.ReadOnly = true;
            CantidadP.Visible = false;
            CantidadP.Width = 60;
            // 
            // panelDetalleVenta
            // 
            panelDetalleVenta.Controls.Add(nbrDescuento);
            panelDetalleVenta.Controls.Add(txtTotalFinal);
            panelDetalleVenta.Controls.Add(txtDescuento);
            panelDetalleVenta.Controls.Add(lblEcabezadoIzquierdo);
            panelDetalleVenta.Controls.Add(tableLayoutPanel2);
            panelDetalleVenta.Controls.Add(txtTotal);
            panelDetalleVenta.Controls.Add(txtIva);
            panelDetalleVenta.Controls.Add(checkDescuento);
            panelDetalleVenta.Controls.Add(txtSubTotal);
            panelDetalleVenta.Dock = DockStyle.Fill;
            panelDetalleVenta.Location = new Point(0, 0);
            panelDetalleVenta.Name = "panelDetalleVenta";
            panelDetalleVenta.Size = new Size(319, 566);
            panelDetalleVenta.TabIndex = 55;
            // 
            // nbrDescuento
            // 
            nbrDescuento.Enabled = false;
            nbrDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbrDescuento.Location = new Point(15, 323);
            nbrDescuento.Name = "nbrDescuento";
            nbrDescuento.Size = new Size(83, 29);
            nbrDescuento.TabIndex = 67;
            nbrDescuento.ValueChanged += nbrDescuento_ValueChanged;
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.AnimateReadOnly = true;
            txtTotalFinal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotalFinal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotalFinal.BackgroundImageLayout = ImageLayout.None;
            txtTotalFinal.CharacterCasing = CharacterCasing.Normal;
            txtTotalFinal.Depth = 0;
            txtTotalFinal.Enabled = false;
            txtTotalFinal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalFinal.HideSelection = true;
            txtTotalFinal.Hint = "Total a pagar";
            txtTotalFinal.LeadingIcon = null;
            txtTotalFinal.Location = new Point(15, 360);
            txtTotalFinal.MaxLength = 32767;
            txtTotalFinal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.PasswordChar = '\0';
            txtTotalFinal.PrefixSuffixText = null;
            txtTotalFinal.ReadOnly = true;
            txtTotalFinal.RightToLeft = RightToLeft.No;
            txtTotalFinal.SelectedText = "";
            txtTotalFinal.SelectionLength = 0;
            txtTotalFinal.SelectionStart = 0;
            txtTotalFinal.ShortcutsEnabled = true;
            txtTotalFinal.Size = new Size(263, 48);
            txtTotalFinal.TabIndex = 66;
            txtTotalFinal.TabStop = false;
            txtTotalFinal.TextAlign = HorizontalAlignment.Center;
            txtTotalFinal.TrailingIcon = null;
            txtTotalFinal.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = true;
            txtDescuento.AutoCompleteMode = AutoCompleteMode.None;
            txtDescuento.AutoCompleteSource = AutoCompleteSource.None;
            txtDescuento.BackgroundImageLayout = ImageLayout.None;
            txtDescuento.CharacterCasing = CharacterCasing.Normal;
            txtDescuento.Depth = 0;
            txtDescuento.Enabled = false;
            txtDescuento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.HideSelection = true;
            txtDescuento.Hint = "Descuento";
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(15, 266);
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PrefixSuffixText = null;
            txtDescuento.ReadOnly = true;
            txtDescuento.RightToLeft = RightToLeft.No;
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.ShortcutsEnabled = true;
            txtDescuento.Size = new Size(260, 48);
            txtDescuento.TabIndex = 65;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
            // 
            // lblEcabezadoIzquierdo
            // 
            lblEcabezadoIzquierdo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEcabezadoIzquierdo.ForeColor = SystemColors.ControlDarkDark;
            lblEcabezadoIzquierdo.Location = new Point(21, 16);
            lblEcabezadoIzquierdo.Name = "lblEcabezadoIzquierdo";
            lblEcabezadoIzquierdo.Size = new Size(263, 53);
            lblEcabezadoIzquierdo.TabIndex = 54;
            lblEcabezadoIzquierdo.Text = "Informacion de venta";
            lblEcabezadoIzquierdo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = true;
            txtTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "Total antes de descuento";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(15, 212);
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
            // txtIva
            // 
            txtIva.AnimateReadOnly = true;
            txtIva.AutoCompleteMode = AutoCompleteMode.None;
            txtIva.AutoCompleteSource = AutoCompleteSource.None;
            txtIva.BackgroundImageLayout = ImageLayout.None;
            txtIva.CharacterCasing = CharacterCasing.Normal;
            txtIva.Depth = 0;
            txtIva.Enabled = false;
            txtIva.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIva.HideSelection = true;
            txtIva.Hint = "Iva";
            txtIva.LeadingIcon = null;
            txtIva.Location = new Point(15, 159);
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
            // checkDescuento
            // 
            checkDescuento.AutoSize = true;
            checkDescuento.Depth = 0;
            checkDescuento.Location = new Point(110, 320);
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
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(panelContenedor, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 21.955719F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 78.04428F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(770, 566);
            tableLayoutPanel3.TabIndex = 52;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel2);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 118);
            panel3.TabIndex = 53;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtCodigoProducto);
            flowLayoutPanel2.Controls.Add(btnAgregarProducto);
            flowLayoutPanel2.Controls.Add(btnBuscar);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel2.Location = new Point(0, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(764, 54);
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
            txtCodigoProducto.Hint = "Ingrese o escaneé el codigo del  producto";
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
            txtCodigoProducto.Size = new Size(406, 48);
            txtCodigoProducto.TabIndex = 49;
            txtCodigoProducto.TabStop = false;
            txtCodigoProducto.TextAlign = HorizontalAlignment.Center;
            txtCodigoProducto.TrailingIcon = null;
            txtCodigoProducto.UseSystemPasswordChar = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(74, 121, 121);
            btnAgregarProducto.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.None;
            btnAgregarProducto.BorderColor = Color.PaleVioletRed;
            btnAgregarProducto.BorderRadius = 10;
            btnAgregarProducto.BorderSize = 0;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Image = (Image)resources.GetObject("btnAgregarProducto.Image");
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(415, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(177, 48);
            btnAgregarProducto.TabIndex = 50;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarProducto.TextColor = Color.White;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(74, 121, 121);
            btnBuscar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.BorderColor = Color.PaleVioletRed;
            btnBuscar.BorderRadius = 10;
            btnBuscar.BorderSize = 0;
            btnBuscar.Dock = DockStyle.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(598, 2);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(163, 50);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "Buscar producto";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextColor = Color.White;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTitulo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(764, 61);
            flowLayoutPanel1.TabIndex = 52;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(tbResumen);
            panelContenedor.Controls.Add(panel2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(3, 127);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(764, 436);
            panelContenedor.TabIndex = 54;
            // 
            // tbResumen
            // 
            tbResumen.AllowUserToAddRows = false;
            tbResumen.AllowUserToOrderColumns = true;
            tbResumen.AllowUserToResizeRows = false;
            tbResumen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbResumen.BackgroundColor = Color.White;
            tbResumen.BorderStyle = BorderStyle.None;
            tbResumen.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbResumen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbResumen.ColumnHeadersHeight = 35;
            tbResumen.Columns.AddRange(new DataGridViewColumn[] { btnVer, btnQuitar, Imagen, Id, Codigo, Nombre, PrecioVenta, Cantidad, SubTotal, Stock });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            tbResumen.DefaultCellStyle = dataGridViewCellStyle5;
            tbResumen.EnableHeadersVisualStyles = false;
            tbResumen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbResumen.GridColor = Color.Gray;
            tbResumen.Location = new Point(0, 169);
            tbResumen.Name = "tbResumen";
            tbResumen.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbResumen.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbResumen.RowHeadersVisible = false;
            tbResumen.RowHeadersWidth = 40;
            tbResumen.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbResumen.RowTemplate.Height = 30;
            tbResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbResumen.Size = new Size(764, 248);
            tbResumen.TabIndex = 54;
            tbResumen.CellContentClick += tbResumen_CellContentClick;
            tbResumen.CellPainting += tbResumen_CellPainting;
            // 
            // btnVer
            // 
            btnVer.HeaderText = "Detalles";
            btnVer.Name = "btnVer";
            btnVer.ReadOnly = true;
            btnVer.Width = 50;
            // 
            // btnQuitar
            // 
            btnQuitar.HeaderText = "Eliminar";
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Width = 50;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            Imagen.Width = 150;
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
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 130;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 50;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStock);
            panel2.Controls.Add(lblSubTotal);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblCantidad);
            panel2.Controls.Add(lblPrecio);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(lblCodigo);
            panel2.Controls.Add(pktProducto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 170);
            panel2.TabIndex = 55;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(166, 127);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(304, 37);
            lblStock.TabIndex = 7;
            lblStock.Text = "Cantidad en inventario:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(476, 129);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(285, 37);
            lblSubTotal.TabIndex = 6;
            lblSubTotal.Text = "SubTotal: ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 4);
            label1.Name = "label1";
            label1.Size = new Size(595, 49);
            label1.TabIndex = 5;
            label1.Text = "Detalles";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            lblCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(476, 53);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(285, 37);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad ordenada:";
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(476, 91);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(285, 37);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio unitario:";
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(166, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(304, 37);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.Location = new Point(166, 53);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(304, 37);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo: ";
            // 
            // pktProducto
            // 
            pktProducto.Location = new Point(3, 4);
            pktProducto.Name = "pktProducto";
            pktProducto.Size = new Size(160, 160);
            pktProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pktProducto.TabIndex = 0;
            pktProducto.TabStop = false;
            // 
            // formVentas
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1095, 569);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panelContenedorIzquierdo);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formVentas";
            Padding = new Padding(3, 0, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            Text = "formVentas";
            WindowState = FormWindowState.Maximized;
            Load += formVentas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panelContenedorIzquierdo.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            panelDetalleVenta.ResumeLayout(false);
            panelDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrDescuento).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbResumen).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pktProducto).EndInit();
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btnFacturar;
        private Label lblTitulo;
        private TextBox txtIdCategoria;
        private Panel panelContenedorIzquierdo;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private ReaLTaiizor.Controls.MaterialCheckBox checkDescuento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigoProducto;
        private RJCodeAdvance.RJControls.RJButton btnAgregarProducto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIva;
        private Label lblEcabezadoIzquierdo;
        private ReaLTaiizor.Controls.PoisonDataGridView tbResumen;
        private Panel panelContenedor;
        private Panel panelDetalleVenta;
        private Panel panel2;
        private Label lblCodigo;
        private PictureBox pktProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblSubTotal;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalFinal;
        private NumericUpDown nbrDescuento;
        private Label lblStock;
        private Panel panelBusqueda;
        private Button btnCerrarBusqueda;
        private Label lblBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private ReaLTaiizor.Controls.PoisonDataGridView tbBusqueda;
        private DataGridViewButtonColumn Añadir;
        private DataGridViewImageColumn Img;
        private DataGridViewTextBoxColumn IdP;
        private DataGridViewTextBoxColumn CodigoP;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn PrecioP;
        private DataGridViewTextBoxColumn CantidadP;
        private DataGridViewButtonColumn btnVer;
        private DataGridViewButtonColumn btnQuitar;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Stock;
    }
}