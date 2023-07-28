namespace CapaVista.FormPrimerAcceso
{
    partial class FormInicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicar));
            barraprogreso = new ReaLTaiizor.Controls.MaterialProgressBar();
            pictureEmpresa = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).BeginInit();
            SuspendLayout();
            // 
            // barraprogreso
            // 
            barraprogreso.Depth = 0;
            barraprogreso.Location = new Point(36, 199);
            barraprogreso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            barraprogreso.Name = "barraprogreso";
            barraprogreso.Size = new Size(314, 34);
            barraprogreso.TabIndex = 0;
            barraprogreso.UseAccentColor = false;
            // 
            // pictureEmpresa
            // 
            pictureEmpresa.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureEmpresa.BorderColor = Color.Black;
            pictureEmpresa.BorderColor2 = Color.Black;
            pictureEmpresa.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureEmpresa.BorderSize = 2;
            pictureEmpresa.GradientAngle = 50F;
            pictureEmpresa.Image = (Image)resources.GetObject("pictureEmpresa.Image");
            pictureEmpresa.Location = new Point(113, 14);
            pictureEmpresa.Name = "pictureEmpresa";
            pictureEmpresa.Size = new Size(161, 161);
            pictureEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEmpresa.TabIndex = 1;
            pictureEmpresa.TabStop = false;
            // 
            // FormInicar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 275);
            Controls.Add(pictureEmpresa);
            Controls.Add(barraprogreso);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            MaximumSize = new Size(396, 275);
            MinimumSize = new Size(396, 275);
            Name = "FormInicar";
            Padding = new Padding(3, 0, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicar";
            ((System.ComponentModel.ISupportInitialize)pictureEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialProgressBar barraprogreso;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pictureEmpresa;
    }
}