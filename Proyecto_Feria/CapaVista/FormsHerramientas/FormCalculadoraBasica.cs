using ReaLTaiizor.Forms;

namespace CapaVista.FormsHerramientas
{
    public partial class FormCalculadoraBasica : MaterialForm
    {
        private string operador;
        private double numero1;
        private double numero2;
        private bool operadorPresionado;
        public FormCalculadoraBasica()
        {
            InitializeComponent();
            btnNumber0.Tag = "0";
            btnNumber1.Tag = "1";
            btnNumber2.Tag = "2";
            btnNumber3.Tag = "3";
            btnNumber4.Tag = "4";
            btnNumber5.Tag = "5";
            btnNumber6.Tag = "6";
            btnNumber7.Tag = "7";
            btnNumber8.Tag = "8";
            btnNumber9.Tag = "9";

            btnAC.Tag = "AC";
            btnEliminar.Tag = "Eliminar";

        }

        // Método para realizar las operaciones
        private double RealizarOperacion(string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    if (numero2 != 0)
                        return numero1 / numero2;
                    else
                        throw new DivideByZeroException("No se puede dividir entre cero.");
                default:
                    throw new ArgumentException("Operador no válido.");
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }


        }
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;


            txtResultado.Text += boton.Tag.ToString();

        }
        private void btnOperador_Click(object sender, EventArgs e)
        {
            // Manejar el clic de los botones de operación (+, -, *, /)
            if (double.TryParse(txtResultado.Text, out numero1))
            {
                Button botonOperador = (Button)sender;
                operador = (String)botonOperador.Tag;
                operadorPresionado = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Manejar el clic del botón de igual (=)
            if (double.TryParse(txtResultado.Text, out numero2))
            {
                try
                {
                    double resultado = RealizarOperacion(operador);
                    txtResultado.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    txtResultado.Text = "Error: " + ex.Message;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Manejar el clic del botón Limpiar (C)
            txtResultado.Text = "";
            numero1 = 0;
            numero2 = 0;
            operadorPresionado = false;
        }

        private void CalculadoraBasica_Load(object sender, EventArgs e)
        {

        }
    }
}
