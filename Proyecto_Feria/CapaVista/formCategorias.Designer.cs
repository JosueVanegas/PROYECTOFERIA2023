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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdCategoria = new TextBox();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            tbCategorias = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
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
            txtNombre.Location = new Point(28, 70);
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
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtIdCategoria);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 492);
            panel1.TabIndex = 18;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 204);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(234, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(28, 166);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(234, 32);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 124);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(234, 36);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            tbCategorias.BackgroundColor = Color.WhiteSmoke;
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
            btnEditar.HeaderText = "editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 500;
            // 
            // formCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(887, 492);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCategorias";
            Text = "formCategorias";
            Load += formCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCategorias;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
    }
}