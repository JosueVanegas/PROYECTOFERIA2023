namespace CapaVista.FormsHerramientas
{
    partial class FormCalculadoraBasica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadoraBasica));
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAC = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber0 = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNumber9 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber8 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber7 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber6 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber5 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber4 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber3 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber2 = new RJCodeAdvance.RJControls.RJButton();
            btnNumber1 = new RJCodeAdvance.RJControls.RJButton();
            panel1 = new Panel();
            txtResultado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel2 = new TableLayoutPanel();
            rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel4.Controls.Add(btnAC, 1, 0);
            tableLayoutPanel4.Controls.Add(btnEliminar, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 70);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(370, 54);
            tableLayoutPanel4.TabIndex = 64;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(63, 63, 70);
            btnAC.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnAC.BackgroundImage = (Image)resources.GetObject("btnAC.BackgroundImage");
            btnAC.BackgroundImageLayout = ImageLayout.Center;
            btnAC.BorderColor = Color.PaleVioletRed;
            btnAC.BorderRadius = 20;
            btnAC.BorderSize = 0;
            btnAC.Dock = DockStyle.Fill;
            btnAC.FlatAppearance.BorderSize = 0;
            btnAC.FlatStyle = FlatStyle.Flat;
            btnAC.ForeColor = Color.White;
            btnAC.ImageAlign = ContentAlignment.MiddleRight;
            btnAC.Location = new Point(228, 2);
            btnAC.Margin = new Padding(3, 2, 3, 2);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(139, 50);
            btnAC.TabIndex = 63;
            btnAC.TextAlign = ContentAlignment.BottomCenter;
            btnAC.TextColor = Color.White;
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.BorderColor = Color.PaleVioletRed;
            btnEliminar.BorderRadius = 16;
            btnEliminar.BorderSize = 0;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(3, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(219, 50);
            btnEliminar.TabIndex = 65;
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel3.Controls.Add(rjButton5, 0, 0);
            tableLayoutPanel3.Controls.Add(btnNumber0, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(3, 331);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(279, 50);
            tableLayoutPanel3.TabIndex = 63;
            // 
            // rjButton5
            // 
            rjButton5.BackColor = Color.FromArgb(63, 63, 70);
            rjButton5.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton5.BackgroundImage = (Image)resources.GetObject("rjButton5.BackgroundImage");
            rjButton5.BackgroundImageLayout = ImageLayout.Center;
            rjButton5.BorderColor = Color.PaleVioletRed;
            rjButton5.BorderRadius = 16;
            rjButton5.BorderSize = 0;
            rjButton5.Dock = DockStyle.Fill;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton5.ForeColor = Color.White;
            rjButton5.ImageAlign = ContentAlignment.MiddleRight;
            rjButton5.Location = new Point(189, 2);
            rjButton5.Margin = new Padding(3, 2, 3, 2);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(87, 46);
            rjButton5.TabIndex = 65;
            rjButton5.TextAlign = ContentAlignment.BottomCenter;
            rjButton5.TextColor = Color.White;
            rjButton5.UseVisualStyleBackColor = false;
            rjButton5.Click += btnIgual_Click;
            // 
            // btnNumber0
            // 
            btnNumber0.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber0.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber0.BackgroundImage = (Image)resources.GetObject("btnNumber0.BackgroundImage");
            btnNumber0.BackgroundImageLayout = ImageLayout.Center;
            btnNumber0.BorderColor = Color.PaleVioletRed;
            btnNumber0.BorderRadius = 20;
            btnNumber0.BorderSize = 0;
            btnNumber0.Dock = DockStyle.Fill;
            btnNumber0.FlatAppearance.BorderSize = 0;
            btnNumber0.FlatStyle = FlatStyle.Flat;
            btnNumber0.ForeColor = Color.White;
            btnNumber0.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber0.Location = new Point(3, 2);
            btnNumber0.Margin = new Padding(3, 2, 3, 2);
            btnNumber0.Name = "btnNumber0";
            btnNumber0.Size = new Size(180, 46);
            btnNumber0.TabIndex = 63;
            btnNumber0.TextAlign = ContentAlignment.BottomCenter;
            btnNumber0.TextColor = Color.White;
            btnNumber0.UseVisualStyleBackColor = false;
            btnNumber0.Click += BtnNumero_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnNumber9, 2, 2);
            tableLayoutPanel1.Controls.Add(btnNumber8, 1, 2);
            tableLayoutPanel1.Controls.Add(btnNumber7, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNumber6, 2, 1);
            tableLayoutPanel1.Controls.Add(btnNumber5, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNumber4, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNumber3, 2, 0);
            tableLayoutPanel1.Controls.Add(btnNumber2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnNumber1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 124);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(279, 207);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // btnNumber9
            // 
            btnNumber9.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber9.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber9.BackgroundImage = (Image)resources.GetObject("btnNumber9.BackgroundImage");
            btnNumber9.BackgroundImageLayout = ImageLayout.Center;
            btnNumber9.BorderColor = Color.PaleVioletRed;
            btnNumber9.BorderRadius = 17;
            btnNumber9.BorderSize = 0;
            btnNumber9.Dock = DockStyle.Fill;
            btnNumber9.FlatAppearance.BorderSize = 0;
            btnNumber9.FlatStyle = FlatStyle.Flat;
            btnNumber9.ForeColor = Color.White;
            btnNumber9.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber9.Location = new Point(189, 138);
            btnNumber9.Margin = new Padding(3, 2, 3, 2);
            btnNumber9.Name = "btnNumber9";
            btnNumber9.Size = new Size(87, 67);
            btnNumber9.TabIndex = 64;
            btnNumber9.TextAlign = ContentAlignment.BottomCenter;
            btnNumber9.TextColor = Color.White;
            btnNumber9.UseVisualStyleBackColor = false;
            btnNumber9.Click += BtnNumero_Click;
            // 
            // btnNumber8
            // 
            btnNumber8.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber8.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber8.BackgroundImage = (Image)resources.GetObject("btnNumber8.BackgroundImage");
            btnNumber8.BackgroundImageLayout = ImageLayout.Center;
            btnNumber8.BorderColor = Color.PaleVioletRed;
            btnNumber8.BorderRadius = 17;
            btnNumber8.BorderSize = 0;
            btnNumber8.Dock = DockStyle.Fill;
            btnNumber8.FlatAppearance.BorderSize = 0;
            btnNumber8.FlatStyle = FlatStyle.Flat;
            btnNumber8.ForeColor = Color.White;
            btnNumber8.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber8.Location = new Point(96, 138);
            btnNumber8.Margin = new Padding(3, 2, 3, 2);
            btnNumber8.Name = "btnNumber8";
            btnNumber8.Size = new Size(87, 67);
            btnNumber8.TabIndex = 63;
            btnNumber8.TextAlign = ContentAlignment.BottomCenter;
            btnNumber8.TextColor = Color.White;
            btnNumber8.UseVisualStyleBackColor = false;
            btnNumber8.Click += BtnNumero_Click;
            // 
            // btnNumber7
            // 
            btnNumber7.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber7.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber7.BackgroundImage = (Image)resources.GetObject("btnNumber7.BackgroundImage");
            btnNumber7.BackgroundImageLayout = ImageLayout.Center;
            btnNumber7.BorderColor = Color.PaleVioletRed;
            btnNumber7.BorderRadius = 17;
            btnNumber7.BorderSize = 0;
            btnNumber7.Dock = DockStyle.Fill;
            btnNumber7.FlatAppearance.BorderSize = 0;
            btnNumber7.FlatStyle = FlatStyle.Flat;
            btnNumber7.ForeColor = Color.White;
            btnNumber7.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber7.Location = new Point(3, 138);
            btnNumber7.Margin = new Padding(3, 2, 3, 2);
            btnNumber7.Name = "btnNumber7";
            btnNumber7.Size = new Size(87, 67);
            btnNumber7.TabIndex = 62;
            btnNumber7.TextAlign = ContentAlignment.BottomCenter;
            btnNumber7.TextColor = Color.White;
            btnNumber7.UseVisualStyleBackColor = false;
            btnNumber7.Click += BtnNumero_Click;
            // 
            // btnNumber6
            // 
            btnNumber6.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber6.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber6.BackgroundImage = (Image)resources.GetObject("btnNumber6.BackgroundImage");
            btnNumber6.BackgroundImageLayout = ImageLayout.Center;
            btnNumber6.BorderColor = Color.PaleVioletRed;
            btnNumber6.BorderRadius = 17;
            btnNumber6.BorderSize = 0;
            btnNumber6.Dock = DockStyle.Fill;
            btnNumber6.FlatAppearance.BorderSize = 0;
            btnNumber6.FlatStyle = FlatStyle.Flat;
            btnNumber6.ForeColor = Color.White;
            btnNumber6.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber6.Location = new Point(189, 70);
            btnNumber6.Margin = new Padding(3, 2, 3, 2);
            btnNumber6.Name = "btnNumber6";
            btnNumber6.Size = new Size(87, 64);
            btnNumber6.TabIndex = 61;
            btnNumber6.TextAlign = ContentAlignment.BottomCenter;
            btnNumber6.TextColor = Color.White;
            btnNumber6.UseVisualStyleBackColor = false;
            btnNumber6.Click += BtnNumero_Click;
            // 
            // btnNumber5
            // 
            btnNumber5.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber5.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber5.BackgroundImage = (Image)resources.GetObject("btnNumber5.BackgroundImage");
            btnNumber5.BackgroundImageLayout = ImageLayout.Center;
            btnNumber5.BorderColor = Color.PaleVioletRed;
            btnNumber5.BorderRadius = 17;
            btnNumber5.BorderSize = 0;
            btnNumber5.Dock = DockStyle.Fill;
            btnNumber5.FlatAppearance.BorderSize = 0;
            btnNumber5.FlatStyle = FlatStyle.Flat;
            btnNumber5.ForeColor = Color.White;
            btnNumber5.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber5.Location = new Point(96, 70);
            btnNumber5.Margin = new Padding(3, 2, 3, 2);
            btnNumber5.Name = "btnNumber5";
            btnNumber5.Size = new Size(87, 64);
            btnNumber5.TabIndex = 60;
            btnNumber5.TextAlign = ContentAlignment.BottomCenter;
            btnNumber5.TextColor = Color.White;
            btnNumber5.UseVisualStyleBackColor = false;
            btnNumber5.Click += BtnNumero_Click;
            // 
            // btnNumber4
            // 
            btnNumber4.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber4.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber4.BackgroundImage = (Image)resources.GetObject("btnNumber4.BackgroundImage");
            btnNumber4.BackgroundImageLayout = ImageLayout.Center;
            btnNumber4.BorderColor = Color.PaleVioletRed;
            btnNumber4.BorderRadius = 17;
            btnNumber4.BorderSize = 0;
            btnNumber4.Dock = DockStyle.Fill;
            btnNumber4.FlatAppearance.BorderSize = 0;
            btnNumber4.FlatStyle = FlatStyle.Flat;
            btnNumber4.ForeColor = Color.White;
            btnNumber4.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber4.Location = new Point(3, 70);
            btnNumber4.Margin = new Padding(3, 2, 3, 2);
            btnNumber4.Name = "btnNumber4";
            btnNumber4.Size = new Size(87, 64);
            btnNumber4.TabIndex = 59;
            btnNumber4.TextAlign = ContentAlignment.BottomCenter;
            btnNumber4.TextColor = Color.White;
            btnNumber4.UseVisualStyleBackColor = false;
            btnNumber4.Click += BtnNumero_Click;
            // 
            // btnNumber3
            // 
            btnNumber3.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber3.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber3.BackgroundImage = (Image)resources.GetObject("btnNumber3.BackgroundImage");
            btnNumber3.BackgroundImageLayout = ImageLayout.Center;
            btnNumber3.BorderColor = Color.PaleVioletRed;
            btnNumber3.BorderRadius = 17;
            btnNumber3.BorderSize = 0;
            btnNumber3.Dock = DockStyle.Fill;
            btnNumber3.FlatAppearance.BorderSize = 0;
            btnNumber3.FlatStyle = FlatStyle.Flat;
            btnNumber3.ForeColor = Color.White;
            btnNumber3.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber3.Location = new Point(189, 2);
            btnNumber3.Margin = new Padding(3, 2, 3, 2);
            btnNumber3.Name = "btnNumber3";
            btnNumber3.Size = new Size(87, 64);
            btnNumber3.TabIndex = 58;
            btnNumber3.TextAlign = ContentAlignment.BottomCenter;
            btnNumber3.TextColor = Color.White;
            btnNumber3.UseVisualStyleBackColor = false;
            btnNumber3.Click += BtnNumero_Click;
            // 
            // btnNumber2
            // 
            btnNumber2.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber2.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber2.BackgroundImage = (Image)resources.GetObject("btnNumber2.BackgroundImage");
            btnNumber2.BackgroundImageLayout = ImageLayout.Center;
            btnNumber2.BorderColor = Color.PaleVioletRed;
            btnNumber2.BorderRadius = 17;
            btnNumber2.BorderSize = 0;
            btnNumber2.Dock = DockStyle.Fill;
            btnNumber2.FlatAppearance.BorderSize = 0;
            btnNumber2.FlatStyle = FlatStyle.Flat;
            btnNumber2.ForeColor = Color.Transparent;
            btnNumber2.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber2.Location = new Point(96, 2);
            btnNumber2.Margin = new Padding(3, 2, 3, 2);
            btnNumber2.Name = "btnNumber2";
            btnNumber2.Size = new Size(87, 64);
            btnNumber2.TabIndex = 57;
            btnNumber2.TextColor = Color.Transparent;
            btnNumber2.UseVisualStyleBackColor = false;
            btnNumber2.Click += BtnNumero_Click;
            // 
            // btnNumber1
            // 
            btnNumber1.BackColor = Color.FromArgb(63, 63, 70);
            btnNumber1.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnNumber1.BackgroundImage = (Image)resources.GetObject("btnNumber1.BackgroundImage");
            btnNumber1.BackgroundImageLayout = ImageLayout.Center;
            btnNumber1.BorderColor = Color.PaleVioletRed;
            btnNumber1.BorderRadius = 17;
            btnNumber1.BorderSize = 0;
            btnNumber1.Dock = DockStyle.Fill;
            btnNumber1.FlatAppearance.BorderSize = 0;
            btnNumber1.FlatStyle = FlatStyle.Flat;
            btnNumber1.ForeColor = Color.Transparent;
            btnNumber1.ImageAlign = ContentAlignment.MiddleRight;
            btnNumber1.Location = new Point(3, 2);
            btnNumber1.Margin = new Padding(3, 2, 3, 2);
            btnNumber1.Name = "btnNumber1";
            btnNumber1.Size = new Size(87, 64);
            btnNumber1.TabIndex = 56;
            btnNumber1.TextColor = Color.Transparent;
            btnNumber1.UseCompatibleTextRendering = true;
            btnNumber1.UseVisualStyleBackColor = false;
            btnNumber1.Click += BtnNumero_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtResultado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 46);
            panel1.TabIndex = 65;
            // 
            // txtResultado
            // 
            txtResultado.AnimateReadOnly = true;
            txtResultado.AutoCompleteMode = AutoCompleteMode.None;
            txtResultado.AutoCompleteSource = AutoCompleteSource.None;
            txtResultado.BackgroundImageLayout = ImageLayout.None;
            txtResultado.CharacterCasing = CharacterCasing.Normal;
            txtResultado.Depth = 0;
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.HideSelection = true;
            txtResultado.LeadingIcon = null;
            txtResultado.Location = new Point(0, 0);
            txtResultado.MaxLength = 32767;
            txtResultado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtResultado.Name = "txtResultado";
            txtResultado.PasswordChar = '\0';
            txtResultado.PrefixSuffixText = null;
            txtResultado.ReadOnly = true;
            txtResultado.RightToLeft = RightToLeft.No;
            txtResultado.SelectedText = "";
            txtResultado.SelectionLength = 0;
            txtResultado.SelectionStart = 0;
            txtResultado.ShortcutsEnabled = true;
            txtResultado.Size = new Size(370, 48);
            txtResultado.TabIndex = 50;
            txtResultado.TabStop = false;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            txtResultado.TrailingIcon = null;
            txtResultado.UseSystemPasswordChar = false;
            txtResultado.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rjButton4, 0, 3);
            tableLayoutPanel2.Controls.Add(rjButton3, 0, 2);
            tableLayoutPanel2.Controls.Add(rjButton2, 0, 1);
            tableLayoutPanel2.Controls.Add(rjButton1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(282, 124);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(91, 257);
            tableLayoutPanel2.TabIndex = 66;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(63, 63, 70);
            rjButton4.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton4.BackgroundImage = (Image)resources.GetObject("rjButton4.BackgroundImage");
            rjButton4.BackgroundImageLayout = ImageLayout.Center;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 16;
            rjButton4.BorderSize = 0;
            rjButton4.Dock = DockStyle.Fill;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.ForeColor = Color.White;
            rjButton4.ImageAlign = ContentAlignment.MiddleRight;
            rjButton4.Location = new Point(3, 194);
            rjButton4.Margin = new Padding(3, 2, 3, 2);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(85, 61);
            rjButton4.TabIndex = 62;
            rjButton4.TextAlign = ContentAlignment.BottomCenter;
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += btnOperador_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(63, 63, 70);
            rjButton3.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton3.BackgroundImage = (Image)resources.GetObject("rjButton3.BackgroundImage");
            rjButton3.BackgroundImageLayout = ImageLayout.Center;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 16;
            rjButton3.BorderSize = 0;
            rjButton3.Dock = DockStyle.Fill;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.ImageAlign = ContentAlignment.MiddleRight;
            rjButton3.Location = new Point(3, 130);
            rjButton3.Margin = new Padding(3, 2, 3, 2);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(85, 60);
            rjButton3.TabIndex = 61;
            rjButton3.TextAlign = ContentAlignment.BottomCenter;
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnOperador_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(63, 63, 70);
            rjButton2.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton2.BackgroundImage = (Image)resources.GetObject("rjButton2.BackgroundImage");
            rjButton2.BackgroundImageLayout = ImageLayout.Center;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.Dock = DockStyle.Fill;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.ImageAlign = ContentAlignment.MiddleRight;
            rjButton2.Location = new Point(3, 66);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(85, 60);
            rjButton2.TabIndex = 60;
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnOperador_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundImage = (Image)resources.GetObject("rjButton1.BackgroundImage");
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.Dock = DockStyle.Fill;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(3, 2);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(85, 60);
            rjButton1.TabIndex = 59;
            rjButton1.TextAlign = ContentAlignment.BottomCenter;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnOperador_Click;
            // 
            // FormCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 384);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MaximumSize = new Size(376, 384);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(376, 384);
            Name = "FormCalculadoraBasica";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            Text = "CalculadoraBasica";
            Load += CalculadoraBasica_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnAC;
        private TableLayoutPanel tableLayoutPanel3;
        private RJCodeAdvance.RJControls.RJButton btnNumber0;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnNumber9;
        private RJCodeAdvance.RJControls.RJButton btnNumber8;
        private RJCodeAdvance.RJControls.RJButton btnNumber7;
        private RJCodeAdvance.RJControls.RJButton btnNumber6;
        private RJCodeAdvance.RJControls.RJButton btnNumber5;
        private RJCodeAdvance.RJControls.RJButton btnNumber4;
        private RJCodeAdvance.RJControls.RJButton btnNumber3;
        private RJCodeAdvance.RJControls.RJButton btnNumber2;
        private RJCodeAdvance.RJControls.RJButton btnNumber1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtResultado;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
    }
}