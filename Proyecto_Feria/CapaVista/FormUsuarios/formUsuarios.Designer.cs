

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblEncabezado = new Label();
            pnlRegistroUsuario = new Panel();
            btnRoles = new RJCodeAdvance.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            cbxEmpleados = new ReaLTaiizor.Controls.MaterialComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            txtConfirmarClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ckbVerContraseña = new ReaLTaiizor.Controls.AirCheckBox();
            txtIdUsuario = new TextBox();
            cbxRol = new ReaLTaiizor.Controls.MaterialComboBox();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pnlContenedor = new Panel();
            materialDrawer1 = new ReaLTaiizor.Controls.MaterialDrawer();
            tbUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
            EDITAR = new DataGridViewButtonColumn();
            ELIMINAR = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            ID_EMPLEADO = new DataGridViewTextBoxColumn();
            ID_ROL = new DataGridViewTextBoxColumn();
            USUARIO = new DataGridViewTextBoxColumn();
            EMPLEADO = new DataGridViewTextBoxColumn();
            ROL = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pnlRegistroUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(225, 71);
            lblEncabezado.TabIndex = 5;
            lblEncabezado.Text = "Usuarios registrados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.White;
            pnlRegistroUsuario.Controls.Add(btnRoles);
            pnlRegistroUsuario.Controls.Add(pictureBox2);
            pnlRegistroUsuario.Controls.Add(cbxEmpleados);
            pnlRegistroUsuario.Controls.Add(tableLayoutPanel1);
            pnlRegistroUsuario.Controls.Add(txtConfirmarClave);
            pnlRegistroUsuario.Controls.Add(ckbVerContraseña);
            pnlRegistroUsuario.Controls.Add(txtIdUsuario);
            pnlRegistroUsuario.Controls.Add(cbxRol);
            pnlRegistroUsuario.Controls.Add(txtClave);
            pnlRegistroUsuario.Controls.Add(txtUsuario);
            pnlRegistroUsuario.Dock = DockStyle.Fill;
            pnlRegistroUsuario.Location = new Point(0, 0);
            pnlRegistroUsuario.Margin = new Padding(3, 4, 3, 4);
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(333, 591);
            pnlRegistroUsuario.TabIndex = 6;
            // 
            // btnRoles
            // 
            btnRoles.Anchor = AnchorStyles.Left;
            btnRoles.BackColor = Color.DarkSlateGray;
            btnRoles.BackgroundColor = Color.DarkSlateGray;
            btnRoles.BackgroundImageLayout = ImageLayout.Center;
            btnRoles.BorderColor = Color.PaleVioletRed;
            btnRoles.BorderRadius = 10;
            btnRoles.BorderSize = 0;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoles.ForeColor = Color.White;
            btnRoles.Location = new Point(218, 291);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(93, 49);
            btnRoles.TabIndex = 78;
            btnRoles.Text = "Roles";
            btnRoles.TextColor = Color.White;
            btnRoles.UseVisualStyleBackColor = false;
            btnRoles.Click += btnRoles_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // cbxEmpleados
            // 
            cbxEmpleados.Anchor = AnchorStyles.Left;
            cbxEmpleados.AutoResize = false;
            cbxEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            cbxEmpleados.Depth = 0;
            cbxEmpleados.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEmpleados.DropDownHeight = 174;
            cbxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleados.DropDownWidth = 121;
            cbxEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEmpleados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEmpleados.FormattingEnabled = true;
            cbxEmpleados.Hint = "Cedula del empleado";
            cbxEmpleados.IntegralHeight = false;
            cbxEmpleados.ItemHeight = 43;
            cbxEmpleados.Location = new Point(15, 364);
            cbxEmpleados.Margin = new Padding(3, 4, 3, 4);
            cbxEmpleados.MaxDropDownItems = 4;
            cbxEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(295, 49);
            cbxEmpleados.StartIndex = 0;
            cbxEmpleados.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel1.Location = new Point(80, 464);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(174, 93);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(79, 87);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnAgregar_Click;
            btnGuardar.MouseHover += btnGuardar_MouseHover;
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Left;
            rjButton2.BackColor = Color.FromArgb(74, 121, 121);
            rjButton2.BackgroundColor = Color.FromArgb(74, 121, 121);
            rjButton2.BackgroundImage = (Image)resources.GetObject("rjButton2.BackgroundImage");
            rjButton2.BackgroundImageLayout = ImageLayout.Center;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.ImageAlign = ContentAlignment.MiddleRight;
            rjButton2.Location = new Point(89, 3);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(81, 87);
            rjButton2.TabIndex = 12;
            rjButton2.Text = "Limpiar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnLimpiar_Click;
            rjButton2.MouseHover += rjButton2_MouseHover;
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
            txtConfirmarClave.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarClave.HideSelection = true;
            txtConfirmarClave.Hint = "ingrese la clave nuevamente";
            txtConfirmarClave.LeadingIcon = null;
            txtConfirmarClave.Location = new Point(15, 188);
            txtConfirmarClave.Margin = new Padding(3, 4, 3, 4);
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
            txtConfirmarClave.Size = new Size(296, 48);
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
            ckbVerContraseña.Location = new Point(15, 260);
            ckbVerContraseña.Margin = new Padding(3, 4, 3, 4);
            ckbVerContraseña.Name = "ckbVerContraseña";
            ckbVerContraseña.NoRounding = false;
            ckbVerContraseña.Size = new Size(267, 17);
            ckbVerContraseña.TabIndex = 13;
            ckbVerContraseña.Text = "ver contraseña";
            ckbVerContraseña.Transparent = false;
            ckbVerContraseña.CheckedChanged += ckbVerContraseña_CheckedChanged;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Anchor = AnchorStyles.Left;
            txtIdUsuario.Location = new Point(293, 4);
            txtIdUsuario.Margin = new Padding(3, 4, 3, 4);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(18, 27);
            txtIdUsuario.TabIndex = 8;
            txtIdUsuario.Text = "0";
            txtIdUsuario.Visible = false;
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
            cbxRol.Hint = "Rol de usuario";
            cbxRol.IntegralHeight = false;
            cbxRol.ItemHeight = 43;
            cbxRol.Location = new Point(15, 291);
            cbxRol.Margin = new Padding(3, 4, 3, 4);
            cbxRol.MaxDropDownItems = 4;
            cbxRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(198, 49);
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
            txtClave.Location = new Point(15, 116);
            txtClave.Margin = new Padding(3, 4, 3, 4);
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
            txtClave.Size = new Size(296, 48);
            txtClave.TabIndex = 6;
            txtClave.TabStop = false;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.TrailingIcon = null;
            txtClave.UseSystemPasswordChar = false;
            txtClave.KeyPress += txtClave_KeyPress;
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
            txtUsuario.Location = new Point(15, 44);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
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
            txtUsuario.Size = new Size(296, 48);
            txtUsuario.TabIndex = 5;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // cbxBuscar
            // 
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.Dock = DockStyle.Left;
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
            cbxBuscar.Items.AddRange(new object[] { "USUARIO", "EMPLEADO", "ROL" });
            cbxBuscar.Location = new Point(225, 0);
            cbxBuscar.Margin = new Padding(3, 4, 3, 4);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(175, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 7;
            cbxBuscar.MouseHover += cbxBuscar_MouseHover;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = true;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.CharacterCasing = CharacterCasing.Normal;
            txtBuscar.Depth = 0;
            txtBuscar.Dock = DockStyle.Left;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar";
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(400, 0);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
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
            txtBuscar.Size = new Size(247, 48);
            txtBuscar.TabIndex = 15;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(pnlRegistroUsuario);
            pnlContenedor.Dock = DockStyle.Left;
            pnlContenedor.Location = new Point(3, 0);
            pnlContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(333, 591);
            pnlContenedor.TabIndex = 16;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-286, 235);
            materialDrawer1.Margin = new Padding(3, 4, 3, 4);
            materialDrawer1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.ShowTabControl = null;
            materialDrawer1.Size = new Size(286, 160);
            materialDrawer1.TabIndex = 0;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // tbUsuarios
            // 
            tbUsuarios.AllowUserToAddRows = false;
            tbUsuarios.AllowUserToDeleteRows = false;
            tbUsuarios.AllowUserToResizeRows = false;
            tbUsuarios.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbUsuarios.BorderStyle = BorderStyle.None;
            tbUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbUsuarios.Columns.AddRange(new DataGridViewColumn[] { EDITAR, ELIMINAR, ID, ID_EMPLEADO, ID_ROL, USUARIO, EMPLEADO, ROL });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            tbUsuarios.Dock = DockStyle.Fill;
            tbUsuarios.EnableHeadersVisualStyles = false;
            tbUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuarios.GridColor = Color.FromArgb(255, 255, 255);
            tbUsuarios.Location = new Point(336, 71);
            tbUsuarios.Margin = new Padding(3, 4, 3, 4);
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
            tbUsuarios.RowHeadersWidth = 51;
            tbUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbUsuarios.RowTemplate.Height = 25;
            tbUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbUsuarios.Size = new Size(714, 520);
            tbUsuarios.TabIndex = 18;
            tbUsuarios.CellContentClick += tbUsuarios_CellContentClick;
            tbUsuarios.CellPainting += tbUsuarios_CellPainting;
            // 
            // EDITAR
            // 
            EDITAR.FlatStyle = FlatStyle.Popup;
            EDITAR.HeaderText = "";
            EDITAR.MinimumWidth = 6;
            EDITAR.Name = "EDITAR";
            EDITAR.ToolTipText = "Editar";
            EDITAR.Width = 40;
            // 
            // ELIMINAR
            // 
            ELIMINAR.FlatStyle = FlatStyle.Popup;
            ELIMINAR.HeaderText = "";
            ELIMINAR.MinimumWidth = 6;
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.ToolTipText = "Eliminar";
            ELIMINAR.Width = 40;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // ID_EMPLEADO
            // 
            ID_EMPLEADO.HeaderText = "ID_EMPLEADO";
            ID_EMPLEADO.MinimumWidth = 6;
            ID_EMPLEADO.Name = "ID_EMPLEADO";
            ID_EMPLEADO.ReadOnly = true;
            ID_EMPLEADO.Visible = false;
            ID_EMPLEADO.Width = 125;
            // 
            // ID_ROL
            // 
            ID_ROL.HeaderText = "ID_ROL";
            ID_ROL.MinimumWidth = 6;
            ID_ROL.Name = "ID_ROL";
            ID_ROL.ReadOnly = true;
            ID_ROL.Visible = false;
            ID_ROL.Width = 125;
            // 
            // USUARIO
            // 
            USUARIO.HeaderText = "USUARIO";
            USUARIO.MinimumWidth = 6;
            USUARIO.Name = "USUARIO";
            USUARIO.ReadOnly = true;
            USUARIO.Width = 150;
            // 
            // EMPLEADO
            // 
            EMPLEADO.HeaderText = "EMPLEADO ASIGNADO";
            EMPLEADO.MinimumWidth = 6;
            EMPLEADO.Name = "EMPLEADO";
            EMPLEADO.ReadOnly = true;
            EMPLEADO.Width = 250;
            // 
            // ROL
            // 
            ROL.HeaderText = "ROL";
            ROL.MinimumWidth = 6;
            ROL.Name = "ROL";
            ROL.ReadOnly = true;
            ROL.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cbxBuscar);
            panel1.Controls.Add(lblEncabezado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(336, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 71);
            panel1.TabIndex = 19;
            // 
            // formUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1053, 595);
            Controls.Add(tbUsuarios);
            Controls.Add(panel1);
            Controls.Add(materialDrawer1);
            Controls.Add(pnlContenedor);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formUsuarios";
            Padding = new Padding(3, 0, 3, 4);
            Text = "formUsuarios";
            Load += formUsuarios_Load;
            pnlRegistroUsuario.ResumeLayout(false);
            pnlRegistroUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblEncabezado;
        private Panel pnlRegistroUsuario;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRol;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private TextBox txtIdUsuario;
        private ReaLTaiizor.Controls.AirCheckBox ckbVerContraseña;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConfirmarClave;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
#pragma warning disable CS0169 // El campo 'formUsuarios.fecha_Registro' nunca se usa
        private DataGridViewTextBoxColumn fecha_Registro;
#pragma warning restore CS0169 // El campo 'formUsuarios.fecha_Registro' nunca se usa
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private Panel pnlContenedor;
        private ReaLTaiizor.Controls.MaterialDrawer materialDrawer1;
        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleados;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuarios;
        private Panel panel1;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ID_EMPLEADO;
        private DataGridViewTextBoxColumn ID_ROL;
        private DataGridViewTextBoxColumn USUARIO;
        private DataGridViewTextBoxColumn EMPLEADO;
        private DataGridViewTextBoxColumn ROL;
        private RJCodeAdvance.RJControls.RJButton btnRoles;
    }
}