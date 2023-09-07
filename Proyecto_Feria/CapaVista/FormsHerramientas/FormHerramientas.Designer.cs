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
            btnGenerarCodigoBarra = new RJCodeAdvance.RJControls.RJButton();
            btnCalcularNomina = new RJCodeAdvance.RJControls.RJButton();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(677, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(256, 509);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(btnCalculadoraBasica, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCalcularNomina, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGenerarCodigoBarra, 0, 1);
            tableLayoutPanel1.Location = new Point(6, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
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
            btnCalculadoraBasica.BackgroundImageLayout = ImageLayout.Center;
            btnCalculadoraBasica.BorderColor = Color.PaleVioletRed;
            btnCalculadoraBasica.BorderRadius = 10;
            btnCalculadoraBasica.BorderSize = 0;
            btnCalculadoraBasica.Dock = DockStyle.Fill;
            btnCalculadoraBasica.FlatAppearance.BorderSize = 0;
            btnCalculadoraBasica.FlatStyle = FlatStyle.Flat;
            btnCalculadoraBasica.ForeColor = Color.White;
            btnCalculadoraBasica.Image = (Image)resources.GetObject("btnCalculadoraBasica.Image");
            btnCalculadoraBasica.Location = new Point(3, 2);
            btnCalculadoraBasica.Margin = new Padding(3, 2, 3, 2);
            btnCalculadoraBasica.Name = "btnCalculadoraBasica";
            btnCalculadoraBasica.Size = new Size(293, 234);
            btnCalculadoraBasica.TabIndex = 12;
            btnCalculadoraBasica.Text = "Calculadora Basica";
            btnCalculadoraBasica.TextAlign = ContentAlignment.BottomCenter;
            btnCalculadoraBasica.TextColor = Color.White;
            btnCalculadoraBasica.UseVisualStyleBackColor = false;
            btnCalculadoraBasica.Visible = false;
            btnCalculadoraBasica.Click += btnCalculadoraBasica_Click;
            // 
            // btnGenerarCodigoBarra
            // 
            btnGenerarCodigoBarra.BackColor = Color.FromArgb(74, 121, 121);
            btnGenerarCodigoBarra.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnGenerarCodigoBarra.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarCodigoBarra.BorderColor = Color.PaleVioletRed;
            btnGenerarCodigoBarra.BorderRadius = 10;
            btnGenerarCodigoBarra.BorderSize = 0;
            btnGenerarCodigoBarra.Dock = DockStyle.Fill;
            btnGenerarCodigoBarra.FlatAppearance.BorderSize = 0;
            btnGenerarCodigoBarra.FlatStyle = FlatStyle.Flat;
            btnGenerarCodigoBarra.ForeColor = Color.White;
            btnGenerarCodigoBarra.Image = (Image)resources.GetObject("btnGenerarCodigoBarra.Image");
            btnGenerarCodigoBarra.Location = new Point(3, 240);
            btnGenerarCodigoBarra.Margin = new Padding(3, 2, 3, 2);
            btnGenerarCodigoBarra.Name = "btnGenerarCodigoBarra";
            btnGenerarCodigoBarra.Size = new Size(293, 234);
            btnGenerarCodigoBarra.TabIndex = 19;
            btnGenerarCodigoBarra.Text = "Crear codigo de barra";
            btnGenerarCodigoBarra.TextAlign = ContentAlignment.BottomCenter;
            btnGenerarCodigoBarra.TextColor = Color.White;
            btnGenerarCodigoBarra.UseVisualStyleBackColor = false;
            btnGenerarCodigoBarra.Visible = false;
            btnGenerarCodigoBarra.Click += btnGenerarCodigoBarra_Click;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.BackColor = Color.FromArgb(74, 121, 121);
            btnCalcularNomina.BackgroundColor = Color.FromArgb(74, 121, 121);
            btnCalcularNomina.BackgroundImageLayout = ImageLayout.Center;
            btnCalcularNomina.BorderColor = Color.PaleVioletRed;
            btnCalcularNomina.BorderRadius = 10;
            btnCalcularNomina.BorderSize = 0;
            btnCalcularNomina.Dock = DockStyle.Fill;
            btnCalcularNomina.FlatAppearance.BorderSize = 0;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.ForeColor = Color.White;
            btnCalcularNomina.Image = (Image)resources.GetObject("btnCalcularNomina.Image");
            btnCalcularNomina.Location = new Point(302, 2);
            btnCalcularNomina.Margin = new Padding(3, 2, 3, 2);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Size = new Size(293, 234);
            btnCalcularNomina.TabIndex = 16;
            btnCalcularNomina.Text = "Calculadora de deducciones";
            btnCalcularNomina.TextAlign = ContentAlignment.BottomCenter;
            btnCalcularNomina.TextColor = Color.White;
            btnCalcularNomina.UseVisualStyleBackColor = false;
            btnCalcularNomina.Visible = false;
            btnCalcularNomina.Click += btnCalcularNomina_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(620, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 72;
            pictureBox4.TabStop = false;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
            // 
            // FormHerramientas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 512);
            Controls.Add(pictureBox4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormHerramientas";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormsHerramientasss";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RJCodeAdvance.RJControls.RJButton btnCalculadoraBasica;
        private RJCodeAdvance.RJControls.RJButton btnCalcularNomina;
        private RJCodeAdvance.RJControls.RJButton btnGenerarCodigoBarra;
        private PictureBox pictureBox4;
    }
}