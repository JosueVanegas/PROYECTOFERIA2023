namespace CapaVista.FormVentas
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
            pictureBox4 = new PictureBox();
            txtTotalFinal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescuento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCambioDeCompra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIva = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSubTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCliente = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnFacturar = new RJCodeAdvance.RJControls.RJButton();
            btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            txtPago = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panelBusqueda = new Panel();
            pictureBox3 = new PictureBox();
            lblBuscar = new Label();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            tbBusqueda = new ReaLTaiizor.Controls.PoisonDataGridView();
            Seleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pdImprimir = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtTotalFinal);
            panel1.Controls.Add(txtDescuento);
            panel1.Controls.Add(txtCambioDeCompra);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtIva);
            panel1.Controls.Add(txtSubTotal);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 632);
            panel1.TabIndex = 54;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 35);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 74;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
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
            txtTotalFinal.Hint = "total a pagar";
            txtTotalFinal.LeadingIcon = null;
            txtTotalFinal.Location = new Point(37, 500);
            txtTotalFinal.Margin = new Padding(3, 4, 3, 4);
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
            txtTotalFinal.Size = new Size(234, 48);
            txtTotalFinal.TabIndex = 65;
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
            txtDescuento.Location = new Point(37, 428);
            txtDescuento.Margin = new Padding(3, 4, 3, 4);
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
            txtDescuento.Size = new Size(234, 48);
            txtDescuento.TabIndex = 64;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
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
            txtCambioDeCompra.Location = new Point(37, 572);
            txtCambioDeCompra.Margin = new Padding(3, 4, 3, 4);
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
            txtCambioDeCompra.Size = new Size(234, 48);
            txtCambioDeCompra.TabIndex = 55;
            txtCambioDeCompra.TabStop = false;
            txtCambioDeCompra.TextAlign = HorizontalAlignment.Center;
            txtCambioDeCompra.TrailingIcon = null;
            txtCambioDeCompra.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(37, 177);
            label2.Name = "label2";
            label2.Size = new Size(223, 36);
            label2.TabIndex = 63;
            label2.Text = "Resumen de venta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            txtTotal.Hint = "total antes de descuento";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(37, 356);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
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
            txtTotal.Size = new Size(234, 48);
            txtTotal.TabIndex = 61;
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
            txtIva.Location = new Point(37, 284);
            txtIva.Margin = new Padding(3, 4, 3, 4);
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
            txtIva.Size = new Size(234, 48);
            txtIva.TabIndex = 62;
            txtIva.TabStop = false;
            txtIva.TextAlign = HorizontalAlignment.Center;
            txtIva.TrailingIcon = null;
            txtIva.UseSystemPasswordChar = false;
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
            txtSubTotal.Location = new Point(37, 212);
            txtSubTotal.Margin = new Padding(3, 4, 3, 4);
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
            txtSubTotal.Size = new Size(234, 48);
            txtSubTotal.TabIndex = 60;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Center;
            txtSubTotal.TrailingIcon = null;
            txtSubTotal.UseSystemPasswordChar = false;
            // 
            // txtCliente
            // 
            txtCliente.AnimateReadOnly = true;
            txtCliente.AutoCompleteMode = AutoCompleteMode.None;
            txtCliente.AutoCompleteSource = AutoCompleteSource.None;
            txtCliente.BackgroundImageLayout = ImageLayout.None;
            txtCliente.CharacterCasing = CharacterCasing.Normal;
            txtCliente.Depth = 0;
            txtCliente.Enabled = false;
            txtCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.HideSelection = true;
            txtCliente.Hint = "Cliente:";
            txtCliente.LeadingIcon = null;
            txtCliente.Location = new Point(14, 109);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.MaxLength = 32767;
            txtCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCliente.Name = "txtCliente";
            txtCliente.PasswordChar = '\0';
            txtCliente.PrefixSuffixText = null;
            txtCliente.ReadOnly = true;
            txtCliente.RightToLeft = RightToLeft.No;
            txtCliente.SelectedText = "";
            txtCliente.SelectionLength = 0;
            txtCliente.SelectionStart = 0;
            txtCliente.ShortcutsEnabled = true;
            txtCliente.Size = new Size(320, 48);
            txtCliente.TabIndex = 50;
            txtCliente.TabStop = false;
            txtCliente.TextAlign = HorizontalAlignment.Center;
            txtCliente.TrailingIcon = null;
            txtCliente.UseSystemPasswordChar = false;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(74, 121, 121);
            btnFacturar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnFacturar.BackgroundImageLayout = ImageLayout.Center;
            btnFacturar.BorderColor = Color.PaleVioletRed;
            btnFacturar.BorderRadius = 10;
            btnFacturar.BorderSize = 0;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.ImageAlign = ContentAlignment.MiddleRight;
            btnFacturar.Location = new Point(24, 428);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(313, 80);
            btnFacturar.TabIndex = 65;
            btnFacturar.Text = "FACTURAR";
            btnFacturar.TextColor = Color.White;
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnPagar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.BackgroundColor = Color.Red;
            btnCancelar.BackgroundImageLayout = ImageLayout.Center;
            btnCancelar.BorderColor = Color.PaleVioletRed;
            btnCancelar.BorderRadius = 10;
            btnCancelar.BorderSize = 0;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(21, 519);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(313, 80);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextColor = Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            txtPago.Location = new Point(14, 165);
            txtPago.Margin = new Padding(3, 4, 3, 4);
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
            txtPago.Size = new Size(320, 48);
            txtPago.TabIndex = 57;
            txtPago.TabStop = false;
            txtPago.TextAlign = HorizontalAlignment.Center;
            txtPago.TrailingIcon = null;
            txtPago.UseSystemPasswordChar = false;
            txtPago.KeyPress += txtPagoTarjeta_KeyPress;
            txtPago.TextChanged += txtPago_TextChanged;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(pictureBox3);
            panelBusqueda.Controls.Add(lblBuscar);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(cbxBuscar);
            panelBusqueda.Controls.Add(tbBusqueda);
            panelBusqueda.Dock = DockStyle.Right;
            panelBusqueda.Location = new Point(348, 0);
            panelBusqueda.Margin = new Padding(3, 4, 3, 4);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(314, 632);
            panelBusqueda.TabIndex = 56;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(267, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 76;
            pictureBox3.TabStop = false;
            pictureBox3.MouseHover += pictureBox3_MouseHover;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Bottom;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(314, 124);
            lblBuscar.TabIndex = 42;
            lblBuscar.Text = "Buscar cliente";
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
            txtBuscar.Location = new Point(0, 139);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
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
            txtBuscar.Size = new Size(314, 48);
            txtBuscar.TabIndex = 63;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
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
            cbxBuscar.Hint = "Buscar Cliente";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "Nombre" });
            cbxBuscar.Location = new Point(0, 187);
            cbxBuscar.Margin = new Padding(3, 4, 3, 4);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(314, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 60;
            cbxBuscar.MouseHover += cbxBuscar_MouseHover;
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
            tbBusqueda.Columns.AddRange(new DataGridViewColumn[] { Seleccionar, Id, Cedula, Nombre });
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
            tbBusqueda.Location = new Point(0, 236);
            tbBusqueda.Margin = new Padding(3, 4, 3, 4);
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
            tbBusqueda.Size = new Size(314, 396);
            tbBusqueda.TabIndex = 55;
            tbBusqueda.CellContentClick += tbBusqueda_CellContentClick;
            tbBusqueda.CellPainting += tbBusqueda_CellPainting;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.MinimumWidth = 6;
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Width = 125;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 10;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            Cedula.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Cliente";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnFacturar);
            panel2.Controls.Add(txtCliente);
            panel2.Controls.Add(panelBusqueda);
            panel2.Controls.Add(txtPago);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 632);
            panel2.TabIndex = 57;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 48);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // FormPagar
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 636);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(975, 636);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(975, 636);
            Name = "FormPagar";
            Padding = new Padding(3, 0, 3, 4);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPagar";
            Load += FormPagar_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

#pragma warning disable CS0169 // El campo 'FormPagar.txtPagoEfectivo' nunca se usa
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPagoEfectivo;
#pragma warning restore CS0169 // El campo 'FormPagar.txtPagoEfectivo' nunca se usa
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCliente;
#pragma warning disable CS0169 // El campo 'FormPagar.rjButton14' nunca se usa
        private RJCodeAdvance.RJControls.RJButton rjButton14;
#pragma warning restore CS0169 // El campo 'FormPagar.rjButton14' nunca se usa
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCambioDeCompra;
        private PictureBox pictureBox1;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIva;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSubTotal;
        private Panel panelBusqueda;
        private Label lblBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private ReaLTaiizor.Controls.PoisonDataGridView tbBusqueda;
        private RJCodeAdvance.RJControls.RJButton btnFacturar;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPago;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescuento;
        private Panel panel2;
        private System.Drawing.Printing.PrintDocument pdImprimir;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalFinal;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DataGridViewButtonColumn Seleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
    }
}