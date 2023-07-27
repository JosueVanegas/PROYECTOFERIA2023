namespace CapaVista.FormPrimerAcceso
{
    partial class FormUsuarioInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioInicial));
            panel1 = new Panel();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            cbxEmpleados = new ReaLTaiizor.Controls.MaterialComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtConfirmarClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ckbVerContraseña = new ReaLTaiizor.Controls.AirCheckBox();
            cbxRol = new ReaLTaiizor.Controls.MaterialComboBox();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbxEmpleados);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(txtConfirmarClave);
            panel1.Controls.Add(ckbVerContraseña);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 423);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(283, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 75);
            lblTitulo.TabIndex = 59;
            lblTitulo.Text = "Completa toda la informacion, esto te servira para tener acceso al sistema y cada uno de sus funciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // cbxEmpleados
            // 
            cbxEmpleados.Anchor = AnchorStyles.Left;
            cbxEmpleados.AutoResize = false;
            cbxEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            cbxEmpleados.Depth = 0;
            cbxEmpleados.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEmpleados.DropDownHeight = 174;
            cbxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleados.DropDownWidth = 121;
            cbxEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEmpleados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEmpleados.FormattingEnabled = true;
            cbxEmpleados.Hint = "seleccione un empleado";
            cbxEmpleados.IntegralHeight = false;
            cbxEmpleados.ItemHeight = 43;
            cbxEmpleados.Location = new Point(21, 263);
            cbxEmpleados.MaxDropDownItems = 4;
            cbxEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(234, 49);
            cbxEmpleados.StartIndex = 0;
            cbxEmpleados.TabIndex = 39;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(98, 324);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(78, 80);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(72, 76);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Anchor = AnchorStyles.Left;
            txtConfirmarClave.AnimateReadOnly = true;
            txtConfirmarClave.AutoCompleteMode = AutoCompleteMode.None;
            txtConfirmarClave.AutoCompleteSource = AutoCompleteSource.None;
            txtConfirmarClave.BackgroundImageLayout = ImageLayout.None;
            txtConfirmarClave.CharacterCasing = CharacterCasing.Normal;
            txtConfirmarClave.Depth = 0;
            txtConfirmarClave.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarClave.HideSelection = true;
            txtConfirmarClave.Hint = "ingrese la clave nuevamente";
            txtConfirmarClave.LeadingIcon = null;
            txtConfirmarClave.Location = new Point(21, 132);
            txtConfirmarClave.MaxLength = 32767;
            txtConfirmarClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.PrefixSuffixText = null;
            txtConfirmarClave.ReadOnly = false;
            txtConfirmarClave.RightToLeft = RightToLeft.No;
            txtConfirmarClave.SelectedText = "";
            txtConfirmarClave.SelectionLength = 0;
            txtConfirmarClave.SelectionStart = 0;
            txtConfirmarClave.ShortcutsEnabled = true;
            txtConfirmarClave.Size = new Size(234, 48);
            txtConfirmarClave.TabIndex = 37;
            txtConfirmarClave.TabStop = false;
            txtConfirmarClave.TextAlign = HorizontalAlignment.Center;
            txtConfirmarClave.TrailingIcon = null;
            txtConfirmarClave.UseSystemPasswordChar = false;
            // 
            // ckbVerContraseña
            // 
            ckbVerContraseña.Anchor = AnchorStyles.Left;
            ckbVerContraseña.Checked = false;
            ckbVerContraseña.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            ckbVerContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbVerContraseña.Image = null;
            ckbVerContraseña.Location = new Point(21, 186);
            ckbVerContraseña.Name = "ckbVerContraseña";
            ckbVerContraseña.NoRounding = false;
            ckbVerContraseña.Size = new Size(234, 17);
            ckbVerContraseña.TabIndex = 36;
            ckbVerContraseña.Text = "ver contraseña";
            ckbVerContraseña.Transparent = false;
            ckbVerContraseña.CheckedChanged += ckbVerContraseña_CheckedChanged;
            // 
            // cbxRol
            // 
            cbxRol.Anchor = AnchorStyles.Left;
            cbxRol.AutoResize = false;
            cbxRol.BackColor = Color.FromArgb(255, 255, 255);
            cbxRol.Depth = 0;
            cbxRol.DrawMode = DrawMode.OwnerDrawVariable;
            cbxRol.DropDownHeight = 174;
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.DropDownWidth = 121;
            cbxRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxRol.FormattingEnabled = true;
            cbxRol.Hint = "seleccione un rol de usuario";
            cbxRol.IntegralHeight = false;
            cbxRol.ItemHeight = 43;
            cbxRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cbxRol.Location = new Point(21, 209);
            cbxRol.MaxDropDownItems = 4;
            cbxRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(234, 49);
            cbxRol.StartIndex = 0;
            cbxRol.TabIndex = 34;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Left;
            txtClave.AnimateReadOnly = true;
            txtClave.AutoCompleteMode = AutoCompleteMode.None;
            txtClave.AutoCompleteSource = AutoCompleteSource.None;
            txtClave.BackgroundImageLayout = ImageLayout.None;
            txtClave.CharacterCasing = CharacterCasing.Normal;
            txtClave.Depth = 0;
            txtClave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.HideSelection = true;
            txtClave.Hint = "ingrese la clave de usuario";
            txtClave.LeadingIcon = null;
            txtClave.Location = new Point(21, 78);
            txtClave.MaxLength = 32767;
            txtClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PrefixSuffixText = null;
            txtClave.ReadOnly = false;
            txtClave.RightToLeft = RightToLeft.No;
            txtClave.SelectedText = "";
            txtClave.SelectionLength = 0;
            txtClave.SelectionStart = 0;
            txtClave.ShortcutsEnabled = true;
            txtClave.Size = new Size(234, 48);
            txtClave.TabIndex = 33;
            txtClave.TabStop = false;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.TrailingIcon = null;
            txtClave.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Left;
            txtUsuario.AnimateReadOnly = true;
            txtUsuario.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "ingrese el nombre de usuario";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(21, 24);
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
            txtUsuario.Size = new Size(234, 48);
            txtUsuario.TabIndex = 32;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // FormUsuarioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormUsuarioInicial";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            Text = "FormUsuarioInicial";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleados;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConfirmarClave;
        private ReaLTaiizor.Controls.AirCheckBox ckbVerContraseña;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRol;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
}