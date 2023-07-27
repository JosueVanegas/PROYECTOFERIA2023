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
            btnUsuario = new RJCodeAdvance.RJControls.RJButton();
            lblUsuario = new Label();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtDireccion = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombreEmpresa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxDepartamento = new ReaLTaiizor.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).BeginInit();
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
            pictureEmpresa.Location = new Point(40, 77);
            pictureEmpresa.Name = "pictureEmpresa";
            pictureEmpresa.Size = new Size(148, 148);
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
            lblTitulo.Text = "Configuracion sobre la Entidad";
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
            cbxPais.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPais.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPais.FormattingEnabled = true;
            cbxPais.Hint = "Seleccione su Pais";
            cbxPais.IntegralHeight = false;
            cbxPais.ItemHeight = 43;
            cbxPais.Items.AddRange(new object[] { "", "Nicaragua", "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania (Myanmar)", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano (Santa Sede)", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos de América", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea-Bissau", "Guinea Ecuatorial", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos (Holanda)", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo (RDC)", "República Dominicana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia (Esuatini)", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            cbxPais.Location = new Point(233, 234);
            cbxPais.MaxDropDownItems = 4;
            cbxPais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(264, 49);
            cbxPais.StartIndex = 0;
            cbxPais.TabIndex = 59;
            cbxPais.SelectedIndexChanged += cbxPais_SelectedIndexChanged;
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
            btnCambiar.Location = new Point(52, 230);
            btnCambiar.Margin = new Padding(3, 2, 3, 2);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(124, 39);
            btnCambiar.TabIndex = 60;
            btnCambiar.Text = "Cambiar";
            btnCambiar.TextColor = Color.White;
            btnCambiar.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            btnUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUsuario.BackColor = Color.FromArgb(63, 63, 70);
            btnUsuario.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnUsuario.BackgroundImage = (Image)resources.GetObject("btnUsuario.BackgroundImage");
            btnUsuario.BackgroundImageLayout = ImageLayout.Center;
            btnUsuario.BorderColor = Color.PaleVioletRed;
            btnUsuario.BorderRadius = 10;
            btnUsuario.BorderSize = 0;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(138, 313);
            btnUsuario.Margin = new Padding(3, 2, 3, 2);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(60, 55);
            btnUsuario.TabIndex = 62;
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.TextColor = Color.White;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Visible = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlDarkDark;
            lblUsuario.Location = new Point(36, 313);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 48);
            lblUsuario.TabIndex = 63;
            lblUsuario.Text = "Creacion de Usuarios";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            lblUsuario.Visible = false;
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
            btnGuardar.Location = new Point(424, 362);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 49);
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
            txtDireccion.Location = new Point(233, 177);
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
            txtDireccion.Size = new Size(516, 48);
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
            txtNombreEmpresa.Location = new Point(233, 120);
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
            txtNombreEmpresa.Size = new Size(516, 48);
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
            txtCorreo.Hint = "Ingrese el correo electronico";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(233, 289);
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
            // materialTextBoxEdit2
            // 
            materialTextBoxEdit2.AnimateReadOnly = true;
            materialTextBoxEdit2.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit2.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit2.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit2.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit2.Depth = 0;
            materialTextBoxEdit2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxEdit2.HideSelection = true;
            materialTextBoxEdit2.Hint = "Ingrese el numero telefonico";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(521, 289);
            materialTextBoxEdit2.MaxLength = 32767;
            materialTextBoxEdit2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit2.Name = "materialTextBoxEdit2";
            materialTextBoxEdit2.PasswordChar = '\0';
            materialTextBoxEdit2.PrefixSuffixText = null;
            materialTextBoxEdit2.ReadOnly = false;
            materialTextBoxEdit2.RightToLeft = RightToLeft.No;
            materialTextBoxEdit2.SelectedText = "";
            materialTextBoxEdit2.SelectionLength = 0;
            materialTextBoxEdit2.SelectionStart = 0;
            materialTextBoxEdit2.ShortcutsEnabled = true;
            materialTextBoxEdit2.Size = new Size(228, 48);
            materialTextBoxEdit2.TabIndex = 69;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Center;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            materialTextBoxEdit2.Visible = false;
            materialTextBoxEdit2.KeyPress += txtNumeroContacto_KeyPress;
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
            cbxDepartamento.Items.AddRange(new object[] { "", "Nicaragua", "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania (Myanmar)", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano (Santa Sede)", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos de América", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea-Bissau", "Guinea Ecuatorial", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos (Holanda)", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo (RDC)", "República Dominicana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia (Esuatini)", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            cbxDepartamento.Location = new Point(503, 234);
            cbxDepartamento.MaxDropDownItems = 4;
            cbxDepartamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(246, 49);
            cbxDepartamento.StartIndex = 0;
            cbxDepartamento.TabIndex = 70;
            // 
            // FormaAjustesEntidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxDepartamento);
            Controls.Add(materialTextBoxEdit2);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreEmpresa);
            Controls.Add(btnGuardar);
            Controls.Add(lblUsuario);
            Controls.Add(btnUsuario);
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
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pictureEmpresa;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPais;
        private RJCodeAdvance.RJControls.RJButton btnCambiar;
        private RJCodeAdvance.RJControls.RJButton btnUsuario;
        private Label lblUsuario;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDireccion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreEmpresa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDepartamento;
    }
}