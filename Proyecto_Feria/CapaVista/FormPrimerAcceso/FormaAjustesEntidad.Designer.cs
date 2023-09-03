namespace CapaVista.FormPrimerAcceso
{
    partial class FormaAjustesEntidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaAjustesEntidad));
            pictureEmpresa = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            lblTitulo = new Label();
            cbxPais = new ReaLTaiizor.Controls.MaterialComboBox();
            btnCambiar = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtDireccion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombreEmpresa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefono = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxDepartamento = new ReaLTaiizor.Controls.MaterialComboBox();
            pictureBox4 = new PictureBox();
            txtRubro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pickerFecha = new ReaLTaiizor.Controls.PoisonDateTime();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureEmpresa
            // 
            pictureEmpresa.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureEmpresa.BorderColor = Color.Black;
            pictureEmpresa.BorderColor2 = Color.Black;
            pictureEmpresa.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureEmpresa.BorderSize = 2;
            pictureEmpresa.GradientAngle = 50F;
            pictureEmpresa.Location = new Point(23, 106);
            pictureEmpresa.Name = "pictureEmpresa";
            pictureEmpresa.Size = new Size(187, 187);
            pictureEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEmpresa.TabIndex = 0;
            pictureEmpresa.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(269, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(421, 48);
            lblTitulo.TabIndex = 51;
            lblTitulo.Text = "Información sobre la Empresa";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxPais
            // 
            cbxPais.Anchor = AnchorStyles.Left;
            cbxPais.AutoResize = false;
            cbxPais.BackColor = Color.FromArgb(255, 255, 255);
            cbxPais.Depth = 0;
            cbxPais.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPais.DropDownHeight = 174;
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.DropDownWidth = 121;
            cbxPais.Enabled = false;
            cbxPais.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPais.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPais.FormattingEnabled = true;
            cbxPais.Hint = "Seleccione su País";
            cbxPais.IntegralHeight = false;
            cbxPais.ItemHeight = 43;
            cbxPais.Items.AddRange(new object[] { "Nicaragua" });
            cbxPais.Location = new Point(521, 160);
            cbxPais.MaxDropDownItems = 4;
            cbxPais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(246, 49);
            cbxPais.StartIndex = 0;
            cbxPais.TabIndex = 59;
            // 
            // btnCambiar
            // 
            btnCambiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCambiar.BackColor = Color.FromArgb(63, 63, 70);
            btnCambiar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnCambiar.BackgroundImageLayout = ImageLayout.Center;
            btnCambiar.BorderColor = Color.PaleVioletRed;
            btnCambiar.BorderRadius = 10;
            btnCambiar.BorderSize = 0;
            btnCambiar.FlatAppearance.BorderSize = 0;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiar.ForeColor = Color.White;
            btnCambiar.Location = new Point(55, 298);
            btnCambiar.Margin = new Padding(3, 2, 3, 2);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(124, 36);
            btnCambiar.TabIndex = 60;
            btnCambiar.Text = "Cambiar";
            btnCambiar.TextColor = Color.White;
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(411, 351);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 46);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            txtDireccion.Hint = "Ingrese la dirreccion de la Empresa";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(233, 215);
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
            txtDireccion.Size = new Size(282, 48);
            txtDireccion.TabIndex = 67;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
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
            txtNombreEmpresa.Location = new Point(233, 106);
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
            txtNombreEmpresa.Size = new Size(282, 48);
            txtNombreEmpresa.TabIndex = 66;
            txtNombreEmpresa.TabStop = false;
            txtNombreEmpresa.TextAlign = HorizontalAlignment.Center;
            txtNombreEmpresa.TrailingIcon = null;
            txtNombreEmpresa.UseSystemPasswordChar = false;
            txtNombreEmpresa.KeyPress += txtNombre_KeyPress;
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
            txtCorreo.Hint = "Ingrese el correo electrónico";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(233, 269);
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
            txtCorreo.Size = new Size(282, 48);
            txtCorreo.TabIndex = 68;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseSystemPasswordChar = false;
            txtCorreo.KeyPress += materialTextBoxEdit1_KeyPress;
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
            txtTelefono.Hint = "Ingrese el numero telefonico";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(521, 216);
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
            txtTelefono.Size = new Size(246, 48);
            txtTelefono.TabIndex = 69;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.KeyPress += txtNumeroContacto_KeyPress;
            // 
            // cbxDepartamento
            // 
            cbxDepartamento.Anchor = AnchorStyles.Left;
            cbxDepartamento.AutoResize = false;
            cbxDepartamento.BackColor = Color.FromArgb(255, 255, 255);
            cbxDepartamento.Depth = 0;
            cbxDepartamento.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDepartamento.DropDownHeight = 174;
            cbxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartamento.DropDownWidth = 121;
            cbxDepartamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDepartamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDepartamento.FormattingEnabled = true;
            cbxDepartamento.Hint = "Seleccione su Departamento";
            cbxDepartamento.IntegralHeight = false;
            cbxDepartamento.ItemHeight = 43;
            cbxDepartamento.Items.AddRange(new object[] { "Managua", "Boaco", "Carazo", "Chinandega", "Chontales", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Masaya", "Matagalpa", "Nueva Segovia", "Rivas", "Río San Juan", "Región Autónoma de la Costa Caribe Norte (RACCN)", "Región Autónoma de la Costa Caribe Sur (RACCS)" });
            cbxDepartamento.Location = new Point(521, 105);
            cbxDepartamento.MaxDropDownItems = 4;
            cbxDepartamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(246, 49);
            cbxDepartamento.StartIndex = 0;
            cbxDepartamento.TabIndex = 70;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(731, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 71;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += pictureBox1_MouseHover;
            // 
            // txtRubro
            // 
            txtRubro.AnimateReadOnly = true;
            txtRubro.AutoCompleteMode = AutoCompleteMode.None;
            txtRubro.AutoCompleteSource = AutoCompleteSource.None;
            txtRubro.BackgroundImageLayout = ImageLayout.None;
            txtRubro.CharacterCasing = CharacterCasing.Normal;
            txtRubro.Depth = 0;
            txtRubro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRubro.HideSelection = true;
            txtRubro.Hint = "ingrese el rubro de la empresa";
            txtRubro.LeadingIcon = null;
            txtRubro.Location = new Point(233, 161);
            txtRubro.MaxLength = 32767;
            txtRubro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRubro.Name = "txtRubro";
            txtRubro.PasswordChar = '\0';
            txtRubro.PrefixSuffixText = null;
            txtRubro.ReadOnly = false;
            txtRubro.RightToLeft = RightToLeft.No;
            txtRubro.SelectedText = "";
            txtRubro.SelectionLength = 0;
            txtRubro.SelectionStart = 0;
            txtRubro.ShortcutsEnabled = true;
            txtRubro.Size = new Size(282, 48);
            txtRubro.TabIndex = 72;
            txtRubro.TabStop = false;
            txtRubro.TextAlign = HorizontalAlignment.Center;
            txtRubro.TrailingIcon = null;
            txtRubro.UseSystemPasswordChar = false;
            // 
            // pickerFecha
            // 
            pickerFecha.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pickerFecha.Location = new Point(522, 288);
            pickerFecha.MinimumSize = new Size(0, 29);
            pickerFecha.Name = "pickerFecha";
            pickerFecha.Size = new Size(248, 29);
            pickerFecha.TabIndex = 73;
            pickerFecha.UseCustomForeColor = true;
            pickerFecha.Value = new DateTime(2023, 9, 2, 9, 45, 42, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 270);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 74;
            label1.Text = "Seleccione la fecha de creación del negocio   ";
            // 
            // FormaAjustesEntidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 447);
            Controls.Add(label1);
            Controls.Add(pickerFecha);
            Controls.Add(txtRubro);
            Controls.Add(pictureBox4);
            Controls.Add(cbxDepartamento);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreEmpresa);
            Controls.Add(btnGuardar);
            Controls.Add(btnCambiar);
            Controls.Add(cbxPais);
            Controls.Add(lblTitulo);
            Controls.Add(pictureEmpresa);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormaAjustesEntidad";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FormaAjustesEntidad";
            Load += FormaAjustesEntidad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pictureEmpresa;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPais;
        private RJCodeAdvance.RJControls.RJButton btnCambiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDireccion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreEmpresa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefono;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDepartamento;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRubro;
        private ReaLTaiizor.Controls.PoisonDateTime pickerFecha;
        private Label label1;
    }
}