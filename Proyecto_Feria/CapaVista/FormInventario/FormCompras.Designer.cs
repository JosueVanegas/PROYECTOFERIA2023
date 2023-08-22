using ReaLTaiizor;
namespace CapaVista.FormInventario
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnlContenedor = new Panel();
            pnlRegistroUsuario = new Panel();
            panel5 = new Panel();
            btnBuscarProducto = new RJCodeAdvance.RJControls.RJButton();
            btnAgregarProducto = new RJCodeAdvance.RJControls.RJButton();
            txtCodigoDeProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbDetalles = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEliminar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            IdProveedor = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardarCompra = new RJCodeAdvance.RJControls.RJButton();
            label2 = new Label();
            txtIdFactura = new TextBox();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNofactura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new Label();
            ckbEmpleadoNulo = new ReaLTaiizor.Controls.AirCheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtIdUsuario = new TextBox();
            panelBusqueda = new Panel();
            btnCerrarBusqueda = new Button();
            lblBuscar = new Label();
            txtBuscarProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscarProducto = new ReaLTaiizor.Controls.MaterialComboBox();
            tbBusqueda = new ReaLTaiizor.Controls.PoisonDataGridView();
            Añadir = new DataGridViewButtonColumn();
            IdP = new DataGridViewTextBoxColumn();
            CodigoP = new DataGridViewTextBoxColumn();
            NombreP = new DataGridViewTextBoxColumn();
            PrecioP = new DataGridViewTextBoxColumn();
            CantidadP = new DataGridViewTextBoxColumn();
            panelCompras = new Panel();
            lblEncabezado = new Label();
            panel2 = new Panel();
            cbxBuscarCompra = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBuscarCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbCompras = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1 = new Panel();
            IdCompra = new DataGridViewTextBoxColumn();
            NoFactura = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            pnlContenedor.SuspendLayout();
            pnlRegistroUsuario.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDetalles).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).BeginInit();
            panelCompras.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCompras).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(pnlRegistroUsuario);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(3, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(594, 447);
            pnlContenedor.TabIndex = 22;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.White;
            pnlRegistroUsuario.Controls.Add(panel5);
            pnlRegistroUsuario.Controls.Add(tbDetalles);
            pnlRegistroUsuario.Controls.Add(panel3);
            pnlRegistroUsuario.Controls.Add(lblTitulo);
            pnlRegistroUsuario.Controls.Add(ckbEmpleadoNulo);
            pnlRegistroUsuario.Controls.Add(tableLayoutPanel1);
            pnlRegistroUsuario.Controls.Add(txtIdUsuario);
            pnlRegistroUsuario.Dock = DockStyle.Fill;
            pnlRegistroUsuario.Location = new Point(0, 0);
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(594, 447);
            pnlRegistroUsuario.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBuscarProducto);
            panel5.Controls.Add(btnAgregarProducto);
            panel5.Controls.Add(txtCodigoDeProducto);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 394);
            panel5.Name = "panel5";
            panel5.Size = new Size(594, 49);
            panel5.TabIndex = 44;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.FromArgb(74, 121, 121);
            btnBuscarProducto.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnBuscarProducto.BackgroundImageLayout = ImageLayout.Center;
            btnBuscarProducto.BorderColor = Color.PaleVioletRed;
            btnBuscarProducto.BorderRadius = 10;
            btnBuscarProducto.BorderSize = 0;
            btnBuscarProducto.Dock = DockStyle.Left;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarProducto.Location = new Point(443, 0);
            btnBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(147, 49);
            btnBuscarProducto.TabIndex = 40;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.TextColor = Color.White;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(74, 121, 121);
            btnAgregarProducto.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.Center;
            btnAgregarProducto.BorderColor = Color.PaleVioletRed;
            btnAgregarProducto.BorderRadius = 10;
            btnAgregarProducto.BorderSize = 0;
            btnAgregarProducto.Dock = DockStyle.Left;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.ImageAlign = ContentAlignment.TopRight;
            btnAgregarProducto.Location = new Point(283, 0);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(160, 49);
            btnAgregarProducto.TabIndex = 39;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextColor = Color.White;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.AnimateReadOnly = true;
            txtCodigoDeProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigoDeProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigoDeProducto.BackgroundImageLayout = ImageLayout.None;
            txtCodigoDeProducto.CharacterCasing = CharacterCasing.Normal;
            txtCodigoDeProducto.Depth = 0;
            txtCodigoDeProducto.Dock = DockStyle.Left;
            txtCodigoDeProducto.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoDeProducto.HideSelection = true;
            txtCodigoDeProducto.Hint = "Ingrese codigo de producto ";
            txtCodigoDeProducto.LeadingIcon = null;
            txtCodigoDeProducto.Location = new Point(0, 0);
            txtCodigoDeProducto.MaxLength = 32767;
            txtCodigoDeProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.PasswordChar = '\0';
            txtCodigoDeProducto.PrefixSuffixText = null;
            txtCodigoDeProducto.ReadOnly = false;
            txtCodigoDeProducto.RightToLeft = RightToLeft.No;
            txtCodigoDeProducto.SelectedText = "";
            txtCodigoDeProducto.SelectionLength = 0;
            txtCodigoDeProducto.SelectionStart = 0;
            txtCodigoDeProducto.ShortcutsEnabled = true;
            txtCodigoDeProducto.Size = new Size(283, 48);
            txtCodigoDeProducto.TabIndex = 41;
            txtCodigoDeProducto.TabStop = false;
            txtCodigoDeProducto.TextAlign = HorizontalAlignment.Center;
            txtCodigoDeProducto.TrailingIcon = null;
            txtCodigoDeProducto.UseSystemPasswordChar = false;
            // 
            // tbDetalles
            // 
            tbDetalles.AllowUserToAddRows = false;
            tbDetalles.AllowUserToOrderColumns = true;
            tbDetalles.AllowUserToResizeRows = false;
            tbDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbDetalles.BackgroundColor = Color.White;
            tbDetalles.BorderStyle = BorderStyle.None;
            tbDetalles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbDetalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbDetalles.ColumnHeadersHeight = 35;
            tbDetalles.Columns.AddRange(new DataGridViewColumn[] { btnEliminar, Id, Codigo, Proveedor, Producto, Cantidad, PrecioCompra, Subtotal, IdProveedor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            tbDetalles.Dock = DockStyle.Top;
            tbDetalles.EnableHeadersVisualStyles = false;
            tbDetalles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDetalles.GridColor = Color.Gray;
            tbDetalles.Location = new Point(0, 188);
            tbDetalles.Name = "tbDetalles";
            tbDetalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbDetalles.RowHeadersVisible = false;
            tbDetalles.RowHeadersWidth = 40;
            tbDetalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbDetalles.RowTemplate.Height = 30;
            tbDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbDetalles.Size = new Size(594, 206);
            tbDetalles.TabIndex = 36;
            tbDetalles.CellContentClick += tbDetalles_CellContentClick;
            tbDetalles.CellPainting += tbDetalles_CellPainting;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ToolTipText = "eliminar";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "IdProveedor";
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(btnGuardarCompra);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtIdFactura);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(txtNofactura);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 156);
            panel3.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(456, 48);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 83);
            btnLimpiar.TabIndex = 40;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.Anchor = AnchorStyles.Left;
            btnGuardarCompra.BackColor = Color.FromArgb(74, 121, 121);
            btnGuardarCompra.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGuardarCompra.BackgroundImage = (Image)resources.GetObject("btnGuardarCompra.BackgroundImage");
            btnGuardarCompra.BackgroundImageLayout = ImageLayout.Center;
            btnGuardarCompra.BorderColor = Color.PaleVioletRed;
            btnGuardarCompra.BorderRadius = 10;
            btnGuardarCompra.BorderSize = 0;
            btnGuardarCompra.FlatAppearance.BorderSize = 0;
            btnGuardarCompra.FlatStyle = FlatStyle.Flat;
            btnGuardarCompra.ForeColor = Color.White;
            btnGuardarCompra.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarCompra.Location = new Point(309, 48);
            btnGuardarCompra.Margin = new Padding(3, 2, 3, 2);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(134, 83);
            btnGuardarCompra.TabIndex = 39;
            btnGuardarCompra.Text = "Guardar";
            btnGuardarCompra.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarCompra.TextColor = Color.White;
            btnGuardarCompra.UseVisualStyleBackColor = false;
            btnGuardarCompra.Click += btnGuardarCompra_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(234, 32);
            label2.TabIndex = 43;
            label2.Text = "Datos generales";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdFactura
            // 
            txtIdFactura.Location = new Point(255, 55);
            txtIdFactura.Name = "txtIdFactura";
            txtIdFactura.Size = new Size(28, 23);
            txtIdFactura.TabIndex = 42;
            txtIdFactura.Text = "1";
            txtIdFactura.Visible = false;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Left;
            txtTotal.AnimateReadOnly = true;
            txtTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "Total de compra";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(5, 105);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = false;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(234, 48);
            txtTotal.TabIndex = 41;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // txtNofactura
            // 
            txtNofactura.Anchor = AnchorStyles.Left;
            txtNofactura.AnimateReadOnly = true;
            txtNofactura.AutoCompleteMode = AutoCompleteMode.None;
            txtNofactura.AutoCompleteSource = AutoCompleteSource.None;
            txtNofactura.BackgroundImageLayout = ImageLayout.None;
            txtNofactura.CharacterCasing = CharacterCasing.Normal;
            txtNofactura.Depth = 0;
            txtNofactura.Enabled = false;
            txtNofactura.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNofactura.HideSelection = true;
            txtNofactura.Hint = "No. Factura";
            txtNofactura.LeadingIcon = null;
            txtNofactura.Location = new Point(5, 48);
            txtNofactura.MaxLength = 32767;
            txtNofactura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNofactura.Name = "txtNofactura";
            txtNofactura.PasswordChar = '\0';
            txtNofactura.PrefixSuffixText = null;
            txtNofactura.ReadOnly = false;
            txtNofactura.RightToLeft = RightToLeft.No;
            txtNofactura.SelectedText = "";
            txtNofactura.SelectionLength = 0;
            txtNofactura.SelectionStart = 0;
            txtNofactura.ShortcutsEnabled = true;
            txtNofactura.Size = new Size(234, 48);
            txtNofactura.TabIndex = 38;
            txtNofactura.TabStop = false;
            txtNofactura.TextAlign = HorizontalAlignment.Center;
            txtNofactura.TrailingIcon = null;
            txtNofactura.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(594, 32);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Registrar compras";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbEmpleadoNulo
            // 
            ckbEmpleadoNulo.Anchor = AnchorStyles.Left;
            ckbEmpleadoNulo.Checked = false;
            ckbEmpleadoNulo.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            ckbEmpleadoNulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbEmpleadoNulo.Image = null;
            ckbEmpleadoNulo.Location = new Point(13, 474);
            ckbEmpleadoNulo.Name = "ckbEmpleadoNulo";
            ckbEmpleadoNulo.NoRounding = false;
            ckbEmpleadoNulo.Size = new Size(234, 17);
            ckbEmpleadoNulo.TabIndex = 32;
            ckbEmpleadoNulo.Text = "Desactivar empleados";
            ckbEmpleadoNulo.Transparent = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(49, 494);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(152, 70);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Left;
            rjButton2.BackColor = Color.FromArgb(63, 63, 70);
            rjButton2.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton2.BackgroundImage = (Image)resources.GetObject("rjButton2.BackgroundImage");
            rjButton2.BackgroundImageLayout = ImageLayout.Center;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.ImageAlign = ContentAlignment.MiddleRight;
            rjButton2.Location = new Point(78, 2);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(71, 66);
            rjButton2.TabIndex = 12;
            rjButton2.Text = "Limpiar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
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
            btnGuardar.Size = new Size(69, 66);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Anchor = AnchorStyles.Left;
            txtIdUsuario.Location = new Point(265, 532);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(16, 23);
            txtIdUsuario.TabIndex = 8;
            txtIdUsuario.Visible = false;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(btnCerrarBusqueda);
            panelBusqueda.Controls.Add(lblBuscar);
            panelBusqueda.Controls.Add(txtBuscarProducto);
            panelBusqueda.Controls.Add(cbxBuscarProducto);
            panelBusqueda.Controls.Add(tbBusqueda);
            panelBusqueda.Dock = DockStyle.Fill;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(429, 447);
            panelBusqueda.TabIndex = 56;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = Color.Red;
            btnCerrarBusqueda.Dock = DockStyle.Top;
            btnCerrarBusqueda.Image = (Image)resources.GetObject("btnCerrarBusqueda.Image");
            btnCerrarBusqueda.Location = new Point(0, 0);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(429, 56);
            btnCerrarBusqueda.TabIndex = 62;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
            btnCerrarBusqueda.Click += btnCerrarBusqueda_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Bottom;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, 70);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(429, 59);
            lblBuscar.TabIndex = 42;
            lblBuscar.Text = "Buscar";
            lblBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.AnimateReadOnly = false;
            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscarProducto.BackgroundImageLayout = ImageLayout.None;
            txtBuscarProducto.CharacterCasing = CharacterCasing.Normal;
            txtBuscarProducto.Depth = 0;
            txtBuscarProducto.Dock = DockStyle.Bottom;
            txtBuscarProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProducto.HideSelection = true;
            txtBuscarProducto.Hint = "Buscar";
            txtBuscarProducto.LeadingIcon = null;
            txtBuscarProducto.Location = new Point(0, 129);
            txtBuscarProducto.MaxLength = 32767;
            txtBuscarProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PasswordChar = '\0';
            txtBuscarProducto.PrefixSuffixText = null;
            txtBuscarProducto.ReadOnly = false;
            txtBuscarProducto.RightToLeft = RightToLeft.No;
            txtBuscarProducto.SelectedText = "";
            txtBuscarProducto.SelectionLength = 0;
            txtBuscarProducto.SelectionStart = 0;
            txtBuscarProducto.ShortcutsEnabled = true;
            txtBuscarProducto.Size = new Size(429, 48);
            txtBuscarProducto.TabIndex = 63;
            txtBuscarProducto.TabStop = false;
            txtBuscarProducto.TextAlign = HorizontalAlignment.Left;
            txtBuscarProducto.TrailingIcon = null;
            txtBuscarProducto.UseSystemPasswordChar = false;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // cbxBuscarProducto
            // 
            cbxBuscarProducto.AutoResize = false;
            cbxBuscarProducto.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscarProducto.Depth = 0;
            cbxBuscarProducto.Dock = DockStyle.Bottom;
            cbxBuscarProducto.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscarProducto.DropDownHeight = 174;
            cbxBuscarProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarProducto.DropDownWidth = 121;
            cbxBuscarProducto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscarProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscarProducto.FormattingEnabled = true;
            cbxBuscarProducto.Hint = "Buscar producto";
            cbxBuscarProducto.IntegralHeight = false;
            cbxBuscarProducto.ItemHeight = 43;
            cbxBuscarProducto.Items.AddRange(new object[] { "Codigo", "Nombre" });
            cbxBuscarProducto.Location = new Point(0, 177);
            cbxBuscarProducto.MaxDropDownItems = 4;
            cbxBuscarProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscarProducto.Name = "cbxBuscarProducto";
            cbxBuscarProducto.Size = new Size(429, 49);
            cbxBuscarProducto.StartIndex = 0;
            cbxBuscarProducto.TabIndex = 60;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbBusqueda.ColumnHeadersHeight = 35;
            tbBusqueda.Columns.AddRange(new DataGridViewColumn[] { Añadir, IdP, CodigoP, NombreP, PrecioP, CantidadP });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            tbBusqueda.DefaultCellStyle = dataGridViewCellStyle5;
            tbBusqueda.Dock = DockStyle.Bottom;
            tbBusqueda.EnableHeadersVisualStyles = false;
            tbBusqueda.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBusqueda.GridColor = Color.Gray;
            tbBusqueda.Location = new Point(0, 226);
            tbBusqueda.Name = "tbBusqueda";
            tbBusqueda.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbBusqueda.RowHeadersVisible = false;
            tbBusqueda.RowHeadersWidth = 40;
            tbBusqueda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbBusqueda.RowTemplate.Height = 30;
            tbBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbBusqueda.Size = new Size(429, 221);
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
            NombreP.Width = 120;
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
            CantidadP.Resizable = DataGridViewTriState.True;
            CantidadP.Width = 60;
            // 
            // panelCompras
            // 
            panelCompras.BackColor = Color.LightGray;
            panelCompras.Controls.Add(lblEncabezado);
            panelCompras.Controls.Add(panel2);
            panelCompras.Controls.Add(tbCompras);
            panelCompras.Dock = DockStyle.Fill;
            panelCompras.Location = new Point(0, 0);
            panelCompras.Name = "panelCompras";
            panelCompras.Size = new Size(429, 447);
            panelCompras.TabIndex = 23;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Top;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(429, 41);
            lblEncabezado.TabIndex = 23;
            lblEncabezado.Text = "Compras realizadas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxBuscarCompra);
            panel2.Controls.Add(txtBuscarCompra);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 62);
            panel2.TabIndex = 26;
            // 
            // cbxBuscarCompra
            // 
            cbxBuscarCompra.AutoResize = false;
            cbxBuscarCompra.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscarCompra.Depth = 0;
            cbxBuscarCompra.Dock = DockStyle.Left;
            cbxBuscarCompra.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscarCompra.DropDownHeight = 174;
            cbxBuscarCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarCompra.DropDownWidth = 121;
            cbxBuscarCompra.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscarCompra.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscarCompra.FormattingEnabled = true;
            cbxBuscarCompra.Hint = "buscar por";
            cbxBuscarCompra.IntegralHeight = false;
            cbxBuscarCompra.ItemHeight = 43;
            cbxBuscarCompra.Items.AddRange(new object[] { "id", "usuario", "rol", "fecha" });
            cbxBuscarCompra.Location = new Point(292, 0);
            cbxBuscarCompra.MaxDropDownItems = 4;
            cbxBuscarCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscarCompra.Name = "cbxBuscarCompra";
            cbxBuscarCompra.Size = new Size(108, 49);
            cbxBuscarCompra.StartIndex = 0;
            cbxBuscarCompra.TabIndex = 24;
            // 
            // txtBuscarCompra
            // 
            txtBuscarCompra.AnimateReadOnly = true;
            txtBuscarCompra.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscarCompra.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscarCompra.BackgroundImageLayout = ImageLayout.None;
            txtBuscarCompra.CharacterCasing = CharacterCasing.Normal;
            txtBuscarCompra.Depth = 0;
            txtBuscarCompra.Dock = DockStyle.Left;
            txtBuscarCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCompra.HideSelection = true;
            txtBuscarCompra.Hint = "Buscar";
            txtBuscarCompra.LeadingIcon = null;
            txtBuscarCompra.Location = new Point(0, 0);
            txtBuscarCompra.MaxLength = 32767;
            txtBuscarCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscarCompra.Name = "txtBuscarCompra";
            txtBuscarCompra.PasswordChar = '\0';
            txtBuscarCompra.PrefixSuffixText = null;
            txtBuscarCompra.ReadOnly = false;
            txtBuscarCompra.RightToLeft = RightToLeft.No;
            txtBuscarCompra.SelectedText = "";
            txtBuscarCompra.SelectionLength = 0;
            txtBuscarCompra.SelectionStart = 0;
            txtBuscarCompra.ShortcutsEnabled = true;
            txtBuscarCompra.Size = new Size(292, 48);
            txtBuscarCompra.TabIndex = 25;
            txtBuscarCompra.TabStop = false;
            txtBuscarCompra.TextAlign = HorizontalAlignment.Center;
            txtBuscarCompra.TrailingIcon = null;
            txtBuscarCompra.UseSystemPasswordChar = false;
            // 
            // tbCompras
            // 
            tbCompras.AllowUserToAddRows = false;
            tbCompras.AllowUserToOrderColumns = true;
            tbCompras.AllowUserToResizeRows = false;
            tbCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbCompras.BackgroundColor = Color.White;
            tbCompras.BorderStyle = BorderStyle.None;
            tbCompras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            tbCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            tbCompras.ColumnHeadersHeight = 35;
            tbCompras.Columns.AddRange(new DataGridViewColumn[] { IdCompra, NoFactura, IdUsuario, NombreUsuario, Total });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.DarkGray;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            tbCompras.DefaultCellStyle = dataGridViewCellStyle8;
            tbCompras.Dock = DockStyle.Bottom;
            tbCompras.EnableHeadersVisualStyles = false;
            tbCompras.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCompras.GridColor = Color.Gray;
            tbCompras.Location = new Point(0, 124);
            tbCompras.Name = "tbCompras";
            tbCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Silver;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            tbCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            tbCompras.RowHeadersVisible = false;
            tbCompras.RowHeadersWidth = 40;
            tbCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCompras.RowTemplate.Height = 30;
            tbCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCompras.Size = new Size(429, 323);
            tbCompras.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelCompras);
            panel1.Controls.Add(panelBusqueda);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(597, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 447);
            panel1.TabIndex = 24;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "IdCompra";
            IdCompra.Name = "IdCompra";
            IdCompra.ReadOnly = true;
            IdCompra.Visible = false;
            IdCompra.Width = 10;
            // 
            // NoFactura
            // 
            NoFactura.HeaderText = "No. Factura";
            NoFactura.Name = "NoFactura";
            NoFactura.ReadOnly = true;
            NoFactura.Width = 150;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdUsuario.Visible = false;
            IdUsuario.Width = 150;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "Recibida por";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 200;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormCompras";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormCompras";
            Load += FormCompras_Load;
            pnlContenedor.ResumeLayout(false);
            pnlRegistroUsuario.ResumeLayout(false);
            pnlRegistroUsuario.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbDetalles).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            panelCompras.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCompras).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOpciones;
        private Panel pnlContenedor;
        private Panel pnlRegistroUsuario;
        private ReaLTaiizor.Controls.AirCheckBox ckbEmpleadoNulo;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private TextBox txtIdUsuario;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.PoisonDataGridView tbDetalles;
        private Panel panelBusqueda;
        private Button btnCerrarBusqueda;
        private Label lblBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscarProducto;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscarProducto;
        private ReaLTaiizor.Controls.PoisonDataGridView tbBusqueda;
        private Panel panelCompras;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscarCompra;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscarCompra;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCompras;
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnAgregarProducto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigoDeProducto;
        private RJCodeAdvance.RJControls.RJButton btnBuscarProducto;
        private Panel panel2;
        private DataGridViewButtonColumn Añadir;
        private DataGridViewTextBoxColumn IdP;
        private DataGridViewTextBoxColumn CodigoP;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn PrecioP;
        private DataGridViewTextBoxColumn CantidadP;
        private Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardarCompra;
        private Label label2;
        private TextBox txtIdFactura;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNofactura;
        private Panel panel5;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn NoFactura;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Total;
    }
}