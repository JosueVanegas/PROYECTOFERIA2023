using CapaVista.FormConfiguracion;
using CapaVista.FormVenta;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.FormVentas
{
    public partial class FormPagar : MaterialForm
    {

        public FormPagar(Boolean Mod)
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
            btnNumberPunto.Tag = ".";
            btnAC.Tag = "AC";
            btnEliminar.Tag = "Eliminar";
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);

            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);


            }
        }

        private void checkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEfectivo.Checked)
            {
                checkTarjeta.Checked = false;
                txtPagoEfectivo.Visible = true;
                txtPagoTarjeta.Visible = false;
                btnNumberPunto.Visible = true;
            }

        }

        private void checkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTarjeta.Checked)
            {
                checkEfectivo.Checked = false;
                txtPagoEfectivo.Visible = false;
                txtPagoTarjeta.Visible = true;
                btnNumberPunto.Visible = false;
            }
        }

        // Evento de clic para los botones del 0 al 9 y el botón del punto decimal
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (txtPagoEfectivo.Visible)
            {
                txtPagoEfectivo.Text += boton.Tag.ToString();
            }
            if (txtPagoTarjeta.Visible)
            {
                txtPagoTarjeta.Text += boton.Tag.ToString();
            }
        }

        // Evento de clic para el botón "AC"
        private void BtnAC_Click(object sender, EventArgs e)
        {
            if (txtPagoEfectivo.Visible)
            {
                txtPagoEfectivo.Clear();
            }
            if (txtPagoTarjeta.Visible)
            {
                txtPagoTarjeta.Clear();
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtPagoEfectivo.Visible)
            {
                if (txtPagoEfectivo.Text.Length > 0)
                {
                    txtPagoEfectivo.Text = txtPagoEfectivo.Text.Remove(txtPagoEfectivo.Text.Length - 1);
                }
            }
            else if (txtPagoTarjeta.Visible)
            {
                if (txtPagoTarjeta.Text.Length > 0)
                {
                    txtPagoTarjeta.Text = txtPagoTarjeta.Text.Remove(txtPagoTarjeta.Text.Length - 1);
                }
            }
        }

        private void txtPagoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Permitir números, punto decimal, tecla de eliminar o suprimir, y teclas de control (copiar, pegar, etc.)
            if (!char.IsDigit(keyPressed) && keyPressed != '.' && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back && !char.IsControl(keyPressed))
            {
                e.Handled = true; // Evitar que se procese el carácter
            }

            // Si se ingresa un punto decimal y ya hay otro presente o es el primer carácter, evitar que se procese
            if ((keyPressed == '.' && (txtPagoEfectivo.Text.Contains(".") || txtPagoEfectivo.Text.Length == 0)))
            {
                e.Handled = true;
            }

            // Validar que solo se ingresen hasta 6 dígitos antes del punto decimal
            if (keyPressed != '.' && txtPagoEfectivo.Text.Contains("."))
            {
                int dotIndex = txtPagoEfectivo.Text.IndexOf('.');
                if (dotIndex != -1 && dotIndex < txtPagoEfectivo.Text.Length - 7)
                {
                    e.Handled = true;
                }
            }
        }



        private void txtPagoEfectivo_Leave(object sender, EventArgs e)
        {
            // Verificar si el texto es válido (es un número con hasta dos decimales y un solo punto decimal)
            if (decimal.TryParse(txtPagoEfectivo.Text, out decimal valor))
            {
                // Formatear el valor en el formato deseado (dos decimales y un punto decimal)
                txtPagoEfectivo.Text = valor.ToString("0.00");
            }

        }


        private void txtPagoTarjeta_Leave(object sender, EventArgs e)
        {
            // Eliminar los espacios en blanco actuales del texto del TextBox
            string textoActual = txtPagoTarjeta.Text.Replace(" ", "");

            // Crear un nuevo StringBuilder para formatear el texto en el formato de tarjeta
            StringBuilder formattedText = new StringBuilder();

            // Agregar espacios en blanco después de cada grupo de 4 dígitos
            for (int i = 0; i < textoActual.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                {
                    formattedText.Append(' '); // Agregar un espacio en blanco después de cada grupo de 4 dígitos
                }

                formattedText.Append(textoActual[i]); // Agregar el dígito actual al texto formateado
            }

            // Actualizar el texto del TextBox con el formato de tarjeta
            txtPagoTarjeta.Text = formattedText.ToString();

            // Mover el cursor al final del TextBox para evitar que se posicione al inicio después de cada cambio
            txtPagoTarjeta.SelectionStart = txtPagoTarjeta.Text.Length;
        }
        private void txtPagoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Permitir solo números y teclas de eliminación (Backspace y Delete)
            if (!char.IsDigit(keyPressed) && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true; // Evitar que se procese el carácter
            }

            // Permitir que el teclado funcione cuando el Shift, Control o Alt están presionados
            if (Control.ModifierKeys.HasFlag(Keys.Shift) || Control.ModifierKeys.HasFlag(Keys.Control) || Control.ModifierKeys.HasFlag(Keys.Alt))
            {
                e.Handled = false; // Permitir el carácter cuando una tecla modificadora está presionada
            }

            // Eliminar los espacios actuales del texto del TextBox para calcular la longitud sin espacios
            string textoActual = txtPagoTarjeta.Text.Replace(" ", "");

            // Limitar la longitud máxima del TextBox a 16 dígitos (sin contar los espacios)
            if (textoActual.Length >= 16 && keyPressed != (char)Keys.Back && keyPressed != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        public class Calculadora
        {
            public static string Sumar(decimal num1, decimal num2)
            {
                decimal resultado = num1 + num2;
                return FormatearNumero(resultado);
            }

            public static string Restar(decimal num1, decimal num2)
            {
                decimal resultado = num1 - num2;
                return FormatearNumero(resultado);
            }

            public static string Multiplicar(decimal num1, decimal num2)
            {
                decimal resultado = num1 * num2;
                return FormatearNumero(resultado);
            }

            private static string FormatearNumero(decimal numero)
            {
                // Si el número tiene dos decimales exactos, lo mostramos con dos decimales
                if (numero == Math.Floor(numero))
                {
                    return numero.ToString("F2");
                }
                // Si el número tiene más de dos decimales, redondeamos a dos decimales
                return Math.Round(numero, 2).ToString();
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal monto = formVentas.Monto;

            Boolean Confirmacion = false;
            String Mensaje = "";
            if (txtPagoEfectivo.Visible)
            {
                decimal pago = decimal.Parse(txtPagoEfectivo.Text);
                if (monto <= pago)
                {
                    Confirmacion = true;
                    txtCambioDeCompra.Text = Calculadora.Restar(pago, monto);
                    Mensaje = "Compra Exitosa";
                }
                if (monto > pago)
                {
                    Confirmacion = false;
                    txtCambioDeCompra.Text = "Pago es insuficiente";
                    Mensaje = "Pago es Insuficiente";
                }
            }


            if (txtPagoTarjeta.Visible)
            {
                txtCambioDeCompra.Text = "Pago aprobado";
                Mensaje = "Compra Exitosa";
            }
            FormConfVenta ConFV = new FormConfVenta(formConfiguraciones.Mod, Confirmacion, Mensaje);
            ConFV.ShowDialog();
        }
        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificamos si la tecla presionada es una letra o el carácter de borrar (delete)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra ni el carácter de borrar, cancelamos el evento KeyPress
                e.Handled = true;
            }
        }


    }
}





