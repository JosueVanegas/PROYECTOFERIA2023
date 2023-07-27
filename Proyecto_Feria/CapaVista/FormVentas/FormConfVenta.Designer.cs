namespace CapaVista.FormVentas
{
    partial class FormConfVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfVenta));
            pictureVentaConfirmada = new PictureBox();
            PictureVentaNoConfirmada = new PictureBox();
            lblTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureVentaConfirmada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureVentaNoConfirmada).BeginInit();
            SuspendLayout();
            // 
            // pictureVentaConfirmada
            // 
            pictureVentaConfirmada.Image = (Image)resources.GetObject("pictureVentaConfirmada.Image");
            pictureVentaConfirmada.Location = new Point(12, 37);
            pictureVentaConfirmada.MaximumSize = new Size(212, 178);
            pictureVentaConfirmada.MinimumSize = new Size(212, 178);
            pictureVentaConfirmada.Name = "pictureVentaConfirmada";
            pictureVentaConfirmada.Size = new Size(212, 178);
            pictureVentaConfirmada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVentaConfirmada.TabIndex = 0;
            pictureVentaConfirmada.TabStop = false;
            pictureVentaConfirmada.Visible = false;
            // 
            // PictureVentaNoConfirmada
            // 
            PictureVentaNoConfirmada.Image = (Image)resources.GetObject("PictureVentaNoConfirmada.Image");
            PictureVentaNoConfirmada.Location = new Point(12, 37);
            PictureVentaNoConfirmada.MaximumSize = new Size(212, 178);
            PictureVentaNoConfirmada.MinimumSize = new Size(212, 178);
            PictureVentaNoConfirmada.Name = "PictureVentaNoConfirmada";
            PictureVentaNoConfirmada.Size = new Size(212, 178);
            PictureVentaNoConfirmada.SizeMode = PictureBoxSizeMode.Zoom;
            PictureVentaNoConfirmada.TabIndex = 1;
            PictureVentaNoConfirmada.TabStop = false;
            PictureVentaNoConfirmada.Visible = false;
            // 
            // lblTxt
            // 
            lblTxt.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTxt.Location = new Point(6, 218);
            lblTxt.Name = "lblTxt";
            lblTxt.Size = new Size(224, 70);
            lblTxt.TabIndex = 25;
            lblTxt.Text = "txt";
            lblTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConfVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 291);
            Controls.Add(lblTxt);
            Controls.Add(PictureVentaNoConfirmada);
            Controls.Add(pictureVentaConfirmada);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormConfVenta";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            Text = "FormConfVenta";
            ((System.ComponentModel.ISupportInitialize)pictureVentaConfirmada).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureVentaNoConfirmada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureVentaConfirmada;
        private PictureBox PictureVentaNoConfirmada;
        private Label lblTxt;
    }
}