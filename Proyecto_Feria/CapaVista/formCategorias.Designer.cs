namespace CapaVista
{
    partial class formCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCategorias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdCategoria = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            tbCategorias = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            LblInf = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(28, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos de la categoria";
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
            txtNombre.Hint = "ingrese el nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(28, 79);
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
            txtNombre.Size = new Size(234, 48);
            txtNombre.TabIndex = 10;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(227, 31);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(35, 23);
            txtIdCategoria.TabIndex = 8;
            txtIdCategoria.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LblInf);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIdCategoria);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 489);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(rjButton6, 2, 0);
            tableLayoutPanel1.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel1.Location = new Point(28, 163);
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
            btnGuardar.Click += btnGuardar_Click;
            // 
            // rjButton6
            // 
            rjButton6.Anchor = AnchorStyles.Left;
            rjButton6.BackColor = Color.FromArgb(63, 63, 70);
            rjButton6.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton6.BackgroundImage = (Image)resources.GetObject("rjButton6.BackgroundImage");
            rjButton6.BackgroundImageLayout = ImageLayout.Center;
            rjButton6.BorderColor = Color.PaleVioletRed;
            rjButton6.BorderRadius = 10;
            rjButton6.BorderSize = 0;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = FlatStyle.Flat;
            rjButton6.ForeColor = Color.White;
            rjButton6.ImageAlign = ContentAlignment.MiddleRight;
            rjButton6.Location = new Point(158, 2);
            rjButton6.Margin = new Padding(3, 2, 3, 2);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(73, 76);
            rjButton6.TabIndex = 10;
            rjButton6.Text = "Eliminar";
            rjButton6.TextAlign = ContentAlignment.BottomCenter;
            rjButton6.TextColor = Color.White;
            rjButton6.UseVisualStyleBackColor = false;
            rjButton6.Click += btnEliminar_Click;
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
            rjButton2.Location = new Point(80, 2);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(72, 76);
            rjButton2.TabIndex = 12;
            rjButton2.Text = "Limpiar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnLimpiar_Click;
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
            txtBuscar.Location = new Point(558, 6);
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
            txtBuscar.TabIndex = 20;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(312, 6);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(197, 48);
            lblEncabezado.TabIndex = 17;
            lblEncabezado.Text = "Categorias registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCategorias
            // 
            tbCategorias.AllowUserToAddRows = false;
            tbCategorias.AllowUserToOrderColumns = true;
            tbCategorias.AllowUserToResizeColumns = false;
            tbCategorias.AllowUserToResizeRows = false;
            tbCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbCategorias.BackgroundColor = Color.FromArgb(50, 50, 50);
            tbCategorias.BorderStyle = BorderStyle.None;
            tbCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbCategorias.ColumnHeadersHeight = 40;
            tbCategorias.Columns.AddRange(new DataGridViewColumn[] { btnEditar, id, nombre });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            tbCategorias.EnableHeadersVisualStyles = false;
            tbCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCategorias.GridColor = Color.FromArgb(255, 255, 255);
            tbCategorias.Location = new Point(312, 57);
            tbCategorias.Name = "tbCategorias";
            tbCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbCategorias.RowHeadersVisible = false;
            tbCategorias.RowHeadersWidth = 40;
            tbCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCategorias.RowTemplate.Height = 30;
            tbCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCategorias.Size = new Size(545, 405);
            tbCategorias.TabIndex = 16;
            tbCategorias.CellContentClick += tbUsuarios_CellContentClick;
            tbCategorias.CellPainting += tbUsuarios_CellPainting;
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
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 500;
            // 
            // LblInf
            // 
            LblInf.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblInf.Location = new Point(96, 422);
            LblInf.Name = "LblInf";
            LblInf.Size = new Size(102, 48);
            LblInf.TabIndex = 21;
            LblInf.Text = "Categorias";
            LblInf.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(887, 492);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbCategorias);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formCategorias";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formCategorias";
            Load += formCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCategorias;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private PictureBox pictureBox1;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private Label LblInf;
    }
}