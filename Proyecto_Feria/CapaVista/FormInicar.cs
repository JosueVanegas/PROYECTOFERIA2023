using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormInicar : MaterialForm
    {
        private System.Windows.Forms.Timer timer;
        private int secondsElapsed = 0;
       
        public FormInicar()
        {

            InitializeComponent();
            InitializeTimer();
            
        }
      
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo (1000 milisegundos)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            // Actualizar la barra de progreso
            barraprogreso.Value = secondsElapsed * 100 / 20;

            if (secondsElapsed >= 20)
            {
                // Detener el temporizador
                timer.Stop();




                /// Josue para saber si es primer acceso
                if (true)
                {
                    FormaAjustesEntidad forms = new FormaAjustesEntidad(true);

                    forms.ShowDialog();
                }
                else
                {
                    formLogin login = new formLogin();
                    login.ShowDialog();
                }
                // Cerrar el formulario después de 20 segundos
                this.Close();


            }
        }


    }
}
