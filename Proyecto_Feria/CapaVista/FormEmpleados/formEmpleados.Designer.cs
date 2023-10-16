namespace CapaVista
{
    partial class formEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dtNacimiento = new DateTimePicker();
            pictureBox4 = new PictureBox();
            txtCargo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtSalario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDireccion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxSexo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroCedula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefono = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new TextBox();
            pictureBox1 = new PictureBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            panel2 = new Panel();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            tbEmpleados = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Nacimiento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtNacimiento);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(cbxSexo);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNumeroCedula);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtId);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 496);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(5, 344);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 48;
            label1.Text = "Fecha de Nacimiento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtNacimiento
            // 
            dtNacimiento.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtNacimiento.Location = new Point(169, 341);
            dtNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(219, 23);
            dtNacimiento.TabIndex = 47;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(340, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += pictureBox1_MouseHover;
            // 
            // txtCargo
            // 
            txtCargo.AnimateReadOnly = true;
            txtCargo.AutoCompleteMode = AutoCompleteMode.None;
            txtCargo.AutoCompleteSource = AutoCompleteSource.None;
            txtCargo.BackgroundImageLayout = ImageLayout.None;
            txtCargo.CharacterCasing = CharacterCasing.Normal;
            txtCargo.Depth = 0;
            txtCargo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.HideSelection = true;
            txtCargo.Hint = "Cargo del empleado";
            txtCargo.LeadingIcon = null;
            txtCargo.Location = new Point(5, 239);
            txtCargo.MaxLength = 32767;
            txtCargo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCargo.Name = "txtCargo";
            txtCargo.PasswordChar = '\0';
            txtCargo.PrefixSuffixText = null;
            txtCargo.ReadOnly = false;
            txtCargo.RightToLeft = RightToLeft.No;
            txtCargo.SelectedText = "";
            txtCargo.SelectionLength = 0;
            txtCargo.SelectionStart = 0;
            txtCargo.ShortcutsEnabled = true;
            txtCargo.Size = new Size(177, 48);
            txtCargo.TabIndex = 45;
            txtCargo.TabStop = false;
            txtCargo.TextAlign = HorizontalAlignment.Center;
            txtCargo.TrailingIcon = null;
            txtCargo.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel2.Location = new Point(108, 385);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(155, 70);
            tableLayoutPanel2.TabIndex = 41;
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
            btnLimpiar.Location = new Point(80, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 65);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
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
            btnGuardar.Location = new Point(3, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(71, 65);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseHover += btnGuardar_MouseHover;
            // 
            // txtSalario
            // 
            txtSalario.AnimateReadOnly = true;
            txtSalario.AutoCompleteMode = AutoCompleteMode.None;
            txtSalario.AutoCompleteSource = AutoCompleteSource.None;
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.CharacterCasing = CharacterCasing.Normal;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.HideSelection = true;
            txtSalario.Hint = "Salario por hora";
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(188, 239);
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffixText = null;
            txtSalario.ReadOnly = false;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(199, 48);
            txtSalario.TabIndex = 44;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Center;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = true;
            txtDireccion.AutoCompleteMode = AutoCompleteMode.None;
            txtDireccion.AutoCompleteSource = AutoCompleteSource.None;
            txtDireccion.BackgroundImageLayout = ImageLayout.None;
            txtDireccion.CharacterCasing = CharacterCasing.Normal;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.HideSelection = true;
            txtDireccion.Hint = "direccion de vivienda";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(5, 293);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.PrefixSuffixText = null;
            txtDireccion.ReadOnly = false;
            txtDireccion.RightToLeft = RightToLeft.No;
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.ShortcutsEnabled = true;
            txtDireccion.Size = new Size(380, 48);
            txtDireccion.TabIndex = 40;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.AnimateReadOnly = true;
            txtCorreo.AutoCompleteMode = AutoCompleteMode.None;
            txtCorreo.AutoCompleteSource = AutoCompleteSource.None;
            txtCorreo.BackgroundImageLayout = ImageLayout.None;
            txtCorreo.CharacterCasing = CharacterCasing.Normal;
            txtCorreo.Depth = 0;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.HideSelection = true;
            txtCorreo.Hint = "Correo Electronico";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(188, 185);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.PrefixSuffixText = null;
            txtCorreo.ReadOnly = false;
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.ShortcutsEnabled = true;
            txtCorreo.Size = new Size(200, 48);
            txtCorreo.TabIndex = 39;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // cbxSexo
            // 
            cbxSexo.AutoResize = false;
            cbxSexo.BackColor = Color.FromArgb(255, 255, 255);
            cbxSexo.Depth = 0;
            cbxSexo.DrawMode = DrawMode.OwnerDrawVariable;
            cbxSexo.DropDownHeight = 174;
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.DropDownWidth = 121;
            cbxSexo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxSexo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Hint = "Sexo";
            cbxSexo.IntegralHeight = false;
            cbxSexo.ItemHeight = 43;
            cbxSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cbxSexo.Location = new Point(188, 128);
            cbxSexo.MaxDropDownItems = 4;
            cbxSexo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(200, 49);
            cbxSexo.StartIndex = 0;
            cbxSexo.TabIndex = 38;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = true;
            txtApellido.AutoCompleteMode = AutoCompleteMode.None;
            txtApellido.AutoCompleteSource = AutoCompleteSource.None;
            txtApellido.BackgroundImageLayout = ImageLayout.None;
            txtApellido.CharacterCasing = CharacterCasing.Normal;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.HideSelection = true;
            txtApellido.Hint = "Apellidos";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(188, 75);
            txtApellido.MaxLength = 32767;
            txtApellido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '\0';
            txtApellido.PrefixSuffixText = null;
            txtApellido.ReadOnly = false;
            txtApellido.RightToLeft = RightToLeft.No;
            txtApellido.SelectedText = "";
            txtApellido.SelectionLength = 0;
            txtApellido.SelectionStart = 0;
            txtApellido.ShortcutsEnabled = true;
            txtApellido.Size = new Size(200, 48);
            txtApellido.TabIndex = 37;
            txtApellido.TabStop = false;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            txtApellido.TrailingIcon = null;
            txtApellido.UseSystemPasswordChar = false;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNumeroCedula
            // 
            txtNumeroCedula.AnimateReadOnly = true;
            txtNumeroCedula.AutoCompleteMode = AutoCompleteMode.None;
            txtNumeroCedula.AutoCompleteSource = AutoCompleteSource.None;
            txtNumeroCedula.BackgroundImageLayout = ImageLayout.None;
            txtNumeroCedula.CharacterCasing = CharacterCasing.Normal;
            txtNumeroCedula.Depth = 0;
            txtNumeroCedula.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroCedula.HideSelection = true;
            txtNumeroCedula.Hint = "No.Cedula";
            txtNumeroCedula.LeadingIcon = null;
            txtNumeroCedula.Location = new Point(3, 128);
            txtNumeroCedula.MaxLength = 32767;
            txtNumeroCedula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumeroCedula.Name = "txtNumeroCedula";
            txtNumeroCedula.PasswordChar = '\0';
            txtNumeroCedula.PrefixSuffixText = null;
            txtNumeroCedula.ReadOnly = false;
            txtNumeroCedula.RightToLeft = RightToLeft.No;
            txtNumeroCedula.SelectedText = "";
            txtNumeroCedula.SelectionLength = 0;
            txtNumeroCedula.SelectionStart = 0;
            txtNumeroCedula.ShortcutsEnabled = true;
            txtNumeroCedula.Size = new Size(177, 48);
            txtNumeroCedula.TabIndex = 32;
            txtNumeroCedula.TabStop = false;
            txtNumeroCedula.TextAlign = HorizontalAlignment.Center;
            txtNumeroCedula.TrailingIcon = null;
            txtNumeroCedula.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = true;
            txtTelefono.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefono.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "# Telefonico";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(5, 185);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(177, 48);
            txtTelefono.TabIndex = 33;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.KeyPress += txtCorreo_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Location = new Point(28, 584);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(234, 80);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(5, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Empleado";
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
            txtNombre.Hint = "Nombres";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(3, 75);
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
            txtNombre.Size = new Size(177, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtId
            // 
            txtId.Location = new Point(280, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
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
            txtBuscar.Location = new Point(495, 0);
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
            txtBuscar.Size = new Size(262, 48);
            txtBuscar.TabIndex = 40;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(49, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(292, 49);
            lblEncabezado.TabIndex = 39;
            lblEncabezado.Text = "Empleados registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(cbxBuscar);
            panel2.Controls.Add(lblEncabezado);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(405, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 49);
            panel2.TabIndex = 41;
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
            cbxBuscar.Items.AddRange(new object[] { "Cedula", "Nombre", "Apellido", "Sexo", "Fecha de nacimiento", "Teléfono", "Dirección", "Correo", "Cargo", "Salario" });
            cbxBuscar.Location = new Point(341, 0);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(154, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 41;
            // 
            // tbEmpleados
            // 
            tbEmpleados.AllowUserToAddRows = false;
            tbEmpleados.AllowUserToOrderColumns = true;
            tbEmpleados.AllowUserToResizeRows = false;
            tbEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbEmpleados.BackgroundColor = Color.White;
            tbEmpleados.BorderStyle = BorderStyle.None;
            tbEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbEmpleados.ColumnHeadersHeight = 35;
            tbEmpleados.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnBorrar, Id, Cedula, Nombre, Apellido, Sexo, Nacimiento, Telefono, Direccion, Correo, Cargo, Salario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            tbEmpleados.Dock = DockStyle.Fill;
            tbEmpleados.EnableHeadersVisualStyles = false;
            tbEmpleados.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmpleados.GridColor = Color.Gray;
            tbEmpleados.Location = new Point(405, 49);
            tbEmpleados.Name = "tbEmpleados";
            tbEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbEmpleados.RowHeadersVisible = false;
            tbEmpleados.RowHeadersWidth = 40;
            tbEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbEmpleados.RowTemplate.Height = 30;
            tbEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbEmpleados.Size = new Size(808, 447);
            tbEmpleados.TabIndex = 42;
            tbEmpleados.CellContentClick += tbEmpleados_CellContentClick;
            tbEmpleados.CellPainting += tbEmpleados_CellPainting;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "Eliminar";
            btnBorrar.MinimumWidth = 6;
            btnBorrar.Name = "btnBorrar";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Nacimiento
            // 
            Nacimiento.HeaderText = "Fecha de nacimiento";
            Nacimiento.MinimumWidth = 6;
            Nacimiento.Name = "Nacimiento";
            Nacimiento.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario por hora";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            // 
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 499);
            Controls.Add(tbEmpleados);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formEmpleados";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formEmpleados";
            Load += formEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefono;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroCedula;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.MaterialComboBox cbxSexo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDireccion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalario;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCargo;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.PoisonDataGridView tbEmpleados;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private Label label1;
        private DateTimePicker dtNacimiento;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Nacimiento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
    }
}