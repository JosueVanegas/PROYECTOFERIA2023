namespace CapaVista.FormVentas
{
    partial class FormBuscarProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarProductos));
            ProductosDataGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            Eliminar = new DataGridViewImageColumn();
            DescripcionData = new DataGridViewTextBoxColumn();
            PrecioVentaDataGrid = new DataGridViewTextBoxColumn();
            StockDataGrid = new DataGridViewTextBoxColumn();
            CantidadDataGrid = new DataGridViewTextBoxColumn();
            TotalDataGrid = new DataGridViewTextBoxColumn();
            IncrementoCantidadDataGrid = new DataGridViewImageColumn();
            DecrementoCantidadDataGrid = new DataGridViewImageColumn();
            ImageProducto = new DataGridViewImageColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAceptar = new RJCodeAdvance.RJControls.RJButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtbuscar = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            cbxBuscar = new ReaLTaiizor.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosDataGrid
            // 
            ProductosDataGrid.AllowUserToResizeRows = false;
            ProductosDataGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            ProductosDataGrid.BorderStyle = BorderStyle.None;
            ProductosDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductosDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDataGrid.Columns.AddRange(new DataGridViewColumn[] { Eliminar, DescripcionData, PrecioVentaDataGrid, StockDataGrid, CantidadDataGrid, TotalDataGrid, IncrementoCantidadDataGrid, DecrementoCantidadDataGrid, ImageProducto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductosDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            ProductosDataGrid.EnableHeadersVisualStyles = false;
            ProductosDataGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            ProductosDataGrid.GridColor = Color.FromArgb(255, 255, 255);
            ProductosDataGrid.Location = new Point(3, 56);
            ProductosDataGrid.Name = "ProductosDataGrid";
            ProductosDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductosDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ProductosDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProductosDataGrid.RowTemplate.Height = 25;
            ProductosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductosDataGrid.Size = new Size(902, 278);
            ProductosDataGrid.TabIndex = 52;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Image = Properties.Resources.eliminar;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            // 
            // DescripcionData
            // 
            DescripcionData.HeaderText = "Descripción";
            DescripcionData.Name = "DescripcionData";
            // 
            // PrecioVentaDataGrid
            // 
            PrecioVentaDataGrid.HeaderText = "Precio Venta";
            PrecioVentaDataGrid.Name = "PrecioVentaDataGrid";
            // 
            // StockDataGrid
            // 
            StockDataGrid.HeaderText = "Stock";
            StockDataGrid.Name = "StockDataGrid";
            // 
            // CantidadDataGrid
            // 
            CantidadDataGrid.HeaderText = "Cantidad";
            CantidadDataGrid.Name = "CantidadDataGrid";
            // 
            // TotalDataGrid
            // 
            TotalDataGrid.HeaderText = "Total";
            TotalDataGrid.Name = "TotalDataGrid";
            // 
            // IncrementoCantidadDataGrid
            // 
            IncrementoCantidadDataGrid.HeaderText = "";
            IncrementoCantidadDataGrid.Name = "IncrementoCantidadDataGrid";
            IncrementoCantidadDataGrid.Resizable = DataGridViewTriState.True;
            // 
            // DecrementoCantidadDataGrid
            // 
            DecrementoCantidadDataGrid.HeaderText = "";
            DecrementoCantidadDataGrid.Name = "DecrementoCantidadDataGrid";
            // 
            // ImageProducto
            // 
            ImageProducto.HeaderText = "";
            ImageProducto.Name = "ImageProducto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAceptar, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(ProductosDataGrid, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7270031F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.272995F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(908, 440);
            tableLayoutPanel1.TabIndex = 53;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(63, 63, 70);
            btnAceptar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnAceptar.BackgroundImage = (Image)resources.GetObject("btnAceptar.BackgroundImage");
            btnAceptar.BackgroundImageLayout = ImageLayout.Center;
            btnAceptar.BorderColor = Color.PaleVioletRed;
            btnAceptar.BorderRadius = 10;
            btnAceptar.BorderSize = 0;
            btnAceptar.Dock = DockStyle.Fill;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(3, 339);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(902, 99);
            btnAceptar.TabIndex = 56;
            btnAceptar.Text = "Agregar al carrito";
            btnAceptar.TextAlign = ContentAlignment.BottomCenter;
            btnAceptar.TextColor = Color.White;
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtbuscar);
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Controls.Add(cbxBuscar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(902, 47);
            flowLayoutPanel1.TabIndex = 55;
            // 
            // txtbuscar
            // 
            txtbuscar.AnimateReadOnly = true;
            txtbuscar.AutoCompleteMode = AutoCompleteMode.None;
            txtbuscar.AutoCompleteSource = AutoCompleteSource.None;
            txtbuscar.BackgroundImageLayout = ImageLayout.None;
            txtbuscar.CharacterCasing = CharacterCasing.Normal;
            txtbuscar.Depth = 0;
            txtbuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.HideSelection = true;
            txtbuscar.Hint = "Buscar";
            txtbuscar.LeadingIcon = null;
            txtbuscar.Location = new Point(3, 3);
            txtbuscar.MaxLength = 32767;
            txtbuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PasswordChar = '\0';
            txtbuscar.PrefixSuffixText = null;
            txtbuscar.ReadOnly = false;
            txtbuscar.RightToLeft = RightToLeft.No;
            txtbuscar.SelectedText = "";
            txtbuscar.SelectionLength = 0;
            txtbuscar.SelectionStart = 0;
            txtbuscar.ShortcutsEnabled = true;
            txtbuscar.Size = new Size(562, 48);
            txtbuscar.TabIndex = 57;
            txtbuscar.TabStop = false;
            txtbuscar.TextAlign = HorizontalAlignment.Center;
            txtbuscar.TrailingIcon = null;
            txtbuscar.UseSystemPasswordChar = false;
            txtbuscar.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(63, 63, 70);
            btnBuscar.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.BorderColor = Color.PaleVioletRed;
            btnBuscar.BorderRadius = 10;
            btnBuscar.BorderSize = 0;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(571, 8);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 39);
            btnBuscar.TabIndex = 59;
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextColor = Color.White;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbxBuscar
            // 
            cbxBuscar.Anchor = AnchorStyles.Left;
            cbxBuscar.AutoResize = false;
            cbxBuscar.BackColor = Color.FromArgb(255, 255, 255);
            cbxBuscar.Depth = 0;
            cbxBuscar.DrawMode = DrawMode.OwnerDrawVariable;
            cbxBuscar.DropDownHeight = 174;
            cbxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscar.DropDownWidth = 121;
            cbxBuscar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxBuscar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Hint = "Buscar producto";
            cbxBuscar.IntegralHeight = false;
            cbxBuscar.ItemHeight = 43;
            cbxBuscar.Items.AddRange(new object[] { "" });
            cbxBuscar.Location = new Point(618, 3);
            cbxBuscar.MaxDropDownItems = 4;
            cbxBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(275, 49);
            cbxBuscar.StartIndex = 0;
            cbxBuscar.TabIndex = 58;
            // 
            // FormBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 507);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormBuscarProductos";
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            Text = "Selecciona tus Productos";
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView ProductosDataGrid;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn DescripcionData;
        private DataGridViewTextBoxColumn PrecioVentaDataGrid;
        private DataGridViewTextBoxColumn StockDataGrid;
        private DataGridViewTextBoxColumn CantidadDataGrid;
        private DataGridViewTextBoxColumn TotalDataGrid;
        private DataGridViewImageColumn IncrementoCantidadDataGrid;
        private DataGridViewImageColumn DecrementoCantidadDataGrid;
        private DataGridViewImageColumn ImageProducto;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnAceptar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtbuscar;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private ReaLTaiizor.Controls.MaterialComboBox cbxBuscar;
    }
}