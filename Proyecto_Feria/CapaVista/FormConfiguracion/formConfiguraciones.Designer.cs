namespace CapaVista.FormConfiguracion
{
    partial class formConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguraciones));
            LunaPicture = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            switchModd = new ReaLTaiizor.Controls.CyberSwitch();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblEncabezado2 = new Label();
            lblEncabezado3 = new Label();
            panel1 = new Panel();
            SolPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LunaPicture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SolPicture).BeginInit();
            SuspendLayout();
            // 
            // LunaPicture
            // 
            LunaPicture.Image = (Image)resources.GetObject("LunaPicture.Image");
            LunaPicture.Location = new Point(3, 3);
            LunaPicture.Name = "LunaPicture";
            LunaPicture.Size = new Size(158, 109);
            LunaPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LunaPicture.TabIndex = 7;
            LunaPicture.TabStop = false;
            LunaPicture.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(switchModd, 0, 0);
            tableLayoutPanel1.Location = new Point(338, 248);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(265, 142);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // switchModd
            // 
            switchModd.Alpha = 50;
            switchModd.BackColor = Color.Transparent;
            switchModd.Background = true;
            switchModd.Background_WidthPen = 2F;
            switchModd.BackgroundPen = true;
            switchModd.Checked = true;
            switchModd.ColorBackground = Color.FromArgb(21, 25, 31);
            switchModd.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            switchModd.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            switchModd.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            switchModd.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            switchModd.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            switchModd.ColorLighting = Color.FromArgb(29, 200, 238);
            switchModd.ColorPen_1 = Color.FromArgb(37, 52, 68);
            switchModd.ColorPen_2 = Color.FromArgb(41, 63, 86);
            switchModd.ColorValue = Color.FromArgb(29, 200, 238);
            switchModd.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            switchModd.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            switchModd.ForeColor = Color.FromArgb(245, 245, 245);
            switchModd.Lighting = true;
            switchModd.LinearGradient_Background = true;
            switchModd.LinearGradient_Value = true;
            switchModd.LinearGradientPen = false;
            switchModd.Location = new Point(3, 3);
            switchModd.Name = "switchModd";
            switchModd.PenWidth = 10;
            switchModd.RGB = false;
            switchModd.Rounding = true;
            switchModd.RoundingInt = 90;
            switchModd.Size = new Size(259, 136);
            switchModd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switchModd.TabIndex = 0;
            switchModd.Tag = "Cyber";
            switchModd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            switchModd.Timer_RGB = 300;
            switchModd.CheckedChanged += cyberSwitch2_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel2.Controls.Add(lblEncabezado2, 0, 0);
            tableLayoutPanel2.Controls.Add(lblEncabezado3, 2, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Location = new Point(57, 37);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(777, 121);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // lblEncabezado2
            // 
            lblEncabezado2.AutoSize = true;
            lblEncabezado2.Dock = DockStyle.Fill;
            lblEncabezado2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado2.ImageAlign = ContentAlignment.MiddleRight;
            lblEncabezado2.Location = new Point(3, 0);
            lblEncabezado2.Name = "lblEncabezado2";
            lblEncabezado2.Size = new Size(331, 121);
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
            lblEncabezado3.Location = new Point(510, 0);
            lblEncabezado3.Name = "lblEncabezado3";
            lblEncabezado3.Size = new Size(264, 121);
            lblEncabezado3.TabIndex = 0;
            lblEncabezado3.Text = "tx";
            lblEncabezado3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(LunaPicture);
            panel1.Controls.Add(SolPicture);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(340, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 115);
            panel1.TabIndex = 1;
            // 
            // SolPicture
            // 
            SolPicture.Image = (Image)resources.GetObject("SolPicture.Image");
            SolPicture.Location = new Point(3, 0);
            SolPicture.Name = "SolPicture";
            SolPicture.Size = new Size(158, 115);
            SolPicture.SizeMode = PictureBoxSizeMode.Zoom;
            SolPicture.TabIndex = 8;
            SolPicture.TabStop = false;
            SolPicture.Visible = false;
            // 
            // formConfiguraciones
            // 
            ClientSize = new Size(936, 512);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formConfiguraciones";
            Padding = new Padding(3, 0, 3, 3);
            ((System.ComponentModel.ISupportInitialize)LunaPicture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SolPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox LunaPicture;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CyberSwitch switchModd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblEncabezado2;
        private PictureBox SolPicture;
        private Label lblEncabezado3;
        private Panel panel1;
    }
}