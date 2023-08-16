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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelAbajo = new Panel();
            panelModo = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            cambioModo = new ReaLTaiizor.Controls.CyberSwitch();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            moonPicture = new PictureBox();
            SolPicture = new PictureBox();
            tablePanel_Admin = new TableLayoutPanel();
            btnContabilidad = new RJCodeAdvance.RJControls.RJButton();
            btnInventario = new RJCodeAdvance.RJControls.RJButton();
            btnPlanilla = new RJCodeAdvance.RJControls.RJButton();
            btnInformes = new RJCodeAdvance.RJControls.RJButton();
            btnVentas = new RJCodeAdvance.RJControls.RJButton();
            tablePanelNombre_Vendedor = new TableLayoutPanel();
            lblRol = new Label();
            lblUsuario = new Label();
            panelVertical_Admin = new TableLayoutPanel();
            btnInicio = new RJCodeAdvance.RJControls.RJButton();
            btnUsuarios = new RJCodeAdvance.RJControls.RJButton();
            btnBarraVertical = new RJCodeAdvance.RJControls.RJButton();
            btnHerramientas = new RJCodeAdvance.RJControls.RJButton();
            btnConfiguraciones = new RJCodeAdvance.RJControls.RJButton();
            tablepanelPanelContenedor = new TableLayoutPanel();
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
            panelAbajo.SuspendLayout();
            panelModo.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moonPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SolPicture).BeginInit();
            tablePanel_Admin.SuspendLayout();
            tablePanelNombre_Vendedor.SuspendLayout();
            panelVertical_Admin.SuspendLayout();
            tablepanelPanelContenedor.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbajo
            // 
            panelAbajo.BackColor = Color.FromArgb(53, 53, 60);
            panelAbajo.Controls.Add(panelModo);
            panelAbajo.Controls.Add(tablePanel_Admin);
            panelAbajo.Controls.Add(tablePanelNombre_Vendedor);
            panelAbajo.Dock = DockStyle.Bottom;
            panelAbajo.Location = new Point(3, 589);
            panelAbajo.Margin = new Padding(3, 2, 3, 2);
            panelAbajo.Name = "panelAbajo";
            panelAbajo.Size = new Size(1063, 94);
            panelAbajo.TabIndex = 1;
            // 
            // panelModo
            // 
            panelModo.Controls.Add(tableLayoutPanel5);
            panelModo.Controls.Add(tableLayoutPanel4);
            panelModo.Dock = DockStyle.Right;
            panelModo.Location = new Point(898, 0);
            panelModo.Name = "panelModo";
            panelModo.Size = new Size(165, 94);
            panelModo.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(cambioModo, 0, 0);
            tableLayoutPanel5.Location = new Point(19, 25);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(78, 43);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // cambioModo
            // 
            cambioModo.Alpha = 50;
            cambioModo.BackColor = Color.Transparent;
            cambioModo.Background = true;
            cambioModo.Background_WidthPen = 2F;
            cambioModo.BackgroundPen = true;
            cambioModo.Checked = true;
            cambioModo.ColorBackground = Color.FromArgb(21, 25, 31);
            cambioModo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cambioModo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cambioModo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cambioModo.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            cambioModo.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            cambioModo.ColorLighting = Color.FromArgb(29, 200, 238);
            cambioModo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cambioModo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cambioModo.ColorValue = Color.FromArgb(29, 200, 238);
            cambioModo.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cambioModo.Dock = DockStyle.Fill;
            cambioModo.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cambioModo.ForeColor = Color.FromArgb(245, 245, 245);
            cambioModo.Lighting = true;
            cambioModo.LinearGradient_Background = true;
            cambioModo.LinearGradient_Value = true;
            cambioModo.LinearGradientPen = false;
            cambioModo.Location = new Point(3, 3);
            cambioModo.Name = "cambioModo";
            cambioModo.PenWidth = 10;
            cambioModo.RGB = false;
            cambioModo.Rounding = true;
            cambioModo.RoundingInt = 90;
            cambioModo.Size = new Size(72, 37);
            cambioModo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cambioModo.TabIndex = 0;
            cambioModo.Tag = "Cyber";
            cambioModo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cambioModo.Timer_RGB = 300;
            cambioModo.CheckedChanged += cyberSwitch2_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Location = new Point(103, 25);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(45, 43);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(moonPicture);
            panel3.Controls.Add(SolPicture);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(39, 37);
            panel3.TabIndex = 1;
            // 
            // moonPicture
            // 
            moonPicture.Dock = DockStyle.Fill;
            moonPicture.Image = (Image)resources.GetObject("moonPicture.Image");
            moonPicture.Location = new Point(0, 0);
            moonPicture.Name = "moonPicture";
            moonPicture.Size = new Size(39, 37);
            moonPicture.SizeMode = PictureBoxSizeMode.Zoom;
            moonPicture.TabIndex = 7;
            moonPicture.TabStop = false;
            // 
            // SolPicture
            // 
            SolPicture.Dock = DockStyle.Fill;
            SolPicture.Image = (Image)resources.GetObject("SolPicture.Image");
            SolPicture.Location = new Point(0, 0);
            SolPicture.Name = "SolPicture";
            SolPicture.Size = new Size(39, 37);
            SolPicture.SizeMode = PictureBoxSizeMode.Zoom;
            SolPicture.TabIndex = 8;
            SolPicture.TabStop = false;
            SolPicture.Visible = false;
            // 
            // tablePanel_Admin
            // 
            tablePanel_Admin.Anchor = AnchorStyles.Bottom;
            tablePanel_Admin.ColumnCount = 5;
            tablePanel_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablePanel_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablePanel_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablePanel_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablePanel_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablePanel_Admin.Controls.Add(btnContabilidad, 0, 0);
            tablePanel_Admin.Controls.Add(btnInventario, 0, 0);
            tablePanel_Admin.Controls.Add(btnPlanilla, 0, 0);
            tablePanel_Admin.Controls.Add(btnInformes, 3, 0);
            tablePanel_Admin.Controls.Add(btnVentas, 4, 0);
            tablePanel_Admin.Location = new Point(310, 13);
            tablePanel_Admin.Margin = new Padding(3, 2, 3, 2);
            tablePanel_Admin.Name = "tablePanel_Admin";
            tablePanel_Admin.RowCount = 1;
            tablePanel_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePanel_Admin.Size = new Size(481, 75);
            tablePanel_Admin.TabIndex = 0;
            // 
            // btnContabilidad
            // 
            btnContabilidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnContabilidad.BackColor = Color.FromArgb(21, 24, 31);
            btnContabilidad.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnContabilidad.BackgroundImage = (Image)resources.GetObject("btnContabilidad.BackgroundImage");
            btnContabilidad.BackgroundImageLayout = ImageLayout.Center;
            btnContabilidad.BorderColor = Color.PaleVioletRed;
            btnContabilidad.BorderRadius = 10;
            btnContabilidad.BorderSize = 0;
            btnContabilidad.FlatAppearance.BorderSize = 0;
            btnContabilidad.FlatStyle = FlatStyle.Flat;
            btnContabilidad.ForeColor = Color.White;
            btnContabilidad.Location = new Point(195, 2);
            btnContabilidad.Margin = new Padding(3, 2, 3, 2);
            btnContabilidad.Name = "btnContabilidad";
            btnContabilidad.Size = new Size(90, 71);
            btnContabilidad.TabIndex = 5;
            btnContabilidad.Text = "Contaduria";
            btnContabilidad.TextAlign = ContentAlignment.BottomCenter;
            btnContabilidad.TextColor = Color.White;
            btnContabilidad.UseVisualStyleBackColor = false;
            btnContabilidad.Click += btnContabilidad_Click;
            btnContabilidad.MouseHover += btnContabilidad_MouseHover;
            // 
            // btnInventario
            // 
            btnInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInventario.BackColor = Color.FromArgb(21, 24, 31);
            btnInventario.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnInventario.BackgroundImage = (Image)resources.GetObject("btnInventario.BackgroundImage");
            btnInventario.BackgroundImageLayout = ImageLayout.Center;
            btnInventario.BorderColor = Color.PaleVioletRed;
            btnInventario.BorderRadius = 10;
            btnInventario.BorderSize = 0;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(99, 2);
            btnInventario.Margin = new Padding(3, 2, 3, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(90, 71);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.BottomCenter;
            btnInventario.TextColor = Color.White;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventory_Click;
            btnInventario.MouseHover += btnInventory_MouseHover;
            // 
            // btnPlanilla
            // 
            btnPlanilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPlanilla.BackColor = Color.FromArgb(21, 24, 31);
            btnPlanilla.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnPlanilla.BackgroundImage = (Image)resources.GetObject("btnPlanilla.BackgroundImage");
            btnPlanilla.BackgroundImageLayout = ImageLayout.Center;
            btnPlanilla.BorderColor = Color.PaleVioletRed;
            btnPlanilla.BorderRadius = 10;
            btnPlanilla.BorderSize = 0;
            btnPlanilla.FlatAppearance.BorderSize = 0;
            btnPlanilla.FlatStyle = FlatStyle.Flat;
            btnPlanilla.ForeColor = Color.White;
            btnPlanilla.Location = new Point(3, 2);
            btnPlanilla.Margin = new Padding(3, 2, 3, 2);
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.Size = new Size(90, 71);
            btnPlanilla.TabIndex = 2;
            btnPlanilla.Text = "Planilla";
            btnPlanilla.TextAlign = ContentAlignment.BottomCenter;
            btnPlanilla.TextColor = Color.White;
            btnPlanilla.UseVisualStyleBackColor = false;
            btnPlanilla.Click += btnPlanilla_Click;
            btnPlanilla.MouseHover += btnPlanilla_MouseHover;
            // 
            // btnInformes
            // 
            btnInformes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInformes.BackColor = Color.FromArgb(21, 24, 31);
            btnInformes.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnInformes.BackgroundImage = (Image)resources.GetObject("btnInformes.BackgroundImage");
            btnInformes.BackgroundImageLayout = ImageLayout.Center;
            btnInformes.BorderColor = Color.PaleVioletRed;
            btnInformes.BorderRadius = 10;
            btnInformes.BorderSize = 0;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.ForeColor = Color.White;
            btnInformes.Location = new Point(291, 2);
            btnInformes.Margin = new Padding(3, 2, 3, 2);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(90, 71);
            btnInformes.TabIndex = 4;
            btnInformes.Text = "Informes";
            btnInformes.TextAlign = ContentAlignment.BottomCenter;
            btnInformes.TextColor = Color.White;
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += btnCalculos_Click;
            btnInformes.MouseHover += btnCalculos_MouseHover;
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVentas.BackColor = Color.FromArgb(21, 24, 31);
            btnVentas.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnVentas.BackgroundImage = (Image)resources.GetObject("btnVentas.BackgroundImage");
            btnVentas.BackgroundImageLayout = ImageLayout.Center;
            btnVentas.BorderColor = Color.PaleVioletRed;
            btnVentas.BorderRadius = 10;
            btnVentas.BorderSize = 0;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(387, 2);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(91, 71);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.BottomCenter;
            btnVentas.TextColor = Color.White;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // tablePanelNombre_Vendedor
            // 
            tablePanelNombre_Vendedor.ColumnCount = 1;
            tablePanelNombre_Vendedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelNombre_Vendedor.Controls.Add(lblRol, 0, 1);
            tablePanelNombre_Vendedor.Controls.Add(lblUsuario, 0, 0);
            tablePanelNombre_Vendedor.Dock = DockStyle.Left;
            tablePanelNombre_Vendedor.Location = new Point(0, 0);
            tablePanelNombre_Vendedor.Name = "tablePanelNombre_Vendedor";
            tablePanelNombre_Vendedor.RowCount = 2;
            tablePanelNombre_Vendedor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelNombre_Vendedor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelNombre_Vendedor.Size = new Size(291, 94);
            tablePanelNombre_Vendedor.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.Dock = DockStyle.Fill;
            lblRol.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(3, 47);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(285, 47);
            lblRol.TabIndex = 53;
            lblRol.Text = "ROL DE USUARIO:";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(3, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(285, 47);
            lblUsuario.TabIndex = 52;
            lblUsuario.Text = "USUARIO ACTUAL:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelVertical_Admin
            // 
            panelVertical_Admin.ColumnCount = 1;
            panelVertical_Admin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelVertical_Admin.Controls.Add(btnInicio, 0, 2);
            panelVertical_Admin.Controls.Add(btnUsuarios, 0, 5);
            panelVertical_Admin.Controls.Add(btnBarraVertical, 0, 1);
            panelVertical_Admin.Controls.Add(btnHerramientas, 0, 3);
            panelVertical_Admin.Controls.Add(btnConfiguraciones, 0, 4);
            panelVertical_Admin.Dock = DockStyle.Left;
            panelVertical_Admin.Location = new Point(0, 0);
            panelVertical_Admin.Margin = new Padding(3, 2, 3, 2);
            panelVertical_Admin.Name = "panelVertical_Admin";
            panelVertical_Admin.RowCount = 7;
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            panelVertical_Admin.Size = new Size(61, 565);
            panelVertical_Admin.TabIndex = 2;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInicio.BackColor = Color.FromArgb(63, 63, 70);
            btnInicio.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnInicio.BackgroundImage = (Image)resources.GetObject("btnInicio.BackgroundImage");
            btnInicio.BackgroundImageLayout = ImageLayout.Center;
            btnInicio.BorderColor = Color.PaleVioletRed;
            btnInicio.BorderRadius = 10;
            btnInicio.BorderSize = 0;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(3, 162);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(55, 76);
            btnInicio.TabIndex = 5;
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.TextColor = Color.White;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseEnter += btnInicio_MouseEnter;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUsuarios.BackColor = Color.FromArgb(63, 63, 70);
            btnUsuarios.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnUsuarios.BackgroundImage = (Image)resources.GetObject("btnUsuarios.BackgroundImage");
            btnUsuarios.BackgroundImageLayout = ImageLayout.Center;
            btnUsuarios.BorderColor = Color.PaleVioletRed;
            btnUsuarios.BorderRadius = 10;
            btnUsuarios.BorderSize = 0;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(3, 402);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(55, 76);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.TextColor = Color.White;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            btnUsuarios.MouseHover += btnUsuarios_MouseHover;
            // 
            // btnBarraVertical
            // 
            btnBarraVertical.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBarraVertical.BackColor = Color.FromArgb(63, 63, 70);
            btnBarraVertical.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnBarraVertical.BackgroundImage = (Image)resources.GetObject("btnBarraVertical.BackgroundImage");
            btnBarraVertical.BackgroundImageLayout = ImageLayout.Center;
            btnBarraVertical.BorderColor = Color.PaleVioletRed;
            btnBarraVertical.BorderRadius = 10;
            btnBarraVertical.BorderSize = 0;
            btnBarraVertical.FlatAppearance.BorderSize = 0;
            btnBarraVertical.FlatStyle = FlatStyle.Flat;
            btnBarraVertical.ForeColor = Color.White;
            btnBarraVertical.Location = new Point(3, 82);
            btnBarraVertical.Margin = new Padding(3, 2, 3, 2);
            btnBarraVertical.Name = "btnBarraVertical";
            btnBarraVertical.Size = new Size(55, 76);
            btnBarraVertical.TabIndex = 8;
            btnBarraVertical.TextAlign = ContentAlignment.BottomCenter;
            btnBarraVertical.TextColor = Color.White;
            btnBarraVertical.UseVisualStyleBackColor = false;
            btnBarraVertical.Click += btnBarraVertical_Button_Click;
            // 
            // btnHerramientas
            // 
            btnHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHerramientas.BackColor = Color.FromArgb(63, 63, 70);
            btnHerramientas.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnHerramientas.BackgroundImage = (Image)resources.GetObject("btnHerramientas.BackgroundImage");
            btnHerramientas.BackgroundImageLayout = ImageLayout.Center;
            btnHerramientas.BorderColor = Color.PaleVioletRed;
            btnHerramientas.BorderRadius = 10;
            btnHerramientas.BorderSize = 0;
            btnHerramientas.FlatAppearance.BorderSize = 0;
            btnHerramientas.FlatStyle = FlatStyle.Flat;
            btnHerramientas.ForeColor = Color.White;
            btnHerramientas.Location = new Point(3, 242);
            btnHerramientas.Margin = new Padding(3, 2, 3, 2);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(55, 76);
            btnHerramientas.TabIndex = 6;
            btnHerramientas.TextAlign = ContentAlignment.BottomCenter;
            btnHerramientas.TextColor = Color.White;
            btnHerramientas.UseVisualStyleBackColor = false;
            btnHerramientas.Click += btnHerramientas_Click;
            btnHerramientas.MouseHover += btnHerramientas_MouseHover;
            // 
            // btnConfiguraciones
            // 
            btnConfiguraciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfiguraciones.BackColor = Color.FromArgb(63, 63, 70);
            btnConfiguraciones.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnConfiguraciones.BackgroundImage = (Image)resources.GetObject("btnConfiguraciones.BackgroundImage");
            btnConfiguraciones.BackgroundImageLayout = ImageLayout.Center;
            btnConfiguraciones.BorderColor = Color.PaleVioletRed;
            btnConfiguraciones.BorderRadius = 10;
            btnConfiguraciones.BorderSize = 0;
            btnConfiguraciones.FlatAppearance.BorderSize = 0;
            btnConfiguraciones.FlatStyle = FlatStyle.Flat;
            btnConfiguraciones.ForeColor = Color.White;
            btnConfiguraciones.Location = new Point(3, 322);
            btnConfiguraciones.Margin = new Padding(3, 2, 3, 2);
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.Size = new Size(55, 76);
            btnConfiguraciones.TabIndex = 9;
            btnConfiguraciones.TextAlign = ContentAlignment.BottomCenter;
            btnConfiguraciones.TextColor = Color.White;
            btnConfiguraciones.UseVisualStyleBackColor = false;
            btnConfiguraciones.Click += btnConfiguraciones_Click;
            btnConfiguraciones.MouseEnter += btnConfiguraciones_MouseEnter;
            // 
            // tablepanelPanelContenedor
            // 
            tablepanelPanelContenedor.ColumnCount = 3;
            tablepanelPanelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.02459013F));
            tablepanelPanelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.0532761F));
            tablepanelPanelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9221311F));
            tablepanelPanelContenedor.Controls.Add(panelContenedor, 1, 1);
            tablepanelPanelContenedor.Dock = DockStyle.Fill;
            tablepanelPanelContenedor.Location = new Point(69, 24);
            tablepanelPanelContenedor.Margin = new Padding(3, 2, 3, 2);
            tablepanelPanelContenedor.Name = "tablepanelPanelContenedor";
            tablepanelPanelContenedor.RowCount = 3;
            tablepanelPanelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tablepanelPanelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tablepanelPanelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tablepanelPanelContenedor.Size = new Size(997, 565);
            tablepanelPanelContenedor.TabIndex = 3;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(13, 7);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.MinimumSize = new Size(564, 272);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(971, 549);
            panelContenedor.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelVertical_Admin);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 565);
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
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(1069, 686);
            Controls.Add(tablepanelPanelContenedor);
            Controls.Add(panel2);
            Controls.Add(panelAbajo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1053, 647);
            Name = "FormPrincipal";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelAbajo.ResumeLayout(false);
            panelModo.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moonPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)SolPicture).EndInit();
            tablePanel_Admin.ResumeLayout(false);
            tablePanelNombre_Vendedor.ResumeLayout(false);
            panelVertical_Admin.ResumeLayout(false);
            tablepanelPanelContenedor.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbajo;
        private TableLayoutPanel tablePanel_Admin;
        private RJCodeAdvance.RJControls.RJButton btnContabilidad;
        private RJCodeAdvance.RJControls.RJButton btnInformes;
        private RJCodeAdvance.RJControls.RJButton btnInventario;
        private RJCodeAdvance.RJControls.RJButton btnPlanilla;
        private TableLayoutPanel panelVertical_Admin;
        private RJCodeAdvance.RJControls.RJButton rjButton8;
        private RJCodeAdvance.RJControls.RJButton btnInicio;
        private RJCodeAdvance.RJControls.RJButton btnHerramientas;
        private RJCodeAdvance.RJControls.RJButton btnUsuarios;
        private TableLayoutPanel tablepanelPanelContenedor;
        private RJCodeAdvance.RJControls.RJButton btnBarraVertical;
        private RJCodeAdvance.RJControls.RJButton btnConfiguraciones;
        private RJCodeAdvance.RJControls.RJButton btnVentas;
        private TableLayoutPanel tablePanelNombre_Vendedor;
        private Label lblUsuario;
        public Panel panelContenedor;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private PictureBox moonPicture;
        private PictureBox SolPicture;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblEncabezado2;
        private Label lblEncabezado3;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panelModo;
        public ReaLTaiizor.Controls.CyberSwitch cambioModo;
        private Label lblRol;
    }
}