using System.Drawing;
namespace CapaVista.FormConfiguracion
{
    partial class formConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguraciones));
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEntidadEmpresa = new RJCodeAdvance.RJControls.RJButton();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.Controls.Add(btnEntidadEmpresa, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(44, 48);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 26.086956F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(437, 149);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // btnEntidadEmpresa
            // 
            btnEntidadEmpresa.BackColor = Color.FromArgb(63, 63, 70);
            btnEntidadEmpresa.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEntidadEmpresa.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnEntidadEmpresa.BackgroundImage");
            btnEntidadEmpresa.BackgroundImageLayout = ImageLayout.Center;
            btnEntidadEmpresa.BorderColor = Color.PaleVioletRed;
            btnEntidadEmpresa.BorderRadius = 10;
            btnEntidadEmpresa.BorderSize = 0;
            btnEntidadEmpresa.FlatAppearance.BorderSize = 0;
            btnEntidadEmpresa.FlatStyle = FlatStyle.Flat;
            btnEntidadEmpresa.ForeColor = Color.White;
            btnEntidadEmpresa.Location = new System.Drawing.Point(3, 2);
            btnEntidadEmpresa.Margin = new Padding(3, 2, 3, 2);
            btnEntidadEmpresa.Name = "btnEntidadEmpresa";
            btnEntidadEmpresa.Size = new System.Drawing.Size(103, 145);
            btnEntidadEmpresa.TabIndex = 12;
            btnEntidadEmpresa.Text = "Entidad de la Empresa";
            btnEntidadEmpresa.TextAlign = ContentAlignment.BottomCenter;
            btnEntidadEmpresa.TextColor = System.Drawing.Color.White;
            btnEntidadEmpresa.UseVisualStyleBackColor = false;
            btnEntidadEmpresa.Click += btnEntidadEmpresa_Click;
            // 
            // formConfiguraciones
            // 
            ClientSize = new Size(936, 512);
            Controls.Add(tableLayoutPanel3);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "formConfiguraciones";
            Padding = new Padding(3, 0, 3, 3);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private RJCodeAdvance.RJControls.RJButton btnEntidadEmpresa;
    }
}