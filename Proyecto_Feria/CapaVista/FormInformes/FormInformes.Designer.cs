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
            pkrFechaInicio = new RJCodeAdvance.RJControls.RJDatePicker();
            pkrFechaFin = new RJCodeAdvance.RJControls.RJDatePicker();
            btnPersonalizado = new RJCodeAdvance.RJControls.RJButton();
            panel3 = new Panel();
            panel2 = new Panel();
            rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            btnInforVentas = new RJCodeAdvance.RJControls.RJButton();
            btninfoCompras = new RJCodeAdvance.RJControls.RJButton();
            rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            PanelRangoreport = new Panel();
            btn15Dias = new RJCodeAdvance.RJControls.RJButton();
            btnAñoActual = new RJCodeAdvance.RJControls.RJButton();
            btnMesActual = new RJCodeAdvance.RJControls.RJButton();
            btnHoy = new RJCodeAdvance.RJControls.RJButton();
            btnAyer = new RJCodeAdvance.RJControls.RJButton();
            btnSemanaActual = new RJCodeAdvance.RJControls.RJButton();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            PanelRangoreport.SuspendLayout();
            SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(pkrFechaInicio);
            panel3.Controls.Add(pkrFechaFin);
            panel3.Controls.Add(btnPersonalizado);
            panel3.Location = new Point(467, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 151);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(rjButton3);
            panel2.Controls.Add(btnInforVentas);
            panel2.Controls.Add(btninfoCompras);
            panel2.Controls.Add(rjButton6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 447);
            panel2.TabIndex = 12;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MediumSlateBlue;
            rjButton3.BackgroundColor = Color.MediumSlateBlue;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(17, 157);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(150, 40);
            rjButton3.TabIndex = 1;
            rjButton3.Text = "Nomina";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.MouseHover += btnEleccionTipoReport_MouseHover;
            // 
            // btnInforVentas
            // 
            btnInforVentas.BackColor = Color.MediumSlateBlue;
            btnInforVentas.BackgroundColor = Color.MediumSlateBlue;
            btnInforVentas.BorderColor = Color.PaleVioletRed;
            btnInforVentas.BorderRadius = 10;
            btnInforVentas.BorderSize = 0;
            btnInforVentas.FlatAppearance.BorderSize = 0;
            btnInforVentas.FlatStyle = FlatStyle.Flat;
            btnInforVentas.ForeColor = Color.White;
            btnInforVentas.Location = new Point(17, 18);
            btnInforVentas.Name = "btnInforVentas";
            btnInforVentas.Size = new Size(150, 40);
            btnInforVentas.TabIndex = 3;
            btnInforVentas.Text = "Informe de ventas";
            btnInforVentas.TextColor = Color.White;
            btnInforVentas.UseVisualStyleBackColor = false;
            btnInforVentas.MouseHover += btnEleccionTipoReport_MouseHover;
            // 
            // btninfoCompras
            // 
            btninfoCompras.BackColor = Color.MediumSlateBlue;
            btninfoCompras.BackgroundColor = Color.MediumSlateBlue;
            btninfoCompras.BorderColor = Color.PaleVioletRed;
            btninfoCompras.BorderRadius = 10;
            btninfoCompras.BorderSize = 0;
            btninfoCompras.FlatAppearance.BorderSize = 0;
            btninfoCompras.FlatStyle = FlatStyle.Flat;
            btninfoCompras.ForeColor = Color.White;
            btninfoCompras.Location = new Point(17, 65);
            btninfoCompras.Name = "btninfoCompras";
            btninfoCompras.Size = new Size(150, 40);
            btninfoCompras.TabIndex = 5;
            btninfoCompras.Text = "Informe de compras";
            btninfoCompras.TextColor = Color.White;
            btninfoCompras.UseVisualStyleBackColor = false;
            btninfoCompras.MouseHover += btnEleccionTipoReport_MouseHover;
            // 
            // rjButton6
            // 
            rjButton6.BackColor = Color.MediumSlateBlue;
            rjButton6.BackgroundColor = Color.MediumSlateBlue;
            rjButton6.BorderColor = Color.PaleVioletRed;
            rjButton6.BorderRadius = 10;
            rjButton6.BorderSize = 0;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = FlatStyle.Flat;
            rjButton6.ForeColor = Color.White;
            rjButton6.Location = new Point(17, 111);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(150, 40);
            rjButton6.TabIndex = 0;
            rjButton6.Text = "Informe de inventario";
            rjButton6.TextColor = Color.White;
            rjButton6.UseVisualStyleBackColor = false;
            rjButton6.MouseHover += btnEleccionTipoReport_MouseHover;
            // 
            // PanelRangoreport
            // 
            PanelRangoreport.BackColor = Color.Transparent;
            PanelRangoreport.Controls.Add(btn15Dias);
            PanelRangoreport.Controls.Add(btnAñoActual);
            PanelRangoreport.Controls.Add(btnMesActual);
            PanelRangoreport.Controls.Add(btnHoy);
            PanelRangoreport.Controls.Add(btnAyer);
            PanelRangoreport.Controls.Add(btnSemanaActual);
            PanelRangoreport.Location = new Point(170, 4);
            PanelRangoreport.Name = "PanelRangoreport";
            PanelRangoreport.Size = new Size(171, 302);
            PanelRangoreport.TabIndex = 1;
            PanelRangoreport.Visible = false;
            PanelRangoreport.MouseEnter += PanelRangoreport_MouseEnter;
            PanelRangoreport.MouseLeave += PanelRangoreport_MouseLeave;
            // 
            // btn15Dias
            // 
            btn15Dias.BackColor = Color.MediumSlateBlue;
            btn15Dias.BackgroundColor = Color.MediumSlateBlue;
            btn15Dias.BorderColor = Color.PaleVioletRed;
            btn15Dias.BorderRadius = 10;
            btn15Dias.BorderSize = 0;
            btn15Dias.FlatAppearance.BorderSize = 0;
            btn15Dias.FlatStyle = FlatStyle.Flat;
            btn15Dias.ForeColor = Color.White;
            btn15Dias.Location = new Point(11, 204);
            btn15Dias.Name = "btn15Dias";
            btn15Dias.Size = new Size(150, 40);
            btn15Dias.TabIndex = 7;
            btn15Dias.Text = "Ultimos 15 Dias";
            btn15Dias.TextColor = Color.White;
            btn15Dias.UseVisualStyleBackColor = false;
            btn15Dias.MouseEnter += PanelRangoreport_MouseEnter;
            btn15Dias.MouseLeave += PanelRangoreport_MouseLeave;
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
            btnAñoActual.Location = new Point(11, 250);
            btnAñoActual.Name = "btnAñoActual";
            btnAñoActual.Size = new Size(150, 40);
            btnAñoActual.TabIndex = 6;
            btnAñoActual.Text = "Año Actual";
            btnAñoActual.TextColor = Color.White;
            btnAñoActual.UseVisualStyleBackColor = false;
            btnAñoActual.Click += ReporteAñoActual_Click;
            btnAñoActual.MouseEnter += PanelRangoreport_MouseEnter;
            btnAñoActual.MouseLeave += PanelRangoreport_MouseLeave;
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
            btnMesActual.Location = new Point(11, 157);
            btnMesActual.Name = "btnMesActual";
            btnMesActual.Size = new Size(150, 40);
            btnMesActual.TabIndex = 1;
            btnMesActual.Text = "Mes Actual";
            btnMesActual.TextColor = Color.White;
            btnMesActual.UseVisualStyleBackColor = false;
            btnMesActual.Click += ReporteMesActual_Click;
            btnMesActual.MouseEnter += PanelRangoreport_MouseEnter;
            btnMesActual.MouseLeave += PanelRangoreport_MouseLeave;
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
            btnHoy.Location = new Point(11, 17);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(150, 40);
            btnHoy.TabIndex = 3;
            btnHoy.Text = "Hoy";
            btnHoy.TextColor = Color.White;
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += ReporteHoy_Click;
            btnHoy.MouseEnter += PanelRangoreport_MouseEnter;
            btnHoy.MouseLeave += PanelRangoreport_MouseLeave;
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
            btnAyer.Location = new Point(11, 65);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(150, 40);
            btnAyer.TabIndex = 5;
            btnAyer.Text = "Ayer";
            btnAyer.TextColor = Color.White;
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += ReporteAyer_Click;
            btnAyer.MouseEnter += PanelRangoreport_MouseEnter;
            btnAyer.MouseLeave += PanelRangoreport_MouseLeave;
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
            btnSemanaActual.Location = new Point(11, 111);
            btnSemanaActual.Name = "btnSemanaActual";
            btnSemanaActual.Size = new Size(150, 40);
            btnSemanaActual.TabIndex = 0;
            btnSemanaActual.Text = "Semana Actual";
            btnSemanaActual.TextColor = Color.White;
            btnSemanaActual.UseVisualStyleBackColor = false;
            btnSemanaActual.Click += FechaUltimaSemana_Click;
            btnSemanaActual.MouseEnter += PanelRangoreport_MouseEnter;
            btnSemanaActual.MouseLeave += PanelRangoreport_MouseLeave;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(PanelRangoreport);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInformes";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.Manual;
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            PanelRangoreport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaInicio;
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaFin;
        private RJCodeAdvance.RJControls.RJButton btnPersonalizado;
        private Panel panel3;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton btnInforVentas;
        private RJCodeAdvance.RJControls.RJButton btninfoCompras;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private Panel PanelRangoreport;
        private RJCodeAdvance.RJControls.RJButton btn15Dias;
        private RJCodeAdvance.RJControls.RJButton btnAñoActual;
        private RJCodeAdvance.RJControls.RJButton btnMesActual;
        private RJCodeAdvance.RJControls.RJButton btnHoy;
        private RJCodeAdvance.RJControls.RJButton btnAyer;
        private RJCodeAdvance.RJControls.RJButton btnSemanaActual;
    }
}