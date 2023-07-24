namespace CapaVista
{
    partial class FrmInicio
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
            RelojInicio = new ReaLTaiizor.Controls.ParrotClock();
            lblEncabezado = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            txtDataCategoria = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataProveedor = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataProducto = new ReaLTaiizor.Controls.ParrotBanner();
            txtDataEmpleado = new ReaLTaiizor.Controls.ParrotBanner();
            tableLayoutPanel1.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RelojInicio
            // 
            RelojInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RelojInicio.CircleThickness = 6;
            RelojInicio.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            RelojInicio.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwelveHour;
            RelojInicio.FilledHourColor = Color.Lime;
            RelojInicio.FilledMinuteColor = Color.FromArgb(60, 60, 70);
            RelojInicio.FilledSecondColor = Color.Crimson;
            RelojInicio.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            RelojInicio.HexagonColor = Color.FromArgb(60, 60, 70);
            RelojInicio.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            RelojInicio.Location = new Point(287, 68);
            RelojInicio.Name = "RelojInicio";
            RelojInicio.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            RelojInicio.ShowAmPm = false;
            RelojInicio.ShowHexagon = true;
            RelojInicio.ShowMinutesCircle = true;
            RelojInicio.ShowSecondsCircle = true;
            RelojInicio.Size = new Size(313, 386);
            RelojInicio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            RelojInicio.TabIndex = 0;
            RelojInicio.Text = "parrotClock1";
            RelojInicio.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            RelojInicio.TimeAMFormat = "hh:mm:ss";
            RelojInicio.TimeColor = Color.White;
            RelojInicio.TimePMFormat = "hh:mm:ss";
            RelojInicio.UnfilledHourColor = Color.FromArgb(75, 70, 85);
            RelojInicio.UnfilledMinuteColor = Color.FromArgb(60, 60, 70);
            RelojInicio.UnfilledSecondColor = Color.FromArgb(60, 60, 70);
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.ForeColor = SystemColors.Control;
            lblEncabezado.Location = new Point(287, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(313, 65);
            lblEncabezado.TabIndex = 40;
            lblEncabezado.Text = "BIENVENIDOS";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.60221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.58011F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.81768F));
            tableLayoutPanel1.Controls.Add(lblEncabezado, 1, 0);
            tableLayoutPanel1.Controls.Add(RelojInicio, 1, 1);
            tableLayoutPanel1.Controls.Add(parrotGroupBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3507977F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.6492F));
            tableLayoutPanel1.Size = new Size(899, 457);
            tableLayoutPanel1.TabIndex = 41;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.DodgerBlue;
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Controls.Add(txtDataCategoria);
            parrotGroupBox1.Controls.Add(txtDataProveedor);
            parrotGroupBox1.Controls.Add(txtDataProducto);
            parrotGroupBox1.Controls.Add(txtDataEmpleado);
            parrotGroupBox1.Location = new Point(606, 68);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(290, 386);
            parrotGroupBox1.TabIndex = 45;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Datos generales";
            parrotGroupBox1.TextColor = Color.DodgerBlue;
            // 
            // txtDataCategoria
            // 
            txtDataCategoria.BackColor = Color.Transparent;
            txtDataCategoria.BannerColor = SystemColors.ActiveCaption;
            txtDataCategoria.BorderColor = Color.White;
            txtDataCategoria.ForeColor = Color.White;
            txtDataCategoria.Location = new Point(6, 22);
            txtDataCategoria.Name = "txtDataCategoria";
            txtDataCategoria.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataCategoria.Size = new Size(280, 60);
            txtDataCategoria.TabIndex = 48;
            txtDataCategoria.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataProveedor
            // 
            txtDataProveedor.BackColor = Color.Transparent;
            txtDataProveedor.BannerColor = SystemColors.ActiveCaption;
            txtDataProveedor.BorderColor = Color.White;
            txtDataProveedor.ForeColor = Color.White;
            txtDataProveedor.Location = new Point(6, 220);
            txtDataProveedor.Name = "txtDataProveedor";
            txtDataProveedor.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataProveedor.Size = new Size(280, 60);
            txtDataProveedor.TabIndex = 46;
            txtDataProveedor.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataProducto
            // 
            txtDataProducto.BackColor = Color.Transparent;
            txtDataProducto.BannerColor = SystemColors.ActiveCaption;
            txtDataProducto.BorderColor = Color.White;
            txtDataProducto.ForeColor = Color.White;
            txtDataProducto.Location = new Point(6, 154);
            txtDataProducto.Name = "txtDataProducto";
            txtDataProducto.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataProducto.Size = new Size(280, 60);
            txtDataProducto.TabIndex = 45;
            txtDataProducto.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDataEmpleado
            // 
            txtDataEmpleado.BackColor = Color.Transparent;
            txtDataEmpleado.BannerColor = SystemColors.ActiveCaption;
            txtDataEmpleado.BorderColor = Color.White;
            txtDataEmpleado.ForeColor = Color.White;
            txtDataEmpleado.Location = new Point(6, 88);
            txtDataEmpleado.Name = "txtDataEmpleado";
            txtDataEmpleado.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            txtDataEmpleado.Size = new Size(280, 60);
            txtDataEmpleado.TabIndex = 44;
            txtDataEmpleado.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(905, 460);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FrmInicio";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Inicio";
            tableLayoutPanel1.ResumeLayout(false);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotClock RelojInicio;
        private Label lblEncabezado;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleados;
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
        private ReaLTaiizor.Controls.ParrotBanner txtDataEmpleado;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.ParrotBanner txtDataProveedor;
        private ReaLTaiizor.Controls.ParrotBanner txtDataProducto;
        private ReaLTaiizor.Controls.ParrotBanner txtDataCategoria;
    }
}