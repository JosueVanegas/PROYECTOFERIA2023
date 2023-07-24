using RJCodeAdvance;
using ReaLTaiizor;
namespace CapaVista
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnContabilidad = new RJCodeAdvance.RJControls.RJButton();
            btnCalculos = new RJCodeAdvance.RJControls.RJButton();
            btnInventory = new RJCodeAdvance.RJControls.RJButton();
            btnPlanilla = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnInicio = new RJCodeAdvance.RJControls.RJButton();
            btnUsuarios = new RJCodeAdvance.RJControls.RJButton();
            btnBarraVertical = new RJCodeAdvance.RJControls.RJButton();
            btnHerramientas = new RJCodeAdvance.RJControls.RJButton();
            btnConfiguraciones = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelContenedor = new Panel();
            btnVentas = new RJCodeAdvance.RJControls.RJButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 53, 60);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 514);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 94);
            panel1.TabIndex = 1;
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
            tableLayoutPanel1.Controls.Add(btnContabilidad, 0, 0);
            tableLayoutPanel1.Controls.Add(btnInventory, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPlanilla, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCalculos, 3, 0);
            tableLayoutPanel1.Controls.Add(btnVentas, 4, 0);
            tableLayoutPanel1.Location = new Point(318, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(481, 75);
            tableLayoutPanel1.TabIndex = 0;
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
            btnContabilidad.Text = "Contabilidad";
            btnContabilidad.TextAlign = ContentAlignment.BottomCenter;
            btnContabilidad.TextColor = Color.White;
            btnContabilidad.UseVisualStyleBackColor = false;
            btnContabilidad.MouseHover += btnContabilidad_MouseHover;
            // 
            // btnCalculos
            // 
            btnCalculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalculos.BackColor = Color.FromArgb(21, 24, 31);
            btnCalculos.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnCalculos.BackgroundImage = (Image)resources.GetObject("btnCalculos.BackgroundImage");
            btnCalculos.BackgroundImageLayout = ImageLayout.Center;
            btnCalculos.BorderColor = Color.PaleVioletRed;
            btnCalculos.BorderRadius = 10;
            btnCalculos.BorderSize = 0;
            btnCalculos.FlatAppearance.BorderSize = 0;
            btnCalculos.FlatStyle = FlatStyle.Flat;
            btnCalculos.ForeColor = Color.White;
            btnCalculos.Location = new Point(291, 2);
            btnCalculos.Margin = new Padding(3, 2, 3, 2);
            btnCalculos.Name = "btnCalculos";
            btnCalculos.Size = new Size(90, 71);
            btnCalculos.TabIndex = 4;
            btnCalculos.Text = "Calculos";
            btnCalculos.TextAlign = ContentAlignment.BottomCenter;
            btnCalculos.TextColor = Color.White;
            btnCalculos.UseVisualStyleBackColor = false;
            btnCalculos.MouseHover += btnCalculos_MouseHover;
            // 
            // btnInventory
            // 
            btnInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInventory.BackColor = Color.FromArgb(21, 24, 31);
            btnInventory.BackgroundColor = Color.FromArgb(21, 24, 31);
            btnInventory.BackgroundImage = (Image)resources.GetObject("btnInventory.BackgroundImage");
            btnInventory.BackgroundImageLayout = ImageLayout.Center;
            btnInventory.BorderColor = Color.PaleVioletRed;
            btnInventory.BorderRadius = 10;
            btnInventory.BorderSize = 0;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(99, 2);
            btnInventory.Margin = new Padding(3, 2, 3, 2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(90, 71);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventario";
            btnInventory.TextAlign = ContentAlignment.BottomCenter;
            btnInventory.TextColor = Color.White;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            btnInventory.MouseHover += btnInventory_MouseHover;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnInicio, 0, 2);
            tableLayoutPanel2.Controls.Add(btnUsuarios, 0, 5);
            tableLayoutPanel2.Controls.Add(btnBarraVertical, 0, 1);
            tableLayoutPanel2.Controls.Add(btnHerramientas, 0, 3);
            tableLayoutPanel2.Controls.Add(btnConfiguraciones, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Size = new Size(61, 514);
            tableLayoutPanel2.TabIndex = 2;
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
            btnInicio.Location = new Point(3, 148);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(55, 69);
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
            btnUsuarios.Location = new Point(3, 367);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(55, 69);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.TextColor = Color.White;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += rjButton9_Click;
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
            btnBarraVertical.Location = new Point(3, 75);
            btnBarraVertical.Margin = new Padding(3, 2, 3, 2);
            btnBarraVertical.Name = "btnBarraVertical";
            btnBarraVertical.Size = new Size(55, 69);
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
            btnHerramientas.Location = new Point(3, 221);
            btnHerramientas.Margin = new Padding(3, 2, 3, 2);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(55, 69);
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
            btnConfiguraciones.Location = new Point(3, 294);
            btnConfiguraciones.Margin = new Padding(3, 2, 3, 2);
            btnConfiguraciones.Name = "btnConfiguraciones";
            btnConfiguraciones.Size = new Size(55, 69);
            btnConfiguraciones.TabIndex = 9;
            btnConfiguraciones.TextAlign = ContentAlignment.BottomCenter;
            btnConfiguraciones.TextColor = Color.White;
            btnConfiguraciones.UseVisualStyleBackColor = false;
            btnConfiguraciones.MouseEnter += btnConfiguraciones_MouseEnter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.02459013F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.0532761F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9221311F));
            tableLayoutPanel3.Controls.Add(panelContenedor, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(61, 0);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel3.Size = new Size(976, 514);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(13, 7);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.MinimumSize = new Size(564, 272);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(951, 499);
            panelContenedor.TabIndex = 0;
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
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(1037, 608);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1053, 647);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnContabilidad;
        private RJCodeAdvance.RJControls.RJButton btnCalculos;
        private RJCodeAdvance.RJControls.RJButton btnInventory;
        private RJCodeAdvance.RJControls.RJButton btnPlanilla;
        private TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton rjButton8;
        private RJCodeAdvance.RJControls.RJButton btnInicio;
        private RJCodeAdvance.RJControls.RJButton btnHerramientas;
        private RJCodeAdvance.RJControls.RJButton btnUsuarios;
        private TableLayoutPanel tableLayoutPanel3;
        public Panel panelContenedor;
        private RJCodeAdvance.RJControls.RJButton btnBarraVertical;
        private RJCodeAdvance.RJControls.RJButton btnConfiguraciones;
        private RJCodeAdvance.RJControls.RJButton btnVentas;
    }
}