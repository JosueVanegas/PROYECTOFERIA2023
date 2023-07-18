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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RelojInicio
            // 
            RelojInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RelojInicio.CircleThickness = 6;
            RelojInicio.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            RelojInicio.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwentyFourHour;
            RelojInicio.FilledHourColor = Color.FromArgb(105, 190, 155);
            RelojInicio.FilledMinuteColor = Color.FromArgb(60, 60, 70);
            RelojInicio.FilledSecondColor = Color.DarkOrchid;
            RelojInicio.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            RelojInicio.HexagonColor = Color.FromArgb(60, 60, 70);
            RelojInicio.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            RelojInicio.Location = new Point(289, 55);
            RelojInicio.Name = "RelojInicio";
            RelojInicio.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            RelojInicio.ShowAmPm = false;
            RelojInicio.ShowHexagon = true;
            RelojInicio.ShowMinutesCircle = true;
            RelojInicio.ShowSecondsCircle = true;
            RelojInicio.Size = new Size(315, 308);
            RelojInicio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            RelojInicio.TabIndex = 0;
            RelojInicio.Text = "parrotClock1";
            RelojInicio.TextRenderingType = System.Drawing.Text.TextRenderingHint.SystemDefault;
            RelojInicio.TimeAMFormat = "h:mm tt";
            RelojInicio.TimeColor = Color.FromArgb(220, 220, 220);
            RelojInicio.TimePMFormat = "HH:mm";
            RelojInicio.UnfilledHourColor = Color.FromArgb(75, 70, 85);
            RelojInicio.UnfilledMinuteColor = Color.FromArgb(60, 60, 70);
            RelojInicio.UnfilledSecondColor = Color.FromArgb(60, 60, 70);
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.ForeColor = SystemColors.Control;
            lblEncabezado.Location = new Point(289, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(315, 52);
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
            tableLayoutPanel1.Controls.Add(RelojInicio, 1, 1);
            tableLayoutPanel1.Controls.Add(lblEncabezado, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3507977F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.6492F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.Size = new Size(905, 460);
            tableLayoutPanel1.TabIndex = 41;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(905, 460);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            Text = "Inicio";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotClock RelojInicio;
        private Label lblEncabezado;
        private TableLayoutPanel tableLayoutPanel1;
    }
}