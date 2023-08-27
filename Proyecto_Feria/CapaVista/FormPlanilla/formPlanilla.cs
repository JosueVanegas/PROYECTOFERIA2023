using ReaLTaiizor.Forms;

namespace CapaVista.FormPlanilla;

public partial class formPlanilla : MaterialForm
{
    public formPlanilla()
    {
        InitializeComponent();
        OpenFormInPanel(new formEmpleados());
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
    private void btnEmpleados_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new formEmpleados());
    }
    private void btnEmpleados_MouseHover(object sender, EventArgs e)
    {
        ToolTip toolTip = new ToolTip();
        toolTip.SetToolTip(btnEmpleados, "Empleados");
    }
}
