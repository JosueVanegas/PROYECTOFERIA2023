namespace CapaVista
{
    partial class formInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInventario));
            panelMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnProveedores = new RJCodeAdvance.RJControls.RJButton();
            btnCategorias = new RJCodeAdvance.RJControls.RJButton();
            btnProductos = new RJCodeAdvance.RJControls.RJButton();
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
            panelMenu.TabIndex = 2;
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
            tableLayoutPanel1.Controls.Add(btnProveedores, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCategorias, 1, 0);
            tableLayoutPanel1.Controls.Add(btnProductos, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(930, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(63, 63, 70);
            btnProveedores.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnProveedores.BackgroundImageLayout = ImageLayout.Center;
            btnProveedores.BorderColor = Color.PaleVioletRed;
            btnProveedores.BorderRadius = 10;
            btnProveedores.BorderSize = 0;
            btnProveedores.Dock = DockStyle.Fill;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(311, 2);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(148, 48);
            btnProveedores.TabIndex = 11;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.TextColor = Color.White;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            btnProveedores.MouseHover += btnProveedores_MouseHover;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(63, 63, 70);
            btnCategorias.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnCategorias.BackgroundImageLayout = ImageLayout.Center;
            btnCategorias.BorderColor = Color.PaleVioletRed;
            btnCategorias.BorderRadius = 10;
            btnCategorias.BorderSize = 0;
            btnCategorias.Dock = DockStyle.Fill;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(157, 2);
            btnCategorias.Margin = new Padding(3, 2, 3, 2);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(148, 48);
            btnCategorias.TabIndex = 10;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleRight;
            btnCategorias.TextColor = Color.White;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            btnCategorias.MouseHover += btnCategorias_MouseHover;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(63, 63, 70);
            btnProductos.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnProductos.BackgroundImageLayout = ImageLayout.Center;
            btnProductos.BorderColor = Color.PaleVioletRed;
            btnProductos.BorderRadius = 10;
            btnProductos.BorderSize = 0;
            btnProductos.Dock = DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 2);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(148, 48);
            btnProductos.TabIndex = 9;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.TextColor = Color.White;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            btnProductos.MouseHover += btnProductos_MouseHover;
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
            panelContenedor.TabIndex = 3;
            // 
            // formInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 519);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formInventario";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formProductos";
            panelMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;

        private RJCodeAdvance.RJControls.RJButton btnProductos;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnProveedores;
        private RJCodeAdvance.RJControls.RJButton btnCategorias;
        public Panel panelContenedor;
    }
}