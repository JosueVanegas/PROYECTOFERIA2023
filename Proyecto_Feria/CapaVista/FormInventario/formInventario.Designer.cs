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
            panelMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnOfertas = new RJCodeAdvance.RJControls.RJButton();
            btnCompras = new RJCodeAdvance.RJControls.RJButton();
            btnProveedores = new RJCodeAdvance.RJControls.RJButton();
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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1064, 69);
            panelMenu.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnOfertas, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCompras, 0, 0);
            tableLayoutPanel1.Controls.Add(btnProveedores, 2, 0);
            tableLayoutPanel1.Controls.Add(btnProductos, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1064, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOfertas
            // 
            btnOfertas.BackColor = Color.Silver;
            btnOfertas.BackgroundColor = Color.Silver;
            btnOfertas.BackgroundImageLayout = ImageLayout.Center;
            btnOfertas.BorderColor = Color.PaleVioletRed;
            btnOfertas.BorderRadius = 10;
            btnOfertas.BorderSize = 0;
            btnOfertas.Dock = DockStyle.Fill;
            btnOfertas.FlatAppearance.BorderSize = 0;
            btnOfertas.FlatStyle = FlatStyle.Flat;
            btnOfertas.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOfertas.ForeColor = Color.Black;
            btnOfertas.ImageAlign = ContentAlignment.MiddleLeft;
            btnOfertas.Location = new Point(535, 3);
            btnOfertas.Name = "btnOfertas";
            btnOfertas.Size = new Size(260, 63);
            btnOfertas.TabIndex = 14;
            btnOfertas.Text = "Ofertas";
            btnOfertas.TextColor = Color.Black;
            btnOfertas.UseVisualStyleBackColor = false;
            btnOfertas.Click += btnOfertas_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.Silver;
            btnCompras.BackgroundColor = Color.Silver;
            btnCompras.BackgroundImageLayout = ImageLayout.Center;
            btnCompras.BorderColor = Color.PaleVioletRed;
            btnCompras.BorderRadius = 10;
            btnCompras.BorderSize = 0;
            btnCompras.Dock = DockStyle.Fill;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.Black;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(269, 3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(260, 63);
            btnCompras.TabIndex = 12;
            btnCompras.Text = "Compras";
            btnCompras.TextColor = Color.Black;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            btnCompras.MouseHover += btnCompras_MouseHover;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.Silver;
            btnProveedores.BackgroundColor = Color.Silver;
            btnProveedores.BackgroundImageLayout = ImageLayout.Center;
            btnProveedores.BorderColor = Color.PaleVioletRed;
            btnProveedores.BorderRadius = 10;
            btnProveedores.BorderSize = 0;
            btnProveedores.Dock = DockStyle.Fill;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(801, 3);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(260, 63);
            btnProveedores.TabIndex = 11;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextColor = Color.Black;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            btnProveedores.MouseHover += btnProveedores_MouseHover;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Silver;
            btnProductos.BackgroundColor = Color.Silver;
            btnProductos.BackgroundImageLayout = ImageLayout.Center;
            btnProductos.BorderColor = Color.PaleVioletRed;
            btnProductos.BorderRadius = 10;
            btnProductos.BorderSize = 0;
            btnProductos.Dock = DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.Black;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(260, 63);
            btnProductos.TabIndex = 9;
            btnProductos.Text = "Productos";
            btnProductos.TextColor = Color.Black;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            btnProductos.MouseHover += btnProductos_MouseHover;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(3, 69);
            panelContenedor.MinimumSize = new Size(645, 363);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1064, 619);
            panelContenedor.TabIndex = 3;
            panelContenedor.MouseHover += btnCompras_MouseHover;
            // 
            // formInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1070, 692);
            ControlBox = false;
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formInventario";
            Padding = new Padding(3, 0, 3, 4);
            Text = "formProductos";
            Load += formInventario_Load;
            panelMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;

        private RJCodeAdvance.RJControls.RJButton btnProductos;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnProveedores;
        public Panel panelContenedor;
        private RJCodeAdvance.RJControls.RJButton btnCompras;
        private RJCodeAdvance.RJControls.RJButton btnOfertas;
    }
}