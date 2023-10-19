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
            PanelSuperior = new Panel();
            lblReloj = new Label();
            panel5 = new Panel();
            lblRol = new Label();
            lblUsuario = new Label();
            PanelNombreFormHijo = new Panel();
            iconform = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panelContenedor = new Panel();
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
            panelMenu = new Panel();
            leftBorderBtn = new Panel();
            btnConfiguraciones = new FontAwesome.Sharp.IconButton();
            btnPlanilla = new FontAwesome.Sharp.IconButton();
            btnHerramientas = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnInformes = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            imgLogoEmpresa = new ReaLTaiizor.Controls.HopePictureBox();
            PanelSuperior.SuspendLayout();
            panel5.SuspendLayout();
            PanelNombreFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconform).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panelMenu.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogoEmpresa).BeginInit();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(31, 30, 68);
            PanelSuperior.Controls.Add(lblReloj);
            PanelSuperior.Controls.Add(panel5);
            PanelSuperior.Controls.Add(PanelNombreFormHijo);
            resources.ApplyResources(PanelSuperior, "PanelSuperior");
            PanelSuperior.Name = "PanelSuperior";
            // 
            // lblReloj
            // 
            lblReloj.BackColor = Color.FromArgb(31, 30, 68);
            resources.ApplyResources(lblReloj, "lblReloj");
            lblReloj.ForeColor = SystemColors.Control;
            lblReloj.Name = "lblReloj";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 30, 68);
            panel5.Controls.Add(lblRol);
            panel5.Controls.Add(lblUsuario);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // lblRol
            // 
            resources.ApplyResources(lblRol, "lblRol");
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Name = "lblRol";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Name = "lblUsuario";
            // 
            // PanelNombreFormHijo
            // 
            PanelNombreFormHijo.Controls.Add(iconform);
            PanelNombreFormHijo.Controls.Add(label1);
            resources.ApplyResources(PanelNombreFormHijo, "PanelNombreFormHijo");
            PanelNombreFormHijo.Name = "PanelNombreFormHijo";
            // 
            // iconform
            // 
            iconform.BackColor = Color.FromArgb(31, 30, 68);
            iconform.ForeColor = SystemColors.ControlText;
            iconform.IconChar = FontAwesome.Sharp.IconChar.None;
            iconform.IconColor = SystemColors.ControlText;
            iconform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(iconform, "iconform");
            iconform.Name = "iconform";
            iconform.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Window;
            resources.ApplyResources(panelContenedor, "panelContenedor");
            panelContenedor.ForeColor = Color.Black;
            panelContenedor.Name = "panelContenedor";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(rjButton1, 0, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // rjButton1
            // 
            resources.ApplyResources(rjButton1, "rjButton1");
            rjButton1.BackColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.ForeColor = Color.White;
            rjButton1.Name = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            resources.ApplyResources(rjButton2, "rjButton2");
            rjButton2.BackColor = Color.FromArgb(63, 63, 70);
            rjButton2.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.ForeColor = Color.White;
            rjButton2.Name = "rjButton2";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(rjButton3, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // rjButton3
            // 
            resources.ApplyResources(rjButton3, "rjButton3");
            rjButton3.BackColor = Color.FromArgb(21, 24, 31);
            rjButton3.BackgroundColor = Color.FromArgb(21, 24, 31);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.ForeColor = Color.White;
            rjButton3.Name = "rjButton3";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            resources.ApplyResources(rjButton4, "rjButton4");
            rjButton4.BackColor = Color.FromArgb(21, 24, 31);
            rjButton4.BackgroundColor = Color.FromArgb(21, 24, 31);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 10;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.ForeColor = Color.White;
            rjButton4.Name = "rjButton4";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(lblEncabezado2, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblEncabezado2
            // 
            resources.ApplyResources(lblEncabezado2, "lblEncabezado2");
            lblEncabezado2.Name = "lblEncabezado2";
            // 
            // lblEncabezado3
            // 
            resources.ApplyResources(lblEncabezado3, "lblEncabezado3");
            lblEncabezado3.Name = "lblEncabezado3";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel6);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.Transparent;
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.Controls.Add(cyberSwitch1, 0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
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
            resources.ApplyResources(cyberSwitch1, "cyberSwitch1");
            cyberSwitch1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberSwitch1.Lighting = true;
            cyberSwitch1.LinearGradient_Background = true;
            cyberSwitch1.LinearGradient_Value = true;
            cyberSwitch1.LinearGradientPen = false;
            cyberSwitch1.Name = "cyberSwitch1";
            cyberSwitch1.PenWidth = 10;
            cyberSwitch1.RGB = false;
            cyberSwitch1.Rounding = true;
            cyberSwitch1.RoundingInt = 90;
            cyberSwitch1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberSwitch1.Tag = "Cyber";
            cyberSwitch1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberSwitch1.Timer_RGB = 300;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.Transparent;
            resources.ApplyResources(tableLayoutPanel7, "tableLayoutPanel7");
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(pictureBox2);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // reloj
            // 
            reloj.Enabled = true;
            reloj.Tick += reloj_Tick;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(234, 234, 234);
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(rjButton5, 0, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // rjButton5
            // 
            resources.ApplyResources(rjButton5, "rjButton5");
            rjButton5.BackColor = Color.White;
            rjButton5.BackgroundColor = Color.White;
            rjButton5.BorderColor = Color.PaleVioletRed;
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 0;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.ForeColor = Color.Black;
            rjButton5.Name = "rjButton5";
            rjButton5.TextColor = Color.Black;
            rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            resources.ApplyResources(rjButton6, "rjButton6");
            rjButton6.BackColor = Color.White;
            rjButton6.BackgroundColor = Color.White;
            rjButton6.BorderColor = Color.PaleVioletRed;
            rjButton6.BorderRadius = 10;
            rjButton6.BorderSize = 0;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.ForeColor = Color.Black;
            rjButton6.Name = "rjButton6";
            rjButton6.TextColor = Color.Black;
            rjButton6.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(leftBorderBtn);
            panelMenu.Controls.Add(btnConfiguraciones);
            panelMenu.Controls.Add(btnPlanilla);
            panelMenu.Controls.Add(btnHerramientas);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnInformes);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(PanelLogo);
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.Name = "panelMenu";
            // 
            // leftBorderBtn
            // 
            resources.ApplyResources(leftBorderBtn, "leftBorderBtn");
            leftBorderBtn.Name = "leftBorderBtn";
            // 
            // btnConfiguraciones
            // 
            resources.ApplyResources(btnConfiguraciones, "btnConfiguraciones");
            btnConfiguraciones.ForeColor = Color.White;
            btnConfiguraciones.IconChar = FontAwesome.Sharp.IconChar.BuildingWheat;
            btnConfiguraciones.IconColor = Color.White;
            btnConfiguraciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguraciones.IconSize = 30;
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.UseVisualStyleBackColor = true;
            btnConfiguraciones.Click += clicks;
            // 
            // btnPlanilla
            // 
            resources.ApplyResources(btnPlanilla, "btnPlanilla");
            btnPlanilla.ForeColor = Color.White;
            btnPlanilla.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnPlanilla.IconColor = Color.White;
            btnPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlanilla.IconSize = 30;
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.UseVisualStyleBackColor = true;
            btnPlanilla.Click += clicks;
            // 
            // btnHerramientas
            // 
            resources.ApplyResources(btnHerramientas, "btnHerramientas");
            btnHerramientas.ForeColor = Color.White;
            btnHerramientas.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnHerramientas.IconColor = Color.White;
            btnHerramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHerramientas.IconSize = 30;
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.UseVisualStyleBackColor = true;
            btnHerramientas.Click += clicks;
            // 
            // btnClientes
            // 
            resources.ApplyResources(btnClientes, "btnClientes");
            btnClientes.ForeColor = Color.White;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 30;
            btnClientes.Name = "btnClientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += clicks;
            // 
            // btnUsuarios
            // 
            resources.ApplyResources(btnUsuarios, "btnUsuarios");
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuarios.IconColor = Color.White;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += clicks;
            // 
            // btnInformes
            // 
            resources.ApplyResources(btnInformes, "btnInformes");
            btnInformes.ForeColor = Color.White;
            btnInformes.IconChar = FontAwesome.Sharp.IconChar.File;
            btnInformes.IconColor = Color.White;
            btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformes.IconSize = 30;
            btnInformes.Name = "btnInformes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += clicks;
            // 
            // btnInventario
            // 
            resources.ApplyResources(btnInventario, "btnInventario");
            btnInventario.ForeColor = Color.White;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnInventario.IconColor = Color.White;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.IconSize = 30;
            btnInventario.Name = "btnInventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += clicks;
            // 
            // btnVentas
            // 
            resources.ApplyResources(btnVentas, "btnVentas");
            btnVentas.ForeColor = Color.White;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnVentas.IconColor = Color.White;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 30;
            btnVentas.Name = "btnVentas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += clicks;
            // 
            // btnInicio
            // 
            resources.ApplyResources(btnInicio, "btnInicio");
            btnInicio.ForeColor = Color.White;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.Name = "btnInicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += clicks;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(imgLogoEmpresa);
            resources.ApplyResources(PanelLogo, "PanelLogo");
            PanelLogo.Name = "PanelLogo";
            // 
            // imgLogoEmpresa
            // 
            imgLogoEmpresa.BackColor = Color.FromArgb(192, 196, 204);
            resources.ApplyResources(imgLogoEmpresa, "imgLogoEmpresa");
            imgLogoEmpresa.Name = "imgLogoEmpresa";
            imgLogoEmpresa.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            imgLogoEmpresa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            imgLogoEmpresa.TabStop = false;
            imgLogoEmpresa.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelContenedor);
            Controls.Add(PanelSuperior);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            PanelSuperior.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PanelNombreFormHijo.ResumeLayout(false);
            PanelNombreFormHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconform).EndInit();
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
            panelMenu.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogoEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSuperior;
        private Label lblUsuario;
        public Panel panelContenedor;
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
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private Panel panelMenu;
        private Label lblReloj;
        private Panel panel5;
        private Panel PanelNombreFormHijo;
        private Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnConfiguraciones;
        private FontAwesome.Sharp.IconButton btnPlanilla;
        private FontAwesome.Sharp.IconButton btnHerramientas;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnInformes;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Panel leftBorderBtn;
        private ReaLTaiizor.Controls.HopePictureBox imgLogoEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconform;
        private Label label1;
    }
}