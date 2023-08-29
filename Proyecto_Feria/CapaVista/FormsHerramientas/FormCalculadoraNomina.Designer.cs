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
            cbxEmpleados = new ReaLTaiizor.Controls.MaterialComboBox();
            txtSalarioNeto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtInss = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIr = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNetoARecibir = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblDeducciones = new Label();
            SuspendLayout();
            // 
            // cbxEmpleados
            // 
            cbxEmpleados.Anchor = AnchorStyles.Left;
            cbxEmpleados.AutoResize = false;
            cbxEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            cbxEmpleados.Depth = 0;
            cbxEmpleados.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEmpleados.DropDownHeight = 174;
            cbxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleados.DropDownWidth = 121;
            cbxEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEmpleados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEmpleados.FormattingEnabled = true;
            cbxEmpleados.Hint = "seleccione un empleado para tomar el salario";
            cbxEmpleados.IntegralHeight = false;
            cbxEmpleados.ItemHeight = 43;
            cbxEmpleados.Location = new Point(26, 12);
            cbxEmpleados.MaxDropDownItems = 4;
            cbxEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(373, 49);
            cbxEmpleados.StartIndex = 0;
            cbxEmpleados.TabIndex = 32;
            cbxEmpleados.SelectedIndexChanged += cbxEmpleados_SelectedIndexChanged;
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
            txtSalarioNeto.Hint = "Ingrese el salario o seleccione un empleado";
            txtSalarioNeto.LeadingIcon = null;
            txtSalarioNeto.Location = new Point(26, 67);
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
            txtSalarioNeto.Size = new Size(373, 48);
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
            txtInss.Location = new Point(26, 236);
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
            txtInss.Size = new Size(226, 48);
            txtInss.TabIndex = 34;
            txtInss.TabStop = false;
            txtInss.Text = "0.00";
            txtInss.TextAlign = HorizontalAlignment.Left;
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
            txtIr.Location = new Point(26, 290);
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
            txtIr.Size = new Size(226, 48);
            txtIr.TabIndex = 35;
            txtIr.TabStop = false;
            txtIr.Text = "0.00";
            txtIr.TextAlign = HorizontalAlignment.Left;
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
            txtNetoARecibir.Location = new Point(26, 344);
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
            txtNetoARecibir.Size = new Size(226, 48);
            txtNetoARecibir.TabIndex = 36;
            txtNetoARecibir.TabStop = false;
            txtNetoARecibir.Text = "0.00";
            txtNetoARecibir.TextAlign = HorizontalAlignment.Left;
            txtNetoARecibir.TrailingIcon = null;
            txtNetoARecibir.UseSystemPasswordChar = false;
            // 
            // lblDeducciones
            // 
            lblDeducciones.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeducciones.Location = new Point(26, 192);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(373, 41);
            lblDeducciones.TabIndex = 37;
            lblDeducciones.Text = "Deducciones:";
            // 
            // FormCalculadoraNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(lblDeducciones);
            Controls.Add(txtNetoARecibir);
            Controls.Add(txtIr);
            Controls.Add(txtInss);
            Controls.Add(txtSalarioNeto);
            Controls.Add(cbxEmpleados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCalculadoraNomina";
            Text = "Calculadora de deducciones";
            Load += FormCalculadoraNomina_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalarioNeto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtInss;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIr;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNetoARecibir;
        private Label lblDeducciones;
    }
}