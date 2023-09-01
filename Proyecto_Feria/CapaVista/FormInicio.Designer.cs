namespace CapaVista
{
    partial class FormInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            lblEncabezado = new Label();
            groupCantidades = new ReaLTaiizor.Controls.ParrotGroupBox();
            chartTopUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelGraficosBarra = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            poisonDateTime2 = new ReaLTaiizor.Controls.PoisonDateTime();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            parrotSuperButton1 = new ReaLTaiizor.Controls.ParrotSuperButton();
            ((System.ComponentModel.ISupportInitialize)chartTopUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            panelGraficosBarra.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.ForeColor = Color.Black;
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(247, 62);
            lblEncabezado.TabIndex = 40;
            lblEncabezado.Text = "Sistema Auxiliar";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            lblEncabezado.Click += lblEncabezado_Click;
            // 
            // groupCantidades
            // 
            groupCantidades.BorderColor = Color.FromArgb(74, 121, 121);
            groupCantidades.BorderWidth = 1;
            groupCantidades.Dock = DockStyle.Fill;
            groupCantidades.Location = new Point(0, 0);
            groupCantidades.Name = "groupCantidades";
            groupCantidades.ShowText = true;
            groupCantidades.Size = new Size(336, 189);
            groupCantidades.TabIndex = 45;
            groupCantidades.TabStop = false;
            groupCantidades.Text = "Cantidades de registros";
            groupCantidades.TextColor = Color.FromArgb(74, 121, 121);
            // 
            // chartTopUsuario
            // 
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Name = "ChartArea1";
            chartTopUsuario.ChartAreas.Add(chartArea1);
            chartTopUsuario.Dock = DockStyle.Fill;
            legend1.BackColor = Color.White;
            legend1.Name = "Legend1";
            chartTopUsuario.Legends.Add(legend1);
            chartTopUsuario.Location = new Point(0, 0);
            chartTopUsuario.Name = "chartTopUsuario";
            chartTopUsuario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.DimGray;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.SmartLabelStyle.CalloutBackColor = Color.White;
            series1.SmartLabelStyle.CalloutLineColor = Color.White;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series1.YValuesPerPoint = 2;
            chartTopUsuario.Series.Add(series1);
            chartTopUsuario.Size = new Size(736, 196);
            chartTopUsuario.TabIndex = 49;
            chartTopUsuario.Text = "chart1";
            title1.BackColor = Color.White;
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Top mejores vendedores";
            chartTopUsuario.Titles.Add(title1);
            // 
            // chartTopProductos
            // 
            chartTopProductos.BorderSkin.BackColor = Color.Black;
            chartTopProductos.BorderSkin.PageColor = Color.Transparent;
            chartTopProductos.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Inclination = 35;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 65;
            chartArea2.Area3DStyle.WallWidth = 4;
            chartArea2.Area3DStyle.ZDepthRealCalc = true;
            chartArea2.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea2);
            chartTopProductos.Dock = DockStyle.Fill;
            legend2.BackColor = Color.White;
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            legend2.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.ShadowColor = Color.DimGray;
            legend2.TitleFont = new Font("Microsoft Tai Le", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            chartTopProductos.Legends.Add(legend2);
            chartTopProductos.Location = new Point(0, 0);
            chartTopProductos.Name = "chartTopProductos";
            chartTopProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartTopProductos.PaletteCustomColors = new Color[] { Color.Cyan, Color.SteelBlue, Color.MidnightBlue, Color.DarkCyan, Color.MediumSpringGreen, Color.SeaGreen };
            series2.BackSecondaryColor = Color.Transparent;
            series2.BorderColor = Color.DimGray;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = Color.DarkGray;
            series2.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            series2.SmartLabelStyle.CalloutBackColor = Color.White;
            series2.SmartLabelStyle.CalloutLineColor = Color.White;
            series2.SmartLabelStyle.IsOverlappedHidden = false;
            series2.YValuesPerPoint = 4;
            chartTopProductos.Series.Add(series2);
            chartTopProductos.Size = new Size(397, 385);
            chartTopProductos.TabIndex = 0;
            chartTopProductos.Text = "chart1";
            title2.BackColor = Color.White;
            title2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top productos más vendidos";
            chartTopProductos.Titles.Add(title2);
            // 
            // panelGraficosBarra
            // 
            panelGraficosBarra.BackColor = Color.White;
            panelGraficosBarra.Controls.Add(chartTopProductos);
            panelGraficosBarra.Dock = DockStyle.Right;
            panelGraficosBarra.Enabled = false;
            panelGraficosBarra.Location = new Point(739, 127);
            panelGraficosBarra.Name = "panelGraficosBarra";
            panelGraficosBarra.Size = new Size(397, 385);
            panelGraficosBarra.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Enabled = false;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 127);
            panel1.TabIndex = 50;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 62);
            panel6.Name = "panel6";
            panel6.Size = new Size(1133, 65);
            panel6.TabIndex = 44;
            // 
            // panel5
            // 
            panel5.Controls.Add(parrotSuperButton1);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(lblEncabezado);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1133, 62);
            panel5.TabIndex = 43;
            // 
            // panel7
            // 
            panel7.Controls.Add(poisonDateTime1);
            panel7.Controls.Add(poisonDateTime2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(247, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 62);
            panel7.TabIndex = 43;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.CustomFormat = "yyyy-MM-dd";
            poisonDateTime1.Dock = DockStyle.Top;
            poisonDateTime1.Location = new Point(0, 29);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(252, 29);
            poisonDateTime1.TabIndex = 41;
            poisonDateTime1.Value = new DateTime(2023, 9, 1, 7, 50, 9, 0);
            // 
            // poisonDateTime2
            // 
            poisonDateTime2.CustomFormat = "yyyy-MM-dd";
            poisonDateTime2.Dock = DockStyle.Top;
            poisonDateTime2.Location = new Point(0, 0);
            poisonDateTime2.MinimumSize = new Size(0, 29);
            poisonDateTime2.Name = "poisonDateTime2";
            poisonDateTime2.Size = new Size(252, 29);
            poisonDateTime2.TabIndex = 42;
            poisonDateTime2.Value = new DateTime(2023, 9, 1, 7, 50, 9, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(chartTopUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 196);
            panel2.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupCantidades);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 189);
            panel3.TabIndex = 52;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(339, 323);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 189);
            panel4.TabIndex = 53;
            // 
            // parrotSuperButton1
            // 
            parrotSuperButton1.BackgroundColor = Color.DarkCyan;
            parrotSuperButton1.ButtonImage = (Image)resources.GetObject("parrotSuperButton1.ButtonImage");
            parrotSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton1.ButtonText = "SuperButton";
            parrotSuperButton1.CornerRadius = 5;
            parrotSuperButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton1.HoverBackgroundColor = Color.FromArgb(102, 217, 174);
            parrotSuperButton1.HoverTextColor = Color.White;
            parrotSuperButton1.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton1.Location = new Point(566, 16);
            parrotSuperButton1.Name = "parrotSuperButton1";
            parrotSuperButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton1.SelectedBackColor = Color.LimeGreen;
            parrotSuperButton1.SelectedTextColor = Color.White;
            parrotSuperButton1.Size = new Size(186, 40);
            parrotSuperButton1.SuperSelected = false;
            parrotSuperButton1.TabIndex = 44;
            parrotSuperButton1.TextColor = Color.White;
            parrotSuperButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton1.Vertical_Alignment = StringAlignment.Center;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 515);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelGraficosBarra);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInicio";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)chartTopUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).EndInit();
            panelGraficosBarra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblEncabezado;
#pragma warning disable CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleados;
#pragma warning restore CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
#pragma warning disable CS0169 // El campo 'FormInicio.parrotPieGraph1' nunca se usa
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
        private ReaLTaiizor.Controls.ParrotGroupBox groupCantidades;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsuario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
        private Panel panelGraficosBarra;
        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton1;
    }
}