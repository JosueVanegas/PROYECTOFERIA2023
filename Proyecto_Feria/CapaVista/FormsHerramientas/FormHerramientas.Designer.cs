namespace CapaVista.FormsHerramientas
{
    partial class FormHerramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHerramientas));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCalculadoraBasica = new RJCodeAdvance.RJControls.RJButton();
            btnCalcularDescuento = new RJCodeAdvance.RJControls.RJButton();
            btnIR = new RJCodeAdvance.RJControls.RJButton();
            btnbitacora = new RJCodeAdvance.RJControls.RJButton();
            btnCalcularNomina = new RJCodeAdvance.RJControls.RJButton();
            btnGenerarCodigoBarra = new RJCodeAdvance.RJControls.RJButton();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(649, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(284, 509);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(btnCalculadoraBasica, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCalcularDescuento, 1, 0);
            tableLayoutPanel1.Controls.Add(btnIR, 2, 0);
            tableLayoutPanel1.Controls.Add(btnbitacora, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCalcularNomina, 3, 0);
            tableLayoutPanel1.Controls.Add(btnGenerarCodigoBarra, 1, 1);
            tableLayoutPanel1.Location = new Point(21, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(598, 476);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCalculadoraBasica
            // 
            btnCalculadoraBasica.BackColor = Color.FromArgb(74, 121, 121);
            btnCalculadoraBasica.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnCalculadoraBasica.BackgroundImage = (Image)resources.GetObject("btnCalculadoraBasica.BackgroundImage");
            btnCalculadoraBasica.BackgroundImageLayout = ImageLayout.Center;
            btnCalculadoraBasica.BorderColor = Color.PaleVioletRed;
            btnCalculadoraBasica.BorderRadius = 10;
            btnCalculadoraBasica.BorderSize = 0;
            btnCalculadoraBasica.FlatAppearance.BorderSize = 0;
            btnCalculadoraBasica.FlatStyle = FlatStyle.Flat;
            btnCalculadoraBasica.ForeColor = Color.White;
            btnCalculadoraBasica.ImageAlign = ContentAlignment.MiddleRight;
            btnCalculadoraBasica.Location = new Point(3, 2);
            btnCalculadoraBasica.Margin = new Padding(3, 2, 3, 2);
            btnCalculadoraBasica.Name = "btnCalculadoraBasica";
            btnCalculadoraBasica.Size = new Size(143, 115);
            btnCalculadoraBasica.TabIndex = 12;
            btnCalculadoraBasica.Text = "Calculadora Basica";
            btnCalculadoraBasica.TextAlign = ContentAlignment.BottomCenter;
            btnCalculadoraBasica.TextColor = Color.White;
            btnCalculadoraBasica.UseVisualStyleBackColor = false;
            btnCalculadoraBasica.Visible = false;
            btnCalculadoraBasica.Click += btnCalculadoraBasica_Click;
            // 
            // btnCalcularDescuento
            // 
            btnCalcularDescuento.BackColor = Color.FromArgb(74, 121, 121);
            btnCalcularDescuento.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnCalcularDescuento.BackgroundImage = (Image)resources.GetObject("btnCalcularDescuento.BackgroundImage");
            btnCalcularDescuento.BackgroundImageLayout = ImageLayout.Center;
            btnCalcularDescuento.BorderColor = Color.PaleVioletRed;
            btnCalcularDescuento.BorderRadius = 10;
            btnCalcularDescuento.BorderSize = 0;
            btnCalcularDescuento.FlatAppearance.BorderSize = 0;
            btnCalcularDescuento.FlatStyle = FlatStyle.Flat;
            btnCalcularDescuento.ForeColor = Color.White;
            btnCalcularDescuento.ImageAlign = ContentAlignment.MiddleRight;
            btnCalcularDescuento.Location = new Point(152, 2);
            btnCalcularDescuento.Margin = new Padding(3, 2, 3, 2);
            btnCalcularDescuento.Name = "btnCalcularDescuento";
            btnCalcularDescuento.Size = new Size(143, 115);
            btnCalcularDescuento.TabIndex = 14;
            btnCalcularDescuento.Text = "Calcular Descuento";
            btnCalcularDescuento.TextAlign = ContentAlignment.BottomCenter;
            btnCalcularDescuento.TextColor = Color.White;
            btnCalcularDescuento.UseVisualStyleBackColor = false;
            btnCalcularDescuento.Visible = false;
            btnCalcularDescuento.Click += btnCalcularDescuento_Click;
            // 
            // btnIR
            // 
            btnIR.BackColor = Color.FromArgb(74, 121, 121);
            btnIR.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnIR.BackgroundImage = (Image)resources.GetObject("btnIR.BackgroundImage");
            btnIR.BackgroundImageLayout = ImageLayout.Center;
            btnIR.BorderColor = Color.PaleVioletRed;
            btnIR.BorderRadius = 10;
            btnIR.BorderSize = 0;
            btnIR.FlatAppearance.BorderSize = 0;
            btnIR.FlatStyle = FlatStyle.Flat;
            btnIR.ForeColor = Color.White;
            btnIR.ImageAlign = ContentAlignment.MiddleRight;
            btnIR.Location = new Point(301, 2);
            btnIR.Margin = new Padding(3, 2, 3, 2);
            btnIR.Name = "btnIR";
            btnIR.Size = new Size(143, 115);
            btnIR.TabIndex = 17;
            btnIR.Text = "Calcular IR";
            btnIR.TextAlign = ContentAlignment.BottomCenter;
            btnIR.TextColor = Color.White;
            btnIR.UseVisualStyleBackColor = false;
            btnIR.Visible = false;
            // 
            // btnbitacora
            // 
            btnbitacora.BackColor = Color.FromArgb(74, 121, 121);
            btnbitacora.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnbitacora.BackgroundImage = (Image)resources.GetObject("btnbitacora.BackgroundImage");
            btnbitacora.BackgroundImageLayout = ImageLayout.Center;
            btnbitacora.BorderColor = Color.PaleVioletRed;
            btnbitacora.BorderRadius = 10;
            btnbitacora.BorderSize = 0;
            btnbitacora.FlatAppearance.BorderSize = 0;
            btnbitacora.FlatStyle = FlatStyle.Flat;
            btnbitacora.ForeColor = Color.White;
            btnbitacora.ImageAlign = ContentAlignment.MiddleRight;
            btnbitacora.Location = new Point(3, 121);
            btnbitacora.Margin = new Padding(3, 2, 3, 2);
            btnbitacora.Name = "btnbitacora";
            btnbitacora.Size = new Size(143, 115);
            btnbitacora.TabIndex = 18;
            btnbitacora.Text = "Bitacora";
            btnbitacora.TextAlign = ContentAlignment.BottomCenter;
            btnbitacora.TextColor = Color.White;
            btnbitacora.UseVisualStyleBackColor = false;
            btnbitacora.Visible = false;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.BackColor = Color.FromArgb(74, 121, 121);
            btnCalcularNomina.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnCalcularNomina.BackgroundImage = (Image)resources.GetObject("btnCalcularNomina.BackgroundImage");
            btnCalcularNomina.BackgroundImageLayout = ImageLayout.Center;
            btnCalcularNomina.BorderColor = Color.PaleVioletRed;
            btnCalcularNomina.BorderRadius = 10;
            btnCalcularNomina.BorderSize = 0;
            btnCalcularNomina.FlatAppearance.BorderSize = 0;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.ForeColor = Color.White;
            btnCalcularNomina.ImageAlign = ContentAlignment.MiddleRight;
            btnCalcularNomina.Location = new Point(450, 2);
            btnCalcularNomina.Margin = new Padding(3, 2, 3, 2);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Size = new Size(143, 115);
            btnCalcularNomina.TabIndex = 16;
            btnCalcularNomina.Text = "Calcular Nomina";
            btnCalcularNomina.TextAlign = ContentAlignment.BottomCenter;
            btnCalcularNomina.TextColor = Color.White;
            btnCalcularNomina.UseVisualStyleBackColor = false;
            btnCalcularNomina.Visible = false;
            // 
            // btnGenerarCodigoBarra
            // 
            btnGenerarCodigoBarra.BackColor = Color.FromArgb(74, 121, 121);
            btnGenerarCodigoBarra.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGenerarCodigoBarra.BackgroundImage = (Image)resources.GetObject("btnGenerarCodigoBarra.BackgroundImage");
            btnGenerarCodigoBarra.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarCodigoBarra.BorderColor = Color.PaleVioletRed;
            btnGenerarCodigoBarra.BorderRadius = 10;
            btnGenerarCodigoBarra.BorderSize = 0;
            btnGenerarCodigoBarra.FlatAppearance.BorderSize = 0;
            btnGenerarCodigoBarra.FlatStyle = FlatStyle.Flat;
            btnGenerarCodigoBarra.ForeColor = Color.White;
            btnGenerarCodigoBarra.ImageAlign = ContentAlignment.MiddleRight;
            btnGenerarCodigoBarra.Location = new Point(152, 121);
            btnGenerarCodigoBarra.Margin = new Padding(3, 2, 3, 2);
            btnGenerarCodigoBarra.Name = "btnGenerarCodigoBarra";
            btnGenerarCodigoBarra.Size = new Size(143, 115);
            btnGenerarCodigoBarra.TabIndex = 19;
            btnGenerarCodigoBarra.Text = "Crear Codigo";
            btnGenerarCodigoBarra.TextAlign = ContentAlignment.BottomCenter;
            btnGenerarCodigoBarra.TextColor = Color.White;
            btnGenerarCodigoBarra.UseVisualStyleBackColor = false;
            btnGenerarCodigoBarra.Visible = false;
            btnGenerarCodigoBarra.Click += btnGenerarCodigoBarra_Click;
            // 
            // FormHerramientas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 512);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormHerramientas";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormsHerramientasss";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnCalculadoraBasica;
        private RJCodeAdvance.RJControls.RJButton btnCalcularDescuento;
        private RJCodeAdvance.RJControls.RJButton btnCalcularNomina;
        private RJCodeAdvance.RJControls.RJButton btnIR;
        private RJCodeAdvance.RJControls.RJButton btnbitacora;
        private RJCodeAdvance.RJControls.RJButton btnGenerarCodigoBarra;
    }
}