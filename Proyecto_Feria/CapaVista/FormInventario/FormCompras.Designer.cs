namespace CapaVista.FormInventario
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlOpciones = new Panel();
            pnlContenedor = new Panel();
            pnlRegistroUsuario = new Panel();
            ckbEmpleadoNulo = new ReaLTaiizor.Controls.AirCheckBox();
            cbxEmpleados = new ReaLTaiizor.Controls.MaterialComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            txtConfirmarClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ckbVerContraseña = new ReaLTaiizor.Controls.AirCheckBox();
            txtIdUsuario = new TextBox();
            cbxRol = new ReaLTaiizor.Controls.MaterialComboBox();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            lblEncabezado = new Label();
            tbUsuarios = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            idEmpleado = new DataGridViewTextBoxColumn();
            pnlContenedor.SuspendLayout();
            pnlRegistroUsuario.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlOpciones
            // 
            pnlOpciones.Location = new Point(14, 8);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(284, 36);
            pnlOpciones.TabIndex = 23;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(pnlRegistroUsuario);
            pnlContenedor.Location = new Point(14, 50);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(284, 393);
            pnlContenedor.TabIndex = 22;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.White;
            pnlRegistroUsuario.Controls.Add(ckbEmpleadoNulo);
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
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(284, 393);
            pnlRegistroUsuario.TabIndex = 6;
            // 
            // ckbEmpleadoNulo
            // 
            ckbEmpleadoNulo.Anchor = AnchorStyles.Left;
            ckbEmpleadoNulo.Checked = false;
            ckbEmpleadoNulo.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            ckbEmpleadoNulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbEmpleadoNulo.Image = null;
            ckbEmpleadoNulo.Location = new Point(13, 447);
            ckbEmpleadoNulo.Name = "ckbEmpleadoNulo";
            ckbEmpleadoNulo.NoRounding = false;
            ckbEmpleadoNulo.Size = new Size(234, 17);
            ckbEmpleadoNulo.TabIndex = 32;
            ckbEmpleadoNulo.Text = "Desactivar empleados";
            ckbEmpleadoNulo.Transparent = false;
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
            cbxEmpleados.Hint = "seleccione un empleado";
            cbxEmpleados.IntegralHeight = false;
            cbxEmpleados.ItemHeight = 43;
            cbxEmpleados.Location = new Point(13, 394);
            cbxEmpleados.MaxDropDownItems = 4;
            cbxEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(234, 49);
            cbxEmpleados.StartIndex = 0;
            cbxEmpleados.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel1.Location = new Point(49, 467);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(152, 70);
            tableLayoutPanel1.TabIndex = 30;
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
            rjButton2.Location = new Point(78, 2);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(71, 66);
            rjButton2.TabIndex = 12;
            rjButton2.Text = "Limpiar";
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
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
            btnGuardar.Size = new Size(69, 66);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
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
            txtConfirmarClave.Location = new Point(13, 262);
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
            ckbVerContraseña.Location = new Point(13, 316);
            ckbVerContraseña.Name = "ckbVerContraseña";
            ckbVerContraseña.NoRounding = false;
            ckbVerContraseña.Size = new Size(234, 17);
            ckbVerContraseña.TabIndex = 13;
            ckbVerContraseña.Text = "ver contraseña";
            ckbVerContraseña.Transparent = false;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Anchor = AnchorStyles.Left;
            txtIdUsuario.Location = new Point(265, 505);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(16, 23);
            txtIdUsuario.TabIndex = 8;
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
            cbxRol.Hint = "seleccione un rol de usuario";
            cbxRol.IntegralHeight = false;
            cbxRol.ItemHeight = 43;
            cbxRol.Location = new Point(13, 339);
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
            txtClave.Location = new Point(13, 208);
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
            txtUsuario.Location = new Point(13, 154);
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
            txtBuscar.Location = new Point(681, 8);
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
            txtBuscar.Size = new Size(216, 48);
            txtBuscar.TabIndex = 21;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
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
            cbxBuscar.Location = new Point(519, 8);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(154, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 20;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(316, 4);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(197, 53);
            lblEncabezado.TabIndex = 19;
            lblEncabezado.Text = "Compras realizadas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
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
            tbUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnBorrar, id, usuario, rol, fecha, idRol, clave, idEmpleado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            tbUsuarios.EnableHeadersVisualStyles = false;
            tbUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuarios.GridColor = Color.Gray;
            tbUsuarios.Location = new Point(316, 58);
            tbUsuarios.Name = "tbUsuarios";
            tbUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbUsuarios.RowHeadersVisible = false;
            tbUsuarios.RowHeadersWidth = 40;
            tbUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbUsuarios.RowTemplate.Height = 30;
            tbUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbUsuarios.Size = new Size(607, 389);
            tbUsuarios.TabIndex = 18;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ToolTipText = "editar";
            btnEditar.Width = 50;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "Eliminar";
            btnBorrar.Name = "btnBorrar";
            btnBorrar.ToolTipText = "eliminar";
            btnBorrar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 10;
            // 
            // usuario
            // 
            usuario.HeaderText = "Nombre de Usuario";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 200;
            // 
            // rol
            // 
            rol.HeaderText = "Rol de Usuario";
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.SortMode = DataGridViewColumnSortMode.NotSortable;
            rol.Width = 150;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha de Registro";
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
            // idEmpleado
            // 
            idEmpleado.HeaderText = "empleado";
            idEmpleado.Name = "idEmpleado";
            idEmpleado.ReadOnly = true;
            idEmpleado.Visible = false;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(pnlOpciones);
            Controls.Add(pnlContenedor);
            Controls.Add(txtBuscar);
            Controls.Add(cbxBuscar);
            Controls.Add(lblEncabezado);
            Controls.Add(tbUsuarios);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormCompras";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormCompras";
            pnlContenedor.ResumeLayout(false);
            pnlRegistroUsuario.ResumeLayout(false);
            pnlRegistroUsuario.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOpciones;
        private Panel pnlContenedor;
        private Panel pnlRegistroUsuario;
        private ReaLTaiizor.Controls.AirCheckBox ckbEmpleadoNulo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleados;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConfirmarClave;
        private ReaLTaiizor.Controls.AirCheckBox ckbVerContraseña;
        private TextBox txtIdUsuario;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRol;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuarios;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnBorrar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn clave;
        private DataGridViewTextBoxColumn idEmpleado;
    }
}