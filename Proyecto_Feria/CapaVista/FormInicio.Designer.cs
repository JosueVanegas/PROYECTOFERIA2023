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
            lblEncabezado = new Label();
            groupCantidades = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtDataUsuarios = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataClientes = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataCategoria = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataProveedor = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataProducto = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataEmpleado = new ReaLTaiizor.Controls.ParrotBanner();
            panelGraficosBarra = new Panel();
            chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            chartTopUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupCantidades.SuspendLayout();
            panelGraficosBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Top;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.ForeColor = Color.Black;
            lblEncabezado.Location = new Point(3, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(929, 65);
            lblEncabezado.TabIndex = 40;
            lblEncabezado.Text = "BIENVENIDO";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            lblEncabezado.Click += lblEncabezado_Click;
            // 
            // groupCantidades
            // 
            groupCantidades.BorderColor = Color.FromArgb(74, 121, 121);
            groupCantidades.BorderWidth = 1;
            groupCantidades.Controls.Add(txtDataUsuarios);
            groupCantidades.Controls.Add(txtDataClientes);
            groupCantidades.Controls.Add(txtDataCategoria);
            groupCantidades.Controls.Add(txtDataProveedor);
            groupCantidades.Controls.Add(txtDataProducto);
            groupCantidades.Controls.Add(txtDataEmpleado);
            groupCantidades.Dock = DockStyle.Fill;
            groupCantidades.Location = new Point(0, 0);
            groupCantidades.Name = "groupCantidades";
            groupCantidades.ShowText = true;
            groupCantidades.Size = new Size(262, 433);
            groupCantidades.TabIndex = 45;
            groupCantidades.TabStop = false;
            groupCantidades.Text = "Cantidades de registros";
            groupCantidades.TextColor = Color.FromArgb(74, 121, 121);
            // 
            // txtDataUsuarios
            // 
            txtDataUsuarios.BackColor = Color.Transparent;
            txtDataUsuarios.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataUsuarios.BorderColor = Color.Black;
            txtDataUsuarios.ForeColor = Color.Black;
            txtDataUsuarios.Location = new Point(27, 325);
            txtDataUsuarios.Name = "txtDataUsuarios";
            txtDataUsuarios.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataUsuarios.Size = new Size(217, 55);
            txtDataUsuarios.TabIndex = 51;
            txtDataUsuarios.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataClientes
            // 
            txtDataClientes.BackColor = Color.Transparent;
            txtDataClientes.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataClientes.BorderColor = Color.Black;
            txtDataClientes.ForeColor = Color.Black;
            txtDataClientes.Location = new Point(27, 264);
            txtDataClientes.Name = "txtDataClientes";
            txtDataClientes.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataClientes.Size = new Size(217, 55);
            txtDataClientes.TabIndex = 50;
            txtDataClientes.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataCategoria
            // 
            txtDataCategoria.BackColor = Color.Transparent;
            txtDataCategoria.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataCategoria.BorderColor = Color.Black;
            txtDataCategoria.ForeColor = Color.Black;
            txtDataCategoria.Location = new Point(27, 22);
            txtDataCategoria.Name = "txtDataCategoria";
            txtDataCategoria.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataCategoria.Size = new Size(214, 55);
            txtDataCategoria.TabIndex = 48;
            txtDataCategoria.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataProveedor
            // 
            txtDataProveedor.BackColor = Color.Transparent;
            txtDataProveedor.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataProveedor.BorderColor = Color.Black;
            txtDataProveedor.ForeColor = Color.Black;
            txtDataProveedor.Location = new Point(27, 203);
            txtDataProveedor.Name = "txtDataProveedor";
            txtDataProveedor.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataProveedor.Size = new Size(219, 55);
            txtDataProveedor.TabIndex = 46;
            txtDataProveedor.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataProducto
            // 
            txtDataProducto.BackColor = Color.Transparent;
            txtDataProducto.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataProducto.BorderColor = Color.Black;
            txtDataProducto.ForeColor = Color.Black;
            txtDataProducto.Location = new Point(27, 142);
            txtDataProducto.Name = "txtDataProducto";
            txtDataProducto.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataProducto.Size = new Size(219, 55);
            txtDataProducto.TabIndex = 45;
            txtDataProducto.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataEmpleado
            // 
            txtDataEmpleado.BackColor = Color.Transparent;
            txtDataEmpleado.BannerColor = Color.FromArgb(74, 121, 121);
            txtDataEmpleado.BorderColor = Color.Black;
            txtDataEmpleado.ForeColor = Color.Black;
            txtDataEmpleado.Location = new Point(27, 81);
            txtDataEmpleado.Name = "txtDataEmpleado";
            txtDataEmpleado.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataEmpleado.Size = new Size(217, 55);
            txtDataEmpleado.TabIndex = 44;
            txtDataEmpleado.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panelGraficosBarra
            // 
            panelGraficosBarra.BackColor = Color.White;
            panelGraficosBarra.Controls.Add(chartTopProductos);
            panelGraficosBarra.Dock = DockStyle.Left;
            panelGraficosBarra.Enabled = false;
            panelGraficosBarra.Location = new Point(3, 65);
            panelGraficosBarra.Name = "panelGraficosBarra";
            panelGraficosBarra.Size = new Size(342, 433);
            panelGraficosBarra.TabIndex = 47;
            // 
            // chartTopProductos
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 35;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 65;
            chartArea1.Area3DStyle.WallWidth = 4;
            chartArea1.Area3DStyle.ZDepthRealCalc = true;
            chartArea1.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea1);
            chartTopProductos.Dock = DockStyle.Fill;
            legend1.BackColor = Color.White;
            legend1.Name = "Legend1";
            chartTopProductos.Legends.Add(legend1);
            chartTopProductos.Location = new Point(0, 0);
            chartTopProductos.Name = "chartTopProductos";
            chartTopProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = Color.DimGray;
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.SmartLabelStyle.CalloutBackColor = Color.White;
            series1.SmartLabelStyle.CalloutLineColor = Color.White;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            chartTopProductos.Series.Add(series1);
            chartTopProductos.Size = new Size(342, 433);
            chartTopProductos.TabIndex = 0;
            chartTopProductos.Text = "chart1";
            title1.BackColor = Color.White;
            title1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Top productos más vendidos";
            chartTopProductos.Titles.Add(title1);
            // 
            // panel2
            // 
            panel2.Controls.Add(groupCantidades);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(670, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 433);
            panel2.TabIndex = 48;
            // 
            // chartTopUsuario
            // 
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Name = "ChartArea1";
            chartTopUsuario.ChartAreas.Add(chartArea2);
            chartTopUsuario.Dock = DockStyle.Fill;
            legend2.BackColor = Color.White;
            legend2.Name = "Legend1";
            chartTopUsuario.Legends.Add(legend2);
            chartTopUsuario.Location = new Point(345, 65);
            chartTopUsuario.Name = "chartTopUsuario";
            chartTopUsuario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.DimGray;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.SmartLabelStyle.CalloutBackColor = Color.White;
            series2.SmartLabelStyle.CalloutLineColor = Color.White;
            series2.SmartLabelStyle.IsOverlappedHidden = false;
            series2.YValuesPerPoint = 2;
            chartTopUsuario.Series.Add(series2);
            chartTopUsuario.Size = new Size(325, 433);
            chartTopUsuario.TabIndex = 49;
            chartTopUsuario.Text = "chart1";
            title2.BackColor = Color.White;
            title2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top mejores vendedores";
            chartTopUsuario.Titles.Add(title2);
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 501);
            Controls.Add(chartTopUsuario);
            Controls.Add(panel2);
            Controls.Add(panelGraficosBarra);
            Controls.Add(lblEncabezado);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInicio";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Inicio";
            groupCantidades.ResumeLayout(false);
            groupCantidades.PerformLayout();
            panelGraficosBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTopUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblEncabezado;
#pragma warning disable CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleados;
#pragma warning restore CS0169 // El campo 'FormInicio.txtDataEmpleados' nunca se usa
#pragma warning disable CS0169 // El campo 'FormInicio.parrotPieGraph1' nunca se usa
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
#pragma warning restore CS0169 // El campo 'FormInicio.parrotPieGraph1' nunca se usa
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleado;
        private ReaLTaiizor.Controls.ParrotGroupBox groupCantidades;
        private ReaLTaiizor.Controls.ParrotBanner txtDataProveedor;
        private ReaLTaiizor.Controls.ParrotBanner txtDataProducto;
        private ReaLTaiizor.Controls.ParrotBanner txtDataCategoria;
        private ReaLTaiizor.Controls.ParrotBanner txtDataUsuarios;
        private ReaLTaiizor.Controls.ParrotBanner txtDataClientes;
        private Panel panelGraficosBarra;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsuario;
    }
}