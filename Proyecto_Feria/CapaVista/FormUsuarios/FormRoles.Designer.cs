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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtRol = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblTitulo = new ReaLTaiizor.Controls.BigLabel();
            tbRoles = new ReaLTaiizor.Controls.PoisonDataGridView();
            EDITAR = new DataGridViewButtonColumn();
            ELIMINAR = new DataGridViewButtonColumn();
            A1 = new DataGridViewTextBoxColumn();
            A2 = new DataGridViewTextBoxColumn();
            A3 = new DataGridViewTextBoxColumn();
            A4 = new DataGridViewTextBoxColumn();
            A5 = new DataGridViewTextBoxColumn();
            A6 = new DataGridViewTextBoxColumn();
            A7 = new DataGridViewTextBoxColumn();
            A8 = new DataGridViewTextBoxColumn();
            A9 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ROL = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            txtIdRol = new TextBox();
            panel1 = new Panel();
            hopeCheckBox9 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox8 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox7 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox6 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox5 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox4 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox3 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox2 = new ReaLTaiizor.Controls.HopeCheckBox();
            hopeCheckBox1 = new ReaLTaiizor.Controls.HopeCheckBox();
            lbltitulo2 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)tbRoles).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            tbRoles.Columns.AddRange(new DataGridViewColumn[] { EDITAR, ELIMINAR, A1, A2, A3, A4, A5, A6, A7, A8, A9, ID, ROL });
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
            tbRoles.Location = new Point(435, 0);
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
            tbRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbRoles.RowTemplate.Height = 25;
            tbRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbRoles.Size = new Size(362, 447);
            tbRoles.TabIndex = 19;
            // 
            // EDITAR
            // 
            EDITAR.FlatStyle = FlatStyle.Popup;
            EDITAR.HeaderText = "";
            EDITAR.Name = "EDITAR";
            EDITAR.ToolTipText = "Editar";
            EDITAR.Width = 40;
            // 
            // ELIMINAR
            // 
            ELIMINAR.FlatStyle = FlatStyle.Popup;
            ELIMINAR.HeaderText = "";
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.ToolTipText = "Eliminar";
            ELIMINAR.Width = 40;
            // 
            // A1
            // 
            A1.HeaderText = "";
            A1.Name = "A1";
            A1.ReadOnly = true;
            A1.Visible = false;
            // 
            // A2
            // 
            A2.HeaderText = "";
            A2.Name = "A2";
            A2.ReadOnly = true;
            A2.Visible = false;
            // 
            // A3
            // 
            A3.HeaderText = "";
            A3.Name = "A3";
            A3.ReadOnly = true;
            A3.Visible = false;
            // 
            // A4
            // 
            A4.HeaderText = "";
            A4.Name = "A4";
            A4.ReadOnly = true;
            A4.Visible = false;
            // 
            // A5
            // 
            A5.HeaderText = "";
            A5.Name = "A5";
            A5.ReadOnly = true;
            A5.Visible = false;
            // 
            // A6
            // 
            A6.HeaderText = "";
            A6.Name = "A6";
            A6.ReadOnly = true;
            A6.Visible = false;
            // 
            // A7
            // 
            A7.HeaderText = "";
            A7.Name = "A7";
            A7.ReadOnly = true;
            A7.Visible = false;
            // 
            // A8
            // 
            A8.HeaderText = "";
            A8.Name = "A8";
            A8.ReadOnly = true;
            A8.Visible = false;
            // 
            // A9
            // 
            A9.HeaderText = "";
            A9.Name = "A9";
            A9.ReadOnly = true;
            A9.Visible = false;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // ROL
            // 
            ROL.HeaderText = "ROL";
            ROL.Name = "ROL";
            ROL.ReadOnly = true;
            ROL.Width = 500;
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
            panel1.Controls.Add(hopeCheckBox9);
            panel1.Controls.Add(hopeCheckBox8);
            panel1.Controls.Add(hopeCheckBox7);
            panel1.Controls.Add(hopeCheckBox6);
            panel1.Controls.Add(hopeCheckBox5);
            panel1.Controls.Add(hopeCheckBox4);
            panel1.Controls.Add(hopeCheckBox3);
            panel1.Controls.Add(hopeCheckBox2);
            panel1.Controls.Add(hopeCheckBox1);
            panel1.Controls.Add(lbltitulo2);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(txtIdRol);
            panel1.Controls.Add(txtRol);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 447);
            panel1.TabIndex = 33;
            // 
            // hopeCheckBox9
            // 
            hopeCheckBox9.AutoSize = true;
            hopeCheckBox9.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox9.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox9.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox9.Enable = true;
            hopeCheckBox9.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox9.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox9.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox9.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox9.Location = new Point(274, 250);
            hopeCheckBox9.Name = "hopeCheckBox9";
            hopeCheckBox9.Size = new Size(111, 20);
            hopeCheckBox9.TabIndex = 43;
            hopeCheckBox9.Text = "Dashboard";
            hopeCheckBox9.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox8
            // 
            hopeCheckBox8.AutoSize = true;
            hopeCheckBox8.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox8.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox8.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox8.Enable = true;
            hopeCheckBox8.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox8.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox8.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox8.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox8.Location = new Point(274, 224);
            hopeCheckBox8.Name = "hopeCheckBox8";
            hopeCheckBox8.Size = new Size(95, 20);
            hopeCheckBox8.TabIndex = 42;
            hopeCheckBox8.Text = "Empresa";
            hopeCheckBox8.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox7
            // 
            hopeCheckBox7.AutoSize = true;
            hopeCheckBox7.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox7.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox7.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox7.Enable = true;
            hopeCheckBox7.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox7.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox7.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox7.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox7.Location = new Point(274, 198);
            hopeCheckBox7.Name = "hopeCheckBox7";
            hopeCheckBox7.Size = new Size(111, 20);
            hopeCheckBox7.TabIndex = 41;
            hopeCheckBox7.Text = "Empleados";
            hopeCheckBox7.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox6
            // 
            hopeCheckBox6.AutoSize = true;
            hopeCheckBox6.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox6.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox6.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox6.Enable = true;
            hopeCheckBox6.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox6.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox6.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox6.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox6.Location = new Point(166, 250);
            hopeCheckBox6.Name = "hopeCheckBox6";
            hopeCheckBox6.Size = new Size(97, 20);
            hopeCheckBox6.TabIndex = 40;
            hopeCheckBox6.Text = "Informes";
            hopeCheckBox6.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox5
            // 
            hopeCheckBox5.AutoSize = true;
            hopeCheckBox5.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox5.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox5.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox5.Enable = true;
            hopeCheckBox5.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox5.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox5.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox5.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox5.Location = new Point(17, 250);
            hopeCheckBox5.Name = "hopeCheckBox5";
            hopeCheckBox5.Size = new Size(129, 20);
            hopeCheckBox5.TabIndex = 39;
            hopeCheckBox5.Text = "Herramientas";
            hopeCheckBox5.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox4
            // 
            hopeCheckBox4.AutoSize = true;
            hopeCheckBox4.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox4.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox4.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox4.Enable = true;
            hopeCheckBox4.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox4.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox4.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox4.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox4.Location = new Point(166, 224);
            hopeCheckBox4.Name = "hopeCheckBox4";
            hopeCheckBox4.Size = new Size(90, 20);
            hopeCheckBox4.TabIndex = 38;
            hopeCheckBox4.Text = "Clientes";
            hopeCheckBox4.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox3
            // 
            hopeCheckBox3.AutoSize = true;
            hopeCheckBox3.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox3.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox3.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox3.Enable = true;
            hopeCheckBox3.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox3.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox3.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox3.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox3.Location = new Point(166, 198);
            hopeCheckBox3.Name = "hopeCheckBox3";
            hopeCheckBox3.Size = new Size(96, 20);
            hopeCheckBox3.TabIndex = 37;
            hopeCheckBox3.Text = "Usuarios";
            hopeCheckBox3.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox2
            // 
            hopeCheckBox2.AutoSize = true;
            hopeCheckBox2.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox2.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox2.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox2.Enable = true;
            hopeCheckBox2.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox2.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox2.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox2.Location = new Point(17, 224);
            hopeCheckBox2.Name = "hopeCheckBox2";
            hopeCheckBox2.Size = new Size(105, 20);
            hopeCheckBox2.TabIndex = 36;
            hopeCheckBox2.Text = "Inventario";
            hopeCheckBox2.UseVisualStyleBackColor = true;
            // 
            // hopeCheckBox1
            // 
            hopeCheckBox1.AutoSize = true;
            hopeCheckBox1.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox1.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox1.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox1.Enable = true;
            hopeCheckBox1.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeCheckBox1.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox1.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeCheckBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox1.Location = new Point(17, 198);
            hopeCheckBox1.Name = "hopeCheckBox1";
            hopeCheckBox1.Size = new Size(81, 20);
            hopeCheckBox1.TabIndex = 35;
            hopeCheckBox1.Text = "Ventas";
            hopeCheckBox1.UseVisualStyleBackColor = true;
            // 
            // lbltitulo2
            // 
            lbltitulo2.AutoSize = true;
            lbltitulo2.BackColor = Color.Transparent;
            lbltitulo2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo2.ForeColor = Color.FromArgb(80, 80, 80);
            lbltitulo2.Location = new Point(18, 148);
            lbltitulo2.Name = "lbltitulo2";
            lbltitulo2.Size = new Size(367, 30);
            lbltitulo2.TabIndex = 34;
            lbltitulo2.Text = "Areas a las que tendra permiso el rol";
            // 
            // FormRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbRoles);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormRoles";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRoles";
            Load += FormRoles_Load;
            ((System.ComponentModel.ISupportInitialize)tbRoles).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRol;
        private ReaLTaiizor.Controls.BigLabel lblTitulo;
        private ReaLTaiizor.Controls.PoisonDataGridView tbRoles;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private TextBox txtIdRol;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel lbltitulo2;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox6;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox5;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox4;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox3;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox2;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox1;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox9;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox8;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox7;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewTextBoxColumn A1;
        private DataGridViewTextBoxColumn A2;
        private DataGridViewTextBoxColumn A3;
        private DataGridViewTextBoxColumn A4;
        private DataGridViewTextBoxColumn A5;
        private DataGridViewTextBoxColumn A6;
        private DataGridViewTextBoxColumn A7;
        private DataGridViewTextBoxColumn A8;
        private DataGridViewTextBoxColumn A9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ROL;
    }
}