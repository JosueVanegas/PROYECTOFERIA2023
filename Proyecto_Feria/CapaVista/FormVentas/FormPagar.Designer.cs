﻿namespace CapaVista.FormVentas
{
    partial class FormPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagar));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtCambioDeCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            txtBusquedaCliente = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnEscribirCliente = new RJCodeAdvance.RJControls.RJButton();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnPagar = new RJCodeAdvance.RJControls.RJButton();
            txtIva = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new Label();
            txtSubTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPago = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panelBusqueda = new Panel();
            lblBuscar = new Label();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCerrarBusqueda = new Button();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            tbBusqueda = new ReaLTaiizor.Controls.PoisonDataGridView();
            Seleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCambioDeCompra);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(txtIva);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(txtPago);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 487);
            panel1.TabIndex = 54;
            // 
            // txtCambioDeCompra
            // 
            txtCambioDeCompra.AnimateReadOnly = true;
            txtCambioDeCompra.AutoCompleteMode = AutoCompleteMode.None;
            txtCambioDeCompra.AutoCompleteSource = AutoCompleteSource.None;
            txtCambioDeCompra.BackgroundImageLayout = ImageLayout.None;
            txtCambioDeCompra.CharacterCasing = CharacterCasing.Normal;
            txtCambioDeCompra.Depth = 0;
            txtCambioDeCompra.Enabled = false;
            txtCambioDeCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCambioDeCompra.HideSelection = true;
            txtCambioDeCompra.Hint = "Cambio";
            txtCambioDeCompra.LeadingIcon = null;
            txtCambioDeCompra.Location = new Point(3, 414);
            txtCambioDeCompra.MaxLength = 32767;
            txtCambioDeCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCambioDeCompra.Name = "txtCambioDeCompra";
            txtCambioDeCompra.PasswordChar = '\0';
            txtCambioDeCompra.PrefixSuffixText = null;
            txtCambioDeCompra.ReadOnly = true;
            txtCambioDeCompra.RightToLeft = RightToLeft.No;
            txtCambioDeCompra.SelectedText = "";
            txtCambioDeCompra.SelectionLength = 0;
            txtCambioDeCompra.SelectionStart = 0;
            txtCambioDeCompra.ShortcutsEnabled = true;
            txtCambioDeCompra.Size = new Size(172, 48);
            txtCambioDeCompra.TabIndex = 55;
            txtCambioDeCompra.TabStop = false;
            txtCambioDeCompra.TextAlign = HorizontalAlignment.Center;
            txtCambioDeCompra.TrailingIcon = null;
            txtCambioDeCompra.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 222);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 63;
            label2.Text = "Resumen de venta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Controls.Add(txtBusquedaCliente);
            flowLayoutPanel1.Controls.Add(btnEscribirCliente);
            flowLayoutPanel1.Location = new Point(3, 158);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(407, 52);
            flowLayoutPanel1.TabIndex = 55;
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
            btnBuscar.Location = new Point(3, 7);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 39);
            btnBuscar.TabIndex = 54;
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextColor = Color.White;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.AnimateReadOnly = true;
            txtBusquedaCliente.AutoCompleteMode = AutoCompleteMode.None;
            txtBusquedaCliente.AutoCompleteSource = AutoCompleteSource.None;
            txtBusquedaCliente.BackgroundImageLayout = ImageLayout.None;
            txtBusquedaCliente.CharacterCasing = CharacterCasing.Normal;
            txtBusquedaCliente.Depth = 0;
            txtBusquedaCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusquedaCliente.HideSelection = true;
            txtBusquedaCliente.Hint = "Ingrese nombre del Cliente";
            txtBusquedaCliente.LeadingIcon = null;
            txtBusquedaCliente.Location = new Point(50, 3);
            txtBusquedaCliente.MaxLength = 32767;
            txtBusquedaCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.PasswordChar = '\0';
            txtBusquedaCliente.PrefixSuffixText = null;
            txtBusquedaCliente.ReadOnly = true;
            txtBusquedaCliente.RightToLeft = RightToLeft.No;
            txtBusquedaCliente.SelectedText = "";
            txtBusquedaCliente.SelectionLength = 0;
            txtBusquedaCliente.SelectionStart = 0;
            txtBusquedaCliente.ShortcutsEnabled = true;
            txtBusquedaCliente.Size = new Size(307, 48);
            txtBusquedaCliente.TabIndex = 50;
            txtBusquedaCliente.TabStop = false;
            txtBusquedaCliente.TextAlign = HorizontalAlignment.Center;
            txtBusquedaCliente.TrailingIcon = null;
            txtBusquedaCliente.UseSystemPasswordChar = false;
            txtBusquedaCliente.KeyPress += txtBusquedaCliente_KeyPress;
            // 
            // btnEscribirCliente
            // 
            btnEscribirCliente.Anchor = AnchorStyles.Left;
            btnEscribirCliente.BackColor = Color.FromArgb(63, 63, 70);
            btnEscribirCliente.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEscribirCliente.BackgroundImage = (Image)resources.GetObject("btnEscribirCliente.BackgroundImage");
            btnEscribirCliente.BackgroundImageLayout = ImageLayout.Center;
            btnEscribirCliente.BorderColor = Color.PaleVioletRed;
            btnEscribirCliente.BorderRadius = 10;
            btnEscribirCliente.BorderSize = 0;
            btnEscribirCliente.FlatAppearance.BorderSize = 0;
            btnEscribirCliente.FlatStyle = FlatStyle.Flat;
            btnEscribirCliente.ForeColor = Color.White;
            btnEscribirCliente.ImageAlign = ContentAlignment.MiddleRight;
            btnEscribirCliente.Location = new Point(363, 7);
            btnEscribirCliente.Margin = new Padding(3, 2, 3, 2);
            btnEscribirCliente.Name = "btnEscribirCliente";
            btnEscribirCliente.Size = new Size(41, 39);
            btnEscribirCliente.TabIndex = 55;
            btnEscribirCliente.TextAlign = ContentAlignment.BottomCenter;
            btnEscribirCliente.TextColor = Color.White;
            btnEscribirCliente.UseVisualStyleBackColor = false;
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
            txtTotal.Hint = "Total a pagar";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(3, 357);
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
            txtTotal.Size = new Size(172, 48);
            txtTotal.TabIndex = 61;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnPagar, 0, 0);
            tableLayoutPanel2.Location = new Point(219, 303);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(193, 64);
            tableLayoutPanel2.TabIndex = 55;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(63, 63, 70);
            btnPagar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnPagar.BackgroundImageLayout = ImageLayout.Center;
            btnPagar.BorderColor = Color.PaleVioletRed;
            btnPagar.BorderRadius = 10;
            btnPagar.BorderSize = 0;
            btnPagar.Dock = DockStyle.Fill;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.ImageAlign = ContentAlignment.MiddleRight;
            btnPagar.Location = new Point(3, 2);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(187, 60);
            btnPagar.TabIndex = 56;
            btnPagar.Text = "PAGAR";
            btnPagar.TextColor = Color.White;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
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
            txtIva.Location = new Point(3, 303);
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
            txtIva.Size = new Size(172, 48);
            txtIva.TabIndex = 62;
            txtIva.TabStop = false;
            txtIva.TextAlign = HorizontalAlignment.Center;
            txtIva.TrailingIcon = null;
            txtIva.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(218, 222);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 24);
            lblTitulo.TabIndex = 58;
            lblTitulo.Text = "Pago en proceso";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            txtSubTotal.Location = new Point(3, 249);
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
            txtSubTotal.Size = new Size(172, 48);
            txtSubTotal.TabIndex = 60;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Center;
            txtSubTotal.TrailingIcon = null;
            txtSubTotal.UseSystemPasswordChar = false;
            // 
            // txtPago
            // 
            txtPago.AnimateReadOnly = true;
            txtPago.AutoCompleteMode = AutoCompleteMode.None;
            txtPago.AutoCompleteSource = AutoCompleteSource.None;
            txtPago.BackgroundImageLayout = ImageLayout.None;
            txtPago.CharacterCasing = CharacterCasing.Normal;
            txtPago.Depth = 0;
            txtPago.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPago.HideSelection = true;
            txtPago.Hint = "Pago del cliente";
            txtPago.LeadingIcon = null;
            txtPago.Location = new Point(219, 249);
            txtPago.MaxLength = 32767;
            txtPago.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPago.Name = "txtPago";
            txtPago.PasswordChar = '\0';
            txtPago.PrefixSuffixText = null;
            txtPago.ReadOnly = false;
            txtPago.RightToLeft = RightToLeft.No;
            txtPago.SelectedText = "";
            txtPago.SelectionLength = 0;
            txtPago.SelectionStart = 0;
            txtPago.ShortcutsEnabled = true;
            txtPago.Size = new Size(192, 48);
            txtPago.TabIndex = 57;
            txtPago.TabStop = false;
            txtPago.TextAlign = HorizontalAlignment.Center;
            txtPago.TrailingIcon = null;
            txtPago.UseSystemPasswordChar = false;
            txtPago.Visible = false;
            txtPago.KeyPress += txtPagoTarjeta_KeyPress;
            txtPago.Leave += txtPagoTarjeta_Leave;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblBuscar);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(btnCerrarBusqueda);
            panelBusqueda.Controls.Add(cbxBuscar);
            panelBusqueda.Controls.Add(tbBusqueda);
            panelBusqueda.Dock = DockStyle.Fill;
            panelBusqueda.Location = new Point(427, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(426, 487);
            panelBusqueda.TabIndex = 56;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Bottom;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, -8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(426, 59);
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
            txtBuscar.Location = new Point(0, 51);
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
            txtBuscar.Size = new Size(426, 48);
            txtBuscar.TabIndex = 63;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = Color.Red;
            btnCerrarBusqueda.Image = (Image)resources.GetObject("btnCerrarBusqueda.Image");
            btnCerrarBusqueda.Location = new Point(271, 3);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(43, 41);
            btnCerrarBusqueda.TabIndex = 62;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
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
            cbxBuscar.Hint = "Buscar Cliente";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "Codigo", "Nombre", "Precio" });
            cbxBuscar.Location = new Point(0, 99);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(426, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 60;
            // 
            // tbBusqueda
            // 
            tbBusqueda.AllowUserToAddRows = false;
            tbBusqueda.AllowUserToOrderColumns = true;
            tbBusqueda.AllowUserToResizeRows = false;
            tbBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbBusqueda.BackgroundColor = SystemColors.ControlDarkDark;
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
            tbBusqueda.Columns.AddRange(new DataGridViewColumn[] { Seleccionar, Id, Nombre });
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
            tbBusqueda.Location = new Point(0, 148);
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
            tbBusqueda.Size = new Size(426, 339);
            tbBusqueda.TabIndex = 55;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Name = "Seleccionar";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 10;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Cliente";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 400;
            // 
            // FormPagar
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 490);
            ControlBox = false;
            Controls.Add(panelBusqueda);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(856, 490);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(856, 490);
            Name = "FormPagar";
            Padding = new Padding(3, 0, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "FormPagar";
            Load += FormPagar_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPagoEfectivo;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBusquedaCliente;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton14;
        private RJCodeAdvance.RJControls.RJButton btnPagar;
        private FlowLayoutPanel flowLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private RJCodeAdvance.RJControls.RJButton btnEscribirCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCambioDeCompra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPago;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIva;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private Panel panelBusqueda;
        private Label lblBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Button btnCerrarBusqueda;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private ReaLTaiizor.Controls.PoisonDataGridView tbBusqueda;
        private DataGridViewButtonColumn Seleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
    }
}