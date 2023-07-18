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
            FechaNacimientoCalendario = new MonthCalendar();
            txtFechadeNacimiento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnFechaNacimiento = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            txtDireccion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxProveedor = new ReaLTaiizor.Controls.MaterialComboBox();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroCedula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumeroContacto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new TextBox();
            pictureBox1 = new PictureBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            tbProveedores = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombreEmpresa = new DataGridViewTextBoxColumn();
            NombreContacto = new DataGridViewTextBoxColumn();
            NumeroContacto = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFechaNacimiento).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FechaNacimientoCalendario);
            panel1.Controls.Add(txtFechadeNacimiento);
            panel1.Controls.Add(btnFechaNacimiento);
            panel1.Controls.Add(tableLayoutPanel2);
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
            panel1.Size = new Size(302, 496);
            panel1.TabIndex = 20;
            // 
            // FechaNacimientoCalendario
            // 
            FechaNacimientoCalendario.Location = new Point(48, 205);
            FechaNacimientoCalendario.Name = "FechaNacimientoCalendario";
            FechaNacimientoCalendario.ShowTodayCircle = false;
            FechaNacimientoCalendario.TabIndex = 21;
            FechaNacimientoCalendario.Visible = false;
            FechaNacimientoCalendario.DateSelected += MonthCalendar1_DateSelected;
            FechaNacimientoCalendario.MouseLeave += FechaNacimientoCalendario_MouseLeave;
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
            txtFechadeNacimiento.Location = new Point(74, 319);
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
            txtFechadeNacimiento.Size = new Size(205, 48);
            txtFechadeNacimiento.TabIndex = 43;
            txtFechadeNacimiento.TabStop = false;
            txtFechadeNacimiento.TextAlign = HorizontalAlignment.Center;
            txtFechadeNacimiento.TrailingIcon = null;
            txtFechadeNacimiento.UseSystemPasswordChar = false;
            txtFechadeNacimiento.KeyPress += Form1_KeyPress;
            // 
            // btnFechaNacimiento
            // 
            btnFechaNacimiento.Image = (Image)resources.GetObject("btnFechaNacimiento.Image");
            btnFechaNacimiento.Location = new Point(25, 333);
            btnFechaNacimiento.Name = "btnFechaNacimiento";
            btnFechaNacimiento.Size = new Size(33, 34);
            btnFechaNacimiento.SizeMode = PictureBoxSizeMode.Zoom;
            btnFechaNacimiento.TabIndex = 42;
            btnFechaNacimiento.TabStop = false;
            btnFechaNacimiento.MouseEnter += PictureBox1_MouseEnter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.Controls.Add(rjButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(rjButton2, 2, 0);
            tableLayoutPanel2.Controls.Add(rjButton3, 1, 0);
            tableLayoutPanel2.Location = new Point(31, 392);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(234, 80);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Left;
            rjButton1.BackColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundImage = (Image)resources.GetObject("rjButton1.BackgroundImage");
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(3, 2);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(71, 76);
            rjButton1.TabIndex = 11;
            rjButton1.Text = "Guardar";
            rjButton1.TextAlign = ContentAlignment.BottomCenter;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.MouseHover += btnGuardar_MouseHover;
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
            rjButton2.Location = new Point(158, 2);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(73, 76);
            rjButton2.TabIndex = 10;
            rjButton2.Text = "Eliminar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.MouseHover += btnEliminar_MouseHover;
            // 
            // rjButton3
            // 
            rjButton3.Anchor = AnchorStyles.Left;
            rjButton3.BackColor = Color.FromArgb(63, 63, 70);
            rjButton3.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton3.BackgroundImage = (Image)resources.GetObject("rjButton3.BackgroundImage");
            rjButton3.BackgroundImageLayout = ImageLayout.Center;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.ImageAlign = ContentAlignment.MiddleRight;
            rjButton3.Location = new Point(80, 2);
            rjButton3.Margin = new Padding(3, 2, 3, 2);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(72, 76);
            rjButton3.TabIndex = 12;
            rjButton3.Text = "Limpiar";
            rjButton3.TextAlign = ContentAlignment.BottomCenter;
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.MouseHover += btnLimpiar_MouseHover;
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
            txtDireccion.Hint = "Ingrese la direccion de vivienda";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(9, 265);
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
            txtDireccion.Size = new Size(270, 48);
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
            txtCorreo.Hint = "Ingrese el Correo Electronico";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(9, 211);
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
            txtCorreo.Size = new Size(270, 48);
            txtCorreo.TabIndex = 39;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseSystemPasswordChar = false;
            txtCorreo.KeyPress += materialTextBoxEdit1_KeyPress;
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
            cbxProveedor.Location = new Point(11, 157);
            cbxProveedor.MaxDropDownItems = 4;
            cbxProveedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(131, 49);
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
            txtApellido.Location = new Point(146, 43);
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
            txtApellido.Size = new Size(133, 48);
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
            txtNumeroCedula.Hint = "Ingrese el numero de Cedula";
            txtNumeroCedula.LeadingIcon = null;
            txtNumeroCedula.Location = new Point(9, 103);
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
            txtNumeroCedula.Size = new Size(270, 48);
            txtNumeroCedula.TabIndex = 32;
            txtNumeroCedula.TabStop = false;
            txtNumeroCedula.TextAlign = HorizontalAlignment.Center;
            txtNumeroCedula.TrailingIcon = null;
            txtNumeroCedula.UseSystemPasswordChar = false;
            txtNumeroCedula.TextChanged += txtNumeroCedula_TextChanged;
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
            txtNumeroContacto.Location = new Point(148, 157);
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
            txtNumeroContacto.Size = new Size(131, 48);
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
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Location = new Point(28, 584);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(234, 80);
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
            btnEliminar.Location = new Point(158, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 76);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnLimpiar.Location = new Point(80, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 76);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(25, -8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Proveedor";
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
            txtNombre.Location = new Point(9, 43);
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
            txtNombre.Size = new Size(131, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtId
            // 
            txtId.Location = new Point(244, 7);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 8;
            txtId.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(311, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 55);
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
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(593, 13);
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
            txtBuscar.Size = new Size(299, 48);
            txtBuscar.TabIndex = 40;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(366, 13);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(215, 48);
            lblEncabezado.TabIndex = 39;
            lblEncabezado.Text = "Empleados registradas";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbProveedores.ColumnHeadersHeight = 40;
            tbProveedores.Columns.AddRange(new DataGridViewColumn[] { btnEditar, id, nombreEmpresa, NombreContacto, NumeroContacto, Pais, Ciudad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            tbProveedores.EnableHeadersVisualStyles = false;
            tbProveedores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProveedores.GridColor = Color.FromArgb(255, 255, 255);
            tbProveedores.Location = new Point(311, 82);
            tbProveedores.Name = "tbProveedores";
            tbProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbProveedores.RowHeadersVisible = false;
            tbProveedores.RowHeadersWidth = 40;
            tbProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProveedores.RowTemplate.Height = 30;
            tbProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProveedores.Size = new Size(581, 405);
            tbProveedores.TabIndex = 38;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombreEmpresa
            // 
            nombreEmpresa.HeaderText = "Empresa";
            nombreEmpresa.Name = "nombreEmpresa";
            nombreEmpresa.ReadOnly = true;
            nombreEmpresa.Width = 130;
            // 
            // NombreContacto
            // 
            NombreContacto.HeaderText = "Contacto";
            NombreContacto.Name = "NombreContacto";
            // 
            // NumeroContacto
            // 
            NumeroContacto.HeaderText = "Numero Telefonico";
            NumeroContacto.Name = "NumeroContacto";
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
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 499);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbProveedores);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formEmpleados";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formEmpleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnFechaNacimiento).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroContacto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumeroCedula;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
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
        private ReaLTaiizor.Controls.PoisonDataGridView tbProveedores;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombreEmpresa;
        private DataGridViewTextBoxColumn NombreContacto;
        private DataGridViewTextBoxColumn NumeroContacto;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Ciudad;
        private PictureBox btnFechaNacimiento;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFechadeNacimiento;
    }
}