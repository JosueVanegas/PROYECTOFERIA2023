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
            panel7 = new Panel();
            lblReloj = new Label();
            panel6 = new Panel();
            lblRol = new Label();
            lblUsuario = new Label();
            btnClientes = new RJCodeAdvance.RJControls.RJButton();
            btnInventario = new RJCodeAdvance.RJControls.RJButton();
            btnPlanilla = new RJCodeAdvance.RJControls.RJButton();
            btnInformes = new RJCodeAdvance.RJControls.RJButton();
            btnVentas = new RJCodeAdvance.RJControls.RJButton();
            btnUsuarios = new RJCodeAdvance.RJControls.RJButton();
            btnConfiguraciones = new RJCodeAdvance.RJControls.RJButton();
            btnHerramientas = new RJCodeAdvance.RJControls.RJButton();
            btnInicio = new RJCodeAdvance.RJControls.RJButton();
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
            panel2 = new Panel();
            panelAbajo.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbajo
            // 
            panelAbajo.BackColor = Color.Silver;
            panelAbajo.Controls.Add(panel7);
            panelAbajo.Controls.Add(panel6);
            resources.ApplyResources(panelAbajo, "panelAbajo");
            panelAbajo.Name = "panelAbajo";
            // 
            // panel7
            // 
            panel7.Controls.Add(lblReloj);
            resources.ApplyResources(panel7, "panel7");
            panel7.Name = "panel7";
            // 
            // lblReloj
            // 
            resources.ApplyResources(lblReloj, "lblReloj");
            lblReloj.Name = "lblReloj";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblRol);
            panel6.Controls.Add(lblUsuario);
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // lblRol
            // 
            resources.ApplyResources(lblRol, "lblRol");
            lblRol.ForeColor = Color.Black;
            lblRol.Name = "lblRol";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Name = "lblUsuario";
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Silver;
            btnClientes.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnClientes, "btnClientes");
            btnClientes.BorderColor = Color.PaleVioletRed;
            btnClientes.BorderRadius = 11;
            btnClientes.BorderSize = 0;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.ForeColor = Color.Black;
            btnClientes.Name = "btnClientes";
            btnClientes.TextColor = Color.Black;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += clicks;
            btnClientes.MouseEnter += MouseEnters;
            btnClientes.MouseLeave += MouseLeaves;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Silver;
            btnInventario.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnInventario, "btnInventario");
            btnInventario.BorderColor = Color.PaleVioletRed;
            btnInventario.BorderRadius = 11;
            btnInventario.BorderSize = 0;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.ForeColor = Color.Black;
            btnInventario.Name = "btnInventario";
            btnInventario.TextColor = Color.Black;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += clicks;
            btnInventario.MouseEnter += MouseEnters;
            btnInventario.MouseLeave += MouseLeaves;
            // 
            // btnPlanilla
            // 
            btnPlanilla.BackColor = Color.Silver;
            btnPlanilla.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnPlanilla, "btnPlanilla");
            btnPlanilla.BorderColor = Color.PaleVioletRed;
            btnPlanilla.BorderRadius = 11;
            btnPlanilla.BorderSize = 0;
            btnPlanilla.FlatAppearance.BorderSize = 0;
            btnPlanilla.ForeColor = Color.Black;
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.TextColor = Color.Black;
            btnPlanilla.UseVisualStyleBackColor = false;
            btnPlanilla.Click += clicks;
            btnPlanilla.MouseEnter += MouseEnters;
            btnPlanilla.MouseLeave += MouseLeaves;
            // 
            // btnInformes
            // 
            btnInformes.BackColor = Color.Silver;
            btnInformes.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnInformes, "btnInformes");
            btnInformes.BorderColor = Color.PaleVioletRed;
            btnInformes.BorderRadius = 11;
            btnInformes.BorderSize = 0;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.ForeColor = Color.Black;
            btnInformes.Name = "btnInformes";
            btnInformes.TextColor = Color.Black;
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += clicks;
            btnInformes.MouseEnter += MouseEnters;
            btnInformes.MouseLeave += MouseLeaves;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Silver;
            btnVentas.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnVentas, "btnVentas");
            btnVentas.BorderColor = Color.PaleVioletRed;
            btnVentas.BorderRadius = 11;
            btnVentas.BorderSize = 0;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.ForeColor = Color.Black;
            btnVentas.Name = "btnVentas";
            btnVentas.TextColor = Color.Black;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += clicks;
            btnVentas.MouseEnter += MouseEnters;
            btnVentas.MouseLeave += MouseLeaves;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Silver;
            btnUsuarios.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnUsuarios, "btnUsuarios");
            btnUsuarios.BorderColor = Color.PaleVioletRed;
            btnUsuarios.BorderRadius = 11;
            btnUsuarios.BorderSize = 0;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.TextColor = Color.Black;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += clicks;
            btnUsuarios.MouseEnter += MouseEnters;
            btnUsuarios.MouseLeave += MouseLeaves;
            // 
            // btnConfiguraciones
            // 
            btnConfiguraciones.BackColor = Color.Silver;
            btnConfiguraciones.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnConfiguraciones, "btnConfiguraciones");
            btnConfiguraciones.BorderColor = Color.PaleVioletRed;
            btnConfiguraciones.BorderRadius = 11;
            btnConfiguraciones.BorderSize = 0;
            btnConfiguraciones.FlatAppearance.BorderSize = 0;
            btnConfiguraciones.ForeColor = Color.Black;
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.TextColor = Color.Black;
            btnConfiguraciones.UseVisualStyleBackColor = false;
            btnConfiguraciones.Click += clicks;
            btnConfiguraciones.MouseEnter += MouseEnters;
            btnConfiguraciones.MouseLeave += MouseLeaves;
            // 
            // btnHerramientas
            // 
            btnHerramientas.BackColor = Color.Silver;
            btnHerramientas.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnHerramientas, "btnHerramientas");
            btnHerramientas.BorderColor = Color.PaleVioletRed;
            btnHerramientas.BorderRadius = 11;
            btnHerramientas.BorderSize = 0;
            btnHerramientas.FlatAppearance.BorderSize = 0;
            btnHerramientas.ForeColor = Color.Black;
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.TextColor = Color.Black;
            btnHerramientas.UseVisualStyleBackColor = false;
            btnHerramientas.Click += clicks;
            btnHerramientas.MouseEnter += MouseEnters;
            btnHerramientas.MouseLeave += MouseLeaves;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Silver;
            btnInicio.BackgroundColor = Color.Silver;
            resources.ApplyResources(btnInicio, "btnInicio");
            btnInicio.BorderColor = Color.PaleVioletRed;
            btnInicio.BorderRadius = 11;
            btnInicio.BorderSize = 0;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.ForeColor = Color.Black;
            btnInicio.Name = "btnInicio";
            btnInicio.TextColor = Color.Black;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += clicks;
            btnInicio.MouseEnter += MouseEnters;
            btnInicio.MouseLeave += MouseLeaves;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
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
            // panel2
            // 
            panel2.Controls.Add(btnConfiguraciones);
            panel2.Controls.Add(btnPlanilla);
            panel2.Controls.Add(btnHerramientas);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnInformes);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInicio);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panelAbajo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelAbajo.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbajo;
        private RJCodeAdvance.RJControls.RJButton btnInformes;
        private RJCodeAdvance.RJControls.RJButton btnInventario;
        private RJCodeAdvance.RJControls.RJButton btnPlanilla;
#pragma warning restore CS0169 // El campo 'FormPrincipal.rjButton8' nunca se usa
        private RJCodeAdvance.RJControls.RJButton btnInicio;
        private RJCodeAdvance.RJControls.RJButton btnHerramientas;
        private RJCodeAdvance.RJControls.RJButton btnUsuarios;
        private RJCodeAdvance.RJControls.RJButton btnConfiguraciones;
        private RJCodeAdvance.RJControls.RJButton btnVentas;
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
        private RJCodeAdvance.RJControls.RJButton btnClientes;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Label lblReloj;
    }
}