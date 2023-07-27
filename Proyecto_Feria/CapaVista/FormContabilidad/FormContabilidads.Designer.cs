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
            tableLayoutPanel3 = new TableLayoutPanel();
            btnContabilidad = new RJCodeAdvance.RJControls.RJButton();
            panel1 = new Panel();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.Controls.Add(btnContabilidad, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(930, 52);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnContabilidad
            // 
            btnContabilidad.BackColor = Color.FromArgb(63, 63, 70);
            btnContabilidad.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnContabilidad.BackgroundImageLayout = ImageLayout.Center;
            btnContabilidad.BorderColor = Color.PaleVioletRed;
            btnContabilidad.BorderRadius = 10;
            btnContabilidad.BorderSize = 0;
            btnContabilidad.Dock = DockStyle.Fill;
            btnContabilidad.FlatAppearance.BorderSize = 0;
            btnContabilidad.FlatStyle = FlatStyle.Flat;
            btnContabilidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnContabilidad.ForeColor = Color.White;
            btnContabilidad.Image = (Image)resources.GetObject("btnContabilidad.Image");
            btnContabilidad.ImageAlign = ContentAlignment.MiddleLeft;
            btnContabilidad.Location = new Point(3, 2);
            btnContabilidad.Margin = new Padding(3, 2, 3, 2);
            btnContabilidad.Name = "btnContabilidad";
            btnContabilidad.Size = new Size(148, 48);
            btnContabilidad.TabIndex = 9;
            btnContabilidad.Text = "Contabilidad";
            btnContabilidad.TextAlign = ContentAlignment.MiddleRight;
            btnContabilidad.TextColor = Color.White;
            btnContabilidad.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 25, 31);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MinimumSize = new Size(564, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 464);
            panel1.TabIndex = 6;
            // 
            // FormContabilidads
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 25, 31);
            ClientSize = new Size(936, 519);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel3);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormContabilidads";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormContabilidads";
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private RJCodeAdvance.RJControls.RJButton btnContabilidad;
        public Panel panel1;
    }
}