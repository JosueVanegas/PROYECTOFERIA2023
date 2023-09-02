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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblEncabezado = new Label();
            chartTopUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelGraficosBarra = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            panel10 = new Panel();
            lblValorInvetario = new Label();
            label8 = new Label();
            rjCircularPictureBox9 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            panel9 = new Panel();
            lblTotalVentas = new Label();
            label6 = new Label();
            rjCircularPictureBox8 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            panel8 = new Panel();
            lblCantidadVentas = new Label();
            label3 = new Label();
            rjCircularPictureBox7 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            panel5 = new Panel();
            btnOrdenarDatos = new ReaLTaiizor.Controls.Button();
            panel7 = new Panel();
            dtFechaFinal = new ReaLTaiizor.Controls.PoisonDateTime();
            dpFechaInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            panel2 = new Panel();
            lblTituloGraficaVentas = new Label();
            panel3 = new Panel();
            txtEmpleados = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategorias = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProveedores = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuarios = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProductos = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rjCircularPictureBox6 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            rjCircularPictureBox5 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            rjCircularPictureBox4 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            rjCircularPictureBox3 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            rjCircularPictureBox2 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            txtClientes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            panel4 = new Panel();
            tbStock = new ReaLTaiizor.Controls.PoisonDataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartTopUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            panelGraficosBarra.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox9).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox8).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox7).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbStock).BeginInit();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.ForeColor = Color.Black;
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(398, 64);
            lblEncabezado.TabIndex = 40;
            lblEncabezado.Text = "Sistema Auxiliar de ventas";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
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
            chartTopUsuario.Location = new Point(0, 38);
            chartTopUsuario.Name = "chartTopUsuario";
            chartTopUsuario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = Color.DimGray;
            series1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.SmartLabelStyle.CalloutBackColor = Color.White;
            series1.SmartLabelStyle.CalloutLineColor = Color.White;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 6;
            chartTopUsuario.Series.Add(series1);
            chartTopUsuario.Size = new Size(736, 158);
            chartTopUsuario.TabIndex = 49;
            chartTopUsuario.Text = "chart1";
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
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
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
            title1.Alignment = ContentAlignment.TopLeft;
            title1.BackColor = Color.White;
            title1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Top productos más vendidos";
            chartTopProductos.Titles.Add(title1);
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
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 127);
            panel1.TabIndex = 50;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 64);
            panel6.Name = "panel6";
            panel6.Size = new Size(1133, 57);
            panel6.TabIndex = 44;
            // 
            // panel10
            // 
            panel10.Controls.Add(lblValorInvetario);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(rjCircularPictureBox9);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(752, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(332, 57);
            panel10.TabIndex = 2;
            // 
            // lblValorInvetario
            // 
            lblValorInvetario.Dock = DockStyle.Top;
            lblValorInvetario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorInvetario.ForeColor = Color.Black;
            lblValorInvetario.Location = new Point(60, 30);
            lblValorInvetario.Name = "lblValorInvetario";
            lblValorInvetario.Size = new Size(272, 30);
            lblValorInvetario.TabIndex = 47;
            lblValorInvetario.Text = "0";
            lblValorInvetario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(60, 0);
            label8.Name = "label8";
            label8.Size = new Size(272, 30);
            label8.TabIndex = 46;
            label8.Text = "Valor del invetario actual:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rjCircularPictureBox9
            // 
            rjCircularPictureBox9.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox9.BorderColor = Color.Indigo;
            rjCircularPictureBox9.BorderColor2 = Color.MediumOrchid;
            rjCircularPictureBox9.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            rjCircularPictureBox9.BorderSize = 5;
            rjCircularPictureBox9.BorderStyle = BorderStyle.FixedSingle;
            rjCircularPictureBox9.Dock = DockStyle.Left;
            rjCircularPictureBox9.GradientAngle = 100F;
            rjCircularPictureBox9.Image = (Image)resources.GetObject("rjCircularPictureBox9.Image");
            rjCircularPictureBox9.Location = new Point(0, 0);
            rjCircularPictureBox9.Name = "rjCircularPictureBox9";
            rjCircularPictureBox9.Size = new Size(60, 60);
            rjCircularPictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox9.TabIndex = 45;
            rjCircularPictureBox9.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(lblTotalVentas);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(rjCircularPictureBox8);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(378, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(374, 57);
            panel9.TabIndex = 1;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.Dock = DockStyle.Top;
            lblTotalVentas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalVentas.ForeColor = Color.Black;
            lblTotalVentas.Location = new Point(60, 30);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(314, 32);
            lblTotalVentas.TabIndex = 47;
            lblTotalVentas.Text = "0";
            lblTotalVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(60, 0);
            label6.Name = "label6";
            label6.Size = new Size(314, 30);
            label6.TabIndex = 46;
            label6.Text = "Total en ventas:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rjCircularPictureBox8
            // 
            rjCircularPictureBox8.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox8.BorderColor = Color.OrangeRed;
            rjCircularPictureBox8.BorderColor2 = Color.GreenYellow;
            rjCircularPictureBox8.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            rjCircularPictureBox8.BorderSize = 5;
            rjCircularPictureBox8.BorderStyle = BorderStyle.FixedSingle;
            rjCircularPictureBox8.Dock = DockStyle.Left;
            rjCircularPictureBox8.GradientAngle = 100F;
            rjCircularPictureBox8.Image = (Image)resources.GetObject("rjCircularPictureBox8.Image");
            rjCircularPictureBox8.Location = new Point(0, 0);
            rjCircularPictureBox8.Name = "rjCircularPictureBox8";
            rjCircularPictureBox8.Size = new Size(60, 60);
            rjCircularPictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox8.TabIndex = 45;
            rjCircularPictureBox8.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblCantidadVentas);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(rjCircularPictureBox7);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(378, 57);
            panel8.TabIndex = 0;
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.Dock = DockStyle.Top;
            lblCantidadVentas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVentas.ForeColor = Color.Black;
            lblCantidadVentas.Location = new Point(60, 30);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(318, 27);
            lblCantidadVentas.TabIndex = 47;
            lblCantidadVentas.Text = "0";
            lblCantidadVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(60, 0);
            label3.Name = "label3";
            label3.Size = new Size(318, 30);
            label3.TabIndex = 46;
            label3.Text = "Cantidad de ventas:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rjCircularPictureBox7
            // 
            rjCircularPictureBox7.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox7.BorderColor = Color.SteelBlue;
            rjCircularPictureBox7.BorderColor2 = Color.SpringGreen;
            rjCircularPictureBox7.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            rjCircularPictureBox7.BorderSize = 5;
            rjCircularPictureBox7.BorderStyle = BorderStyle.FixedSingle;
            rjCircularPictureBox7.Dock = DockStyle.Left;
            rjCircularPictureBox7.GradientAngle = 100F;
            rjCircularPictureBox7.Image = (Image)resources.GetObject("rjCircularPictureBox7.Image");
            rjCircularPictureBox7.Location = new Point(0, 0);
            rjCircularPictureBox7.Name = "rjCircularPictureBox7";
            rjCircularPictureBox7.Size = new Size(60, 60);
            rjCircularPictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox7.TabIndex = 45;
            rjCircularPictureBox7.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnOrdenarDatos);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(lblEncabezado);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1133, 64);
            panel5.TabIndex = 43;
            // 
            // btnOrdenarDatos
            // 
            btnOrdenarDatos.BackColor = Color.Transparent;
            btnOrdenarDatos.BorderColor = Color.FromArgb(32, 34, 37);
            btnOrdenarDatos.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnOrdenarDatos.EnteredColor = Color.FromArgb(32, 34, 37);
            btnOrdenarDatos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenarDatos.Image = null;
            btnOrdenarDatos.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrdenarDatos.InactiveColor = Color.FromArgb(32, 34, 37);
            btnOrdenarDatos.Location = new Point(742, 3);
            btnOrdenarDatos.Name = "btnOrdenarDatos";
            btnOrdenarDatos.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnOrdenarDatos.PressedColor = Color.FromArgb(165, 37, 37);
            btnOrdenarDatos.Size = new Size(120, 58);
            btnOrdenarDatos.TabIndex = 44;
            btnOrdenarDatos.Text = "Seleccionar rango";
            btnOrdenarDatos.TextAlignment = StringAlignment.Center;
            btnOrdenarDatos.Click += btnOrdenarDatos_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(dtFechaFinal);
            panel7.Controls.Add(dpFechaInicio);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(398, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(338, 64);
            panel7.TabIndex = 43;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.CustomFormat = "yyyy-MM-dd";
            dtFechaFinal.Dock = DockStyle.Bottom;
            dtFechaFinal.Location = new Point(0, 35);
            dtFechaFinal.MinimumSize = new Size(0, 29);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(338, 29);
            dtFechaFinal.TabIndex = 41;
            dtFechaFinal.Value = new DateTime(2023, 9, 1, 7, 50, 9, 0);
            dtFechaFinal.ValueChanged += dtFechaFinal_ValueChanged;
            // 
            // dpFechaInicio
            // 
            dpFechaInicio.CustomFormat = "yyyy-MM-dd";
            dpFechaInicio.Dock = DockStyle.Top;
            dpFechaInicio.Location = new Point(0, 0);
            dpFechaInicio.MinimumSize = new Size(0, 29);
            dpFechaInicio.Name = "dpFechaInicio";
            dpFechaInicio.Size = new Size(338, 29);
            dpFechaInicio.TabIndex = 42;
            dpFechaInicio.Value = new DateTime(2023, 9, 1, 7, 50, 9, 0);
            dpFechaInicio.ValueChanged += dpFechaInicio_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(chartTopUsuario);
            panel2.Controls.Add(lblTituloGraficaVentas);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 196);
            panel2.TabIndex = 51;
            // 
            // lblTituloGraficaVentas
            // 
            lblTituloGraficaVentas.BackColor = Color.White;
            lblTituloGraficaVentas.Dock = DockStyle.Top;
            lblTituloGraficaVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloGraficaVentas.ForeColor = Color.Black;
            lblTituloGraficaVentas.Location = new Point(0, 0);
            lblTituloGraficaVentas.Name = "lblTituloGraficaVentas";
            lblTituloGraficaVentas.Size = new Size(736, 38);
            lblTituloGraficaVentas.TabIndex = 50;
            lblTituloGraficaVentas.Text = "Ventas ordenadas por fecha";
            lblTituloGraficaVentas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtEmpleados);
            panel3.Controls.Add(txtCategorias);
            panel3.Controls.Add(txtProveedores);
            panel3.Controls.Add(txtUsuarios);
            panel3.Controls.Add(txtProductos);
            panel3.Controls.Add(rjCircularPictureBox6);
            panel3.Controls.Add(rjCircularPictureBox5);
            panel3.Controls.Add(rjCircularPictureBox4);
            panel3.Controls.Add(rjCircularPictureBox3);
            panel3.Controls.Add(rjCircularPictureBox2);
            panel3.Controls.Add(rjCircularPictureBox1);
            panel3.Controls.Add(txtClientes);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 189);
            panel3.TabIndex = 52;
            // 
            // txtEmpleados
            // 
            txtEmpleados.AnimateReadOnly = false;
            txtEmpleados.AutoCompleteMode = AutoCompleteMode.None;
            txtEmpleados.AutoCompleteSource = AutoCompleteSource.None;
            txtEmpleados.BackgroundImageLayout = ImageLayout.None;
            txtEmpleados.CharacterCasing = CharacterCasing.Normal;
            txtEmpleados.Depth = 0;
            txtEmpleados.Enabled = false;
            txtEmpleados.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmpleados.HelperText = "Cantidad de Empleados registrados";
            txtEmpleados.HideSelection = true;
            txtEmpleados.Hint = "Empleados: ";
            txtEmpleados.LeadingIcon = null;
            txtEmpleados.Location = new Point(256, 135);
            txtEmpleados.MaxLength = 10;
            txtEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmpleados.Name = "txtEmpleados";
            txtEmpleados.PasswordChar = '\0';
            txtEmpleados.PrefixSuffixText = null;
            txtEmpleados.ReadOnly = true;
            txtEmpleados.RightToLeft = RightToLeft.No;
            txtEmpleados.SelectedText = "";
            txtEmpleados.SelectionLength = 0;
            txtEmpleados.SelectionStart = 0;
            txtEmpleados.ShortcutsEnabled = true;
            txtEmpleados.Size = new Size(134, 48);
            txtEmpleados.TabIndex = 53;
            txtEmpleados.TabStop = false;
            txtEmpleados.Text = "0";
            txtEmpleados.TextAlign = HorizontalAlignment.Left;
            txtEmpleados.TrailingIcon = null;
            txtEmpleados.UseSystemPasswordChar = false;
            // 
            // txtCategorias
            // 
            txtCategorias.AnimateReadOnly = false;
            txtCategorias.AutoCompleteMode = AutoCompleteMode.None;
            txtCategorias.AutoCompleteSource = AutoCompleteSource.None;
            txtCategorias.BackgroundImageLayout = ImageLayout.None;
            txtCategorias.CharacterCasing = CharacterCasing.Normal;
            txtCategorias.Depth = 0;
            txtCategorias.Enabled = false;
            txtCategorias.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategorias.HelperText = "Cantidad de categorias registrados";
            txtCategorias.HideSelection = true;
            txtCategorias.Hint = "Categorias: ";
            txtCategorias.LeadingIcon = null;
            txtCategorias.Location = new Point(256, 84);
            txtCategorias.MaxLength = 10;
            txtCategorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategorias.Name = "txtCategorias";
            txtCategorias.PasswordChar = '\0';
            txtCategorias.PrefixSuffixText = null;
            txtCategorias.ReadOnly = true;
            txtCategorias.RightToLeft = RightToLeft.No;
            txtCategorias.SelectedText = "";
            txtCategorias.SelectionLength = 0;
            txtCategorias.SelectionStart = 0;
            txtCategorias.ShortcutsEnabled = true;
            txtCategorias.Size = new Size(134, 48);
            txtCategorias.TabIndex = 52;
            txtCategorias.TabStop = false;
            txtCategorias.Text = "0";
            txtCategorias.TextAlign = HorizontalAlignment.Left;
            txtCategorias.TrailingIcon = null;
            txtCategorias.UseSystemPasswordChar = false;
            // 
            // txtProveedores
            // 
            txtProveedores.AnimateReadOnly = false;
            txtProveedores.AutoCompleteMode = AutoCompleteMode.None;
            txtProveedores.AutoCompleteSource = AutoCompleteSource.None;
            txtProveedores.BackgroundImageLayout = ImageLayout.None;
            txtProveedores.CharacterCasing = CharacterCasing.Normal;
            txtProveedores.Depth = 0;
            txtProveedores.Enabled = false;
            txtProveedores.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProveedores.HelperText = "Cantidad de proveedores registrados";
            txtProveedores.HideSelection = true;
            txtProveedores.Hint = "Proveedores:";
            txtProveedores.LeadingIcon = null;
            txtProveedores.Location = new Point(256, 33);
            txtProveedores.MaxLength = 10;
            txtProveedores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProveedores.Name = "txtProveedores";
            txtProveedores.PasswordChar = '\0';
            txtProveedores.PrefixSuffixText = null;
            txtProveedores.ReadOnly = true;
            txtProveedores.RightToLeft = RightToLeft.No;
            txtProveedores.SelectedText = "";
            txtProveedores.SelectionLength = 0;
            txtProveedores.SelectionStart = 0;
            txtProveedores.ShortcutsEnabled = true;
            txtProveedores.Size = new Size(134, 48);
            txtProveedores.TabIndex = 51;
            txtProveedores.TabStop = false;
            txtProveedores.Text = "0";
            txtProveedores.TextAlign = HorizontalAlignment.Left;
            txtProveedores.TrailingIcon = null;
            txtProveedores.UseSystemPasswordChar = false;
            // 
            // txtUsuarios
            // 
            txtUsuarios.AnimateReadOnly = false;
            txtUsuarios.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuarios.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuarios.BackgroundImageLayout = ImageLayout.None;
            txtUsuarios.CharacterCasing = CharacterCasing.Normal;
            txtUsuarios.Depth = 0;
            txtUsuarios.Enabled = false;
            txtUsuarios.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuarios.HelperText = "Cantidad de Usuarios registrados";
            txtUsuarios.HideSelection = true;
            txtUsuarios.Hint = "Usuarios: ";
            txtUsuarios.LeadingIcon = null;
            txtUsuarios.Location = new Point(64, 135);
            txtUsuarios.MaxLength = 10;
            txtUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.PasswordChar = '\0';
            txtUsuarios.PrefixSuffixText = null;
            txtUsuarios.ReadOnly = true;
            txtUsuarios.RightToLeft = RightToLeft.No;
            txtUsuarios.SelectedText = "";
            txtUsuarios.SelectionLength = 0;
            txtUsuarios.SelectionStart = 0;
            txtUsuarios.ShortcutsEnabled = true;
            txtUsuarios.Size = new Size(134, 48);
            txtUsuarios.TabIndex = 50;
            txtUsuarios.TabStop = false;
            txtUsuarios.Text = "0";
            txtUsuarios.TextAlign = HorizontalAlignment.Left;
            txtUsuarios.TrailingIcon = null;
            txtUsuarios.UseSystemPasswordChar = false;
            // 
            // txtProductos
            // 
            txtProductos.AnimateReadOnly = false;
            txtProductos.AutoCompleteMode = AutoCompleteMode.None;
            txtProductos.AutoCompleteSource = AutoCompleteSource.None;
            txtProductos.BackgroundImageLayout = ImageLayout.None;
            txtProductos.CharacterCasing = CharacterCasing.Normal;
            txtProductos.Depth = 0;
            txtProductos.Enabled = false;
            txtProductos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductos.HelperText = "Cantidad de productos registrados";
            txtProductos.HideSelection = true;
            txtProductos.Hint = "Productos:";
            txtProductos.LeadingIcon = null;
            txtProductos.Location = new Point(64, 84);
            txtProductos.MaxLength = 10;
            txtProductos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProductos.Name = "txtProductos";
            txtProductos.PasswordChar = '\0';
            txtProductos.PrefixSuffixText = null;
            txtProductos.ReadOnly = true;
            txtProductos.RightToLeft = RightToLeft.No;
            txtProductos.SelectedText = "";
            txtProductos.SelectionLength = 0;
            txtProductos.SelectionStart = 0;
            txtProductos.ShortcutsEnabled = true;
            txtProductos.Size = new Size(134, 48);
            txtProductos.TabIndex = 49;
            txtProductos.TabStop = false;
            txtProductos.Text = "0";
            txtProductos.TextAlign = HorizontalAlignment.Left;
            txtProductos.TrailingIcon = null;
            txtProductos.UseSystemPasswordChar = false;
            // 
            // rjCircularPictureBox6
            // 
            rjCircularPictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox6.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox6.BorderColor = Color.Cyan;
            rjCircularPictureBox6.BorderColor2 = Color.MidnightBlue;
            rjCircularPictureBox6.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox6.BorderSize = 2;
            rjCircularPictureBox6.GradientAngle = 50F;
            rjCircularPictureBox6.Image = (Image)resources.GetObject("rjCircularPictureBox6.Image");
            rjCircularPictureBox6.Location = new Point(207, 135);
            rjCircularPictureBox6.Name = "rjCircularPictureBox6";
            rjCircularPictureBox6.Size = new Size(45, 45);
            rjCircularPictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox6.TabIndex = 48;
            rjCircularPictureBox6.TabStop = false;
            // 
            // rjCircularPictureBox5
            // 
            rjCircularPictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox5.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox5.BorderColor = Color.DarkTurquoise;
            rjCircularPictureBox5.BorderColor2 = Color.Yellow;
            rjCircularPictureBox5.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox5.BorderSize = 2;
            rjCircularPictureBox5.GradientAngle = 50F;
            rjCircularPictureBox5.Image = (Image)resources.GetObject("rjCircularPictureBox5.Image");
            rjCircularPictureBox5.Location = new Point(207, 84);
            rjCircularPictureBox5.Name = "rjCircularPictureBox5";
            rjCircularPictureBox5.Size = new Size(45, 45);
            rjCircularPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox5.TabIndex = 47;
            rjCircularPictureBox5.TabStop = false;
            // 
            // rjCircularPictureBox4
            // 
            rjCircularPictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox4.BorderColor = Color.Lime;
            rjCircularPictureBox4.BorderColor2 = Color.LightSkyBlue;
            rjCircularPictureBox4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox4.BorderSize = 2;
            rjCircularPictureBox4.GradientAngle = 50F;
            rjCircularPictureBox4.Image = (Image)resources.GetObject("rjCircularPictureBox4.Image");
            rjCircularPictureBox4.Location = new Point(207, 36);
            rjCircularPictureBox4.Name = "rjCircularPictureBox4";
            rjCircularPictureBox4.Size = new Size(45, 45);
            rjCircularPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox4.TabIndex = 46;
            rjCircularPictureBox4.TabStop = false;
            // 
            // rjCircularPictureBox3
            // 
            rjCircularPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox3.BorderColor = Color.DarkMagenta;
            rjCircularPictureBox3.BorderColor2 = Color.DodgerBlue;
            rjCircularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox3.BorderSize = 2;
            rjCircularPictureBox3.GradientAngle = 50F;
            rjCircularPictureBox3.Image = (Image)resources.GetObject("rjCircularPictureBox3.Image");
            rjCircularPictureBox3.Location = new Point(13, 135);
            rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            rjCircularPictureBox3.Size = new Size(45, 45);
            rjCircularPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox3.TabIndex = 45;
            rjCircularPictureBox3.TabStop = false;
            // 
            // rjCircularPictureBox2
            // 
            rjCircularPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox2.BorderColor = Color.Green;
            rjCircularPictureBox2.BorderColor2 = Color.SkyBlue;
            rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox2.BorderSize = 2;
            rjCircularPictureBox2.GradientAngle = 50F;
            rjCircularPictureBox2.Image = (Image)resources.GetObject("rjCircularPictureBox2.Image");
            rjCircularPictureBox2.Location = new Point(13, 84);
            rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            rjCircularPictureBox2.Size = new Size(45, 45);
            rjCircularPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox2.TabIndex = 44;
            rjCircularPictureBox2.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = Color.Crimson;
            rjCircularPictureBox1.BorderColor2 = Color.MidnightBlue;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 2;
            rjCircularPictureBox1.GradientAngle = 50F;
            rjCircularPictureBox1.Image = (Image)resources.GetObject("rjCircularPictureBox1.Image");
            rjCircularPictureBox1.Location = new Point(13, 33);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(45, 45);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            rjCircularPictureBox1.TabIndex = 43;
            rjCircularPictureBox1.TabStop = false;
            // 
            // txtClientes
            // 
            txtClientes.AnimateReadOnly = false;
            txtClientes.AutoCompleteMode = AutoCompleteMode.None;
            txtClientes.AutoCompleteSource = AutoCompleteSource.None;
            txtClientes.BackgroundImageLayout = ImageLayout.None;
            txtClientes.CharacterCasing = CharacterCasing.Normal;
            txtClientes.Depth = 0;
            txtClientes.Enabled = false;
            txtClientes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientes.HelperText = "Cantidad de clientes registrados";
            txtClientes.HideSelection = true;
            txtClientes.Hint = "Clientes: ";
            txtClientes.LeadingIcon = null;
            txtClientes.Location = new Point(64, 33);
            txtClientes.MaxLength = 10;
            txtClientes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClientes.Name = "txtClientes";
            txtClientes.PasswordChar = '\0';
            txtClientes.PrefixSuffixText = null;
            txtClientes.ReadOnly = true;
            txtClientes.RightToLeft = RightToLeft.No;
            txtClientes.SelectedText = "";
            txtClientes.SelectionLength = 0;
            txtClientes.SelectionStart = 0;
            txtClientes.ShortcutsEnabled = true;
            txtClientes.Size = new Size(134, 48);
            txtClientes.TabIndex = 42;
            txtClientes.TabStop = false;
            txtClientes.Text = "0";
            txtClientes.TextAlign = HorizontalAlignment.Left;
            txtClientes.TrailingIcon = null;
            txtClientes.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(398, 30);
            label1.TabIndex = 41;
            label1.Text = "Registros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbStock);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(401, 323);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 189);
            panel4.TabIndex = 53;
            // 
            // tbStock
            // 
            tbStock.AllowUserToAddRows = false;
            tbStock.AllowUserToOrderColumns = true;
            tbStock.AllowUserToResizeRows = false;
            tbStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tbStock.BackgroundColor = Color.White;
            tbStock.BorderStyle = BorderStyle.None;
            tbStock.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbStock.ColumnHeadersHeight = 35;
            tbStock.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Cantidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbStock.DefaultCellStyle = dataGridViewCellStyle2;
            tbStock.Dock = DockStyle.Fill;
            tbStock.EditMode = DataGridViewEditMode.EditProgrammatically;
            tbStock.EnableHeadersVisualStyles = false;
            tbStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbStock.GridColor = Color.FromArgb(255, 255, 255);
            tbStock.Location = new Point(0, 30);
            tbStock.Name = "tbStock";
            tbStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbStock.RowHeadersVisible = false;
            tbStock.RowHeadersWidth = 40;
            tbStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbStock.RowTemplate.Height = 30;
            tbStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbStock.Size = new Size(338, 159);
            tbStock.TabIndex = 5;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Unidades disponibles";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(338, 30);
            label2.TabIndex = 42;
            label2.Text = "Stock de productos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox9).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox8).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblEncabezado;
#pragma warning disable CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleados;
#pragma warning restore CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
#pragma warning disable CS0169 // El campo 'FormInicio.parrotPieGraph1' nunca se usa
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsuario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
        private Panel panelGraficosBarra;
        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDateTime dtFechaFinal;
        private ReaLTaiizor.Controls.PoisonDateTime dpFechaInicio;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClientes;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmpleados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategorias;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtProveedores;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuarios;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtProductos;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox6;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox5;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox4;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox3;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private ReaLTaiizor.Controls.PoisonDataGridView tbStock;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private Label label2;
        private Panel panel8;
        private Label label4;
        private Label label3;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox7;
        private Panel panel10;
        private Label lblValorInvetario;
        private Label label8;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox9;
        private Panel panel9;
        private Label label5;
        private Label label6;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox8;
        private Label lblTituloGraficaVentas;
        private Label lblTotalVentas;
        private Label lblCantidadVentas;
        private ReaLTaiizor.Controls.Button btnOrdenarDatos;
    }
}