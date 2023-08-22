using ReaLTaiizor.Forms;

namespace CapaVista.FormsHerramientas
{
    public partial class FormCalculadoraBasica : MaterialForm
    {
         string operador;
         decimal numero1;
         decimal numero2;
        public FormCalculadoraBasica()
        {
            InitializeComponent();

        }

        // Método para realizar las operaciones
        private void RealizarOperacion(string operacion)
        {
            decimal total = 0;
            numero2 = Convert.ToDecimal(txtResultado.Text);
            txtProceso.Text += " " + numero2;
            switch (operacion)
            {
                case "+":
                    total = numero1 + numero2;
                    txtResultado.Text = total.ToString();
                    break;
                case "-":
                    total = numero1 - numero2;
                    txtResultado.Text = total.ToString();
                    break;
                case "*":
                    total = numero1 * numero2;
                    txtResultado.Text = total.ToString();
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        total = numero1 / numero2;
                        txtResultado.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                    }
                    break;
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
            if (txtResultado.Text.Length <= 10)
            {
                if (sender.Equals(btnNumber0))
                {
                    txtResultado.Text += "0";
                }
                if (sender.Equals(btnNumber1))
                {
                    txtResultado.Text += "1";
                }
                if (sender.Equals(btnNumber2))
                {
                    txtResultado.Text += "2";
                }
                if (sender.Equals(btnNumber3))
                {
                    txtResultado.Text += "3";
                }
                if (sender.Equals(btnNumber4))
                {
                    txtResultado.Text += "4";
                }
                if (sender.Equals(btnNumber5))
                {
                    txtResultado.Text += "5";
                }
                if (sender.Equals(btnNumber6))
                {
                    txtResultado.Text += "6";
                }
                if (sender.Equals(btnNumber7))
                {
                    txtResultado.Text += "7";
                }
                if (sender.Equals(btnNumber8))
                {
                    txtResultado.Text += "8";
                }
                if (sender.Equals(btnNumber9))
                {
                    txtResultado.Text += "9";
                }
            }
        }
        private void btnOperador_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btnNumberMasMenos))
            {
                if (txtResultado.Text != "")
                {
                    decimal n = Convert.ToDecimal(txtResultado.Text);
                    n = n * -1;
                    txtResultado.Text = n.ToString();
                }
            }
            if (sender.Equals(btnMas))
            {
                numero1 = Convert.ToDecimal(txtResultado.Text);
                txtProceso.Text = numero1 + "+";
                txtResultado.Text = "";
                operador = "+";
            }
            if (sender.Equals(btnMenos))
            {
                numero1 = Convert.ToDecimal(txtResultado.Text);
                txtProceso.Text = numero1 + "-";
                txtResultado.Text = "";
                operador = "-";
            }
            if (sender.Equals(btnMulti))
            {
                numero1 = Convert.ToDecimal(txtResultado.Text);
                txtProceso.Text = numero1 + "*";
                txtResultado.Text = "";
                operador = "*";
            }
            if (sender.Equals(btnDiv))
            {
                numero1 = Convert.ToDecimal(txtResultado.Text);
                txtProceso.Text = numero1 + "/";
                txtResultado.Text = "";
                operador = "/";
            }
            if (sender.Equals(btnIgual))
            {
                if (txtResultado.Text != "")
                {
                    if(operador == "+")
                    {
                        RealizarOperacion("+");
                    }
                    if (operador == "-")
                    {
                        RealizarOperacion("-");
                    }
                    if (operador == "*")
                    {
                        RealizarOperacion("*");
                    }
                    if (operador == "/")
                    {
                        RealizarOperacion("/");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el segundo valor");
                }
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Manejar el clic del botón Limpiar (C)
            txtResultado.Text = "";
            txtProceso.Text = "";
            numero1 = 0;
            numero2 = 0;
            operador = "";
        }

        private void CalculadoraBasica_Load(object sender, EventArgs e)
        {

        }
    }
}
