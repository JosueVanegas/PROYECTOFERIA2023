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
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            pictureBox4 = new PictureBox();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            label2 = new Label();
            txtIdFactura = new TextBox();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNofactura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new Label();
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
            IdCompra = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pnlContenedor.SuspendLayout();
            pnlRegistroUsuario.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDetalles).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            pnlContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(680, 808);
            pnlContenedor.TabIndex = 22;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.White;
            pnlRegistroUsuario.Controls.Add(panel5);
            pnlRegistroUsuario.Controls.Add(tbDetalles);
            pnlRegistroUsuario.Controls.Add(panel3);
            pnlRegistroUsuario.Controls.Add(lblTitulo);
            pnlRegistroUsuario.Controls.Add(txtIdUsuario);
            pnlRegistroUsuario.Dock = DockStyle.Fill;
            pnlRegistroUsuario.Location = new Point(0, 0);
            pnlRegistroUsuario.Margin = new Padding(3, 4, 3, 4);
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(680, 808);
            pnlRegistroUsuario.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBuscarProducto);
            panel5.Controls.Add(btnAgregarProducto);
            panel5.Controls.Add(txtCodigoDeProducto);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 518);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(680, 65);
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
            btnBuscarProducto.Location = new Point(506, 0);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(168, 65);
            btnBuscarProducto.TabIndex = 40;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.TextColor = Color.White;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            btnBuscarProducto.MouseHover += btnBuscarProducto_MouseHover;
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
            btnAgregarProducto.Location = new Point(323, 0);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(183, 65);
            btnAgregarProducto.TabIndex = 39;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextColor = Color.White;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            btnAgregarProducto.MouseHover += btnAgregarProducto_MouseHover;
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
            txtCodigoDeProducto.Margin = new Padding(3, 4, 3, 4);
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
            txtCodigoDeProducto.Size = new Size(323, 48);
            txtCodigoDeProducto.TabIndex = 41;
            txtCodigoDeProducto.TabStop = false;
            txtCodigoDeProducto.TextAlign = HorizontalAlignment.Center;
            txtCodigoDeProducto.TrailingIcon = null;
            txtCodigoDeProducto.UseSystemPasswordChar = false;
            txtCodigoDeProducto.KeyPress += txtCodigoDeProducto_KeyPress;
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
            tbDetalles.Location = new Point(0, 251);
            tbDetalles.Margin = new Padding(3, 4, 3, 4);
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
            tbDetalles.Size = new Size(680, 267);
            tbDetalles.TabIndex = 36;
            tbDetalles.CellContentClick += tbDetalles_CellContentClick;
            tbDetalles.CellPainting += tbDetalles_CellPainting;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ToolTipText = "eliminar";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "IdProveedor";
            IdProveedor.MinimumWidth = 6;
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtIdFactura);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(txtNofactura);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 43);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 208);
            panel3.TabIndex = 42;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(237, 47);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 71);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardarCompra_Click;
            btnGuardar.MouseHover += btnGuardar_MouseHover;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(623, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += lblTitulo_MouseHover;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(237, 123);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 71);
            btnLimpiar.TabIndex = 40;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 43);
            label2.TabIndex = 43;
            label2.Text = "Datos generales";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdFactura
            // 
            txtIdFactura.Location = new Point(546, 12);
            txtIdFactura.Margin = new Padding(3, 4, 3, 4);
            txtIdFactura.Name = "txtIdFactura";
            txtIdFactura.Size = new Size(31, 27);
            txtIdFactura.TabIndex = 42;
            txtIdFactura.Text = "0";
            txtIdFactura.Visible = false;
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
            txtTotal.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "Total de compra";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(6, 129);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
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
            txtTotal.Size = new Size(173, 48);
            txtTotal.TabIndex = 41;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // txtNofactura
            // 
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
            txtNofactura.Location = new Point(6, 47);
            txtNofactura.Margin = new Padding(3, 4, 3, 4);
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
            txtNofactura.Size = new Size(173, 48);
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
            lblTitulo.Size = new Size(680, 43);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Registrar compras";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Anchor = AnchorStyles.Left;
            txtIdUsuario.Location = new Point(303, 816);
            txtIdUsuario.Margin = new Padding(3, 4, 3, 4);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(18, 27);
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
            panelBusqueda.Margin = new Padding(3, 4, 3, 4);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(490, 808);
            panelBusqueda.TabIndex = 56;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = Color.Red;
            btnCerrarBusqueda.Dock = DockStyle.Top;
            btnCerrarBusqueda.Image = (Image)resources.GetObject("btnCerrarBusqueda.Image");
            btnCerrarBusqueda.Location = new Point(0, 0);
            btnCerrarBusqueda.Margin = new Padding(3, 4, 3, 4);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(490, 75);
            btnCerrarBusqueda.TabIndex = 62;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
            btnCerrarBusqueda.Click += btnCerrarBusqueda_Click;
            btnCerrarBusqueda.MouseHover += btnCerrarBusqueda_MouseHover;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Bottom;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, 337);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(490, 79);
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
            txtBuscarProducto.Location = new Point(0, 416);
            txtBuscarProducto.Margin = new Padding(3, 4, 3, 4);
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
            txtBuscarProducto.Size = new Size(490, 48);
            txtBuscarProducto.TabIndex = 63;
            txtBuscarProducto.TabStop = false;
            txtBuscarProducto.TextAlign = HorizontalAlignment.Left;
            txtBuscarProducto.TrailingIcon = null;
            txtBuscarProducto.UseSystemPasswordChar = false;
            txtBuscarProducto.KeyPress += txtBuscarProducto_KeyPress;
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
            cbxBuscarProducto.Location = new Point(0, 464);
            cbxBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            cbxBuscarProducto.MaxDropDownItems = 4;
            cbxBuscarProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscarProducto.Name = "cbxBuscarProducto";
            cbxBuscarProducto.Size = new Size(490, 49);
            cbxBuscarProducto.StartIndex = 0;
            cbxBuscarProducto.TabIndex = 60;
            cbxBuscarProducto.MouseHover += cbxBuscarProducto_MouseHover;
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
            tbBusqueda.Location = new Point(0, 513);
            tbBusqueda.Margin = new Padding(3, 4, 3, 4);
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
            tbBusqueda.Size = new Size(490, 295);
            tbBusqueda.TabIndex = 55;
            tbBusqueda.CellContentClick += tbBusqueda_CellContentClick;
            tbBusqueda.CellPainting += tbBusqueda_CellPainting;
            // 
            // Añadir
            // 
            Añadir.HeaderText = "Añadir";
            Añadir.MinimumWidth = 6;
            Añadir.Name = "Añadir";
            Añadir.Width = 50;
            // 
            // IdP
            // 
            IdP.HeaderText = "Id";
            IdP.MinimumWidth = 6;
            IdP.Name = "IdP";
            IdP.ReadOnly = true;
            IdP.Visible = false;
            IdP.Width = 10;
            // 
            // CodigoP
            // 
            CodigoP.HeaderText = "Codigo";
            CodigoP.MinimumWidth = 6;
            CodigoP.Name = "CodigoP";
            CodigoP.ReadOnly = true;
            CodigoP.Width = 120;
            // 
            // NombreP
            // 
            NombreP.HeaderText = "producto";
            NombreP.MinimumWidth = 6;
            NombreP.Name = "NombreP";
            NombreP.ReadOnly = true;
            NombreP.Width = 120;
            // 
            // PrecioP
            // 
            PrecioP.HeaderText = "Precio de compra";
            PrecioP.MinimumWidth = 6;
            PrecioP.Name = "PrecioP";
            PrecioP.ReadOnly = true;
            PrecioP.Width = 80;
            // 
            // CantidadP
            // 
            CantidadP.HeaderText = "Cantidad";
            CantidadP.MinimumWidth = 6;
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
            panelCompras.Margin = new Padding(3, 4, 3, 4);
            panelCompras.Name = "panelCompras";
            panelCompras.Size = new Size(490, 808);
            panelCompras.TabIndex = 23;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Top;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(490, 55);
            lblEncabezado.TabIndex = 23;
            lblEncabezado.Text = "Compras realizadas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            lblEncabezado.MouseHover += lblEncabezado_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxBuscarCompra);
            panel2.Controls.Add(txtBuscarCompra);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 294);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 83);
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
            cbxBuscarCompra.Items.AddRange(new object[] { "Usuario", "Fecha" });
            cbxBuscarCompra.Location = new Point(334, 0);
            cbxBuscarCompra.Margin = new Padding(3, 4, 3, 4);
            cbxBuscarCompra.MaxDropDownItems = 4;
            cbxBuscarCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscarCompra.Name = "cbxBuscarCompra";
            cbxBuscarCompra.Size = new Size(153, 49);
            cbxBuscarCompra.StartIndex = 0;
            cbxBuscarCompra.TabIndex = 24;
            cbxBuscarCompra.MouseHover += cbxBuscarCompra_MouseHover;
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
            txtBuscarCompra.Margin = new Padding(3, 4, 3, 4);
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
            txtBuscarCompra.Size = new Size(334, 48);
            txtBuscarCompra.TabIndex = 25;
            txtBuscarCompra.TabStop = false;
            txtBuscarCompra.TextAlign = HorizontalAlignment.Center;
            txtBuscarCompra.TrailingIcon = null;
            txtBuscarCompra.UseSystemPasswordChar = false;
            txtBuscarCompra.TextChanged += txtBuscar_TextChanged;
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
            tbCompras.Columns.AddRange(new DataGridViewColumn[] { IdCompra, Usuario, Total, Fecha });
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
            tbCompras.Location = new Point(0, 377);
            tbCompras.Margin = new Padding(3, 4, 3, 4);
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
            tbCompras.Size = new Size(490, 431);
            tbCompras.TabIndex = 22;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "ID";
            IdCompra.MinimumWidth = 6;
            IdCompra.Name = "IdCompra";
            IdCompra.ReadOnly = true;
            IdCompra.Width = 50;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Recibida por";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelCompras);
            panel1.Controls.Add(panelBusqueda);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(683, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 808);
            panel1.TabIndex = 24;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 812);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompras";
            Padding = new Padding(3, 0, 3, 4);
            Text = "FormCompras";
            Load += FormCompras_Load;
            pnlContenedor.ResumeLayout(false);
            pnlRegistroUsuario.ResumeLayout(false);
            pnlRegistroUsuario.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbDetalles).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            panelCompras.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCompras).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

#pragma warning disable CS0169 // El campo 'FormCompras.pnlOpciones' nunca se usa
        private Panel pnlOpciones;
#pragma warning restore CS0169 // El campo 'FormCompras.pnlOpciones' nunca se usa
        private Panel pnlContenedor;
        private Panel pnlRegistroUsuario;
        private ReaLTaiizor.Controls.AirCheckBox ckbEmpleadoNulo;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
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
        private Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
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
        private PictureBox pictureBox4;
        private DataGridViewButtonColumn Añadir;
        private DataGridViewTextBoxColumn IdP;
        private DataGridViewTextBoxColumn CodigoP;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn PrecioP;
        private DataGridViewTextBoxColumn CantidadP;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Fecha;
    }
}