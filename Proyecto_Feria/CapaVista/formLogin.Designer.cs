namespace CapaVista
{
    partial class formLogin
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnIngresar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            txtContraseña = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            ckbVerContraseña = new ReaLTaiizor.Controls.AirCheckBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.RosyBrown;
            parrotGradientPanel1.BottomRight = Color.DarkCyan;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Dock = DockStyle.Left;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(3, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(233, 297);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.Fuchsia;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSize = false;
            btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIngresar.Depth = 0;
            btnIngresar.HighEmphasis = true;
            btnIngresar.Icon = null;
            btnIngresar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnIngresar.Location = new Point(255, 211);
            btnIngresar.Margin = new Padding(4, 6, 4, 6);
            btnIngresar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.NoAccentTextColor = Color.Empty;
            btnIngresar.Size = new Size(91, 36);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "ingresar";
            btnIngresar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIngresar.UseAccentColor = false;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = false;
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = true;
            btnSalir.Icon = null;
            btnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalir.Location = new Point(370, 211);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(85, 36);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "salir";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalir.UseAccentColor = false;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = true;
            txtContraseña.AutoCompleteMode = AutoCompleteMode.None;
            txtContraseña.AutoCompleteSource = AutoCompleteSource.None;
            txtContraseña.BackgroundImageLayout = ImageLayout.None;
            txtContraseña.CharacterCasing = CharacterCasing.Normal;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.HideSelection = true;
            txtContraseña.Hint = "ingrese la contraseña";
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(255, 131);
            txtContraseña.MaxLength = 32767;
            txtContraseña.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PrefixSuffixText = null;
            txtContraseña.ReadOnly = false;
            txtContraseña.RightToLeft = RightToLeft.No;
            txtContraseña.SelectedText = "";
            txtContraseña.SelectionLength = 0;
            txtContraseña.SelectionStart = 0;
            txtContraseña.ShortcutsEnabled = true;
            txtContraseña.Size = new Size(200, 48);
            txtContraseña.TabIndex = 3;
            txtContraseña.TabStop = false;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.TrailingIcon = null;
            txtContraseña.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = true;
            txtUsuario.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "ingrese el usuario";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(255, 63);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PrefixSuffixText = null;
            txtUsuario.ReadOnly = false;
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(200, 48);
            txtUsuario.TabIndex = 4;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(255, 9);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(200, 51);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Login";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbVerContraseña
            // 
            ckbVerContraseña.Checked = false;
            ckbVerContraseña.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            ckbVerContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbVerContraseña.Image = null;
            ckbVerContraseña.Location = new Point(255, 185);
            ckbVerContraseña.Name = "ckbVerContraseña";
            ckbVerContraseña.NoRounding = false;
            ckbVerContraseña.Size = new Size(200, 17);
            ckbVerContraseña.TabIndex = 6;
            ckbVerContraseña.Text = "ver contraseña";
            ckbVerContraseña.Transparent = false;
            ckbVerContraseña.CheckedChanged += ckbVerContraseña_CheckedChanged;
            // 
            // lblConexion
            // 
            lblConexion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConexion.ForeColor = SystemColors.ControlDarkDark;
            lblConexion.Location = new Point(255, 273);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(200, 18);
            lblConexion.TabIndex = 7;
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 300);
            Controls.Add(lblConexion);
            Controls.Add(ckbVerContraseña);
            Controls.Add(materialLabel1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(parrotGradientPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formLogin";
            Padding = new Padding(3, 0, 3, 3);
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.MaterialButton btnIngresar;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.AirCheckBox ckbVerContraseña;
        private Label lblConexion;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit txtContraseña;
    }
}