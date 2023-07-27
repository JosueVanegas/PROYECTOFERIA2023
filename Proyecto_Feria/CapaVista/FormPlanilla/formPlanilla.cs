﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormPlanilla;

public partial class formPlanilla : MaterialForm
{
    public formPlanilla(Boolean Mod)
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
            btnEmpleados.BackColor = Color.FromArgb(63, 63, 70);
            tableLayoutPanel1.BackColor = Color.FromArgb(21, 25, 31);
            panelContenedor.BackColor = Color.FromArgb(21, 25, 31);
        }
        if (!Mod)
        {
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
            //Modo Light
            btnEmpleados.BackColor = Color.FromArgb(242, 242, 242);
            tableLayoutPanel1.BackColor = Color.FromArgb(242, 242, 242);
            panelContenedor.BackColor = Color.FromArgb(242, 242, 242);

        }
    }
    private void OpenFormInPanel(object formHijo)
    {
        if (this.panelContenedor.Controls.Count > 0)
            this.panelContenedor.Controls.RemoveAt(0);


        Form fh = (Form)formHijo;
        fh.TopLevel = false;
        fh.FormBorderStyle = FormBorderStyle.None;
        fh.Dock = DockStyle.Fill;
        this.panelContenedor.Controls.Add(fh);
        this.panelContenedor.Tag = fh;
        fh.Show();
    }
    //Clicks
    private void btnEmpleados_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new formEmpleados(formConfiguraciones.Mod));
    }
    //Descripciones
    private void btnEmpleados_MouseHover(object sender, EventArgs e)
    {
        // Crear un objeto ToolTip
        ToolTip toolTip = new ToolTip();

        // Establecer el texto de la descripción
        toolTip.SetToolTip(btnEmpleados, "Empleados");
    }
}
