using RJCodeAdvance;
using ReaLTaiizor;
namespace CapaVista
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelAbajo = new Panel();
            lblRol = new Label();
            lblReloj = new Label();
            lblUsuario = new Label();
            btnClientes = new RJCodeAdvance.RJControls.RJButton();
            btnInventario = new RJCodeAdvance.RJControls.RJButton();
            btnPlanilla = new RJCodeAdvance.RJControls.RJButton();
            btnInformes = new RJCodeAdvance.RJControls.RJButton();
            btnVentas = new RJCodeAdvance.RJControls.RJButton();
            panelVertical_Admin = new TableLayoutPanel();
            btnUsuarios = new RJCodeAdvance.RJControls.RJButton();
            btnConfiguraciones = new RJCodeAdvance.RJControls.RJButton();
            btnHerramientas = new RJCodeAdvance.RJControls.RJButton();
            btnBarraVertical = new RJCodeAdvance.RJControls.RJButton();
            btnInicio = new RJCodeAdvance.RJControls.RJButton();
            panelContenedor = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblEncabezado2 = new Label();
            lblEncabezado3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            cyberSwitch1 = new ReaLTaiizor.Controls.CyberSwitch();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            reloj = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            panel5 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panelAbajo.SuspendLayout();
            panelVertical_Admin.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbajo
            // 
            panelAbajo.BackColor = Color.Silver;
            panelAbajo.Controls.Add(lblRol);
            panelAbajo.Controls.Add(lblReloj);
            panelAbajo.Controls.Add(lblUsuario);
            panelAbajo.Dock = DockStyle.Bottom;
            panelAbajo.Location = new Point(126, 575);
            panelAbajo.Margin = new Padding(5, 3, 5, 3);
            panelAbajo.Name = "panelAbajo";
            panelAbajo.Size = new Size(966, 68);
            panelAbajo.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(273, 4);
            lblRol.Margin = new Padding(5, 0, 5, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(322, 64);
            lblRol.TabIndex = 53;
            lblRol.Text = "Rol del usuario:";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReloj
            // 
            lblReloj.Dock = DockStyle.Right;
            lblReloj.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.ForeColor = Color.Black;
            lblReloj.Location = new Point(665, 0);
            lblReloj.Margin = new Padding(5, 0, 5, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(301, 68);
            lblReloj.TabIndex = 53;
            lblReloj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(322, 63);
            lblUsuario.TabIndex = 52;
            lblUsuario.Text = "Usuario actual:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClientes.BackColor = Color.Silver;
            btnClientes.BackgroundColor = Color.Silver;
            btnClientes.BackgroundImage = (Image)resources.GetObject("btnClientes.BackgroundImage");
            btnClientes.BackgroundImageLayout = ImageLayout.Center;
            btnClientes.BorderColor = Color.PaleVioletRed;
            btnClientes.BorderRadius = 10;
            btnClientes.BorderSize = 0;
            btnClientes.Enabled = false;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.Black;
            btnClientes.Location = new Point(5, 247);
            btnClientes.Margin = new Padding(5, 3, 5, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(111, 116);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.TextColor = Color.Black;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInventario
            // 
            btnInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInventario.BackColor = Color.Silver;
            btnInventario.BackgroundColor = Color.Silver;
            btnInventario.BackgroundImage = (Image)resources.GetObject("btnInventario.BackgroundImage");
            btnInventario.BackgroundImageLayout = ImageLayout.Center;
            btnInventario.BorderColor = Color.PaleVioletRed;
            btnInventario.BorderRadius = 10;
            btnInventario.BorderSize = 0;
            btnInventario.Enabled = false;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.Black;
            btnInventario.Location = new Point(5, 125);
            btnInventario.Margin = new Padding(5, 3, 5, 3);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(111, 116);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.BottomCenter;
            btnInventario.TextColor = Color.Black;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventory_Click;
            btnInventario.MouseHover += btnInventory_MouseHover;
            // 
            // btnPlanilla
            // 
            btnPlanilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPlanilla.BackColor = Color.Silver;
            btnPlanilla.BackgroundColor = Color.Silver;
            btnPlanilla.BackgroundImage = (Image)resources.GetObject("btnPlanilla.BackgroundImage");
            btnPlanilla.BackgroundImageLayout = ImageLayout.Center;
            btnPlanilla.BorderColor = Color.PaleVioletRed;
            btnPlanilla.BorderRadius = 10;
            btnPlanilla.BorderSize = 0;
            btnPlanilla.Enabled = false;
            btnPlanilla.FlatAppearance.BorderSize = 0;
            btnPlanilla.FlatStyle = FlatStyle.Flat;
            btnPlanilla.ForeColor = Color.Black;
            btnPlanilla.Location = new Point(5, 3);
            btnPlanilla.Margin = new Padding(5, 3, 5, 3);
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.Size = new Size(111, 116);
            btnPlanilla.TabIndex = 2;
            btnPlanilla.Text = "Empleados";
            btnPlanilla.TextAlign = ContentAlignment.BottomCenter;
            btnPlanilla.TextColor = Color.Black;
            btnPlanilla.UseVisualStyleBackColor = false;
            btnPlanilla.Click += btnPlanilla_Click;
            btnPlanilla.MouseHover += btnPlanilla_MouseHover;
            // 
            // btnInformes
            // 
            btnInformes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInformes.BackColor = Color.Silver;
            btnInformes.BackgroundColor = Color.Silver;
            btnInformes.BackgroundImage = (Image)resources.GetObject("btnInformes.BackgroundImage");
            btnInformes.BackgroundImageLayout = ImageLayout.Center;
            btnInformes.BorderColor = Color.PaleVioletRed;
            btnInformes.BorderRadius = 10;
            btnInformes.BorderSize = 0;
            btnInformes.Enabled = false;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.ForeColor = Color.Black;
            btnInformes.Location = new Point(5, 369);
            btnInformes.Margin = new Padding(5, 3, 5, 3);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(111, 116);
            btnInformes.TabIndex = 4;
            btnInformes.Text = "Informes";
            btnInformes.TextAlign = ContentAlignment.BottomCenter;
            btnInformes.TextColor = Color.Black;
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += btnCalculos_Click;
            btnInformes.MouseHover += btnCalculos_MouseHover;
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVentas.BackColor = Color.Silver;
            btnVentas.BackgroundColor = Color.Silver;
            btnVentas.BackgroundImage = (Image)resources.GetObject("btnVentas.BackgroundImage");
            btnVentas.BackgroundImageLayout = ImageLayout.Center;
            btnVentas.BorderColor = Color.PaleVioletRed;
            btnVentas.BorderRadius = 10;
            btnVentas.BorderSize = 0;
            btnVentas.Enabled = false;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(5, 491);
            btnVentas.Margin = new Padding(5, 3, 5, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(111, 117);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.BottomCenter;
            btnVentas.TextColor = Color.Black;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelVertical_Admin
            // 
            panelVertical_Admin.BackColor = Color.White;
            panelVertical_Admin.ColumnCount = 1;
            panelVertical_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelVertical_Admin.Controls.Add(btnUsuarios, 0, 4);
            panelVertical_Admin.Controls.Add(btnConfiguraciones, 0, 3);
            panelVertical_Admin.Controls.Add(btnHerramientas, 0, 2);
            panelVertical_Admin.Controls.Add(btnBarraVertical, 0, 0);
            panelVertical_Admin.Controls.Add(btnInicio, 0, 1);
            panelVertical_Admin.Dock = DockStyle.Fill;
            panelVertical_Admin.Location = new Point(0, 0);
            panelVertical_Admin.Margin = new Padding(5, 3, 5, 3);
            panelVertical_Admin.Name = "panelVertical_Admin";
            panelVertical_Admin.RowCount = 5;
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelVertical_Admin.Size = new Size(121, 611);
            panelVertical_Admin.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUsuarios.BackColor = Color.Silver;
            btnUsuarios.BackgroundColor = Color.Silver;
            btnUsuarios.BackgroundImage = (Image)resources.GetObject("btnUsuarios.BackgroundImage");
            btnUsuarios.BackgroundImageLayout = ImageLayout.Center;
            btnUsuarios.BorderColor = Color.PaleVioletRed;
            btnUsuarios.BorderRadius = 10;
            btnUsuarios.BorderSize = 0;
            btnUsuarios.Enabled = false;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(5, 491);
            btnUsuarios.Margin = new Padding(5, 3, 5, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(111, 117);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "usuarios";
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.TextColor = Color.Black;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            btnUsuarios.MouseHover += btnUsuarios_MouseHover;
            // 
            // btnConfiguraciones
            // 
            btnConfiguraciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfiguraciones.BackColor = Color.Silver;
            btnConfiguraciones.BackgroundColor = Color.Silver;
            btnConfiguraciones.BackgroundImage = (Image)resources.GetObject("btnConfiguraciones.BackgroundImage");
            btnConfiguraciones.BackgroundImageLayout = ImageLayout.Center;
            btnConfiguraciones.BorderColor = Color.PaleVioletRed;
            btnConfiguraciones.BorderRadius = 10;
            btnConfiguraciones.BorderSize = 0;
            btnConfiguraciones.Enabled = false;
            btnConfiguraciones.FlatAppearance.BorderSize = 0;
            btnConfiguraciones.FlatStyle = FlatStyle.Flat;
            btnConfiguraciones.ForeColor = Color.Black;
            btnConfiguraciones.Location = new Point(5, 369);
            btnConfiguraciones.Margin = new Padding(5, 3, 5, 3);
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.Size = new Size(111, 116);
            btnConfiguraciones.TabIndex = 9;
            btnConfiguraciones.Text = "Empresa";
            btnConfiguraciones.TextAlign = ContentAlignment.BottomCenter;
            btnConfiguraciones.TextColor = Color.Black;
            btnConfiguraciones.UseVisualStyleBackColor = false;
            btnConfiguraciones.Click += btnConfiguraciones_Click;
            btnConfiguraciones.MouseEnter += btnConfiguraciones_MouseEnter;
            // 
            // btnHerramientas
            // 
            btnHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHerramientas.BackColor = Color.Silver;
            btnHerramientas.BackgroundColor = Color.Silver;
            btnHerramientas.BackgroundImage = (Image)resources.GetObject("btnHerramientas.BackgroundImage");
            btnHerramientas.BackgroundImageLayout = ImageLayout.Center;
            btnHerramientas.BorderColor = Color.PaleVioletRed;
            btnHerramientas.BorderRadius = 10;
            btnHerramientas.BorderSize = 0;
            btnHerramientas.Enabled = false;
            btnHerramientas.FlatAppearance.BorderSize = 0;
            btnHerramientas.FlatStyle = FlatStyle.Flat;
            btnHerramientas.ForeColor = Color.Black;
            btnHerramientas.Location = new Point(5, 247);
            btnHerramientas.Margin = new Padding(5, 3, 5, 3);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(111, 116);
            btnHerramientas.TabIndex = 6;
            btnHerramientas.Text = "Herramientas";
            btnHerramientas.TextAlign = ContentAlignment.BottomCenter;
            btnHerramientas.TextColor = Color.Black;
            btnHerramientas.UseVisualStyleBackColor = false;
            btnHerramientas.Click += btnHerramientas_Click;
            btnHerramientas.MouseHover += btnHerramientas_MouseHover;
            // 
            // btnBarraVertical
            // 
            btnBarraVertical.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBarraVertical.BackColor = Color.Silver;
            btnBarraVertical.BackgroundColor = Color.Silver;
            btnBarraVertical.BackgroundImage = (Image)resources.GetObject("btnBarraVertical.BackgroundImage");
            btnBarraVertical.BackgroundImageLayout = ImageLayout.Center;
            btnBarraVertical.BorderColor = Color.PaleVioletRed;
            btnBarraVertical.BorderRadius = 10;
            btnBarraVertical.BorderSize = 0;
            btnBarraVertical.FlatAppearance.BorderSize = 0;
            btnBarraVertical.FlatStyle = FlatStyle.Flat;
            btnBarraVertical.ForeColor = Color.Black;
            btnBarraVertical.Location = new Point(5, 3);
            btnBarraVertical.Margin = new Padding(5, 3, 5, 3);
            btnBarraVertical.Name = "btnBarraVertical";
            btnBarraVertical.Size = new Size(111, 116);
            btnBarraVertical.TabIndex = 8;
            btnBarraVertical.TextAlign = ContentAlignment.BottomCenter;
            btnBarraVertical.TextColor = Color.Black;
            btnBarraVertical.UseVisualStyleBackColor = false;
            btnBarraVertical.Click += btnBarraVertical_Button_Click;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInicio.BackColor = Color.Silver;
            btnInicio.BackgroundColor = Color.Silver;
            btnInicio.BackgroundImage = (Image)resources.GetObject("btnInicio.BackgroundImage");
            btnInicio.BackgroundImageLayout = ImageLayout.Center;
            btnInicio.BorderColor = Color.PaleVioletRed;
            btnInicio.BorderRadius = 10;
            btnInicio.BorderSize = 0;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(5, 125);
            btnInicio.Margin = new Padding(5, 3, 5, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(111, 116);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.TextColor = Color.Black;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseEnter += btnInicio_MouseEnter;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.ForeColor = Color.Black;
            panelContenedor.Location = new Point(126, 32);
            panelContenedor.Margin = new Padding(0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(966, 543);
            panelContenedor.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelVertical_Admin);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(5, 32);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 611);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rjButton1, 0, 5);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton1.BackColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundImage = (Image)resources.GetObject("rjButton1.BackgroundImage");
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(3, 102);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(194, 16);
            rjButton1.TabIndex = 6;
            rjButton1.TextAlign = ContentAlignment.BottomCenter;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            rjButton2.Location = new Point(3, 2);
            rjButton2.Margin = new Padding(3, 2, 3, 2);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(194, 69);
            rjButton2.TabIndex = 3;
            rjButton2.TextAlign = ContentAlignment.BottomCenter;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(rjButton3, 3, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rjButton3
            // 
            rjButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton3.BackColor = Color.FromArgb(21, 24, 31);
            rjButton3.BackgroundColor = Color.FromArgb(21, 24, 31);
            rjButton3.BackgroundImage = (Image)resources.GetObject("rjButton3.BackgroundImage");
            rjButton3.BackgroundImageLayout = ImageLayout.Center;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(123, 2);
            rjButton3.Margin = new Padding(3, 2, 3, 2);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(34, 96);
            rjButton3.TabIndex = 4;
            rjButton3.Text = "Calculos";
            rjButton3.TextAlign = ContentAlignment.BottomCenter;
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            rjButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton4.BackColor = Color.FromArgb(21, 24, 31);
            rjButton4.BackgroundColor = Color.FromArgb(21, 24, 31);
            rjButton4.BackgroundImage = (Image)resources.GetObject("rjButton4.BackgroundImage");
            rjButton4.BackgroundImageLayout = ImageLayout.Center;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 10;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(83, 2);
            rjButton4.Margin = new Padding(3, 2, 3, 2);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(34, 96);
            rjButton4.TabIndex = 5;
            rjButton4.Text = "Contabilidad";
            rjButton4.TextAlign = ContentAlignment.BottomCenter;
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel3.Controls.Add(lblEncabezado2, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblEncabezado2
            // 
            lblEncabezado2.AutoSize = true;
            lblEncabezado2.Dock = DockStyle.Fill;
            lblEncabezado2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado2.ImageAlign = ContentAlignment.MiddleRight;
            lblEncabezado2.Location = new Point(3, 0);
            lblEncabezado2.Name = "lblEncabezado2";
            lblEncabezado2.Size = new Size(1, 100);
            lblEncabezado2.TabIndex = 0;
            lblEncabezado2.Text = "MODO";
            lblEncabezado2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEncabezado3
            // 
            lblEncabezado3.AutoSize = true;
            lblEncabezado3.Dock = DockStyle.Fill;
            lblEncabezado3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado3.ImageAlign = ContentAlignment.MiddleRight;
            lblEncabezado3.Location = new Point(-67, 0);
            lblEncabezado3.Name = "lblEncabezado3";
            lblEncabezado3.Size = new Size(264, 100);
            lblEncabezado3.TabIndex = 0;
            lblEncabezado3.Text = "tx";
            lblEncabezado3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(cyberSwitch1, 0, 0);
            tableLayoutPanel6.Location = new Point(19, 25);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(78, 43);
            tableLayoutPanel6.TabIndex = 18;
            // 
            // cyberSwitch1
            // 
            cyberSwitch1.Alpha = 50;
            cyberSwitch1.BackColor = Color.Transparent;
            cyberSwitch1.Background = true;
            cyberSwitch1.Background_WidthPen = 2F;
            cyberSwitch1.BackgroundPen = true;
            cyberSwitch1.Checked = true;
            cyberSwitch1.ColorBackground = Color.FromArgb(21, 25, 31);
            cyberSwitch1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberSwitch1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberSwitch1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberSwitch1.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            cyberSwitch1.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            cyberSwitch1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberSwitch1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberSwitch1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberSwitch1.ColorValue = Color.FromArgb(29, 200, 238);
            cyberSwitch1.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberSwitch1.Dock = DockStyle.Fill;
            cyberSwitch1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberSwitch1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberSwitch1.Lighting = true;
            cyberSwitch1.LinearGradient_Background = true;
            cyberSwitch1.LinearGradient_Value = true;
            cyberSwitch1.LinearGradientPen = false;
            cyberSwitch1.Location = new Point(3, 3);
            cyberSwitch1.Name = "cyberSwitch1";
            cyberSwitch1.PenWidth = 10;
            cyberSwitch1.RGB = false;
            cyberSwitch1.Rounding = true;
            cyberSwitch1.RoundingInt = 90;
            cyberSwitch1.Size = new Size(72, 37);
            cyberSwitch1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberSwitch1.TabIndex = 0;
            cyberSwitch1.Tag = "Cyber";
            cyberSwitch1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberSwitch1.Timer_RGB = 300;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 94);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // reloj
            // 
            reloj.Enabled = true;
            reloj.Tick += reloj_Tick;
            // 
            // panel3
            // 
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(234, 234, 234);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(rjButton5, 0, 4);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // rjButton5
            // 
            rjButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton5.BackColor = Color.White;
            rjButton5.BackgroundColor = Color.White;
            rjButton5.BackgroundImage = (Image)resources.GetObject("rjButton5.BackgroundImage");
            rjButton5.BackgroundImageLayout = ImageLayout.Center;
            rjButton5.BorderColor = Color.PaleVioletRed;
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 0;
            rjButton5.Enabled = false;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.ForeColor = Color.Black;
            rjButton5.Location = new Point(4, 2);
            rjButton5.Margin = new Padding(4, 2, 4, 2);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(192, 96);
            rjButton5.TabIndex = 7;
            rjButton5.Text = "usuarios";
            rjButton5.TextAlign = ContentAlignment.BottomCenter;
            rjButton5.TextColor = Color.Black;
            rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            rjButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton6.BackColor = Color.White;
            rjButton6.BackgroundColor = Color.White;
            rjButton6.BackgroundImage = (Image)resources.GetObject("rjButton6.BackgroundImage");
            rjButton6.BackgroundImageLayout = ImageLayout.Center;
            rjButton6.BorderColor = Color.PaleVioletRed;
            rjButton6.BorderRadius = 10;
            rjButton6.BorderSize = 0;
            rjButton6.Enabled = false;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = FlatStyle.Flat;
            rjButton6.ForeColor = Color.Black;
            rjButton6.Location = new Point(4, 2);
            rjButton6.Margin = new Padding(4, 2, 4, 2);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(192, 78);
            rjButton6.TabIndex = 9;
            rjButton6.Text = "Empresa";
            rjButton6.TextAlign = ContentAlignment.BottomCenter;
            rjButton6.TextColor = Color.Black;
            rjButton6.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(tableLayoutPanel5);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1092, 32);
            panel5.Margin = new Padding(5, 4, 5, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 611);
            panel5.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.WhiteSmoke;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(btnVentas, 0, 4);
            tableLayoutPanel5.Controls.Add(btnInformes, 0, 3);
            tableLayoutPanel5.Controls.Add(btnClientes, 0, 2);
            tableLayoutPanel5.Controls.Add(btnPlanilla, 0, 0);
            tableLayoutPanel5.Controls.Add(btnInventario, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(121, 611);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1218, 647);
            Controls.Add(panelContenedor);
            Controls.Add(panelAbajo);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1201, 683);
            Name = "FormPrincipal";
            Padding = new Padding(5, 32, 5, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema administrativo de negocio auxiliar";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelAbajo.ResumeLayout(false);
            panelVertical_Admin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbajo;
        private RJCodeAdvance.RJControls.RJButton btnInformes;
        private RJCodeAdvance.RJControls.RJButton btnInventario;
        private RJCodeAdvance.RJControls.RJButton btnPlanilla;
        private TableLayoutPanel panelVertical_Admin;
#pragma warning restore CS0169 // El campo 'FormPrincipal.rjButton8' nunca se usa
        private RJCodeAdvance.RJControls.RJButton btnInicio;
        private RJCodeAdvance.RJControls.RJButton btnHerramientas;
        private RJCodeAdvance.RJControls.RJButton btnUsuarios;
        private RJCodeAdvance.RJControls.RJButton btnBarraVertical;
        private RJCodeAdvance.RJControls.RJButton btnConfiguraciones;
        private RJCodeAdvance.RJControls.RJButton btnVentas;
        private Label lblUsuario;
        public Panel panelContenedor;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblEncabezado2;
        private Label lblEncabezado3;
        private Label lblRol;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        public ReaLTaiizor.Controls.CyberSwitch cyberSwitch1;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer reloj;
        private RJCodeAdvance.RJControls.RJButton btnClientes;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblReloj;
    }
}