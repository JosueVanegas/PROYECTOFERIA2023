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
            panel1 = new Panel();
            txtCargo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            FechaNacimientoCalendario = new MonthCalendar();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            txtSalario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtFechadeNacimiento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDireccion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroCedula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroContacto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new TextBox();
            pictureBox1 = new PictureBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(FechaNacimientoCalendario);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(txtFechadeNacimiento);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(cbxProveedor);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNumeroCedula);
            panel1.Controls.Add(txtNumeroContacto);
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
            txtCargo.Location = new Point(3, 197);
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
            // FechaNacimientoCalendario
            // 
            FechaNacimientoCalendario.FirstDayOfWeek = Day.Monday;
            FechaNacimientoCalendario.Location = new Point(136, 279);
            FechaNacimientoCalendario.Name = "FechaNacimientoCalendario";
            FechaNacimientoCalendario.ShowTodayCircle = false;
            FechaNacimientoCalendario.TabIndex = 21;
            FechaNacimientoCalendario.Visible = false;
            FechaNacimientoCalendario.DateSelected += MonthCalendar1_DateSelected;
            FechaNacimientoCalendario.MouseLeave += FechaNacimientoCalendario_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel2.Location = new Point(106, 401);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(155, 70);
            tableLayoutPanel2.TabIndex = 41;
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
            btnGuardar.Size = new Size(71, 66);
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
            btnLimpiar.Size = new Size(72, 66);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.MouseHover += btnLimpiar_MouseHover;
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
            txtSalario.Hint = "Salario";
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(3, 251);
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
            txtSalario.Size = new Size(177, 48);
            txtSalario.TabIndex = 44;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Center;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // txtFechadeNacimiento
            // 
            txtFechadeNacimiento.AnimateReadOnly = true;
            txtFechadeNacimiento.AutoCompleteMode = AutoCompleteMode.None;
            txtFechadeNacimiento.AutoCompleteSource = AutoCompleteSource.None;
            txtFechadeNacimiento.BackgroundImageLayout = ImageLayout.None;
            txtFechadeNacimiento.CharacterCasing = CharacterCasing.Normal;
            txtFechadeNacimiento.Depth = 0;
            txtFechadeNacimiento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechadeNacimiento.HideSelection = true;
            txtFechadeNacimiento.Hint = "Fecha de Nacimiento";
            txtFechadeNacimiento.LeadingIcon = null;
            txtFechadeNacimiento.Location = new Point(186, 251);
            txtFechadeNacimiento.MaxLength = 32767;
            txtFechadeNacimiento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFechadeNacimiento.Name = "txtFechadeNacimiento";
            txtFechadeNacimiento.PasswordChar = '\0';
            txtFechadeNacimiento.PrefixSuffixText = null;
            txtFechadeNacimiento.ReadOnly = false;
            txtFechadeNacimiento.RightToLeft = RightToLeft.No;
            txtFechadeNacimiento.SelectedText = "";
            txtFechadeNacimiento.SelectionLength = 0;
            txtFechadeNacimiento.SelectionStart = 0;
            txtFechadeNacimiento.ShortcutsEnabled = true;
            txtFechadeNacimiento.Size = new Size(200, 48);
            txtFechadeNacimiento.TabIndex = 43;
            txtFechadeNacimiento.TabStop = false;
            txtFechadeNacimiento.TextAlign = HorizontalAlignment.Center;
            txtFechadeNacimiento.TrailingIcon = null;
            txtFechadeNacimiento.UseSystemPasswordChar = false;
            txtFechadeNacimiento.KeyPress += txtFecha_KeyPress;
            txtFechadeNacimiento.MouseHover += txtFechadeNacimiento_MouseHover;
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
            txtDireccion.Location = new Point(186, 196);
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
            txtDireccion.Size = new Size(200, 48);
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
            txtCorreo.Location = new Point(186, 143);
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
            // cbxProveedor
            // 
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
            cbxProveedor.Hint = "Sexo";
            cbxProveedor.IntegralHeight = false;
            cbxProveedor.ItemHeight = 43;
            cbxProveedor.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cbxProveedor.Location = new Point(186, 88);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(200, 49);
            cbxProveedor.StartIndex = 0;
            cbxProveedor.TabIndex = 38;
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
            txtApellido.Hint = "Apellido";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(186, 34);
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
            txtNumeroCedula.Location = new Point(3, 87);
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
            txtNumeroContacto.Hint = "# Telefonico";
            txtNumeroContacto.LeadingIcon = null;
            txtNumeroContacto.Location = new Point(3, 143);
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
            txtNumeroContacto.Size = new Size(177, 48);
            txtNumeroContacto.TabIndex = 33;
            txtNumeroContacto.TabStop = false;
            txtNumeroContacto.TextAlign = HorizontalAlignment.Center;
            txtNumeroContacto.TrailingIcon = null;
            txtNumeroContacto.UseSystemPasswordChar = false;
            txtNumeroContacto.KeyPress += txtNumeroContacto_KeyPress;
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
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 30);
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
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(3, 33);
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
            txtId.Location = new Point(199, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 8;
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
            pictureBox1.MouseHover += pictureBox1_MouseHover;
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
            txtBuscar.Location = new Point(264, 0);
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
            lblEncabezado.Size = new Size(215, 49);
            lblEncabezado.TabIndex = 39;
            lblEncabezado.Text = "Empleados registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(lblEncabezado);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(405, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 49);
            panel2.TabIndex = 41;
            // 
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 499);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formEmpleados";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formEmpleados";
            Load += formEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroContacto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroCedula;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedor;
        private MonthCalendar FechaNacimientoCalendario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDireccion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFechadeNacimiento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalario;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCargo;
    }
}