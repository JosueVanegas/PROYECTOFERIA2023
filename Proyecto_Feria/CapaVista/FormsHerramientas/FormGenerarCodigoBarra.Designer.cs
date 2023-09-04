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
            panelCodigo = new Panel();
            imagenCodigo = new PictureBox();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenCodigo).BeginInit();
            SuspendLayout();
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.White;
            panelCodigo.Controls.Add(imagenCodigo);
            panelCodigo.Location = new Point(53, 37);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(311, 168);
            panelCodigo.TabIndex = 3;
            // 
            // imagenCodigo
            // 
            imagenCodigo.Dock = DockStyle.Fill;
            imagenCodigo.Location = new Point(0, 0);
            imagenCodigo.Name = "imagenCodigo";
            imagenCodigo.Size = new Size(311, 168);
            imagenCodigo.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenCodigo.TabIndex = 0;
            imagenCodigo.TabStop = false;
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
            txtCodigo.Location = new Point(53, 211);
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
            txtCodigo.Size = new Size(311, 48);
            txtCodigo.TabIndex = 4;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DarkSlateGray;
            rjButton1.BackgroundColor = Color.DarkSlateGray;
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 17;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(130, 264);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(156, 39);
            rjButton1.TabIndex = 66;
            rjButton1.Text = "Guardar";
            rjButton1.TextAlign = ContentAlignment.BottomCenter;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnGuardar_Click;
            // 
            // FormGenerarCodigoBarra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 368);
            Controls.Add(rjButton1);
            Controls.Add(txtCodigo);
            Controls.Add(panelCodigo);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MaximumSize = new Size(800, 450);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormGenerarCodigoBarra";
            Padding = new Padding(3, 24, 3, 3);
            panelCodigo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenCodigo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
#pragma warning disable CS0169 // El campo 'FormGenerarCodigoBarra.btnGuardar' nunca se usa
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
#pragma warning restore CS0169 // El campo 'FormGenerarCodigoBarra.btnGuardar' nunca se usa
#pragma warning disable CS0169 // El campo 'FormGenerarCodigoBarra.btnGenerar' nunca se usa
        private ReaLTaiizor.Controls.MaterialButton btnGenerar;
#pragma warning restore CS0169 // El campo 'FormGenerarCodigoBarra.btnGenerar' nunca se usa

        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private PictureBox imagenCodigo;
    }
}