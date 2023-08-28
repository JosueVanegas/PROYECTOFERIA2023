using CapaControlador;
using ReaLTaiizor.Forms;
using System.Data;

namespace CapaPresentacion.FormInformes
{
    public partial class FormInformes : MaterialForm
    {
        ControlInforme cInforme = new ControlInforme();
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            crearInforme();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
   
                

                
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir.
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void crearInforme()
        {

           
        }
    }
}

