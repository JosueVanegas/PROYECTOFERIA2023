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
            btnCategorias = new ReaLTaiizor.Controls.MaterialButton();
            panelContenedor = new Panel();
            panelMenu = new Panel();
            btnProveedores = new ReaLTaiizor.Controls.MaterialButton();
            btnProductos = new ReaLTaiizor.Controls.MaterialButton();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.AutoSize = false;
            btnCategorias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategorias.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCategorias.Depth = 0;
            btnCategorias.HighEmphasis = true;
            btnCategorias.Icon = null;
            btnCategorias.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCategorias.Location = new Point(170, 16);
            btnCategorias.Margin = new Padding(4, 6, 4, 6);
            btnCategorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCategorias.Name = "btnCategorias";
            btnCategorias.NoAccentTextColor = Color.Empty;
            btnCategorias.Size = new Size(158, 36);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCategorias.UseAccentColor = false;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 52);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(936, 467);
            panelContenedor.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(936, 52);
            panelMenu.TabIndex = 2;
            // 
            // btnProveedores
            // 
            btnProveedores.AutoSize = false;
            btnProveedores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProveedores.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProveedores.Depth = 0;
            btnProveedores.HighEmphasis = true;
            btnProveedores.Icon = null;
            btnProveedores.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProveedores.Location = new Point(336, 16);
            btnProveedores.Margin = new Padding(4, 6, 4, 6);
            btnProveedores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProveedores.Name = "btnProveedores";
            btnProveedores.NoAccentTextColor = Color.Empty;
            btnProveedores.Size = new Size(158, 36);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProveedores.UseAccentColor = false;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.AutoSize = false;
            btnProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProductos.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProductos.Depth = 0;
            btnProductos.HighEmphasis = true;
            btnProductos.Icon = null;
            btnProductos.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProductos.Location = new Point(4, 16);
            btnProductos.Margin = new Padding(4, 6, 4, 6);
            btnProductos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProductos.Name = "btnProductos";
            btnProductos.NoAccentTextColor = Color.Empty;
            btnProductos.Size = new Size(158, 36);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductos.UseAccentColor = false;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // formInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 519);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formInventario";
            Text = "formProductos";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnCategorias;
        private Panel panelContenedor;
        private Panel panelMenu;
        private ReaLTaiizor.Controls.MaterialButton btnProductos;
        private ReaLTaiizor.Controls.MaterialButton btnProveedores;
    }
}