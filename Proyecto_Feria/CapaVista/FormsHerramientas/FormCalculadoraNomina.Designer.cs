namespace CapaPresentacion.FormsHerramientas
{
    partial class FormCalculadoraNomina
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
            txtSalarioNeto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtInss = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIr = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNetoARecibir = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblDeducciones = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSalarioNeto
            // 
            txtSalarioNeto.AnimateReadOnly = false;
            txtSalarioNeto.AutoCompleteMode = AutoCompleteMode.None;
            txtSalarioNeto.AutoCompleteSource = AutoCompleteSource.None;
            txtSalarioNeto.BackgroundImageLayout = ImageLayout.None;
            txtSalarioNeto.CharacterCasing = CharacterCasing.Normal;
            txtSalarioNeto.Depth = 0;
            txtSalarioNeto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalarioNeto.HideSelection = true;
            txtSalarioNeto.Hint = "ingrese un salario devengado";
            txtSalarioNeto.LeadingIcon = null;
            txtSalarioNeto.Location = new Point(6, 77);
            txtSalarioNeto.MaxLength = 32767;
            txtSalarioNeto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalarioNeto.Name = "txtSalarioNeto";
            txtSalarioNeto.PasswordChar = '\0';
            txtSalarioNeto.PrefixSuffixText = null;
            txtSalarioNeto.ReadOnly = false;
            txtSalarioNeto.RightToLeft = RightToLeft.No;
            txtSalarioNeto.SelectedText = "";
            txtSalarioNeto.SelectionLength = 0;
            txtSalarioNeto.SelectionStart = 0;
            txtSalarioNeto.ShortcutsEnabled = true;
            txtSalarioNeto.Size = new Size(240, 48);
            txtSalarioNeto.TabIndex = 33;
            txtSalarioNeto.TabStop = false;
            txtSalarioNeto.TextAlign = HorizontalAlignment.Left;
            txtSalarioNeto.TrailingIcon = null;
            txtSalarioNeto.UseSystemPasswordChar = false;
            txtSalarioNeto.KeyPress += txtSalarioNeto_KeyPress;
            txtSalarioNeto.TextChanged += txtSalarioNeto_TextChanged;
            // 
            // txtInss
            // 
            txtInss.AnimateReadOnly = false;
            txtInss.AutoCompleteMode = AutoCompleteMode.None;
            txtInss.AutoCompleteSource = AutoCompleteSource.None;
            txtInss.BackgroundImageLayout = ImageLayout.None;
            txtInss.CharacterCasing = CharacterCasing.Normal;
            txtInss.Depth = 0;
            txtInss.Enabled = false;
            txtInss.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInss.HideSelection = true;
            txtInss.Hint = "INSS:";
            txtInss.LeadingIcon = null;
            txtInss.Location = new Point(6, 188);
            txtInss.MaxLength = 32767;
            txtInss.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtInss.Name = "txtInss";
            txtInss.PasswordChar = '\0';
            txtInss.PrefixSuffixText = null;
            txtInss.ReadOnly = false;
            txtInss.RightToLeft = RightToLeft.No;
            txtInss.SelectedText = "";
            txtInss.SelectionLength = 0;
            txtInss.SelectionStart = 0;
            txtInss.ShortcutsEnabled = true;
            txtInss.Size = new Size(240, 48);
            txtInss.TabIndex = 34;
            txtInss.TabStop = false;
            txtInss.Text = "0.00";
            txtInss.TextAlign = HorizontalAlignment.Center;
            txtInss.TrailingIcon = null;
            txtInss.UseSystemPasswordChar = false;
            // 
            // txtIr
            // 
            txtIr.AnimateReadOnly = false;
            txtIr.AutoCompleteMode = AutoCompleteMode.None;
            txtIr.AutoCompleteSource = AutoCompleteSource.None;
            txtIr.BackgroundImageLayout = ImageLayout.None;
            txtIr.CharacterCasing = CharacterCasing.Normal;
            txtIr.Depth = 0;
            txtIr.Enabled = false;
            txtIr.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIr.HideSelection = true;
            txtIr.Hint = "IR:";
            txtIr.LeadingIcon = null;
            txtIr.Location = new Point(6, 242);
            txtIr.MaxLength = 32767;
            txtIr.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIr.Name = "txtIr";
            txtIr.PasswordChar = '\0';
            txtIr.PrefixSuffixText = null;
            txtIr.ReadOnly = false;
            txtIr.RightToLeft = RightToLeft.No;
            txtIr.SelectedText = "";
            txtIr.SelectionLength = 0;
            txtIr.SelectionStart = 0;
            txtIr.ShortcutsEnabled = true;
            txtIr.Size = new Size(240, 48);
            txtIr.TabIndex = 35;
            txtIr.TabStop = false;
            txtIr.Text = "0.00";
            txtIr.TextAlign = HorizontalAlignment.Center;
            txtIr.TrailingIcon = null;
            txtIr.UseSystemPasswordChar = false;
            // 
            // txtNetoARecibir
            // 
            txtNetoARecibir.AnimateReadOnly = false;
            txtNetoARecibir.AutoCompleteMode = AutoCompleteMode.None;
            txtNetoARecibir.AutoCompleteSource = AutoCompleteSource.None;
            txtNetoARecibir.BackgroundImageLayout = ImageLayout.None;
            txtNetoARecibir.CharacterCasing = CharacterCasing.Normal;
            txtNetoARecibir.Depth = 0;
            txtNetoARecibir.Enabled = false;
            txtNetoARecibir.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNetoARecibir.HideSelection = true;
            txtNetoARecibir.Hint = "SALARIO NETO A PAGAR:";
            txtNetoARecibir.LeadingIcon = null;
            txtNetoARecibir.Location = new Point(6, 296);
            txtNetoARecibir.MaxLength = 32767;
            txtNetoARecibir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNetoARecibir.Name = "txtNetoARecibir";
            txtNetoARecibir.PasswordChar = '\0';
            txtNetoARecibir.PrefixSuffixText = null;
            txtNetoARecibir.ReadOnly = false;
            txtNetoARecibir.RightToLeft = RightToLeft.No;
            txtNetoARecibir.SelectedText = "";
            txtNetoARecibir.SelectionLength = 0;
            txtNetoARecibir.SelectionStart = 0;
            txtNetoARecibir.ShortcutsEnabled = true;
            txtNetoARecibir.Size = new Size(240, 48);
            txtNetoARecibir.TabIndex = 36;
            txtNetoARecibir.TabStop = false;
            txtNetoARecibir.Text = "0.00";
            txtNetoARecibir.TextAlign = HorizontalAlignment.Center;
            txtNetoARecibir.TrailingIcon = null;
            txtNetoARecibir.UseSystemPasswordChar = false;
            // 
            // lblDeducciones
            // 
            lblDeducciones.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeducciones.Location = new Point(6, 144);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(240, 41);
            lblDeducciones.TabIndex = 37;
            lblDeducciones.Text = "Deducciones:";
            lblDeducciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 38;
            label1.Text = "Salario devengado:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCalculadoraNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 367);
            Controls.Add(label1);
            Controls.Add(lblDeducciones);
            Controls.Add(txtNetoARecibir);
            Controls.Add(txtIr);
            Controls.Add(txtInss);
            Controls.Add(txtSalarioNeto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "FormCalculadoraNomina";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de deducciones";
            Load += FormCalculadoraNomina_Load;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalarioNeto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtInss;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIr;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNetoARecibir;
        private Label lblDeducciones;
        private Label label1;
    }
}