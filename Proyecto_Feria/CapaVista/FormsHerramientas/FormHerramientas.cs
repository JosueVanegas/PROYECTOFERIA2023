using CapaDatos;
using CapaPresentacion.FormsHerramientas;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CapaVista.FormsHerramientas
{
    public partial class FormHerramientas : MaterialForm
    {

        public FormHerramientas(Usuario Rol)
        {
            InitializeComponent();

            btnbitacora.Visible = true;
            btnCalculadoraBasica.Visible = true;

            btnCalcularNomina.Visible = true;
            btnGenerarCodigoBarra.Visible = true;
        }
        private void btnCalculadoraBasica_Click(object sender, EventArgs e)
        {
            FormCalculadoraBasica Ca = new FormCalculadoraBasica();
            Ca.Show();
        }

        private void btnGenerarCodigoBarra_Click(object sender, EventArgs e)
        {
            FormGenerarCodigoBarra GeneradorCodigo = new FormGenerarCodigoBarra();
            GeneradorCodigo.ShowDialog();
        }

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            FormCalculadoraNomina calNom = new FormCalculadoraNomina();
            calNom.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox4, "Bienvenido a la seccion de Herramienta de apoyo para nuestas tareas laborales");
        }
    }
}
