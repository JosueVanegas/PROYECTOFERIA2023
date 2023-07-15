namespace CapaVista
{
    partial class formEmpleados
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
            lblEncabezado = new Label();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(362, 199);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(197, 48);
            lblEncabezado.TabIndex = 18;
            lblEncabezado.Text = "Empleados";
            lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 446);
            Controls.Add(lblEncabezado);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formEmpleados";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formEmpleados";
            ResumeLayout(false);
        }

        #endregion

        private Label lblEncabezado;
    }
}