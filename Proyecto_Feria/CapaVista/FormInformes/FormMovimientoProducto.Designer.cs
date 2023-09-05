namespace CapaPresentacion.FormInformes
{
    partial class FormMovimientoProducto
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
            panelBusqueda = new Panel();
            tbBusqueda = new ReaLTaiizor.Controls.PoisonDataGridView();
            Añadir = new DataGridViewButtonColumn();
            IdP = new DataGridViewTextBoxColumn();
            CodigoP = new DataGridViewTextBoxColumn();
            NombreP = new DataGridViewTextBoxColumn();
            txtBuscarProducto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscarProducto = new ReaLTaiizor.Controls.MaterialComboBox();
            lblBuscar = new Label();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            btnRealizarInforme = new ReaLTaiizor.Controls.MaterialButton();
            txtId = new Label();
            txtFechaInicio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtFechaFin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).BeginInit();
            SuspendLayout();
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(tbBusqueda);
            panelBusqueda.Controls.Add(txtBuscarProducto);
            panelBusqueda.Controls.Add(cbxBuscarProducto);
            panelBusqueda.Controls.Add(lblBuscar);
            panelBusqueda.Dock = DockStyle.Right;
            panelBusqueda.Location = new Point(359, 24);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(323, 279);
            panelBusqueda.TabIndex = 57;
            // 
            // tbBusqueda
            // 
            tbBusqueda.AllowUserToAddRows = false;
            tbBusqueda.AllowUserToOrderColumns = true;
            tbBusqueda.AllowUserToResizeRows = false;
            tbBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbBusqueda.BackgroundColor = Color.White;
            tbBusqueda.BorderStyle = BorderStyle.None;
            tbBusqueda.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbBusqueda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbBusqueda.ColumnHeadersHeight = 35;
            tbBusqueda.Columns.AddRange(new DataGridViewColumn[] { Añadir, IdP, CodigoP, NombreP });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            tbBusqueda.Dock = DockStyle.Fill;
            tbBusqueda.EnableHeadersVisualStyles = false;
            tbBusqueda.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBusqueda.GridColor = Color.Gray;
            tbBusqueda.Location = new Point(0, 153);
            tbBusqueda.Name = "tbBusqueda";
            tbBusqueda.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbBusqueda.RowHeadersVisible = false;
            tbBusqueda.RowHeadersWidth = 40;
            tbBusqueda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbBusqueda.RowTemplate.Height = 30;
            tbBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbBusqueda.Size = new Size(323, 126);
            tbBusqueda.TabIndex = 55;
            tbBusqueda.CellContentClick += tbBusqueda_CellContentClick;
            tbBusqueda.CellPainting += tbBusqueda_CellPainting;
            // 
            // Añadir
            // 
            Añadir.HeaderText = "Añadir";
            Añadir.Name = "Añadir";
            Añadir.Width = 50;
            // 
            // IdP
            // 
            IdP.HeaderText = "Id";
            IdP.Name = "IdP";
            IdP.ReadOnly = true;
            IdP.Visible = false;
            IdP.Width = 10;
            // 
            // CodigoP
            // 
            CodigoP.HeaderText = "Codigo";
            CodigoP.Name = "CodigoP";
            CodigoP.ReadOnly = true;
            CodigoP.Width = 150;
            // 
            // NombreP
            // 
            NombreP.HeaderText = "producto";
            NombreP.Name = "NombreP";
            NombreP.ReadOnly = true;
            NombreP.Width = 250;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.AnimateReadOnly = false;
            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscarProducto.BackgroundImageLayout = ImageLayout.None;
            txtBuscarProducto.CharacterCasing = CharacterCasing.Normal;
            txtBuscarProducto.Depth = 0;
            txtBuscarProducto.Dock = DockStyle.Top;
            txtBuscarProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProducto.HideSelection = true;
            txtBuscarProducto.Hint = "Buscar";
            txtBuscarProducto.LeadingIcon = null;
            txtBuscarProducto.Location = new Point(0, 105);
            txtBuscarProducto.MaxLength = 32767;
            txtBuscarProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PasswordChar = '\0';
            txtBuscarProducto.PrefixSuffixText = null;
            txtBuscarProducto.ReadOnly = false;
            txtBuscarProducto.RightToLeft = RightToLeft.No;
            txtBuscarProducto.SelectedText = "";
            txtBuscarProducto.SelectionLength = 0;
            txtBuscarProducto.SelectionStart = 0;
            txtBuscarProducto.ShortcutsEnabled = true;
            txtBuscarProducto.Size = new Size(323, 48);
            txtBuscarProducto.TabIndex = 63;
            txtBuscarProducto.TabStop = false;
            txtBuscarProducto.TextAlign = HorizontalAlignment.Left;
            txtBuscarProducto.TrailingIcon = null;
            txtBuscarProducto.UseSystemPasswordChar = false;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // cbxBuscarProducto
            // 
            cbxBuscarProducto.AutoResize = false;
            cbxBuscarProducto.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscarProducto.Depth = 0;
            cbxBuscarProducto.Dock = DockStyle.Top;
            cbxBuscarProducto.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscarProducto.DropDownHeight = 174;
            cbxBuscarProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarProducto.DropDownWidth = 121;
            cbxBuscarProducto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscarProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscarProducto.FormattingEnabled = true;
            cbxBuscarProducto.Hint = "Buscar producto";
            cbxBuscarProducto.IntegralHeight = false;
            cbxBuscarProducto.ItemHeight = 43;
            cbxBuscarProducto.Items.AddRange(new object[] { "Codigo", "Nombre" });
            cbxBuscarProducto.Location = new Point(0, 56);
            cbxBuscarProducto.MaxDropDownItems = 4;
            cbxBuscarProducto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscarProducto.Name = "cbxBuscarProducto";
            cbxBuscarProducto.Size = new Size(323, 49);
            cbxBuscarProducto.StartIndex = 0;
            cbxBuscarProducto.TabIndex = 60;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.White;
            lblBuscar.Dock = DockStyle.Top;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(63, 63, 70);
            lblBuscar.Location = new Point(0, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(323, 56);
            lblBuscar.TabIndex = 42;
            lblBuscar.Text = "Seleccione un producto";
            lblBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Codigo";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(44, 135);
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
            txtCodigo.Size = new Size(259, 48);
            txtCodigo.TabIndex = 58;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Nombre del producto";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(44, 189);
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
            txtNombre.Size = new Size(259, 48);
            txtNombre.TabIndex = 59;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 63, 70);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(356, 56);
            label1.TabIndex = 60;
            label1.Text = "Movimientos de producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRealizarInforme
            // 
            btnRealizarInforme.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRealizarInforme.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRealizarInforme.Depth = 0;
            btnRealizarInforme.HighEmphasis = true;
            btnRealizarInforme.Icon = null;
            btnRealizarInforme.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRealizarInforme.Location = new Point(102, 246);
            btnRealizarInforme.Margin = new Padding(4, 6, 4, 6);
            btnRealizarInforme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRealizarInforme.Name = "btnRealizarInforme";
            btnRealizarInforme.NoAccentTextColor = Color.Empty;
            btnRealizarInforme.Size = new Size(156, 36);
            btnRealizarInforme.TabIndex = 61;
            btnRealizarInforme.Text = "Realizar informe";
            btnRealizarInforme.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRealizarInforme.UseAccentColor = false;
            btnRealizarInforme.UseVisualStyleBackColor = true;
            btnRealizarInforme.Click += btnRealizarInforme_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(340, 85);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 62;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.AnimateReadOnly = false;
            txtFechaInicio.AutoCompleteMode = AutoCompleteMode.None;
            txtFechaInicio.AutoCompleteSource = AutoCompleteSource.None;
            txtFechaInicio.BackgroundImageLayout = ImageLayout.None;
            txtFechaInicio.CharacterCasing = CharacterCasing.Normal;
            txtFechaInicio.Depth = 0;
            txtFechaInicio.Enabled = false;
            txtFechaInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaInicio.HideSelection = true;
            txtFechaInicio.Hint = "Desde:";
            txtFechaInicio.LeadingIcon = null;
            txtFechaInicio.Location = new Point(44, 85);
            txtFechaInicio.MaxLength = 32767;
            txtFechaInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PasswordChar = '\0';
            txtFechaInicio.PrefixSuffixText = null;
            txtFechaInicio.ReadOnly = false;
            txtFechaInicio.RightToLeft = RightToLeft.No;
            txtFechaInicio.SelectedText = "";
            txtFechaInicio.SelectionLength = 0;
            txtFechaInicio.SelectionStart = 0;
            txtFechaInicio.ShortcutsEnabled = true;
            txtFechaInicio.Size = new Size(128, 48);
            txtFechaInicio.TabIndex = 63;
            txtFechaInicio.TabStop = false;
            txtFechaInicio.TextAlign = HorizontalAlignment.Left;
            txtFechaInicio.TrailingIcon = null;
            txtFechaInicio.UseSystemPasswordChar = false;
            // 
            // txtFechaFin
            // 
            txtFechaFin.AnimateReadOnly = false;
            txtFechaFin.AutoCompleteMode = AutoCompleteMode.None;
            txtFechaFin.AutoCompleteSource = AutoCompleteSource.None;
            txtFechaFin.BackgroundImageLayout = ImageLayout.None;
            txtFechaFin.CharacterCasing = CharacterCasing.Normal;
            txtFechaFin.Depth = 0;
            txtFechaFin.Enabled = false;
            txtFechaFin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaFin.HideSelection = true;
            txtFechaFin.Hint = "Hasta:";
            txtFechaFin.LeadingIcon = null;
            txtFechaFin.Location = new Point(178, 85);
            txtFechaFin.MaxLength = 32767;
            txtFechaFin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PasswordChar = '\0';
            txtFechaFin.PrefixSuffixText = null;
            txtFechaFin.ReadOnly = false;
            txtFechaFin.RightToLeft = RightToLeft.No;
            txtFechaFin.SelectedText = "";
            txtFechaFin.SelectionLength = 0;
            txtFechaFin.SelectionStart = 0;
            txtFechaFin.ShortcutsEnabled = true;
            txtFechaFin.Size = new Size(125, 48);
            txtFechaFin.TabIndex = 64;
            txtFechaFin.TabStop = false;
            txtFechaFin.TextAlign = HorizontalAlignment.Left;
            txtFechaFin.TrailingIcon = null;
            txtFechaFin.UseSystemPasswordChar = false;
            // 
            // FormMovimientoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 306);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtId);
            Controls.Add(btnRealizarInforme);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(panelBusqueda);
            DrawerHamburgerCursor = Cursors.Arrow;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMovimientoProducto";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FormMovimientoProducto";
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBusqueda;
        private Label lblBuscar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscarProducto;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscarProducto;
        private ReaLTaiizor.Controls.PoisonDataGridView tbBusqueda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private DataGridViewButtonColumn Añadir;
        private DataGridViewTextBoxColumn IdP;
        private DataGridViewTextBoxColumn CodigoP;
        private DataGridViewTextBoxColumn NombreP;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnRealizarInforme;
        private Label txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFechaInicio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFechaFin;
    }
}