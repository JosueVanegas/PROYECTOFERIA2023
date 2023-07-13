namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void OpenFormInPanel(object formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);


            Form fh = (Form)formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }
        private void rjButton9_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new formUsuarios());
        }
    }
}
