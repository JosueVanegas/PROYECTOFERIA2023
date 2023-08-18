namespace CapaVista.FormsHerramientas
{
    partial class FormGenerarCodigoBarra
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
            btnGenerar = new ReaLTaiizor.Controls.MaterialButton();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            btnCerrar = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            panelCodigo = new Panel();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerar.Depth = 0;
            btnGenerar.HighEmphasis = true;
            btnGenerar.Icon = null;
            btnGenerar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGenerar.Location = new Point(305, 256);
            btnGenerar.Margin = new Padding(4, 6, 4, 6);
            btnGenerar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGenerar.Name = "btnGenerar";
            btnGenerar.NoAccentTextColor = Color.Empty;
            btnGenerar.Size = new Size(145, 36);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar Codigo";
            btnGenerar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerar.UseAccentColor = false;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.Enabled = false;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGuardar.Location = new Point(305, 304);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "guardar";
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ActiveCaption;
            btnCerrar.Depth = 0;
            btnCerrar.Dock = DockStyle.Left;
            btnCerrar.Icon = null;
            btnCerrar.Location = new Point(3, 0);
            btnCerrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(56, 447);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "\r\n";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.White;
            panelCodigo.Location = new Point(233, 16);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(311, 168);
            panelCodigo.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Ingrese el codigo de barra";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(287, 199);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(221, 48);
            txtCodigo.TabIndex = 4;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // FormGenerarCodigoBarra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigo);
            Controls.Add(panelCodigo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(btnGenerar);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormGenerarCodigoBarra";
            Padding = new Padding(3, 0, 3, 3);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnGenerar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btnCerrar;
        private Panel panelCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
    }
}