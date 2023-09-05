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
            label1 = new Label();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnGenerarCodigo = new RJCodeAdvance.RJControls.RJButton();
            panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenCodigo).BeginInit();
            SuspendLayout();
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.White;
            panelCodigo.Controls.Add(imagenCodigo);
            panelCodigo.Location = new Point(13, 224);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(303, 168);
            panelCodigo.TabIndex = 3;
            // 
            // imagenCodigo
            // 
            imagenCodigo.Dock = DockStyle.Fill;
            imagenCodigo.Location = new Point(0, 0);
            imagenCodigo.Name = "imagenCodigo";
            imagenCodigo.Size = new Size(303, 168);
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
            txtCodigo.Location = new Point(14, 115);
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
            txtCodigo.Size = new Size(303, 48);
            txtCodigo.TabIndex = 4;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DarkCyan;
            rjButton1.BackgroundColor = Color.DarkCyan;
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 17;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(62, 397);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(213, 39);
            rjButton1.TabIndex = 66;
            rjButton1.Text = "Guardar codigo";
            rjButton1.TextAlign = ContentAlignment.BottomCenter;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(324, 38);
            label1.TabIndex = 67;
            label1.Text = "Generador de codigo de barra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "ingrese el titulo del codigo de barra";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(14, 65);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(303, 48);
            txtTitulo.TabIndex = 68;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // btnGenerarCodigo
            // 
            btnGenerarCodigo.BackColor = Color.SeaGreen;
            btnGenerarCodigo.BackgroundColor = Color.SeaGreen;
            btnGenerarCodigo.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarCodigo.BorderColor = Color.PaleVioletRed;
            btnGenerarCodigo.BorderRadius = 17;
            btnGenerarCodigo.BorderSize = 0;
            btnGenerarCodigo.FlatAppearance.BorderSize = 0;
            btnGenerarCodigo.FlatStyle = FlatStyle.Flat;
            btnGenerarCodigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarCodigo.ForeColor = Color.White;
            btnGenerarCodigo.ImageAlign = ContentAlignment.MiddleRight;
            btnGenerarCodigo.Location = new Point(62, 168);
            btnGenerarCodigo.Margin = new Padding(3, 2, 3, 2);
            btnGenerarCodigo.Name = "btnGenerarCodigo";
            btnGenerarCodigo.Size = new Size(213, 39);
            btnGenerarCodigo.TabIndex = 69;
            btnGenerarCodigo.Text = "Generar codigo";
            btnGenerarCodigo.TextAlign = ContentAlignment.BottomCenter;
            btnGenerarCodigo.TextColor = Color.White;
            btnGenerarCodigo.UseVisualStyleBackColor = false;
            btnGenerarCodigo.Click += btnGenerarCodigo_Click;
            // 
            // FormGenerarCodigoBarra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(btnGenerarCodigo);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private RJCodeAdvance.RJControls.RJButton btnGenerarCodigo;
    }
}