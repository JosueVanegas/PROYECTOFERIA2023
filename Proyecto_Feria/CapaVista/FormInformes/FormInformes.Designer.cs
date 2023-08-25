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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(233, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(564, 447);
            reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(rjButton1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 447);
            panel1.TabIndex = 1;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(26, 123);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(164, 150);
            dataGridView1.TabIndex = 1;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewer1);
            Controls.Add(panel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInformes";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.Manual;
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private DataGridView dataGridView1;
    }
}