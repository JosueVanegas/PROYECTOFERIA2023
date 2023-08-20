using ReaLTaiizor.Forms;

namespace CapaVista.FormsHerramientas
{
    public partial class FormCalcularDescuento : MaterialForm
    {
        public FormCalcularDescuento()
        {
            InitializeComponent();


        }



        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            // Manejar el clic del botón para calcular el descuento
            if (double.TryParse(txtPrecioOriginal.Text, out double precioOriginal) && double.TryParse(txtPorcentajeDescuento.Text, out double porcentajeDescuento))
            {
                if (porcentajeDescuento >= 0 && porcentajeDescuento <= 100)
                {
                    double descuento = precioOriginal * (porcentajeDescuento / 100);
                    double precioFinal = precioOriginal - descuento;

                    txtDescuento.Text = $"Descuento: {descuento:C2}";
                    txtPrecioFinal.Text = $"Precio final: {precioFinal:C2}";
                }
                else
                {
                    MessageBox.Show("El porcentaje de descuento debe estar entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
