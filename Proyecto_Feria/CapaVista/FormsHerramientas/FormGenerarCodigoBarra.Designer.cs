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
            cbxProductos = new ReaLTaiizor.Controls.MaterialComboBox();
            panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenCodigo).BeginInit();
            SuspendLayout();
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.White;
            panelCodigo.Controls.Add(imagenCodigo);
            panelCodigo.Location = new Point(14, 360);
            panelCodigo.Margin = new Padding(3, 4, 3, 4);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(354, 175);
            panelCodigo.TabIndex = 3;
            // 
            // imagenCodigo
            // 
            imagenCodigo.Dock = DockStyle.Fill;
            imagenCodigo.Location = new Point(0, 0);
            imagenCodigo.Margin = new Padding(3, 4, 3, 4);
            imagenCodigo.Name = "imagenCodigo";
            imagenCodigo.Size = new Size(354, 175);
            imagenCodigo.SizeMode = PictureBoxSizeMode.Zoom;
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
            txtCodigo.Location = new Point(18, 232);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
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
            txtCodigo.Size = new Size(346, 48);
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
            rjButton1.Location = new Point(69, 541);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(243, 52);
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
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(372, 51);
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
            txtTitulo.Location = new Point(18, 160);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
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
            txtTitulo.Size = new Size(346, 48);
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
            btnGenerarCodigo.Location = new Point(69, 303);
            btnGenerarCodigo.Name = "btnGenerarCodigo";
            btnGenerarCodigo.Size = new Size(243, 51);
            btnGenerarCodigo.TabIndex = 69;
            btnGenerarCodigo.Text = "Generar codigo";
            btnGenerarCodigo.TextAlign = ContentAlignment.BottomCenter;
            btnGenerarCodigo.TextColor = Color.White;
            btnGenerarCodigo.UseVisualStyleBackColor = false;
            btnGenerarCodigo.Click += btnGenerarCodigo_Click;
            // 
            // cbxProductos
            // 
            cbxProductos.AutoResize = false;
            cbxProductos.BackColor = Color.FromArgb(255, 255, 255);
            cbxProductos.Depth = 0;
            cbxProductos.DrawMode = DrawMode.OwnerDrawVariable;
            cbxProductos.DropDownHeight = 174;
            cbxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductos.DropDownWidth = 121;
            cbxProductos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxProductos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxProductos.FormattingEnabled = true;
            cbxProductos.Hint = "Seleccione el codigo de un producto";
            cbxProductos.IntegralHeight = false;
            cbxProductos.ItemHeight = 43;
            cbxProductos.Location = new Point(18, 87);
            cbxProductos.Margin = new Padding(3, 4, 3, 4);
            cbxProductos.MaxDropDownItems = 4;
            cbxProductos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProductos.Name = "cbxProductos";
            cbxProductos.Size = new Size(346, 49);
            cbxProductos.StartIndex = 1;
            cbxProductos.TabIndex = 70;
            cbxProductos.SelectedIndexChanged += cbxProductos_SelectedIndexChanged;
            // 
            // FormGenerarCodigoBarra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 600);
            Controls.Add(cbxProductos);
            Controls.Add(btnGenerarCodigo);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Controls.Add(rjButton1);
            Controls.Add(txtCodigo);
            Controls.Add(panelCodigo);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(378, 600);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(378, 600);
            Name = "FormGenerarCodigoBarra";
            Padding = new Padding(3, 32, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormGenerarCodigoBarra_Load;
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
        private ReaLTaiizor.Controls.MaterialComboBox cbxProductos;
    }
}