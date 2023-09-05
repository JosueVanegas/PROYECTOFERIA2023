using ReaLTaiizor.Forms;

namespace CapaVista.FormContabilidad
{
    public partial class FormContabilidads : MaterialForm
    {
        bool excel = false;
        public FormContabilidads()
        {
            InitializeComponent();

        }

        private void tgExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (tgExcel.Checked == true)
            {
                tgPdf.Checked = false;
                excel = true;
            }
            else
            {
                tgPdf.Checked = true;
                excel = false;
            }
        }

        private void tgPdf_CheckedChanged(object sender, EventArgs e)
        {
            if (tgPdf.Checked == true)
            {
                tgExcel.Checked = false;
                excel = false;
            }
            else
            {
                tgExcel.Checked = true;
                excel = true;
            }
        }
    }
}
