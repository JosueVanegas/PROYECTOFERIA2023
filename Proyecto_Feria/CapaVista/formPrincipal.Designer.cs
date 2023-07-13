using CapaDatos;
using CapaVista;

namespace CapaVista
{
    partial class formPrincipal
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
            components = new System.ComponentModel.Container();
            btnInicio = new ReaLTaiizor.Controls.MaterialButton();
            panel1 = new ReaLTaiizor.Controls.Panel();
            btnInventario = new ReaLTaiizor.Controls.MaterialButton();
            btnUsuarios = new ReaLTaiizor.Controls.MaterialButton();
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            btnAcercaDe = new ReaLTaiizor.Controls.MaterialButton();
            btnReportes = new ReaLTaiizor.Controls.MaterialButton();
            btnClientes = new ReaLTaiizor.Controls.MaterialButton();
            btnCompras = new ReaLTaiizor.Controls.MaterialButton();
            btnVentas = new ReaLTaiizor.Controls.MaterialButton();
            usuarioBindingSource = new BindingSource(components);
            lblUsuarioActual = new Label();
            panel2 = new Panel();
            lblEncabezado = new Label();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.None;
            btnInicio.AutoSize = false;
            btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicio.BackColor = Color.White;
            btnInicio.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInicio.Depth = 0;
            btnInicio.ForeColor = Color.Black;
            btnInicio.HighEmphasis = false;
            btnInicio.Icon = null;
            btnInicio.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnInicio.Location = new Point(-6, 74);
            btnInicio.Margin = new Padding(4, 6, 4, 6);
            btnInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnInicio.Name = "btnInicio";
            btnInicio.NoAccentTextColor = Color.Empty;
            btnInicio.Size = new Size(118, 36);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInicio.UseAccentColor = false;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAcercaDe);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Left;
            panel1.EdgeColor = Color.White;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(143, 548);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // btnInventario
            // 
            btnInventario.Anchor = AnchorStyles.None;
            btnInventario.AutoSize = false;
            btnInventario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInventario.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInventario.Depth = 0;
            btnInventario.HighEmphasis = false;
            btnInventario.Icon = null;
            btnInventario.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnInventario.Location = new Point(-6, 212);
            btnInventario.Margin = new Padding(4, 6, 4, 6);
            btnInventario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnInventario.Name = "btnInventario";
            btnInventario.NoAccentTextColor = Color.Empty;
            btnInventario.Size = new Size(118, 33);
            btnInventario.TabIndex = 10;
            btnInventario.Text = "Inventario";
            btnInventario.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInventario.UseAccentColor = false;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.None;
            btnUsuarios.AutoSize = false;
            btnUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsuarios.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUsuarios.Depth = 0;
            btnUsuarios.HighEmphasis = false;
            btnUsuarios.Icon = null;
            btnUsuarios.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnUsuarios.Location = new Point(-6, 302);
            btnUsuarios.Margin = new Padding(4, 6, 4, 6);
            btnUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NoAccentTextColor = Color.Empty;
            btnUsuarios.Size = new Size(118, 33);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUsuarios.UseAccentColor = false;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.AutoSize = false;
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = false;
            btnSalir.Icon = null;
            btnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalir.Location = new Point(-6, 437);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(118, 33);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "salir";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalir.UseAccentColor = false;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Anchor = AnchorStyles.None;
            btnAcercaDe.AutoSize = false;
            btnAcercaDe.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAcercaDe.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAcercaDe.Depth = 0;
            btnAcercaDe.HighEmphasis = false;
            btnAcercaDe.Icon = null;
            btnAcercaDe.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAcercaDe.Location = new Point(-6, 392);
            btnAcercaDe.Margin = new Padding(4, 6, 4, 6);
            btnAcercaDe.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.NoAccentTextColor = Color.Empty;
            btnAcercaDe.Size = new Size(118, 33);
            btnAcercaDe.TabIndex = 7;
            btnAcercaDe.Text = "acerca de";
            btnAcercaDe.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAcercaDe.UseAccentColor = false;
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // btnReportes
            // 
            btnReportes.Anchor = AnchorStyles.None;
            btnReportes.AutoSize = false;
            btnReportes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReportes.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReportes.Depth = 0;
            btnReportes.HighEmphasis = false;
            btnReportes.Icon = null;
            btnReportes.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnReportes.Location = new Point(-6, 347);
            btnReportes.Margin = new Padding(4, 6, 4, 6);
            btnReportes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnReportes.Name = "btnReportes";
            btnReportes.NoAccentTextColor = Color.Empty;
            btnReportes.Size = new Size(118, 33);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "reportes";
            btnReportes.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReportes.UseAccentColor = false;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.None;
            btnClientes.AutoSize = false;
            btnClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClientes.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClientes.Depth = 0;
            btnClientes.HighEmphasis = false;
            btnClientes.Icon = null;
            btnClientes.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnClientes.Location = new Point(-6, 257);
            btnClientes.Margin = new Padding(4, 6, 4, 6);
            btnClientes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnClientes.Name = "btnClientes";
            btnClientes.NoAccentTextColor = Color.Empty;
            btnClientes.Size = new Size(118, 33);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClientes.UseAccentColor = false;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCompras
            // 
            btnCompras.Anchor = AnchorStyles.None;
            btnCompras.AutoSize = false;
            btnCompras.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCompras.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCompras.Depth = 0;
            btnCompras.HighEmphasis = false;
            btnCompras.Icon = null;
            btnCompras.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCompras.Location = new Point(-6, 167);
            btnCompras.Margin = new Padding(4, 6, 4, 6);
            btnCompras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCompras.Name = "btnCompras";
            btnCompras.NoAccentTextColor = Color.Empty;
            btnCompras.Size = new Size(118, 33);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "compras";
            btnCompras.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCompras.UseAccentColor = false;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.None;
            btnVentas.AutoSize = false;
            btnVentas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVentas.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVentas.Depth = 0;
            btnVentas.HighEmphasis = false;
            btnVentas.Icon = null;
            btnVentas.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVentas.Location = new Point(-6, 122);
            btnVentas.Margin = new Padding(4, 6, 4, 6);
            btnVentas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVentas.Name = "btnVentas";
            btnVentas.NoAccentTextColor = Color.Empty;
            btnVentas.Size = new Size(118, 33);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "ventas";
            btnVentas.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVentas.UseAccentColor = false;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 

            // 
            // lblUsuarioActual
            // 
            lblUsuarioActual.Dock = DockStyle.Right;
            lblUsuarioActual.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioActual.ForeColor = SystemColors.GrayText;
            lblUsuarioActual.Location = new Point(911, 0);
            lblUsuarioActual.Name = "lblUsuarioActual";
            lblUsuarioActual.Size = new Size(214, 60);
            lblUsuarioActual.TabIndex = 0;
            lblUsuarioActual.Text = "Usuario: \r\nTipo de acceso:";
            lblUsuarioActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblEncabezado);
            panel2.Controls.Add(lblUsuarioActual);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 60);
            panel2.TabIndex = 4;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Left;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(327, 60);
            lblEncabezado.TabIndex = 1;
            lblEncabezado.Text = "Administrador de Empresa";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoScroll = true;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(143, 60);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(982, 548);
            panelContenedor.TabIndex = 5;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1125, 608);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formPricipal";
            WindowState = FormWindowState.Maximized;
            Load += formPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnInicio;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnVentas;
        private ReaLTaiizor.Controls.MaterialButton btnAcercaDe;
        private ReaLTaiizor.Controls.MaterialButton btnReportes;
        private ReaLTaiizor.Controls.MaterialButton btnClientes;
        private ReaLTaiizor.Controls.MaterialButton btnCompras;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private BindingSource usuarioBindingSource;
        private Label lblUsuarioActual;
        private Panel panel2;
        private Label lblEncabezado;
        private ReaLTaiizor.Controls.MaterialButton btnUsuarios;
        private Panel panelContenedor;
        private ReaLTaiizor.Controls.MaterialButton btnInventario;
    }
}