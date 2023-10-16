using ReaLTaiizor.Forms;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormInicar : MaterialForm
    {
        private System.Windows.Forms.Timer timer;
        private int secondsElapsed = 0;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormInicar()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {

            InitializeComponent();
            InitializeTimer();

        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo (1000 milisegundos)
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
            timer.Tick += Timer_Tick;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
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
                    FormaAjustesEntidad forms = new FormaAjustesEntidad();

                    forms.ShowDialog();
                }
                else
                {
#pragma warning disable CS0162 // Se detectó código inaccesible
                    formLogin login = new formLogin();
#pragma warning restore CS0162 // Se detectó código inaccesible
                    login.ShowDialog();
                }
                // Cerrar el formulario después de 20 segundos
                this.Close();


            }
        }


    }
}
