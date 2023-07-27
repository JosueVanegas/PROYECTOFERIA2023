using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.FormCalculos
{
    public partial class FormCalculos : MaterialForm
    {
        public FormCalculos(Boolean Mod)
        {
            InitializeComponent();
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                //Modo Dark
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                //Modo Light
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormCalculos));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEmpleados = new RJCodeAdvance.RJControls.RJButton();
            panelContenedor = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            panelMenu = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnGraficas = new RJCodeAdvance.RJControls.RJButton();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(63, 63, 70);
            btnEmpleados.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnEmpleados.BackgroundImageLayout = ImageLayout.Center;
            btnEmpleados.BorderColor = Color.PaleVioletRed;
            btnEmpleados.BorderRadius = 10;
            btnEmpleados.BorderSize = 0;
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(3, 2);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(27, 96);
            btnEmpleados.TabIndex = 9;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.TextColor = Color.White;
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(3, 0);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.MinimumSize = new Size(564, 272);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(930, 516);
            panelContenedor.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundColor = Color.FromArgb(63, 63, 70);
            rjButton1.BackgroundImageLayout = ImageLayout.Center;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.Dock = DockStyle.Fill;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Image = (Image)resources.GetObject("rjButton1.Image");
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.Location = new Point(3, 2);
            rjButton1.Margin = new Padding(3, 2, 3, 2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(27, 96);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Empleados";
            rjButton1.TextAlign = ContentAlignment.MiddleRight;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(21, 25, 31);
            panelMenu.Controls.Add(tableLayoutPanel3);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(930, 52);
            panelMenu.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.Controls.Add(btnGraficas, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(930, 52);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnGraficas
            // 
            btnGraficas.BackColor = Color.FromArgb(63, 63, 70);
            btnGraficas.BackgroundColor = Color.FromArgb(63, 63, 70);
            btnGraficas.BackgroundImageLayout = ImageLayout.Center;
            btnGraficas.BorderColor = Color.PaleVioletRed;
            btnGraficas.BorderRadius = 10;
            btnGraficas.BorderSize = 0;
            btnGraficas.Dock = DockStyle.Fill;
            btnGraficas.FlatAppearance.BorderSize = 0;
            btnGraficas.FlatStyle = FlatStyle.Flat;
            btnGraficas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGraficas.ForeColor = Color.White;
            btnGraficas.Image = (Image)resources.GetObject("btnGraficas.Image");
            btnGraficas.ImageAlign = ContentAlignment.MiddleLeft;
            btnGraficas.Location = new Point(3, 2);
            btnGraficas.Margin = new Padding(3, 2, 3, 2);
            btnGraficas.Name = "btnGraficas";
            btnGraficas.Size = new Size(148, 48);
            btnGraficas.TabIndex = 9;
            btnGraficas.Text = "Graficas";
            btnGraficas.TextAlign = ContentAlignment.MiddleRight;
            btnGraficas.TextColor = Color.White;
            btnGraficas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 25, 31);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MinimumSize = new Size(564, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 464);
            panel1.TabIndex = 5;
            // 
            // FormCalculos
            // 
            ClientSize = new Size(936, 519);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "FormCalculos";
            Padding = new Padding(3, 0, 3, 3);
            panelMenu.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
