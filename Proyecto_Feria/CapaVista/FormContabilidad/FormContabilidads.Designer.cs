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
            panel1 = new Panel();
            panelPrincipal = new Panel();
            label10 = new Label();
            lblInventario = new Label();
            lblCompras = new Label();
            lblIva = new Label();
            lblDescVentas = new Label();
            lblVentas = new Label();
            panel2 = new Panel();
            dateHasta = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            dateDesde = new ReaLTaiizor.Controls.PoisonDateTime();
            label1 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panelPrincipal.Controls.Add(panel5);
            panelPrincipal.Controls.Add(panel4);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 134);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(930, 382);
            panelPrincipal.TabIndex = 7;
            panelPrincipal.Tag = "Cuentas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(18, 258);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 12;
            label10.Text = "Ventas: ";
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInventario.ForeColor = Color.DarkSlateGray;
            lblInventario.Location = new Point(18, 217);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(112, 25);
            lblInventario.TabIndex = 11;
            lblInventario.Text = "Inventario:";
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompras.ForeColor = Color.DarkSlateGray;
            lblCompras.Location = new Point(18, 166);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(104, 25);
            lblCompras.TabIndex = 10;
            lblCompras.Text = "Compras:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIva.ForeColor = Color.DarkSlateGray;
            lblIva.Location = new Point(18, 115);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(150, 25);
            lblIva.TabIndex = 9;
            lblIva.Text = "Iva por pagar: ";
            // 
            // lblDescVentas
            // 
            lblDescVentas.AutoSize = true;
            lblDescVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescVentas.ForeColor = Color.DarkSlateGray;
            lblDescVentas.Location = new Point(18, 63);
            lblDescVentas.Name = "lblDescVentas";
            lblDescVentas.Size = new Size(268, 25);
            lblDescVentas.TabIndex = 8;
            lblDescVentas.Text = "Descuentos sobre ventas: ";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentas.ForeColor = Color.DarkSlateGray;
            lblVentas.Location = new Point(18, 17);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(91, 25);
            lblVentas.TabIndex = 7;
            lblVentas.Text = "Ventas: ";
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
            dateHasta.Location = new Point(568, 12);
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
            label2.Location = new Point(485, 16);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 5;
            label2.Text = "hasta: ";
            // 
            // dateDesde
            // 
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.Location = new Point(262, 12);
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
            label1.Location = new Point(170, 16);
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
            label4.Size = new Size(161, 25);
            label4.TabIndex = 6;
            label4.Text = "Tomar cuentas ";
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
            label3.Text = "Cuentas del negocio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblIva);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblVentas);
            panel4.Controls.Add(lblInventario);
            panel4.Controls.Add(lblDescVentas);
            panel4.Controls.Add(lblCompras);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(454, 382);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(454, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(476, 382);
            panel5.TabIndex = 14;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label10;
        private Label lblInventario;
        private Label lblCompras;
        private Label lblIva;
        private Label lblDescVentas;
        private Label lblVentas;
        private Panel panel5;
        private Panel panel4;
    }
}