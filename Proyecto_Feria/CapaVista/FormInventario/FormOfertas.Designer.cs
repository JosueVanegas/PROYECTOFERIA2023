namespace CapaPresentacion.FormInventario
{
    partial class FormOfertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfertas));
            tbOfertas = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Inicio = new DataGridViewTextBoxColumn();
            Final = new DataGridViewTextBoxColumn();
            Registro = new DataGridViewTextBoxColumn();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            lblEncabezado = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            txtDescripcion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdOferta = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            dtFinal = new ReaLTaiizor.Controls.PoisonDateTime();
            label4 = new Label();
            dtInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            ckInactiva = new ReaLTaiizor.Controls.HopeCheckBox();
            label3 = new Label();
            ckActiva = new ReaLTaiizor.Controls.HopeCheckBox();
            label2 = new Label();
            nbDescuento = new ReaLTaiizor.Controls.HopeNumeric();
            label1 = new Label();
            nbCantidad = new ReaLTaiizor.Controls.HopeNumeric();
            cbxProductos = new ReaLTaiizor.Controls.MaterialComboBox();
            info = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tbOfertas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbOfertas
            // 
            tbOfertas.AllowUserToAddRows = false;
            tbOfertas.AllowUserToOrderColumns = true;
            tbOfertas.AllowUserToResizeRows = false;
            tbOfertas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbOfertas.BackgroundColor = Color.White;
            tbOfertas.BorderStyle = BorderStyle.None;
            tbOfertas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbOfertas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbOfertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbOfertas.ColumnHeadersHeight = 35;
            tbOfertas.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnBorrar, Descripcion, Id, Producto, Cantidad, Descuento, Estado, Inicio, Final, Registro });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbOfertas.DefaultCellStyle = dataGridViewCellStyle2;
            tbOfertas.Dock = DockStyle.Fill;
            tbOfertas.EnableHeadersVisualStyles = false;
            tbOfertas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbOfertas.GridColor = Color.Gray;
            tbOfertas.Location = new Point(296, 49);
            tbOfertas.Margin = new Padding(3, 4, 3, 4);
            tbOfertas.Name = "tbOfertas";
            tbOfertas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbOfertas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbOfertas.RowHeadersVisible = false;
            tbOfertas.RowHeadersWidth = 40;
            tbOfertas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbOfertas.RowTemplate.Height = 30;
            tbOfertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbOfertas.Size = new Size(949, 564);
            tbOfertas.TabIndex = 27;
            tbOfertas.CellContentClick += tbOfertas_CellContentClick;
            tbOfertas.CellPainting += tbOfertas_CellPainting;
            // 
            // btnEditar
            // 
            btnEditar.FillWeight = 211.808029F;
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            btnBorrar.FillWeight = 213.903763F;
            btnBorrar.HeaderText = "Eliminar";
            btnBorrar.MinimumWidth = 6;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Width = 50;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 71.786026F;
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
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
            // Producto
            // 
            Producto.FillWeight = 71.786026F;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 71.786026F;
            Cantidad.HeaderText = "Cantidad aplicable";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Descuento
            // 
            Descuento.FillWeight = 71.786026F;
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 125;
            // 
            // Estado
            // 
            Estado.FillWeight = 71.786026F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Visible = false;
            Estado.Width = 50;
            // 
            // Inicio
            // 
            Inicio.FillWeight = 71.786026F;
            Inicio.HeaderText = "Inicio";
            Inicio.MinimumWidth = 6;
            Inicio.Name = "Inicio";
            Inicio.ReadOnly = true;
            Inicio.Width = 120;
            // 
            // Final
            // 
            Final.FillWeight = 71.786026F;
            Final.HeaderText = "Finalización";
            Final.MinimumWidth = 6;
            Final.Name = "Final";
            Final.ReadOnly = true;
            Final.Width = 120;
            // 
            // Registro
            // 
            Registro.FillWeight = 71.786026F;
            Registro.HeaderText = "Fecha de registro";
            Registro.MinimumWidth = 6;
            Registro.Name = "Registro";
            Registro.ReadOnly = true;
            Registro.Width = 120;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = true;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.CharacterCasing = CharacterCasing.Normal;
            txtBuscar.Depth = 0;
            txtBuscar.Dock = DockStyle.Left;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(429, 0);
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
            txtBuscar.Size = new Size(433, 48);
            txtBuscar.TabIndex = 25;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cbxBuscar
            // 
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.Dock = DockStyle.Left;
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
            cbxBuscar.Items.AddRange(new object[] { "Descripcion", "Producto", "Descuento", "Inicio", "Final", "Registro" });
            cbxBuscar.Location = new Point(254, 0);
            cbxBuscar.Margin = new Padding(3, 4, 3, 4);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(175, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 26;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(254, 49);
            lblEncabezado.TabIndex = 23;
            lblEncabezado.Text = "Ofertas registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(60, 518);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(165, 83);
            tableLayoutPanel1.TabIndex = 31;
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
            btnLimpiar.Location = new Point(85, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 77);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(76, 77);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(6, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 43);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos de la oferta";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = true;
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.None;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.None;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Depth = 0;
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Descripcion de la oferta";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(6, 56);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.PrefixSuffixText = null;
            txtDescripcion.ReadOnly = false;
            txtDescripcion.RightToLeft = RightToLeft.No;
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.ShortcutsEnabled = true;
            txtDescripcion.Size = new Size(276, 48);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Center;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtIdOferta
            // 
            txtIdOferta.Location = new Point(243, 8);
            txtIdOferta.Margin = new Padding(3, 4, 3, 4);
            txtIdOferta.Name = "txtIdOferta";
            txtIdOferta.Size = new Size(39, 27);
            txtIdOferta.TabIndex = 8;
            txtIdOferta.Text = "0";
            txtIdOferta.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtFinal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtInicio);
            panel1.Controls.Add(ckInactiva);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ckActiva);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nbDescuento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nbCantidad);
            panel1.Controls.Add(cbxProductos);
            panel1.Controls.Add(info);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtIdOferta);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 613);
            panel1.TabIndex = 24;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(6, 390);
            label5.Name = "label5";
            label5.Size = new Size(276, 21);
            label5.TabIndex = 60;
            label5.Text = "Fecha de finalización";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtFinal
            // 
            dtFinal.Location = new Point(6, 414);
            dtFinal.MinimumSize = new Size(0, 30);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(276, 30);
            dtFinal.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(6, 332);
            label4.Name = "label4";
            label4.Size = new Size(276, 21);
            label4.TabIndex = 58;
            label4.Text = "Fecha de inicio";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(6, 356);
            dtInicio.MinimumSize = new Size(0, 30);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(276, 30);
            dtInicio.TabIndex = 7;
            dtInicio.ValueChanged += dtInicio_ValueChanged;
            // 
            // ckInactiva
            // 
            ckInactiva.AutoSize = true;
            ckInactiva.CheckedColor = Color.FromArgb(64, 158, 255);
            ckInactiva.DisabledColor = Color.FromArgb(196, 198, 202);
            ckInactiva.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckInactiva.Enable = true;
            ckInactiva.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckInactiva.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckInactiva.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckInactiva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckInactiva.ForeColor = Color.FromArgb(48, 49, 51);
            ckInactiva.Location = new Point(118, 309);
            ckInactiva.Name = "ckInactiva";
            ckInactiva.Size = new Size(104, 20);
            ckInactiva.TabIndex = 6;
            ckInactiva.Text = "Inactiva";
            ckInactiva.UseVisualStyleBackColor = true;
            ckInactiva.CheckedChanged += ckInactiva_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(6, 285);
            label3.Name = "label3";
            label3.Size = new Size(276, 21);
            label3.TabIndex = 55;
            label3.Text = "Estado de la oferta";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ckActiva
            // 
            ckActiva.AutoSize = true;
            ckActiva.Checked = true;
            ckActiva.CheckedColor = Color.FromArgb(64, 158, 255);
            ckActiva.CheckState = CheckState.Checked;
            ckActiva.DisabledColor = Color.FromArgb(196, 198, 202);
            ckActiva.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckActiva.Enable = true;
            ckActiva.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckActiva.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckActiva.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckActiva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckActiva.ForeColor = Color.FromArgb(48, 49, 51);
            ckActiva.Location = new Point(6, 309);
            ckActiva.Name = "ckActiva";
            ckActiva.Size = new Size(91, 20);
            ckActiva.TabIndex = 5;
            ckActiva.Text = "Activa";
            ckActiva.UseVisualStyleBackColor = true;
            ckActiva.CheckedChanged += ckActiva_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(6, 226);
            label2.Name = "label2";
            label2.Size = new Size(276, 21);
            label2.TabIndex = 53;
            label2.Text = "Descuento aplicable %";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nbDescuento
            // 
            nbDescuento.BackColor = Color.White;
            nbDescuento.BaseColor = Color.FromArgb(242, 246, 252);
            nbDescuento.BorderColorA = Color.FromArgb(192, 196, 204);
            nbDescuento.BorderColorB = Color.FromArgb(192, 196, 204);
            nbDescuento.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            nbDescuento.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            nbDescuento.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            nbDescuento.EnterKey = true;
            nbDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbDescuento.ForeColor = Color.Black;
            nbDescuento.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            nbDescuento.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            nbDescuento.Location = new Point(6, 250);
            nbDescuento.MaxNum = 100F;
            nbDescuento.MinNum = 1F;
            nbDescuento.Name = "nbDescuento";
            nbDescuento.Precision = 0;
            nbDescuento.Size = new Size(276, 32);
            nbDescuento.Step = 1F;
            nbDescuento.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            nbDescuento.TabIndex = 4;
            nbDescuento.ValueNumber = 1F;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(6, 163);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 51;
            label1.Text = "Cantidad de producto aplicable";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nbCantidad
            // 
            nbCantidad.BackColor = Color.White;
            nbCantidad.BaseColor = Color.FromArgb(242, 246, 252);
            nbCantidad.BorderColorA = Color.FromArgb(192, 196, 204);
            nbCantidad.BorderColorB = Color.FromArgb(192, 196, 204);
            nbCantidad.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            nbCantidad.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            nbCantidad.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            nbCantidad.EnterKey = true;
            nbCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbCantidad.ForeColor = Color.Black;
            nbCantidad.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            nbCantidad.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            nbCantidad.Location = new Point(6, 191);
            nbCantidad.MaxNum = 100F;
            nbCantidad.MinNum = 1F;
            nbCantidad.Name = "nbCantidad";
            nbCantidad.Precision = 0;
            nbCantidad.Size = new Size(276, 32);
            nbCantidad.Step = 1F;
            nbCantidad.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            nbCantidad.TabIndex = 3;
            nbCantidad.ValueNumber = 1F;
            // 
            // cbxProductos
            // 
            cbxProductos.AutoResize = false;
            cbxProductos.BackColor = Color.FromArgb(255, 255, 255);
            cbxProductos.Depth = 0;
            cbxProductos.DrawMode = DrawMode.OwnerDrawVariable;
            cbxProductos.DropDownHeight = 174;
            cbxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductos.DropDownWidth = 121;
            cbxProductos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxProductos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxProductos.FormattingEnabled = true;
            cbxProductos.Hint = "Seleccione el producto";
            cbxProductos.IntegralHeight = false;
            cbxProductos.ItemHeight = 43;
            cbxProductos.Location = new Point(6, 111);
            cbxProductos.MaxDropDownItems = 4;
            cbxProductos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProductos.Name = "cbxProductos";
            cbxProductos.Size = new Size(276, 49);
            cbxProductos.StartIndex = 0;
            cbxProductos.TabIndex = 2;
            // 
            // info
            // 
            info.Image = (Image)resources.GetObject("info.Image");
            info.Location = new Point(201, 8);
            info.Margin = new Padding(3, 4, 3, 4);
            info.Name = "info";
            info.Size = new Size(36, 44);
            info.SizeMode = PictureBoxSizeMode.Zoom;
            info.TabIndex = 34;
            info.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(cbxBuscar);
            panel2.Controls.Add(lblEncabezado);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 49);
            panel2.TabIndex = 28;
            // 
            // FormOfertas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 613);
            ControlBox = false;
            Controls.Add(tbOfertas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOfertas";
            Text = "FormOfertas";
            Load += FormOfertas_Load;
            ((System.ComponentModel.ISupportInitialize)tbOfertas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbOfertas;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private Label lblEncabezado;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescripcion;
        private TextBox txtIdOferta;
        private Panel panel1;
        private PictureBox info;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProductos;
        private Label label2;
        private ReaLTaiizor.Controls.HopeNumeric nbDescuento;
        private Label label1;
        private ReaLTaiizor.Controls.HopeNumeric nbCantidad;
        private Label label3;
        private ReaLTaiizor.Controls.HopeCheckBox ckActiva;
        private ReaLTaiizor.Controls.HopeCheckBox ckInactiva;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Inicio;
        private DataGridViewTextBoxColumn Finalizacion;
        private DataGridViewTextBoxColumn Registro;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonDateTime dtInicio;
        private Label label5;
        private ReaLTaiizor.Controls.PoisonDateTime dtFinal;
        private DataGridViewTextBoxColumn Final;
    }
}