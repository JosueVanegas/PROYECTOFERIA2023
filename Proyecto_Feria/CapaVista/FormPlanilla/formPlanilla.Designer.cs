﻿namespace CapaVista.FormPlanilla
{
    partial class formPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPlanilla));
            panelMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEmpleados = new RJCodeAdvance.RJControls.RJButton();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(21, 25, 31);
            panelMenu.Controls.Add(tableLayoutPanel1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(930, 52);
            panelMenu.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(btnEmpleados, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(930, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(63, 63, 70);
            btnEmpleados.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEmpleados.BackgroundImageLayout = ImageLayout.Center;
            btnEmpleados.BorderColor = Color.PaleVioletRed;
            btnEmpleados.BorderRadius = 10;
            btnEmpleados.BorderSize = 0;
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(3, 2);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(148, 48);
            btnEmpleados.TabIndex = 9;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.TextColor = Color.White;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(3, 52);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.MinimumSize = new Size(564, 272);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(930, 464);
            panelContenedor.TabIndex = 4;
            // 
            // formPlanilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 519);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formPlanilla";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formPlanilla";
            panelMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnProveedores;
        private RJCodeAdvance.RJControls.RJButton btnCategorias;
        private RJCodeAdvance.RJControls.RJButton btnEmpleados;
        public Panel panelContenedor;
    }
}