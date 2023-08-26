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
            panel1 = new Panel();
            btnPorSemana = new RJCodeAdvance.RJControls.RJButton();
            panel2 = new Panel();
            pkrFechaInicio = new RJCodeAdvance.RJControls.RJDatePicker();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPorSemana);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 447);
            panel1.TabIndex = 1;
            // 
            // btnPorSemana
            // 
            btnPorSemana.BackColor = Color.MediumSlateBlue;
            btnPorSemana.BackgroundColor = Color.MediumSlateBlue;
            btnPorSemana.BorderColor = Color.PaleVioletRed;
            btnPorSemana.BorderRadius = 0;
            btnPorSemana.BorderSize = 0;
            btnPorSemana.FlatAppearance.BorderSize = 0;
            btnPorSemana.FlatStyle = FlatStyle.Flat;
            btnPorSemana.ForeColor = Color.White;
            btnPorSemana.Location = new Point(40, 61);
            btnPorSemana.Name = "btnPorSemana";
            btnPorSemana.Size = new Size(150, 40);
            btnPorSemana.TabIndex = 0;
            btnPorSemana.Text = "Reporte semanal";
            btnPorSemana.TextColor = Color.White;
            btnPorSemana.UseVisualStyleBackColor = false;
            btnPorSemana.Click += rjButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pkrFechaInicio);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(233, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 61);
            panel2.TabIndex = 3;
            // 
            // pkrFechaInicio
            // 
            pkrFechaInicio.BorderColor = Color.PaleVioletRed;
            pkrFechaInicio.BorderSize = 0;
            pkrFechaInicio.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pkrFechaInicio.Location = new Point(102, 20);
            pkrFechaInicio.MinimumSize = new Size(0, 35);
            pkrFechaInicio.Name = "pkrFechaInicio";
            pkrFechaInicio.Size = new Size(213, 35);
            pkrFechaInicio.SkinColor = Color.Navy;
            pkrFechaInicio.TabIndex = 0;
            pkrFechaInicio.TextColor = Color.White;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportEmbeddedResource = "";
            reportViewer1.Location = new Point(233, 61);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(579, 386);
            reportViewer1.TabIndex = 4;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(reportViewer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInformes";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.Manual;
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnPorSemana;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}