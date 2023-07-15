namespace CapaVista
{
    partial class formProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProveedor));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            materialTextBoxEdit4 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit3 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            lblTitulo = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdCategoria = new TextBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblEncabezado = new Label();
            tbProveedores = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            nombreEmpresa = new DataGridViewTextBoxColumn();
            NombreContacto = new DataGridViewTextBoxColumn();
            NumeroContacto = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(materialTextBoxEdit4);
            panel1.Controls.Add(materialTextBoxEdit3);
            panel1.Controls.Add(materialTextBoxEdit2);
            panel1.Controls.Add(materialTextBoxEdit1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIdCategoria);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 492);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // materialTextBoxEdit4
            // 
            materialTextBoxEdit4.AnimateReadOnly = true;
            materialTextBoxEdit4.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit4.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit4.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit4.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit4.Depth = 0;
            materialTextBoxEdit4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxEdit4.HideSelection = true;
            materialTextBoxEdit4.Hint = "Ciudad";
            materialTextBoxEdit4.LeadingIcon = null;
            materialTextBoxEdit4.Location = new Point(12, 314);
            materialTextBoxEdit4.MaxLength = 32767;
            materialTextBoxEdit4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit4.Name = "materialTextBoxEdit4";
            materialTextBoxEdit4.PasswordChar = '\0';
            materialTextBoxEdit4.PrefixSuffixText = null;
            materialTextBoxEdit4.ReadOnly = false;
            materialTextBoxEdit4.RightToLeft = RightToLeft.No;
            materialTextBoxEdit4.SelectedText = "";
            materialTextBoxEdit4.SelectionLength = 0;
            materialTextBoxEdit4.SelectionStart = 0;
            materialTextBoxEdit4.ShortcutsEnabled = true;
            materialTextBoxEdit4.Size = new Size(110, 48);
            materialTextBoxEdit4.TabIndex = 35;
            materialTextBoxEdit4.TabStop = false;
            materialTextBoxEdit4.TextAlign = HorizontalAlignment.Center;
            materialTextBoxEdit4.TrailingIcon = null;
            materialTextBoxEdit4.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit3
            // 
            materialTextBoxEdit3.AnimateReadOnly = true;
            materialTextBoxEdit3.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit3.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit3.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit3.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit3.Depth = 0;
            materialTextBoxEdit3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxEdit3.HideSelection = true;
            materialTextBoxEdit3.Hint = "Pais";
            materialTextBoxEdit3.LeadingIcon = null;
            materialTextBoxEdit3.Location = new Point(12, 257);
            materialTextBoxEdit3.MaxLength = 32767;
            materialTextBoxEdit3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit3.Name = "materialTextBoxEdit3";
            materialTextBoxEdit3.PasswordChar = '\0';
            materialTextBoxEdit3.PrefixSuffixText = null;
            materialTextBoxEdit3.ReadOnly = false;
            materialTextBoxEdit3.RightToLeft = RightToLeft.No;
            materialTextBoxEdit3.SelectedText = "";
            materialTextBoxEdit3.SelectionLength = 0;
            materialTextBoxEdit3.SelectionStart = 0;
            materialTextBoxEdit3.ShortcutsEnabled = true;
            materialTextBoxEdit3.Size = new Size(110, 48);
            materialTextBoxEdit3.TabIndex = 34;
            materialTextBoxEdit3.TabStop = false;
            materialTextBoxEdit3.TextAlign = HorizontalAlignment.Center;
            materialTextBoxEdit3.TrailingIcon = null;
            materialTextBoxEdit3.UseSystemPasswordChar = false;
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
            materialTextBoxEdit2.Hint = "Ingrese el numero de contacto";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(12, 193);
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
            materialTextBoxEdit2.Size = new Size(263, 48);
            materialTextBoxEdit2.TabIndex = 33;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Center;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = true;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.Hint = "Ingrese el nombre de contacto";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(12, 130);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(263, 48);
            materialTextBoxEdit1.TabIndex = 32;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Center;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Location = new Point(28, 386);
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
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.BorderColor = Color.PaleVioletRed;
            btnEliminar.BorderRadius = 10;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(158, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 76);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(80, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 76);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(28, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 48);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Proveedor";
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
            txtNombre.Hint = "Ingrese el nombre de la Empresa";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(12, 70);
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
            txtNombre.Size = new Size(263, 48);
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
            txtBuscar.Location = new Point(567, 19);
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
            txtBuscar.TabIndex = 23;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(321, 19);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(215, 48);
            lblEncabezado.TabIndex = 22;
            lblEncabezado.Text = "Proveedores registradas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbProveedores
            // 
            tbProveedores.AllowUserToAddRows = false;
            tbProveedores.AllowUserToOrderColumns = true;
            tbProveedores.AllowUserToResizeColumns = false;
            tbProveedores.AllowUserToResizeRows = false;
            tbProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbProveedores.BackgroundColor = Color.FromArgb(50, 50, 50);
            tbProveedores.BorderStyle = BorderStyle.None;
            tbProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbProveedores.ColumnHeadersHeight = 40;
            tbProveedores.Columns.AddRange(new DataGridViewColumn[] { btnEditar, id, nombreEmpresa, NombreContacto, NumeroContacto, Pais, Ciudad });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            tbProveedores.DefaultCellStyle = dataGridViewCellStyle5;
            tbProveedores.EnableHeadersVisualStyles = false;
            tbProveedores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProveedores.GridColor = Color.FromArgb(255, 255, 255);
            tbProveedores.Location = new Point(321, 70);
            tbProveedores.Name = "tbProveedores";
            tbProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbProveedores.RowHeadersVisible = false;
            tbProveedores.RowHeadersWidth = 40;
            tbProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProveedores.RowTemplate.Height = 30;
            tbProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProveedores.Size = new Size(545, 405);
            tbProveedores.TabIndex = 21;
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
            // nombreEmpresa
            // 
            nombreEmpresa.HeaderText = "Empresa";
            nombreEmpresa.Name = "nombreEmpresa";
            nombreEmpresa.ReadOnly = true;
            nombreEmpresa.Width = 500;
            // 
            // NombreContacto
            // 
            NombreContacto.HeaderText = "Contacto";
            NombreContacto.Name = "NombreContacto";
            // 
            // NumeroContacto
            // 
            NumeroContacto.HeaderText = "Numero Telefonico";
            NumeroContacto.Name = "NumeroContacto";
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            // 
            // formProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 492);
            Controls.Add(txtBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbProveedores);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formProveedor";
            Text = "formProveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private TextBox txtIdCategoria;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbProveedores;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombreEmpresa;
        private DataGridViewTextBoxColumn NombreContacto;
        private DataGridViewTextBoxColumn NumeroContacto;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Ciudad;
    }
}