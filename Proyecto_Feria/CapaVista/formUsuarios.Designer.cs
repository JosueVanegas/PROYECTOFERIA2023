

namespace CapaVista
{
    partial class formUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuarios));
            tbUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
            lblEncabezado = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuarda = new RJCodeAdvance.RJControls.RJButton();
            rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            txtConfirmarClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ckbVerContraseña = new ReaLTaiizor.Controls.AirCheckBox();
            label1 = new Label();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdUsuario = new TextBox();
            cbxRol = new ReaLTaiizor.Controls.MaterialComboBox();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsuarios
            // 
            tbUsuarios.AllowUserToAddRows = false;
            tbUsuarios.AllowUserToOrderColumns = true;
            tbUsuarios.AllowUserToResizeRows = false;
            tbUsuarios.Anchor = AnchorStyles.Left;
            tbUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbUsuarios.BackgroundColor = Color.FromArgb(50, 50, 50);
            tbUsuarios.BorderStyle = BorderStyle.None;
            tbUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbUsuarios.ColumnHeadersHeight = 35;
            tbUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, usuario, rol, fecha, idRol, clave });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            tbUsuarios.EnableHeadersVisualStyles = false;
            tbUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuarios.GridColor = Color.FromArgb(255, 255, 255);
            tbUsuarios.Location = new Point(285, 51);
            tbUsuarios.Name = "tbUsuarios";
            tbUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbUsuarios.RowHeadersVisible = false;
            tbUsuarios.RowHeadersWidth = 40;
            tbUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbUsuarios.RowTemplate.Height = 30;
            tbUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbUsuarios.Size = new Size(600, 389);
            tbUsuarios.TabIndex = 4;
            tbUsuarios.CellContentClick += tbUsuarios_CellContentClick;
            tbUsuarios.CellPainting += tbUsuarios_CellPainting;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(285, -4);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(197, 48);
            lblEncabezado.TabIndex = 5;
            lblEncabezado.Text = "Usuarios registrados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(txtConfirmarClave);
            panel1.Controls.Add(ckbVerContraseña);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIdUsuario);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 489);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnGuarda, 0, 0);
            tableLayoutPanel1.Controls.Add(rjButton6, 2, 0);
            tableLayoutPanel1.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 362);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(234, 80);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // btnGuarda
            // 
            btnGuarda.Anchor = AnchorStyles.Left;
            btnGuarda.BackColor = Color.FromArgb(63, 63, 70);
            btnGuarda.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGuarda.BackgroundImage = (Image)resources.GetObject("btnGuarda.BackgroundImage");
            btnGuarda.BackgroundImageLayout = ImageLayout.Center;
            btnGuarda.BorderColor = Color.PaleVioletRed;
            btnGuarda.BorderRadius = 10;
            btnGuarda.BorderSize = 0;
            btnGuarda.FlatAppearance.BorderSize = 0;
            btnGuarda.FlatStyle = FlatStyle.Flat;
            btnGuarda.ForeColor = Color.White;
            btnGuarda.ImageAlign = ContentAlignment.MiddleRight;
            btnGuarda.Location = new Point(3, 4);
            btnGuarda.Margin = new Padding(3, 2, 3, 2);
            btnGuarda.Name = "btnGuarda";
            btnGuarda.Size = new Size(71, 72);
            btnGuarda.TabIndex = 11;
            btnGuarda.Text = "Guardar";
            btnGuarda.TextAlign = ContentAlignment.BottomCenter;
            btnGuarda.TextColor = Color.White;
            btnGuarda.UseVisualStyleBackColor = false;
            btnGuarda.Click += btnAgregar_Click;
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
            rjButton6.Location = new Point(157, 4);
            rjButton6.Margin = new Padding(3, 2, 3, 2);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(74, 72);
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
            rjButton2.Location = new Point(80, 4);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(71, 72);
            rjButton2.TabIndex = 12;
            rjButton2.Text = "Limpiar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnLimpiar_Click;
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
            txtConfirmarClave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarClave.HideSelection = true;
            txtConfirmarClave.Hint = "ingrese la clave nuevamente";
            txtConfirmarClave.LeadingIcon = null;
            txtConfirmarClave.Location = new Point(12, 222);
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
            txtConfirmarClave.TabIndex = 14;
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
            ckbVerContraseña.Location = new Point(12, 276);
            ckbVerContraseña.Name = "ckbVerContraseña";
            ckbVerContraseña.NoRounding = false;
            ckbVerContraseña.Size = new Size(234, 17);
            ckbVerContraseña.TabIndex = 13;
            ckbVerContraseña.Text = "ver contraseña";
            ckbVerContraseña.Transparent = false;
            ckbVerContraseña.CheckedChanged += ckbVerContraseña_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 48);
            label1.TabIndex = 7;
            label1.Text = "Datos del usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.AnimateReadOnly = true;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "ingrese el nombre completo";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(12, 60);
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
            // txtIdUsuario
            // 
            txtIdUsuario.Anchor = AnchorStyles.Left;
            txtIdUsuario.Location = new Point(211, 12);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(35, 23);
            txtIdUsuario.TabIndex = 8;
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
            cbxRol.Location = new Point(12, 308);
            cbxRol.MaxDropDownItems = 4;
            cbxRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(234, 49);
            cbxRol.StartIndex = 0;
            cbxRol.TabIndex = 7;
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
            txtClave.Location = new Point(12, 168);
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
            txtClave.TabIndex = 6;
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
            txtUsuario.Location = new Point(12, 114);
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
            txtUsuario.TabIndex = 5;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // cbxBuscar
            // 
            cbxBuscar.Anchor = AnchorStyles.Left;
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscar.DropDownHeight = 174;
            cbxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscar.DropDownWidth = 121;
            cbxBuscar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Hint = "buscar por";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "id", "usuario", "rol", "fecha" });
            cbxBuscar.Location = new Point(493, 0);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(154, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
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
            txtBuscar.Location = new Point(648, 1);
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
            txtBuscar.Size = new Size(237, 48);
            txtBuscar.TabIndex = 15;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "Editar";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.HeaderText = "Nombre de Usuario";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 150;
            // 
            // rol
            // 
            rol.HeaderText = "Rol de Usuario";
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            fecha.HeaderText = "Recha de Registro";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 200;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            // 
            // clave
            // 
            clave.HeaderText = "clave";
            clave.Name = "clave";
            clave.ReadOnly = true;
            clave.Visible = false;
            // 
            // formUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(921, 446);
            Controls.Add(txtBuscar);
            Controls.Add(cbxBuscar);
            Controls.Add(panel1);
            Controls.Add(lblEncabezado);
            Controls.Add(tbUsuarios);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formUsuarios";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formUsuarios";
            Load += formUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuarios;
        private Label lblEncabezado;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRol;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private TextBox txtIdUsuario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private Label label1;
        private ReaLTaiizor.Controls.AirCheckBox ckbVerContraseña;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConfirmarClave;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private DataGridViewTextBoxColumn fecha_Registro;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuarda;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn clave;
    }
}