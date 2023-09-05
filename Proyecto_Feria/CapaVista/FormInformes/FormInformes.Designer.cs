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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            pkrFechaInicio = new RJCodeAdvance.RJControls.RJDatePicker();
            pkrFechaFin = new RJCodeAdvance.RJControls.RJDatePicker();
            btnPersonalizado = new RJCodeAdvance.RJControls.RJButton();
            panel2 = new Panel();
            btnMovimientoProductos = new RJCodeAdvance.RJControls.RJButton();
            label5 = new Label();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            tgPdf = new RJCodeAdvance.RJControls.RJToggleButton();
            label4 = new Label();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            tgExcel = new RJCodeAdvance.RJControls.RJToggleButton();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblEncabezado = new Label();
            btnNomina = new RJCodeAdvance.RJControls.RJButton();
            btnInforVentas = new RJCodeAdvance.RJControls.RJButton();
            PanelRangoreport = new Panel();
            label2 = new Label();
            btn15Dias = new RJCodeAdvance.RJControls.RJButton();
            btnAñoActual = new RJCodeAdvance.RJControls.RJButton();
            btnMesActual = new RJCodeAdvance.RJControls.RJButton();
            btnHoy = new RJCodeAdvance.RJControls.RJButton();
            btnAyer = new RJCodeAdvance.RJControls.RJButton();
            btnSemanaActual = new RJCodeAdvance.RJControls.RJButton();
            btninfoCompras = new RJCodeAdvance.RJControls.RJButton();
            btnInventario = new RJCodeAdvance.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelRangoreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pkrFechaInicio
            // 
            pkrFechaInicio.BorderColor = Color.PaleVioletRed;
            pkrFechaInicio.BorderSize = 0;
            pkrFechaInicio.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pkrFechaInicio.Format = DateTimePickerFormat.Short;
            pkrFechaInicio.Location = new Point(12, 321);
            pkrFechaInicio.MaxDate = new DateTime(2023, 9, 3, 0, 0, 0, 0);
            pkrFechaInicio.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            pkrFechaInicio.MinimumSize = new Size(0, 35);
            pkrFechaInicio.Name = "pkrFechaInicio";
            pkrFechaInicio.Size = new Size(145, 35);
            pkrFechaInicio.SkinColor = Color.DarkCyan;
            pkrFechaInicio.TabIndex = 0;
            pkrFechaInicio.TextColor = Color.White;
            pkrFechaInicio.Value = new DateTime(2023, 9, 3, 0, 0, 0, 0);
            pkrFechaInicio.ValueChanged += pkrFechaInicio_ValueChanged;
            // 
            // pkrFechaFin
            // 
            pkrFechaFin.BorderColor = Color.PaleVioletRed;
            pkrFechaFin.BorderSize = 0;
            pkrFechaFin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            pkrFechaFin.Format = DateTimePickerFormat.Short;
            pkrFechaFin.Location = new Point(12, 362);
            pkrFechaFin.MaxDate = new DateTime(2023, 9, 3, 0, 0, 0, 0);
            pkrFechaFin.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            pkrFechaFin.MinimumSize = new Size(0, 35);
            pkrFechaFin.Name = "pkrFechaFin";
            pkrFechaFin.Size = new Size(145, 35);
            pkrFechaFin.SkinColor = Color.LightSlateGray;
            pkrFechaFin.TabIndex = 4;
            pkrFechaFin.TextColor = Color.White;
            pkrFechaFin.Value = new DateTime(2023, 9, 3, 0, 0, 0, 0);
            // 
            // btnPersonalizado
            // 
            btnPersonalizado.BackColor = Color.FromArgb(74, 121, 121);
            btnPersonalizado.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnPersonalizado.BorderColor = Color.PaleVioletRed;
            btnPersonalizado.BorderRadius = 10;
            btnPersonalizado.BorderSize = 0;
            btnPersonalizado.FlatAppearance.BorderSize = 0;
            btnPersonalizado.FlatStyle = FlatStyle.Flat;
            btnPersonalizado.ForeColor = Color.White;
            btnPersonalizado.Location = new Point(12, 403);
            btnPersonalizado.Name = "btnPersonalizado";
            btnPersonalizado.Size = new Size(150, 40);
            btnPersonalizado.TabIndex = 8;
            btnPersonalizado.Text = "Personalizar";
            btnPersonalizado.TextColor = Color.White;
            btnPersonalizado.UseVisualStyleBackColor = false;
            btnPersonalizado.Click += ReporteFechaPersonaizado_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMovimientoProductos);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(hopePictureBox2);
            panel2.Controls.Add(tgPdf);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(hopePictureBox1);
            panel2.Controls.Add(tgExcel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblEncabezado);
            panel2.Controls.Add(btnNomina);
            panel2.Controls.Add(btnInforVentas);
            panel2.Controls.Add(PanelRangoreport);
            panel2.Controls.Add(btninfoCompras);
            panel2.Controls.Add(btnInventario);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(232, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 590);
            panel2.TabIndex = 12;
            // 
            // btnMovimientoProductos
            // 
            btnMovimientoProductos.BackColor = Color.FromArgb(74, 121, 121);
            btnMovimientoProductos.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnMovimientoProductos.BorderColor = Color.PaleVioletRed;
            btnMovimientoProductos.BorderRadius = 10;
            btnMovimientoProductos.BorderSize = 0;
            btnMovimientoProductos.FlatAppearance.BorderSize = 0;
            btnMovimientoProductos.FlatStyle = FlatStyle.Flat;
            btnMovimientoProductos.ForeColor = Color.White;
            btnMovimientoProductos.Image = (Image)resources.GetObject("btnMovimientoProductos.Image");
            btnMovimientoProductos.Location = new Point(176, 400);
            btnMovimientoProductos.Name = "btnMovimientoProductos";
            btnMovimientoProductos.Size = new Size(164, 71);
            btnMovimientoProductos.TabIndex = 87;
            btnMovimientoProductos.Text = "Movimientos de productos";
            btnMovimientoProductos.TextAlign = ContentAlignment.BottomCenter;
            btnMovimientoProductos.TextColor = Color.White;
            btnMovimientoProductos.UseVisualStyleBackColor = false;
            btnMovimientoProductos.Click += PanelRangoreport_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 169);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 86;
            label5.Text = "Pdf";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Image = (Image)resources.GetObject("hopePictureBox2.Image");
            hopePictureBox2.Location = new Point(20, 169);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(56, 50);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 85;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tgPdf
            // 
            tgPdf.AutoSize = true;
            tgPdf.Location = new Point(82, 197);
            tgPdf.MinimumSize = new Size(45, 22);
            tgPdf.Name = "tgPdf";
            tgPdf.OffBackColor = Color.Gray;
            tgPdf.OffToggleColor = Color.Gainsboro;
            tgPdf.OnBackColor = Color.Crimson;
            tgPdf.OnToggleColor = Color.WhiteSmoke;
            tgPdf.Size = new Size(45, 22);
            tgPdf.TabIndex = 84;
            tgPdf.UseVisualStyleBackColor = true;
            tgPdf.CheckedChanged += tgPdf_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 101);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 83;
            label4.Text = "Excel";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(20, 101);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(56, 50);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 82;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tgExcel
            // 
            tgExcel.AutoSize = true;
            tgExcel.Location = new Point(82, 129);
            tgExcel.MinimumSize = new Size(45, 22);
            tgExcel.Name = "tgExcel";
            tgExcel.OffBackColor = Color.Gray;
            tgExcel.OffToggleColor = Color.Gainsboro;
            tgExcel.OnBackColor = Color.Green;
            tgExcel.OnToggleColor = Color.WhiteSmoke;
            tgExcel.Size = new Size(45, 22);
            tgExcel.TabIndex = 80;
            tgExcel.UseVisualStyleBackColor = true;
            tgExcel.CheckedChanged += tgExcel_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 79;
            label3.Text = "Formato del informe";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 67);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 78;
            label1.Text = "Tipo de Informe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(517, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Dock = DockStyle.Top;
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(0, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(567, 43);
            lblEncabezado.TabIndex = 18;
            lblEncabezado.Text = "Generacion de Informe";
            lblEncabezado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = Color.FromArgb(74, 121, 121);
            btnNomina.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnNomina.BorderColor = Color.PaleVioletRed;
            btnNomina.BorderRadius = 10;
            btnNomina.BorderSize = 0;
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.ForeColor = Color.White;
            btnNomina.Image = (Image)resources.GetObject("btnNomina.Image");
            btnNomina.Location = new Point(176, 246);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(164, 71);
            btnNomina.TabIndex = 1;
            btnNomina.Text = "Nomina";
            btnNomina.TextAlign = ContentAlignment.BottomCenter;
            btnNomina.TextColor = Color.White;
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // btnInforVentas
            // 
            btnInforVentas.BackColor = Color.FromArgb(74, 121, 121);
            btnInforVentas.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnInforVentas.BorderColor = Color.PaleVioletRed;
            btnInforVentas.BorderRadius = 10;
            btnInforVentas.BorderSize = 0;
            btnInforVentas.FlatAppearance.BorderSize = 0;
            btnInforVentas.FlatStyle = FlatStyle.Flat;
            btnInforVentas.ForeColor = Color.White;
            btnInforVentas.Image = (Image)resources.GetObject("btnInforVentas.Image");
            btnInforVentas.Location = new Point(176, 92);
            btnInforVentas.Name = "btnInforVentas";
            btnInforVentas.Size = new Size(164, 71);
            btnInforVentas.TabIndex = 3;
            btnInforVentas.Text = "Informe de ventas";
            btnInforVentas.TextAlign = ContentAlignment.BottomCenter;
            btnInforVentas.TextColor = Color.White;
            btnInforVentas.UseVisualStyleBackColor = false;
            btnInforVentas.Click += PanelRangoreport_Click;
            // 
            // PanelRangoreport
            // 
            PanelRangoreport.BackColor = Color.Transparent;
            PanelRangoreport.Controls.Add(label2);
            PanelRangoreport.Controls.Add(btnPersonalizado);
            PanelRangoreport.Controls.Add(pkrFechaFin);
            PanelRangoreport.Controls.Add(pkrFechaInicio);
            PanelRangoreport.Controls.Add(btn15Dias);
            PanelRangoreport.Controls.Add(btnAñoActual);
            PanelRangoreport.Controls.Add(btnMesActual);
            PanelRangoreport.Controls.Add(btnHoy);
            PanelRangoreport.Controls.Add(btnAyer);
            PanelRangoreport.Controls.Add(btnSemanaActual);
            PanelRangoreport.Location = new Point(363, 59);
            PanelRangoreport.Name = "PanelRangoreport";
            PanelRangoreport.Size = new Size(175, 459);
            PanelRangoreport.TabIndex = 1;
            PanelRangoreport.Visible = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 39);
            label2.TabIndex = 79;
            label2.Text = "Periodo del informe";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn15Dias
            // 
            btn15Dias.BackColor = Color.FromArgb(74, 121, 121);
            btn15Dias.BackgroundColor = Color.FromArgb(74, 121, 121);
            btn15Dias.BorderColor = Color.PaleVioletRed;
            btn15Dias.BorderRadius = 10;
            btn15Dias.BorderSize = 0;
            btn15Dias.FlatAppearance.BorderSize = 0;
            btn15Dias.FlatStyle = FlatStyle.Flat;
            btn15Dias.ForeColor = Color.White;
            btn15Dias.Location = new Point(12, 182);
            btn15Dias.Name = "btn15Dias";
            btn15Dias.Size = new Size(150, 40);
            btn15Dias.TabIndex = 7;
            btn15Dias.Text = "Ultimos 15 Dias";
            btn15Dias.TextColor = Color.White;
            btn15Dias.UseVisualStyleBackColor = false;
            btn15Dias.Click += btn15Dias_Click;
            // 
            // btnAñoActual
            // 
            btnAñoActual.BackColor = Color.FromArgb(74, 121, 121);
            btnAñoActual.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnAñoActual.BorderColor = Color.PaleVioletRed;
            btnAñoActual.BorderRadius = 10;
            btnAñoActual.BorderSize = 0;
            btnAñoActual.FlatAppearance.BorderSize = 0;
            btnAñoActual.FlatStyle = FlatStyle.Flat;
            btnAñoActual.ForeColor = Color.White;
            btnAñoActual.Location = new Point(12, 275);
            btnAñoActual.Name = "btnAñoActual";
            btnAñoActual.Size = new Size(150, 40);
            btnAñoActual.TabIndex = 6;
            btnAñoActual.Text = "Año Actual";
            btnAñoActual.TextColor = Color.White;
            btnAñoActual.UseVisualStyleBackColor = false;
            btnAñoActual.Click += ReporteAñoActual_Click;
            // 
            // btnMesActual
            // 
            btnMesActual.BackColor = Color.FromArgb(74, 121, 121);
            btnMesActual.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnMesActual.BorderColor = Color.PaleVioletRed;
            btnMesActual.BorderRadius = 10;
            btnMesActual.BorderSize = 0;
            btnMesActual.FlatAppearance.BorderSize = 0;
            btnMesActual.FlatStyle = FlatStyle.Flat;
            btnMesActual.ForeColor = Color.White;
            btnMesActual.Location = new Point(12, 227);
            btnMesActual.Name = "btnMesActual";
            btnMesActual.Size = new Size(150, 40);
            btnMesActual.TabIndex = 1;
            btnMesActual.Text = "Mes Actual";
            btnMesActual.TextColor = Color.White;
            btnMesActual.UseVisualStyleBackColor = false;
            btnMesActual.Click += ReporteMesActual_Click;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.FromArgb(74, 121, 121);
            btnHoy.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnHoy.BorderColor = Color.PaleVioletRed;
            btnHoy.BorderRadius = 10;
            btnHoy.BorderSize = 0;
            btnHoy.FlatAppearance.BorderSize = 0;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.White;
            btnHoy.Location = new Point(12, 42);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(150, 40);
            btnHoy.TabIndex = 3;
            btnHoy.Text = "Hoy";
            btnHoy.TextColor = Color.White;
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += ReporteHoy_Click;
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.FromArgb(74, 121, 121);
            btnAyer.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnAyer.BorderColor = Color.PaleVioletRed;
            btnAyer.BorderRadius = 10;
            btnAyer.BorderSize = 0;
            btnAyer.FlatAppearance.BorderSize = 0;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.White;
            btnAyer.Location = new Point(12, 90);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(150, 40);
            btnAyer.TabIndex = 5;
            btnAyer.Text = "Ayer";
            btnAyer.TextColor = Color.White;
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += ReporteAyer_Click;
            // 
            // btnSemanaActual
            // 
            btnSemanaActual.BackColor = Color.FromArgb(74, 121, 121);
            btnSemanaActual.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnSemanaActual.BorderColor = Color.PaleVioletRed;
            btnSemanaActual.BorderRadius = 10;
            btnSemanaActual.BorderSize = 0;
            btnSemanaActual.FlatAppearance.BorderSize = 0;
            btnSemanaActual.FlatStyle = FlatStyle.Flat;
            btnSemanaActual.ForeColor = Color.White;
            btnSemanaActual.Location = new Point(12, 136);
            btnSemanaActual.Name = "btnSemanaActual";
            btnSemanaActual.Size = new Size(150, 40);
            btnSemanaActual.TabIndex = 0;
            btnSemanaActual.Text = "Semana actual";
            btnSemanaActual.TextColor = Color.White;
            btnSemanaActual.UseVisualStyleBackColor = false;
            btnSemanaActual.Click += FechaUltimaSemana_Click;
            // 
            // btninfoCompras
            // 
            btninfoCompras.BackColor = Color.FromArgb(74, 121, 121);
            btninfoCompras.BackgroundColor = Color.FromArgb(74, 121, 121);
            btninfoCompras.BorderColor = Color.PaleVioletRed;
            btninfoCompras.BorderRadius = 10;
            btninfoCompras.BorderSize = 0;
            btninfoCompras.FlatAppearance.BorderSize = 0;
            btninfoCompras.FlatStyle = FlatStyle.Flat;
            btninfoCompras.ForeColor = Color.White;
            btninfoCompras.Image = (Image)resources.GetObject("btninfoCompras.Image");
            btninfoCompras.Location = new Point(176, 169);
            btninfoCompras.Name = "btninfoCompras";
            btninfoCompras.Size = new Size(164, 71);
            btninfoCompras.TabIndex = 5;
            btninfoCompras.Text = "Informe de compras";
            btninfoCompras.TextAlign = ContentAlignment.BottomCenter;
            btninfoCompras.TextColor = Color.White;
            btninfoCompras.UseVisualStyleBackColor = false;
            btninfoCompras.Click += PanelRangoreport_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(74, 121, 121);
            btnInventario.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnInventario.BorderColor = Color.PaleVioletRed;
            btnInventario.BorderRadius = 10;
            btnInventario.BorderSize = 0;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(176, 323);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(164, 71);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Informe de inventario";
            btnInventario.TextAlign = ContentAlignment.BottomCenter;
            btnInventario.TextColor = Color.White;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(799, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 590);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 590);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 593);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormInformes";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.Manual;
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelRangoreport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaInicio;
        private RJCodeAdvance.RJControls.RJDatePicker pkrFechaFin;
        private RJCodeAdvance.RJControls.RJButton btnPersonalizado;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnNomina;
        private RJCodeAdvance.RJControls.RJButton btnInforVentas;
        private RJCodeAdvance.RJControls.RJButton btninfoCompras;
        private RJCodeAdvance.RJControls.RJButton btnInventario;
        private Panel PanelRangoreport;
        private RJCodeAdvance.RJControls.RJButton btn15Dias;
        private RJCodeAdvance.RJControls.RJButton btnAñoActual;
        private RJCodeAdvance.RJControls.RJButton btnMesActual;
        private RJCodeAdvance.RJControls.RJButton btnHoy;
        private RJCodeAdvance.RJControls.RJButton btnAyer;
        private RJCodeAdvance.RJControls.RJButton btnSemanaActual;
        private PictureBox pictureBox1;
        private Label lblEncabezado;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label5;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private RJCodeAdvance.RJControls.RJToggleButton tgPdf;
        private Label label4;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private RJCodeAdvance.RJControls.RJToggleButton tgExcel;
        private Label label3;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton btnMovimientoProductos;
    }
}