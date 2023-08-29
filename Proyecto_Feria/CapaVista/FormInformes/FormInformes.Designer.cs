namespace CapaPresentacion.FormInformes
{
    partial class FormInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            panel1 = new Panel();
            btnAñoActual = new RJCodeAdvance.RJControls.RJButton();
            btnAñoPasado = new RJCodeAdvance.RJControls.RJButton();
            btnSegundoSemestre = new RJCodeAdvance.RJControls.RJButton();
            btnMesActual = new RJCodeAdvance.RJControls.RJButton();
            btnHoy = new RJCodeAdvance.RJControls.RJButton();
            btnAyer = new RJCodeAdvance.RJControls.RJButton();
            btnPrimerSemestre = new RJCodeAdvance.RJControls.RJButton();
            btnMesPasado = new RJCodeAdvance.RJControls.RJButton();
            btnSemanaActual = new RJCodeAdvance.RJControls.RJButton();
            pkrFechaInicio = new RJCodeAdvance.RJControls.RJDatePicker();
            pkrFechaFin = new RJCodeAdvance.RJControls.RJDatePicker();
            btnPersonalizado = new RJCodeAdvance.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAñoActual);
            panel1.Controls.Add(btnAñoPasado);
            panel1.Controls.Add(btnSegundoSemestre);
            panel1.Controls.Add(btnMesActual);
            panel1.Controls.Add(btnHoy);
            panel1.Controls.Add(btnAyer);
            panel1.Controls.Add(btnPrimerSemestre);
            panel1.Controls.Add(btnMesPasado);
            panel1.Controls.Add(btnSemanaActual);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 447);
            panel1.TabIndex = 1;
            // 
            // btnAñoActual
            // 
            btnAñoActual.BackColor = Color.MediumSlateBlue;
            btnAñoActual.BackgroundColor = Color.MediumSlateBlue;
            btnAñoActual.BorderColor = Color.PaleVioletRed;
            btnAñoActual.BorderRadius = 10;
            btnAñoActual.BorderSize = 0;
            btnAñoActual.FlatAppearance.BorderSize = 0;
            btnAñoActual.FlatStyle = FlatStyle.Flat;
            btnAñoActual.ForeColor = Color.White;
            btnAñoActual.Location = new Point(27, 341);
            btnAñoActual.Name = "btnAñoActual";
            btnAñoActual.Size = new Size(150, 40);
            btnAñoActual.TabIndex = 6;
            btnAñoActual.Text = "Año Actual";
            btnAñoActual.TextColor = Color.White;
            btnAñoActual.UseVisualStyleBackColor = false;
            btnAñoActual.Click += ReporteAñoActual_Click;
            // 
            // btnAñoPasado
            // 
            btnAñoPasado.BackColor = Color.MediumSlateBlue;
            btnAñoPasado.BackgroundColor = Color.MediumSlateBlue;
            btnAñoPasado.BorderColor = Color.PaleVioletRed;
            btnAñoPasado.BorderRadius = 10;
            btnAñoPasado.BorderSize = 0;
            btnAñoPasado.FlatAppearance.BorderSize = 0;
            btnAñoPasado.FlatStyle = FlatStyle.Flat;
            btnAñoPasado.ForeColor = Color.White;
            btnAñoPasado.Location = new Point(27, 387);
            btnAñoPasado.Name = "btnAñoPasado";
            btnAñoPasado.Size = new Size(150, 40);
            btnAñoPasado.TabIndex = 9;
            btnAñoPasado.Text = "Año Pasado";
            btnAñoPasado.TextColor = Color.White;
            btnAñoPasado.UseVisualStyleBackColor = false;
            btnAñoPasado.Click += ReporteAñoPasado_Click;
            // 
            // btnSegundoSemestre
            // 
            btnSegundoSemestre.BackColor = Color.MediumSlateBlue;
            btnSegundoSemestre.BackgroundColor = Color.MediumSlateBlue;
            btnSegundoSemestre.BorderColor = Color.PaleVioletRed;
            btnSegundoSemestre.BorderRadius = 10;
            btnSegundoSemestre.BorderSize = 0;
            btnSegundoSemestre.FlatAppearance.BorderSize = 0;
            btnSegundoSemestre.FlatStyle = FlatStyle.Flat;
            btnSegundoSemestre.ForeColor = Color.White;
            btnSegundoSemestre.Location = new Point(27, 295);
            btnSegundoSemestre.Name = "btnSegundoSemestre";
            btnSegundoSemestre.Size = new Size(150, 40);
            btnSegundoSemestre.TabIndex = 4;
            btnSegundoSemestre.Text = "Segundo Semestre";
            btnSegundoSemestre.TextColor = Color.White;
            btnSegundoSemestre.UseVisualStyleBackColor = false;
            btnSegundoSemestre.Click += ReporteSegundoSemestre_Click;
            // 
            // btnMesActual
            // 
            btnMesActual.BackColor = Color.MediumSlateBlue;
            btnMesActual.BackgroundColor = Color.MediumSlateBlue;
            btnMesActual.BorderColor = Color.PaleVioletRed;
            btnMesActual.BorderRadius = 10;
            btnMesActual.BorderSize = 0;
            btnMesActual.FlatAppearance.BorderSize = 0;
            btnMesActual.FlatStyle = FlatStyle.Flat;
            btnMesActual.ForeColor = Color.White;
            btnMesActual.Location = new Point(27, 157);
            btnMesActual.Name = "btnMesActual";
            btnMesActual.Size = new Size(150, 40);
            btnMesActual.TabIndex = 1;
            btnMesActual.Text = "Mes Actual";
            btnMesActual.TextColor = Color.White;
            btnMesActual.UseVisualStyleBackColor = false;
            btnMesActual.Click += ReporteMesActual_Click;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.MediumSlateBlue;
            btnHoy.BackgroundColor = Color.MediumSlateBlue;
            btnHoy.BorderColor = Color.PaleVioletRed;
            btnHoy.BorderRadius = 10;
            btnHoy.BorderSize = 0;
            btnHoy.FlatAppearance.BorderSize = 0;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.White;
            btnHoy.Location = new Point(27, 17);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(150, 40);
            btnHoy.TabIndex = 3;
            btnHoy.Text = "Hoy";
            btnHoy.TextColor = Color.White;
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += ReporteHoy_Click;
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.MediumSlateBlue;
            btnAyer.BackgroundColor = Color.MediumSlateBlue;
            btnAyer.BorderColor = Color.PaleVioletRed;
            btnAyer.BorderRadius = 10;
            btnAyer.BorderSize = 0;
            btnAyer.FlatAppearance.BorderSize = 0;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.White;
            btnAyer.Location = new Point(27, 65);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(150, 40);
            btnAyer.TabIndex = 5;
            btnAyer.Text = "Ayer";
            btnAyer.TextColor = Color.White;
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += ReporteAyer_Click;
            // 
            // btnPrimerSemestre
            // 
            btnPrimerSemestre.BackColor = Color.MediumSlateBlue;
            btnPrimerSemestre.BackgroundColor = Color.MediumSlateBlue;
            btnPrimerSemestre.BorderColor = Color.PaleVioletRed;
            btnPrimerSemestre.BorderRadius = 10;
            btnPrimerSemestre.BorderSize = 0;
            btnPrimerSemestre.FlatAppearance.BorderSize = 0;
            btnPrimerSemestre.FlatStyle = FlatStyle.Flat;
            btnPrimerSemestre.ForeColor = Color.White;
            btnPrimerSemestre.Location = new Point(27, 249);
            btnPrimerSemestre.Name = "btnPrimerSemestre";
            btnPrimerSemestre.Size = new Size(150, 40);
            btnPrimerSemestre.TabIndex = 7;
            btnPrimerSemestre.Text = "Primer Semestre";
            btnPrimerSemestre.TextColor = Color.White;
            btnPrimerSemestre.UseVisualStyleBackColor = false;
            btnPrimerSemestre.Click += ReportePrimerSemestre_Click;
            // 
            // btnMesPasado
            // 
            btnMesPasado.BackColor = Color.MediumSlateBlue;
            btnMesPasado.BackgroundColor = Color.MediumSlateBlue;
            btnMesPasado.BorderColor = Color.PaleVioletRed;
            btnMesPasado.BorderRadius = 10;
            btnMesPasado.BorderSize = 0;
            btnMesPasado.FlatAppearance.BorderSize = 0;
            btnMesPasado.FlatStyle = FlatStyle.Flat;
            btnMesPasado.ForeColor = Color.White;
            btnMesPasado.Location = new Point(27, 203);
            btnMesPasado.Name = "btnMesPasado";
            btnMesPasado.Size = new Size(150, 40);
            btnMesPasado.TabIndex = 2;
            btnMesPasado.Text = "Mes Pasado";
            btnMesPasado.TextColor = Color.White;
            btnMesPasado.UseVisualStyleBackColor = false;
            btnMesPasado.Click += ReporteMesPasado_Click;
            // 
            // btnSemanaActual
            // 
            btnSemanaActual.BackColor = Color.MediumSlateBlue;
            btnSemanaActual.BackgroundColor = Color.MediumSlateBlue;
            btnSemanaActual.BorderColor = Color.PaleVioletRed;
            btnSemanaActual.BorderRadius = 10;
            btnSemanaActual.BorderSize = 0;
            btnSemanaActual.FlatAppearance.BorderSize = 0;
            btnSemanaActual.FlatStyle = FlatStyle.Flat;
            btnSemanaActual.ForeColor = Color.White;
            btnSemanaActual.Location = new Point(27, 111);
            btnSemanaActual.Name = "btnSemanaActual";
            btnSemanaActual.Size = new Size(150, 40);
            btnSemanaActual.TabIndex = 0;
            btnSemanaActual.Text = "Semana Actual";
            btnSemanaActual.TextColor = Color.White;
            btnSemanaActual.UseVisualStyleBackColor = false;
            btnSemanaActual.Click += FechaUltimaSemana_Click;
            // 
            // pkrFechaInicio
            // 
            pkrFechaInicio.BorderColor = Color.PaleVioletRed;
            pkrFechaInicio.BorderSize = 0;
            pkrFechaInicio.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pkrFechaInicio.Location = new Point(67, 17);
            pkrFechaInicio.MinimumSize = new Size(0, 35);
            pkrFechaInicio.Name = "pkrFechaInicio";
            pkrFechaInicio.Size = new Size(213, 35);
            pkrFechaInicio.SkinColor = Color.Navy;
            pkrFechaInicio.TabIndex = 0;
            pkrFechaInicio.TextColor = Color.White;
            // 
            // pkrFechaFin
            // 
            pkrFechaFin.BorderColor = Color.PaleVioletRed;
            pkrFechaFin.BorderSize = 0;
            pkrFechaFin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pkrFechaFin.Location = new Point(67, 58);
            pkrFechaFin.MinimumSize = new Size(0, 35);
            pkrFechaFin.Name = "pkrFechaFin";
            pkrFechaFin.Size = new Size(213, 35);
            pkrFechaFin.SkinColor = Color.LightSlateGray;
            pkrFechaFin.TabIndex = 4;
            pkrFechaFin.TextColor = Color.White;
            // 
            // btnPersonalizado
            // 
            btnPersonalizado.BackColor = Color.MediumSlateBlue;
            btnPersonalizado.BackgroundColor = Color.MediumSlateBlue;
            btnPersonalizado.BorderColor = Color.PaleVioletRed;
            btnPersonalizado.BorderRadius = 10;
            btnPersonalizado.BorderSize = 0;
            btnPersonalizado.FlatAppearance.BorderSize = 0;
            btnPersonalizado.FlatStyle = FlatStyle.Flat;
            btnPersonalizado.ForeColor = Color.White;
            btnPersonalizado.Location = new Point(103, 99);
            btnPersonalizado.Name = "btnPersonalizado";
            btnPersonalizado.Size = new Size(150, 40);
            btnPersonalizado.TabIndex = 8;
            btnPersonalizado.Text = "Personalizar";
            btnPersonalizado.TextColor = Color.White;
            btnPersonalizado.UseVisualStyleBackColor = false;
            btnPersonalizado.Click += ReporteFechaPersonaizado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(570, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 447);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(pkrFechaInicio);
            panel3.Controls.Add(pkrFechaFin);
            panel3.Controls.Add(btnPersonalizado);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(228, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 151);
            panel3.TabIndex = 11;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInformes";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.Manual;
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnSemanaActual;
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaInicio;
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaFin;
        private RJCodeAdvance.RJControls.RJButton btnMesPasado;
        private RJCodeAdvance.RJControls.RJButton btnMesActual;
        private RJCodeAdvance.RJControls.RJButton btnHoy;
        private RJCodeAdvance.RJControls.RJButton btnSegundoSemestre;
        private RJCodeAdvance.RJControls.RJButton btnAyer;
        private RJCodeAdvance.RJControls.RJButton btnAñoActual;
        private RJCodeAdvance.RJControls.RJButton btnPrimerSemestre;
        private RJCodeAdvance.RJControls.RJButton btnPersonalizado;
        private RJCodeAdvance.RJControls.RJButton btnAñoPasado;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
    }
}