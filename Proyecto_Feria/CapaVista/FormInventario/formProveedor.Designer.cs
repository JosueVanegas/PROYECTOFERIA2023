namespace CapaVista
{
    partial class formProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProveedor));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtCiudad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPais = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroContacto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombreContacto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            txtNombreEmpresa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new TextBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            tbProveedores = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtCiudad);
            panel1.Controls.Add(txtPais);
            panel1.Controls.Add(txtNumeroContacto);
            panel1.Controls.Add(txtNombreContacto);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombreEmpresa);
            panel1.Controls.Add(txtId);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 489);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // txtCiudad
            // 
            txtCiudad.AnimateReadOnly = true;
            txtCiudad.AutoCompleteMode = AutoCompleteMode.None;
            txtCiudad.AutoCompleteSource = AutoCompleteSource.None;
            txtCiudad.BackgroundImageLayout = ImageLayout.None;
            txtCiudad.CharacterCasing = CharacterCasing.Normal;
            txtCiudad.Depth = 0;
            txtCiudad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCiudad.HideSelection = true;
            txtCiudad.Hint = "Ciudad";
            txtCiudad.LeadingIcon = null;
            txtCiudad.Location = new Point(12, 314);
            txtCiudad.MaxLength = 32767;
            txtCiudad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PasswordChar = '\0';
            txtCiudad.PrefixSuffixText = null;
            txtCiudad.ReadOnly = false;
            txtCiudad.RightToLeft = RightToLeft.No;
            txtCiudad.SelectedText = "";
            txtCiudad.SelectionLength = 0;
            txtCiudad.SelectionStart = 0;
            txtCiudad.ShortcutsEnabled = true;
            txtCiudad.Size = new Size(145, 48);
            txtCiudad.TabIndex = 35;
            txtCiudad.TabStop = false;
            txtCiudad.TextAlign = HorizontalAlignment.Center;
            txtCiudad.TrailingIcon = null;
            txtCiudad.UseSystemPasswordChar = false;
            txtCiudad.KeyPress += txtCiudad_KeyPress;
            // 
            // txtPais
            // 
            txtPais.AnimateReadOnly = true;
            txtPais.AutoCompleteMode = AutoCompleteMode.None;
            txtPais.AutoCompleteSource = AutoCompleteSource.None;
            txtPais.BackgroundImageLayout = ImageLayout.None;
            txtPais.CharacterCasing = CharacterCasing.Normal;
            txtPais.Depth = 0;
            txtPais.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPais.HideSelection = true;
            txtPais.Hint = "Pais";
            txtPais.LeadingIcon = null;
            txtPais.Location = new Point(12, 257);
            txtPais.MaxLength = 32767;
            txtPais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPais.Name = "txtPais";
            txtPais.PasswordChar = '\0';
            txtPais.PrefixSuffixText = null;
            txtPais.ReadOnly = false;
            txtPais.RightToLeft = RightToLeft.No;
            txtPais.SelectedText = "";
            txtPais.SelectionLength = 0;
            txtPais.SelectionStart = 0;
            txtPais.ShortcutsEnabled = true;
            txtPais.Size = new Size(145, 48);
            txtPais.TabIndex = 34;
            txtPais.TabStop = false;
            txtPais.TextAlign = HorizontalAlignment.Center;
            txtPais.TrailingIcon = null;
            txtPais.UseSystemPasswordChar = false;
            txtPais.KeyPress += txtPais_KeyPress;
            // 
            // txtNumeroContacto
            // 
            txtNumeroContacto.AnimateReadOnly = true;
            txtNumeroContacto.AutoCompleteMode = AutoCompleteMode.None;
            txtNumeroContacto.AutoCompleteSource = AutoCompleteSource.None;
            txtNumeroContacto.BackgroundImageLayout = ImageLayout.None;
            txtNumeroContacto.CharacterCasing = CharacterCasing.Normal;
            txtNumeroContacto.Depth = 0;
            txtNumeroContacto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroContacto.HideSelection = true;
            txtNumeroContacto.Hint = "Ingrese el numero de contacto";
            txtNumeroContacto.LeadingIcon = null;
            txtNumeroContacto.Location = new Point(12, 193);
            txtNumeroContacto.MaxLength = 32767;
            txtNumeroContacto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumeroContacto.Name = "txtNumeroContacto";
            txtNumeroContacto.PasswordChar = '\0';
            txtNumeroContacto.PrefixSuffixText = null;
            txtNumeroContacto.ReadOnly = false;
            txtNumeroContacto.RightToLeft = RightToLeft.No;
            txtNumeroContacto.SelectedText = "";
            txtNumeroContacto.SelectionLength = 0;
            txtNumeroContacto.SelectionStart = 0;
            txtNumeroContacto.ShortcutsEnabled = true;
            txtNumeroContacto.Size = new Size(263, 48);
            txtNumeroContacto.TabIndex = 33;
            txtNumeroContacto.TabStop = false;
            txtNumeroContacto.TextAlign = HorizontalAlignment.Center;
            txtNumeroContacto.TrailingIcon = null;
            txtNumeroContacto.UseSystemPasswordChar = false;
            txtNumeroContacto.KeyPress += txtNumeroContacto_KeyPress;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.AnimateReadOnly = true;
            txtNombreContacto.AutoCompleteMode = AutoCompleteMode.None;
            txtNombreContacto.AutoCompleteSource = AutoCompleteSource.None;
            txtNombreContacto.BackgroundImageLayout = ImageLayout.None;
            txtNombreContacto.CharacterCasing = CharacterCasing.Normal;
            txtNombreContacto.Depth = 0;
            txtNombreContacto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreContacto.HideSelection = true;
            txtNombreContacto.Hint = "Ingrese el nombre de contacto";
            txtNombreContacto.LeadingIcon = null;
            txtNombreContacto.Location = new Point(12, 130);
            txtNombreContacto.MaxLength = 32767;
            txtNombreContacto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.PasswordChar = '\0';
            txtNombreContacto.PrefixSuffixText = null;
            txtNombreContacto.ReadOnly = false;
            txtNombreContacto.RightToLeft = RightToLeft.No;
            txtNombreContacto.SelectedText = "";
            txtNombreContacto.SelectionLength = 0;
            txtNombreContacto.SelectionStart = 0;
            txtNombreContacto.ShortcutsEnabled = true;
            txtNombreContacto.Size = new Size(263, 48);
            txtNombreContacto.TabIndex = 32;
            txtNombreContacto.TabStop = false;
            txtNombreContacto.TextAlign = HorizontalAlignment.Center;
            txtNombreContacto.TrailingIcon = null;
            txtNombreContacto.UseSystemPasswordChar = false;
            txtNombreContacto.KeyPress += txtNombreContacto_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Location = new Point(65, 384);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(156, 80);
            tableLayoutPanel1.TabIndex = 31;
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
            btnLimpiar.Location = new Point(81, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 76);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(28, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Proveedor";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.AnimateReadOnly = true;
            txtNombreEmpresa.AutoCompleteMode = AutoCompleteMode.None;
            txtNombreEmpresa.AutoCompleteSource = AutoCompleteSource.None;
            txtNombreEmpresa.BackgroundImageLayout = ImageLayout.None;
            txtNombreEmpresa.CharacterCasing = CharacterCasing.Normal;
            txtNombreEmpresa.Depth = 0;
            txtNombreEmpresa.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEmpresa.HideSelection = true;
            txtNombreEmpresa.Hint = "Ingrese el nombre de la Empresa";
            txtNombreEmpresa.LeadingIcon = null;
            txtNombreEmpresa.Location = new Point(12, 70);
            txtNombreEmpresa.MaxLength = 32767;
            txtNombreEmpresa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.PasswordChar = '\0';
            txtNombreEmpresa.PrefixSuffixText = null;
            txtNombreEmpresa.ReadOnly = false;
            txtNombreEmpresa.RightToLeft = RightToLeft.No;
            txtNombreEmpresa.SelectedText = "";
            txtNombreEmpresa.SelectionLength = 0;
            txtNombreEmpresa.SelectionStart = 0;
            txtNombreEmpresa.ShortcutsEnabled = true;
            txtNombreEmpresa.Size = new Size(263, 48);
            txtNombreEmpresa.TabIndex = 10;
            txtNombreEmpresa.TabStop = false;
            txtNombreEmpresa.TextAlign = HorizontalAlignment.Center;
            txtNombreEmpresa.TrailingIcon = null;
            txtNombreEmpresa.UseSystemPasswordChar = false;
            txtNombreEmpresa.KeyPress += txtNombreEmpresa_KeyPress;
            // 
            // txtId
            // 
            txtId.Location = new Point(227, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 8;
            txtId.Visible = false;
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
            txtBuscar.Location = new Point(642, 16);
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
            txtBuscar.Size = new Size(329, 48);
            txtBuscar.TabIndex = 23;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(321, 15);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(181, 48);
            lblEncabezado.TabIndex = 22;
            lblEncabezado.Text = "Proveedores registrados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbProveedores
            // 
            tbProveedores.AllowUserToAddRows = false;
            tbProveedores.AllowUserToOrderColumns = true;
            tbProveedores.AllowUserToResizeColumns = false;
            tbProveedores.AllowUserToResizeRows = false;
            tbProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbProveedores.BackgroundColor = Color.FromArgb(50, 50, 50);
            tbProveedores.BorderStyle = BorderStyle.None;
            tbProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbProveedores.ColumnHeadersHeight = 40;
            tbProveedores.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnBorrar, Id, Empresa, Contacto, Numero, Pais, Ciudad });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            tbProveedores.DefaultCellStyle = dataGridViewCellStyle5;
            tbProveedores.EnableHeadersVisualStyles = false;
            tbProveedores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProveedores.GridColor = Color.FromArgb(255, 255, 255);
            tbProveedores.Location = new Point(321, 70);
            tbProveedores.Name = "tbProveedores";
            tbProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbProveedores.RowHeadersVisible = false;
            tbProveedores.RowHeadersWidth = 40;
            tbProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProveedores.RowTemplate.Height = 30;
            tbProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProveedores.Size = new Size(650, 405);
            tbProveedores.TabIndex = 21;
            tbProveedores.CellContentClick += tbProveedores_CellContentClick;
            tbProveedores.CellPainting += tbProveedores_CellPainting;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "Eliminar";
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Width = 50;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Empresa
            // 
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            Empresa.Width = 150;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero Telefonico";
            Numero.Name = "Numero";
            Numero.Width = 150;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
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
            cbxBuscar.Hint = "buscar por";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Location = new Point(508, 16);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(128, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 27;
            // 
            // formProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 492);
            Controls.Add(cbxBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbProveedores);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formProveedor";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formProveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreEmpresa;
        private TextBox txtId;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCiudad;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPais;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroContacto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreContacto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbProveedores;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Ciudad;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
    }
}