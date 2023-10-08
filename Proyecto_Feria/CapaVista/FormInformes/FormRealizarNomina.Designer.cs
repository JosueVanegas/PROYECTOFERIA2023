namespace CapaPresentacion.FormInformes
{
    partial class FormRealizarNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealizarNomina));
            label1 = new Label();
            txtEmpleado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHorasTrabajadas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txthorasExtras = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEmpleados = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEditar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Trabajador = new DataGridViewTextBoxColumn();
            Salariohora = new DataGridViewTextBoxColumn();
            HorasTrabajadas = new DataGridViewTextBoxColumn();
            HorasExtras = new DataGridViewTextBoxColumn();
            btnCerrarBusqueda = new Button();
            btnRealizarNomina = new RJCodeAdvance.RJControls.RJButton();
            lblId = new Label();
            btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tbEmpleados).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos para realizar la nómina";
            // 
            // txtEmpleado
            // 
            txtEmpleado.AnimateReadOnly = false;
            txtEmpleado.AutoCompleteMode = AutoCompleteMode.None;
            txtEmpleado.AutoCompleteSource = AutoCompleteSource.None;
            txtEmpleado.BackgroundImageLayout = ImageLayout.None;
            txtEmpleado.CharacterCasing = CharacterCasing.Normal;
            txtEmpleado.Depth = 0;
            txtEmpleado.Dock = DockStyle.Left;
            txtEmpleado.Enabled = false;
            txtEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmpleado.HideSelection = true;
            txtEmpleado.Hint = "nombre del trabajador";
            txtEmpleado.LeadingIcon = null;
            txtEmpleado.Location = new Point(0, 0);
            txtEmpleado.MaxLength = 32767;
            txtEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.PasswordChar = '\0';
            txtEmpleado.PrefixSuffixText = null;
            txtEmpleado.ReadOnly = false;
            txtEmpleado.RightToLeft = RightToLeft.No;
            txtEmpleado.SelectedText = "";
            txtEmpleado.SelectionLength = 0;
            txtEmpleado.SelectionStart = 0;
            txtEmpleado.ShortcutsEnabled = true;
            txtEmpleado.Size = new Size(272, 48);
            txtEmpleado.TabIndex = 1;
            txtEmpleado.TabStop = false;
            txtEmpleado.TextAlign = HorizontalAlignment.Left;
            txtEmpleado.TrailingIcon = null;
            txtEmpleado.UseSystemPasswordChar = false;
            // 
            // txtHorasTrabajadas
            // 
            txtHorasTrabajadas.AnimateReadOnly = false;
            txtHorasTrabajadas.AutoCompleteMode = AutoCompleteMode.None;
            txtHorasTrabajadas.AutoCompleteSource = AutoCompleteSource.None;
            txtHorasTrabajadas.BackgroundImageLayout = ImageLayout.None;
            txtHorasTrabajadas.CharacterCasing = CharacterCasing.Normal;
            txtHorasTrabajadas.Depth = 0;
            txtHorasTrabajadas.Dock = DockStyle.Left;
            txtHorasTrabajadas.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorasTrabajadas.HideSelection = true;
            txtHorasTrabajadas.Hint = "horas trabajadas";
            txtHorasTrabajadas.LeadingIcon = null;
            txtHorasTrabajadas.Location = new Point(272, 0);
            txtHorasTrabajadas.MaxLength = 32767;
            txtHorasTrabajadas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.PasswordChar = '\0';
            txtHorasTrabajadas.PrefixSuffixText = null;
            txtHorasTrabajadas.ReadOnly = false;
            txtHorasTrabajadas.RightToLeft = RightToLeft.No;
            txtHorasTrabajadas.SelectedText = "";
            txtHorasTrabajadas.SelectionLength = 0;
            txtHorasTrabajadas.SelectionStart = 0;
            txtHorasTrabajadas.ShortcutsEnabled = true;
            txtHorasTrabajadas.Size = new Size(160, 48);
            txtHorasTrabajadas.TabIndex = 2;
            txtHorasTrabajadas.TabStop = false;
            txtHorasTrabajadas.TextAlign = HorizontalAlignment.Left;
            txtHorasTrabajadas.TrailingIcon = null;
            txtHorasTrabajadas.UseSystemPasswordChar = false;
            txtHorasTrabajadas.KeyPress += txtHorasTrabajadas_KeyPress;
            // 
            // txthorasExtras
            // 
            txthorasExtras.AnimateReadOnly = false;
            txthorasExtras.AutoCompleteMode = AutoCompleteMode.None;
            txthorasExtras.AutoCompleteSource = AutoCompleteSource.None;
            txthorasExtras.BackgroundImageLayout = ImageLayout.None;
            txthorasExtras.CharacterCasing = CharacterCasing.Normal;
            txthorasExtras.Depth = 0;
            txthorasExtras.Dock = DockStyle.Left;
            txthorasExtras.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txthorasExtras.HideSelection = true;
            txthorasExtras.Hint = "horas extras";
            txthorasExtras.LeadingIcon = null;
            txthorasExtras.Location = new Point(432, 0);
            txthorasExtras.MaxLength = 32767;
            txthorasExtras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txthorasExtras.Name = "txthorasExtras";
            txthorasExtras.PasswordChar = '\0';
            txthorasExtras.PrefixSuffixText = null;
            txthorasExtras.ReadOnly = false;
            txthorasExtras.RightToLeft = RightToLeft.No;
            txthorasExtras.SelectedText = "";
            txthorasExtras.SelectionLength = 0;
            txthorasExtras.SelectionStart = 0;
            txthorasExtras.ShortcutsEnabled = true;
            txthorasExtras.Size = new Size(151, 48);
            txthorasExtras.TabIndex = 3;
            txthorasExtras.TabStop = false;
            txthorasExtras.TextAlign = HorizontalAlignment.Left;
            txthorasExtras.TrailingIcon = null;
            txthorasExtras.UseSystemPasswordChar = false;
            txthorasExtras.KeyPress += txthorasExtras_KeyPress;
            // 
            // tbEmpleados
            // 
            tbEmpleados.AllowUserToAddRows = false;
            tbEmpleados.AllowUserToOrderColumns = true;
            tbEmpleados.AllowUserToResizeRows = false;
            tbEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbEmpleados.BackgroundColor = Color.White;
            tbEmpleados.BorderStyle = BorderStyle.None;
            tbEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tbEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbEmpleados.ColumnHeadersHeight = 35;
            tbEmpleados.Columns.AddRange(new DataGridViewColumn[] { btnEditar, Id, Trabajador, Salariohora, HorasTrabajadas, HorasExtras });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            tbEmpleados.EnableHeadersVisualStyles = false;
            tbEmpleados.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmpleados.GridColor = Color.Gray;
            tbEmpleados.Location = new Point(36, 3);
            tbEmpleados.Name = "tbEmpleados";
            tbEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbEmpleados.RowHeadersVisible = false;
            tbEmpleados.RowHeadersWidth = 40;
            tbEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbEmpleados.RowTemplate.Height = 30;
            tbEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbEmpleados.Size = new Size(769, 263);
            tbEmpleados.TabIndex = 43;
            tbEmpleados.CellContentClick += tbEmpleados_CellContentClick;
            tbEmpleados.CellPainting += tbEmpleados_CellPainting;
            // 
            // btnEditar
            // 
            btnEditar.FillWeight = 126.903564F;
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Trabajador
            // 
            Trabajador.FillWeight = 140.873535F;
            Trabajador.HeaderText = "Trabajador";
            Trabajador.Name = "Trabajador";
            Trabajador.ReadOnly = true;
            Trabajador.Width = 270;
            // 
            // Salariohora
            // 
            Salariohora.FillWeight = 59.176487F;
            Salariohora.HeaderText = "Salario hora";
            Salariohora.Name = "Salariohora";
            Salariohora.ReadOnly = true;
            Salariohora.Width = 150;
            // 
            // HorasTrabajadas
            // 
            HorasTrabajadas.FillWeight = 75.5511F;
            HorasTrabajadas.HeaderText = "Horas trabajadas";
            HorasTrabajadas.Name = "HorasTrabajadas";
            HorasTrabajadas.ReadOnly = true;
            HorasTrabajadas.Width = 150;
            // 
            // HorasExtras
            // 
            HorasExtras.FillWeight = 97.49532F;
            HorasExtras.HeaderText = "Horas extras trabajadas";
            HorasExtras.Name = "HorasExtras";
            HorasExtras.ReadOnly = true;
            HorasExtras.Width = 150;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = Color.Red;
            btnCerrarBusqueda.Dock = DockStyle.Right;
            btnCerrarBusqueda.Image = (Image)resources.GetObject("btnCerrarBusqueda.Image");
            btnCerrarBusqueda.Location = new Point(824, 0);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(34, 35);
            btnCerrarBusqueda.TabIndex = 63;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
            btnCerrarBusqueda.Click += btnCerrarBusqueda_Click;
            // 
            // btnRealizarNomina
            // 
            btnRealizarNomina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRealizarNomina.BackColor = Color.FromArgb(74, 121, 121);
            btnRealizarNomina.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnRealizarNomina.BackgroundImage = (Image)resources.GetObject("btnRealizarNomina.BackgroundImage");
            btnRealizarNomina.BackgroundImageLayout = ImageLayout.Center;
            btnRealizarNomina.BorderColor = Color.PaleVioletRed;
            btnRealizarNomina.BorderRadius = 10;
            btnRealizarNomina.BorderSize = 0;
            btnRealizarNomina.FlatAppearance.BorderSize = 0;
            btnRealizarNomina.FlatStyle = FlatStyle.Flat;
            btnRealizarNomina.ForeColor = Color.White;
            btnRealizarNomina.ImageAlign = ContentAlignment.MiddleRight;
            btnRealizarNomina.Location = new Point(323, 271);
            btnRealizarNomina.Margin = new Padding(3, 2, 3, 2);
            btnRealizarNomina.Name = "btnRealizarNomina";
            btnRealizarNomina.Size = new Size(233, 62);
            btnRealizarNomina.TabIndex = 64;
            btnRealizarNomina.Text = "Realizar nomina";
            btnRealizarNomina.TextAlign = ContentAlignment.BottomCenter;
            btnRealizarNomina.TextColor = Color.White;
            btnRealizarNomina.UseVisualStyleBackColor = false;
            btnRealizarNomina.Click += btnRealizarNomina_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Left;
            lblId.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(323, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 19);
            lblId.TabIndex = 65;
            lblId.Text = "0";
            lblId.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkCyan;
            btnGuardar.BackgroundColor = Color.DarkCyan;
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 10;
            btnGuardar.BorderSize = 0;
            btnGuardar.Dock = DockStyle.Left;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(583, 0);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 51);
            btnGuardar.TabIndex = 66;
            btnGuardar.Text = "guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(btnCerrarBusqueda);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 0);
            panel1.MaximumSize = new Size(858, 35);
            panel1.MinimumSize = new Size(858, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 35);
            panel1.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(txthorasExtras);
            panel2.Controls.Add(txtHorasTrabajadas);
            panel2.Controls.Add(txtEmpleado);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 51);
            panel2.TabIndex = 68;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(tbEmpleados);
            panel3.Controls.Add(btnRealizarNomina);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 408);
            panel3.TabIndex = 69;
            // 
            // FormRealizarNomina
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(864, 497);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormRealizarNomina";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRealizarNomina";
            Load += FormRealizarNomina_Load;
            ((System.ComponentModel.ISupportInitialize)tbEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmpleado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHorasTrabajadas;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txthorasExtras;
        private ReaLTaiizor.Controls.PoisonDataGridView tbEmpleados;
        private Button btnCerrarBusqueda;
        private RJCodeAdvance.RJControls.RJButton btnRealizarNomina;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Trabajador;
        private DataGridViewTextBoxColumn Salariohora;
        private DataGridViewTextBoxColumn HorasTrabajadas;
        private DataGridViewTextBoxColumn HorasExtras;
        private Label lblId;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}