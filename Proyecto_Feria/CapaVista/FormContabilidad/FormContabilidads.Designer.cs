namespace CapaVista.FormContabilidad
{
    partial class FormContabilidads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContabilidads));
            panel1 = new Panel();
            panelPrincipal = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            dateHasta = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            dateDesde = new ReaLTaiizor.Controls.PoisonDateTime();
            label1 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label5 = new Label();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            tgPdf = new RJCodeAdvance.RJControls.RJToggleButton();
            label6 = new Label();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            tgExcel = new RJCodeAdvance.RJControls.RJToggleButton();
            label7 = new Label();
            panel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 121, 121);
            panel1.Controls.Add(panelPrincipal);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MinimumSize = new Size(564, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 516);
            panel1.TabIndex = 6;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(panel4);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 134);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(930, 382);
            panelPrincipal.TabIndex = 7;
            panelPrincipal.Tag = "Cuentas";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(hopePictureBox2);
            panel4.Controls.Add(tgPdf);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(hopePictureBox1);
            panel4.Controls.Add(tgExcel);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(930, 382);
            panel4.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(dateHasta);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateDesde);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 58);
            panel2.TabIndex = 6;
            // 
            // dateHasta
            // 
            dateHasta.Format = DateTimePickerFormat.Short;
            dateHasta.Location = new Point(623, 12);
            dateHasta.MaxDate = new DateTime(2023, 8, 26, 0, 0, 0, 0);
            dateHasta.MinimumSize = new Size(0, 29);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(216, 29);
            dateHasta.TabIndex = 3;
            dateHasta.Value = new DateTime(2023, 8, 26, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(540, 16);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 5;
            label2.Text = "hasta: ";
            // 
            // dateDesde
            // 
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.Location = new Point(317, 12);
            dateDesde.MinimumSize = new Size(0, 29);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(217, 29);
            dateDesde.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 16);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 4;
            label1.Text = "Desde: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 6;
            label4.Text = "Periodo de reportes";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 76);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(930, 76);
            label3.TabIndex = 6;
            label3.Text = "Contabilidad";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(86, 94);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 93;
            label5.Text = "Pdf";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Image = (Image)resources.GetObject("hopePictureBox2.Image");
            hopePictureBox2.Location = new Point(24, 94);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(56, 50);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 92;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tgPdf
            // 
            tgPdf.AutoSize = true;
            tgPdf.Location = new Point(86, 122);
            tgPdf.MinimumSize = new Size(45, 22);
            tgPdf.Name = "tgPdf";
            tgPdf.OffBackColor = Color.Gray;
            tgPdf.OffToggleColor = Color.Gainsboro;
            tgPdf.OnBackColor = Color.Crimson;
            tgPdf.OnToggleColor = Color.WhiteSmoke;
            tgPdf.Size = new Size(45, 22);
            tgPdf.TabIndex = 91;
            tgPdf.UseVisualStyleBackColor = true;
            tgPdf.CheckedChanged += tgPdf_CheckedChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(86, 26);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 90;
            label6.Text = "Excel";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(24, 26);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(56, 50);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 89;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tgExcel
            // 
            tgExcel.AutoSize = true;
            tgExcel.Location = new Point(86, 54);
            tgExcel.MinimumSize = new Size(45, 22);
            tgExcel.Name = "tgExcel";
            tgExcel.OffBackColor = Color.Gray;
            tgExcel.OffToggleColor = Color.Gainsboro;
            tgExcel.OnBackColor = Color.Green;
            tgExcel.OnToggleColor = Color.WhiteSmoke;
            tgExcel.Size = new Size(45, 22);
            tgExcel.TabIndex = 88;
            tgExcel.UseVisualStyleBackColor = true;
            tgExcel.CheckedChanged += tgExcel_CheckedChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(211, 23);
            label7.TabIndex = 87;
            label7.Text = "Formato de los reportes";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormContabilidads
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(936, 519);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormContabilidads";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormContabilidads";
            panel1.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.PoisonDateTime dateHasta;
        private Label label2;
        private ReaLTaiizor.Controls.PoisonDateTime dateDesde;
        private Label label1;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panelPrincipal;
        private Panel panel4;
        private Label label5;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private RJCodeAdvance.RJControls.RJToggleButton tgPdf;
        private Label label6;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private RJCodeAdvance.RJControls.RJToggleButton tgExcel;
        private Label label7;
    }
}