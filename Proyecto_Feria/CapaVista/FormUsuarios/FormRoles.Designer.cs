namespace CapaPresentacion.FormUsuarios
{
    partial class FormRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoles));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtRol = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            txtIdRol = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnCerrar = new ReaLTaiizor.Controls.SocialButton();
            tbRoles = new ReaLTaiizor.Controls.PoisonDataGridView();
            EDITAR = new DataGridViewButtonColumn();
            ELIMINAR = new DataGridViewButtonColumn();
            A0 = new DataGridViewTextBoxColumn();
            A1 = new DataGridViewTextBoxColumn();
            A2 = new DataGridViewTextBoxColumn();
            A3 = new DataGridViewTextBoxColumn();
            A4 = new DataGridViewTextBoxColumn();
            A5 = new DataGridViewTextBoxColumn();
            A6 = new DataGridViewTextBoxColumn();
            A7 = new DataGridViewTextBoxColumn();
            ID_ROL = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            ckEmpresa = new ReaLTaiizor.Controls.HopeCheckBox();
            ckEmpleados = new ReaLTaiizor.Controls.HopeCheckBox();
            ckInformes = new ReaLTaiizor.Controls.HopeCheckBox();
            ckHerramientas = new ReaLTaiizor.Controls.HopeCheckBox();
            ckClientes = new ReaLTaiizor.Controls.HopeCheckBox();
            ckUsuarios = new ReaLTaiizor.Controls.HopeCheckBox();
            ckInventario = new ReaLTaiizor.Controls.HopeCheckBox();
            ckVentas = new ReaLTaiizor.Controls.HopeCheckBox();
            lbltitulo2 = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRoles).BeginInit();
            SuspendLayout();
            // 
            // txtRol
            // 
            txtRol.AnimateReadOnly = false;
            txtRol.AutoCompleteMode = AutoCompleteMode.None;
            txtRol.AutoCompleteSource = AutoCompleteSource.None;
            txtRol.BackgroundImageLayout = ImageLayout.None;
            txtRol.CharacterCasing = CharacterCasing.Normal;
            txtRol.Depth = 0;
            txtRol.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRol.HideSelection = true;
            txtRol.LeadingIcon = null;
            txtRol.Location = new Point(18, 97);
            txtRol.MaxLength = 32767;
            txtRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRol.Name = "txtRol";
            txtRol.PasswordChar = '\0';
            txtRol.PrefixSuffixText = null;
            txtRol.ReadOnly = false;
            txtRol.RightToLeft = RightToLeft.No;
            txtRol.SelectedText = "";
            txtRol.SelectionLength = 0;
            txtRol.SelectionStart = 0;
            txtRol.ShortcutsEnabled = true;
            txtRol.Size = new Size(367, 48);
            txtRol.TabIndex = 1;
            txtRol.TabStop = false;
            txtRol.Text = "Ingrese el nombre del rol";
            txtRol.TextAlign = HorizontalAlignment.Left;
            txtRol.TrailingIcon = null;
            txtRol.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(80, 80, 80);
            lblTitulo.Location = new Point(17, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(408, 41);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Creacion de roles de usuarios";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 0);
            tableLayoutPanel1.Location = new Point(115, 365);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(184, 48);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(3, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 44);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.BorderColor = Color.PaleVioletRed;
            btnLimpiar.BorderRadius = 10;
            btnLimpiar.BorderSize = 0;
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(94, 2);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 44);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextColor = Color.White;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdRol
            // 
            txtIdRol.Anchor = AnchorStyles.Left;
            txtIdRol.Location = new Point(18, 292);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(16, 23);
            txtIdRol.TabIndex = 32;
            txtIdRol.Text = "0";
            txtIdRol.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(tbRoles);
            panel1.Controls.Add(ckEmpresa);
            panel1.Controls.Add(ckEmpleados);
            panel1.Controls.Add(ckInformes);
            panel1.Controls.Add(ckHerramientas);
            panel1.Controls.Add(ckClientes);
            panel1.Controls.Add(ckUsuarios);
            panel1.Controls.Add(ckInventario);
            panel1.Controls.Add(ckVentas);
            panel1.Controls.Add(lbltitulo2);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(txtIdRol);
            panel1.Controls.Add(txtRol);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 447);
            panel1.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(458, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ActiveCaption;
            btnCerrar.DownEllipseColor = Color.Blue;
            btnCerrar.HoverEllipseColor = Color.FromArgb(32, 34, 37);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(3, 2);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.NormalEllipseColor = Color.FromArgb(66, 76, 85);
            btnCerrar.Size = new Size(54, 54);
            btnCerrar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCerrar.TabIndex = 44;
            btnCerrar.Text = "socialButton1";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tbRoles
            // 
            tbRoles.AllowUserToAddRows = false;
            tbRoles.AllowUserToDeleteRows = false;
            tbRoles.AllowUserToResizeRows = false;
            tbRoles.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbRoles.BorderStyle = BorderStyle.None;
            tbRoles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRoles.Columns.AddRange(new DataGridViewColumn[] { EDITAR, ELIMINAR, A0, A1, A2, A3, A4, A5, A6, A7, ID_ROL, NOMBRE });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbRoles.DefaultCellStyle = dataGridViewCellStyle2;
            tbRoles.Dock = DockStyle.Right;
            tbRoles.EnableHeadersVisualStyles = false;
            tbRoles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbRoles.GridColor = Color.FromArgb(255, 255, 255);
            tbRoles.Location = new Point(514, 0);
            tbRoles.Name = "tbRoles";
            tbRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbRoles.RowHeadersWidth = 51;
            tbRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbRoles.RowTemplate.Height = 25;
            tbRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbRoles.Size = new Size(340, 447);
            tbRoles.TabIndex = 43;
            tbRoles.CellContentClick += tbRoles_CellContentClick;
            tbRoles.CellPainting += tbRoles_CellPainting;
            // 
            // EDITAR
            // 
            EDITAR.FlatStyle = FlatStyle.Popup;
            EDITAR.HeaderText = "";
            EDITAR.MinimumWidth = 6;
            EDITAR.Name = "EDITAR";
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
            // A0
            // 
            A0.HeaderText = "";
            A0.MinimumWidth = 6;
            A0.Name = "A0";
            A0.ReadOnly = true;
            A0.Visible = false;
            A0.Width = 10;
            // 
            // A1
            // 
            A1.HeaderText = "";
            A1.MinimumWidth = 6;
            A1.Name = "A1";
            A1.ReadOnly = true;
            A1.Visible = false;
            A1.Width = 10;
            // 
            // A2
            // 
            A2.HeaderText = "";
            A2.MinimumWidth = 6;
            A2.Name = "A2";
            A2.ReadOnly = true;
            A2.Visible = false;
            A2.Width = 10;
            // 
            // A3
            // 
            A3.HeaderText = "";
            A3.MinimumWidth = 6;
            A3.Name = "A3";
            A3.ReadOnly = true;
            A3.Visible = false;
            A3.Width = 10;
            // 
            // A4
            // 
            A4.HeaderText = "";
            A4.MinimumWidth = 6;
            A4.Name = "A4";
            A4.ReadOnly = true;
            A4.Visible = false;
            A4.Width = 10;
            // 
            // A5
            // 
            A5.HeaderText = "";
            A5.MinimumWidth = 6;
            A5.Name = "A5";
            A5.ReadOnly = true;
            A5.Visible = false;
            A5.Width = 10;
            // 
            // A6
            // 
            A6.HeaderText = "";
            A6.MinimumWidth = 6;
            A6.Name = "A6";
            A6.ReadOnly = true;
            A6.Visible = false;
            A6.Width = 10;
            // 
            // A7
            // 
            A7.HeaderText = "";
            A7.MinimumWidth = 6;
            A7.Name = "A7";
            A7.ReadOnly = true;
            A7.Visible = false;
            A7.Width = 10;
            // 
            // ID_ROL
            // 
            ID_ROL.HeaderText = "ID";
            ID_ROL.MinimumWidth = 6;
            ID_ROL.Name = "ID_ROL";
            ID_ROL.ReadOnly = true;
            ID_ROL.Width = 50;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "ROL";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 200;
            // 
            // ckEmpresa
            // 
            ckEmpresa.AutoSize = true;
            ckEmpresa.CheckedColor = Color.FromArgb(64, 158, 255);
            ckEmpresa.DisabledColor = Color.FromArgb(196, 198, 202);
            ckEmpresa.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckEmpresa.Enable = true;
            ckEmpresa.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckEmpresa.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckEmpresa.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckEmpresa.ForeColor = Color.FromArgb(48, 49, 51);
            ckEmpresa.Location = new Point(253, 261);
            ckEmpresa.Name = "ckEmpresa";
            ckEmpresa.Size = new Size(95, 20);
            ckEmpresa.TabIndex = 42;
            ckEmpresa.Text = "Empresa";
            ckEmpresa.UseVisualStyleBackColor = true;
            // 
            // ckEmpleados
            // 
            ckEmpleados.AutoSize = true;
            ckEmpleados.CheckedColor = Color.FromArgb(64, 158, 255);
            ckEmpleados.DisabledColor = Color.FromArgb(196, 198, 202);
            ckEmpleados.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckEmpleados.Enable = true;
            ckEmpleados.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckEmpleados.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckEmpleados.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckEmpleados.ForeColor = Color.FromArgb(48, 49, 51);
            ckEmpleados.Location = new Point(253, 240);
            ckEmpleados.Name = "ckEmpleados";
            ckEmpleados.Size = new Size(111, 20);
            ckEmpleados.TabIndex = 41;
            ckEmpleados.Text = "Empleados";
            ckEmpleados.UseVisualStyleBackColor = true;
            // 
            // ckInformes
            // 
            ckInformes.AutoSize = true;
            ckInformes.CheckedColor = Color.FromArgb(64, 158, 255);
            ckInformes.DisabledColor = Color.FromArgb(196, 198, 202);
            ckInformes.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckInformes.Enable = true;
            ckInformes.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckInformes.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckInformes.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckInformes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckInformes.ForeColor = Color.FromArgb(48, 49, 51);
            ckInformes.Location = new Point(18, 261);
            ckInformes.Name = "ckInformes";
            ckInformes.Size = new Size(97, 20);
            ckInformes.TabIndex = 40;
            ckInformes.Text = "Informes";
            ckInformes.UseVisualStyleBackColor = true;
            // 
            // ckHerramientas
            // 
            ckHerramientas.AutoSize = true;
            ckHerramientas.CheckedColor = Color.FromArgb(64, 158, 255);
            ckHerramientas.DisabledColor = Color.FromArgb(196, 198, 202);
            ckHerramientas.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckHerramientas.Enable = true;
            ckHerramientas.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckHerramientas.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckHerramientas.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckHerramientas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckHerramientas.ForeColor = Color.FromArgb(48, 49, 51);
            ckHerramientas.Location = new Point(17, 240);
            ckHerramientas.Name = "ckHerramientas";
            ckHerramientas.Size = new Size(129, 20);
            ckHerramientas.TabIndex = 39;
            ckHerramientas.Text = "Herramientas";
            ckHerramientas.UseVisualStyleBackColor = true;
            // 
            // ckClientes
            // 
            ckClientes.AutoSize = true;
            ckClientes.CheckedColor = Color.FromArgb(64, 158, 255);
            ckClientes.DisabledColor = Color.FromArgb(196, 198, 202);
            ckClientes.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckClientes.Enable = true;
            ckClientes.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckClientes.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckClientes.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckClientes.ForeColor = Color.FromArgb(48, 49, 51);
            ckClientes.Location = new Point(253, 219);
            ckClientes.Name = "ckClientes";
            ckClientes.Size = new Size(90, 20);
            ckClientes.TabIndex = 38;
            ckClientes.Text = "Clientes";
            ckClientes.UseVisualStyleBackColor = true;
            // 
            // ckUsuarios
            // 
            ckUsuarios.AutoSize = true;
            ckUsuarios.CheckedColor = Color.FromArgb(64, 158, 255);
            ckUsuarios.DisabledColor = Color.FromArgb(196, 198, 202);
            ckUsuarios.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckUsuarios.Enable = true;
            ckUsuarios.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckUsuarios.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckUsuarios.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckUsuarios.ForeColor = Color.FromArgb(48, 49, 51);
            ckUsuarios.Location = new Point(253, 198);
            ckUsuarios.Name = "ckUsuarios";
            ckUsuarios.Size = new Size(96, 20);
            ckUsuarios.TabIndex = 37;
            ckUsuarios.Text = "Usuarios";
            ckUsuarios.UseVisualStyleBackColor = true;
            // 
            // ckInventario
            // 
            ckInventario.AutoSize = true;
            ckInventario.CheckedColor = Color.FromArgb(64, 158, 255);
            ckInventario.DisabledColor = Color.FromArgb(196, 198, 202);
            ckInventario.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckInventario.Enable = true;
            ckInventario.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckInventario.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckInventario.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckInventario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckInventario.ForeColor = Color.FromArgb(48, 49, 51);
            ckInventario.Location = new Point(17, 219);
            ckInventario.Name = "ckInventario";
            ckInventario.Size = new Size(105, 20);
            ckInventario.TabIndex = 36;
            ckInventario.Text = "Inventario";
            ckInventario.UseVisualStyleBackColor = true;
            // 
            // ckVentas
            // 
            ckVentas.AutoSize = true;
            ckVentas.CheckedColor = Color.FromArgb(64, 158, 255);
            ckVentas.DisabledColor = Color.FromArgb(196, 198, 202);
            ckVentas.DisabledStringColor = Color.FromArgb(186, 187, 189);
            ckVentas.Enable = true;
            ckVentas.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            ckVentas.EnabledStringColor = Color.FromArgb(153, 153, 153);
            ckVentas.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            ckVentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckVentas.ForeColor = Color.FromArgb(48, 49, 51);
            ckVentas.Location = new Point(18, 198);
            ckVentas.Name = "ckVentas";
            ckVentas.Size = new Size(81, 20);
            ckVentas.TabIndex = 35;
            ckVentas.Text = "Ventas";
            ckVentas.UseVisualStyleBackColor = true;
            // 
            // lbltitulo2
            // 
            lbltitulo2.AutoSize = true;
            lbltitulo2.BackColor = Color.Transparent;
            lbltitulo2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo2.ForeColor = Color.FromArgb(80, 80, 80);
            lbltitulo2.Location = new Point(18, 148);
            lbltitulo2.Name = "lbltitulo2";
            lbltitulo2.Size = new Size(338, 30);
            lbltitulo2.TabIndex = 34;
            lbltitulo2.Text = "Areas a las que tiene acceso el rol";
            // 
            // FormRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormRoles";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRoles";
            Load += FormRoles_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRol;
        private ReaLTaiizor.Controls.BigLabel lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private TextBox txtIdRol;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel lbltitulo2;
        private ReaLTaiizor.Controls.HopeCheckBox ckInformes;
        private ReaLTaiizor.Controls.HopeCheckBox ckHerramientas;
        private ReaLTaiizor.Controls.HopeCheckBox ckClientes;
        private ReaLTaiizor.Controls.HopeCheckBox ckUsuarios;
        private ReaLTaiizor.Controls.HopeCheckBox ckInventario;
        private ReaLTaiizor.Controls.HopeCheckBox ckVentas;
        private ReaLTaiizor.Controls.HopeCheckBox ckEmpresa;
        private ReaLTaiizor.Controls.HopeCheckBox ckEmpleados;
        private ReaLTaiizor.Controls.PoisonDataGridView tbRoles;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewTextBoxColumn A0;
        private DataGridViewTextBoxColumn A1;
        private DataGridViewTextBoxColumn A2;
        private DataGridViewTextBoxColumn A3;
        private DataGridViewTextBoxColumn A4;
        private DataGridViewTextBoxColumn A5;
        private DataGridViewTextBoxColumn A6;
        private DataGridViewTextBoxColumn A7;
        private DataGridViewTextBoxColumn ID_ROL;
        private DataGridViewTextBoxColumn NOMBRE;
        private ReaLTaiizor.Controls.SocialButton btnCerrar;
        private PictureBox pictureBox2;
    }
}