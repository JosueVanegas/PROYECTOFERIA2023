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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVista
{
    public partial class formCompras : MaterialForm
    {
        private readonly MaterialSkinManager manager;
        public formCompras()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox1, "Descripción del PictureBox");
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnLimpiar, "Limpiar");
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el texto de la descripción
            toolTip.SetToolTip(btnLimpiar, "Eliminar");
        }

        private void txtPrecioDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Permitir números, punto decimal, tecla de eliminar o suprimir, y teclas de control (copiar, pegar, etc.)
            if (!char.IsDigit(keyPressed) && keyPressed != '.' && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back && !char.IsControl(keyPressed))
            {
                e.Handled = true; // Evitar que se procese el carácter
            }

            // Si se ingresa un punto decimal y ya hay otro presente o es el primer carácter, evitar que se procese
            if ((keyPressed == '.' && (txtPrecioDeCompra.Text.Contains(".") || txtPrecioDeCompra.Text.Length == 0)))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioDeCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioDeCompra != null)
            {
                // Si el último carácter es un punto decimal, eliminarlo
                if (txtPrecioDeCompra.Text.EndsWith("."))
                {
                    txtPrecioDeCompra.Text = txtPrecioDeCompra.Text.TrimEnd('.');
                }

                // Si no hay un punto decimal o si el último carácter es el punto decimal, añadir ".00" al final
                if (txtPrecioDeCompra.Text.IndexOf('.') == -1 || txtPrecioDeCompra.Text.EndsWith("."))
                {
                    txtPrecioDeCompra.Text += ".00";
                }
                // Si hay un punto decimal, pero solo un dígito después de él, agregar un cero adicional
                else if (txtPrecioDeCompra.Text.Length - txtPrecioDeCompra.Text.IndexOf('.') == 2)
                {
                    txtPrecioDeCompra.Text += "0";
                }
                // Si no hay dígitos después del punto decimal, agregar dos ceros adicionales
                else if (txtPrecioDeCompra.Text.Length - txtPrecioDeCompra.Text.IndexOf('.') == 1)
                {
                    txtPrecioDeCompra.Text += "00";
                }
            }


        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Permitir números, punto decimal, tecla de eliminar o suprimir, y teclas de control (copiar, pegar, etc.)
            if (!char.IsDigit(keyPressed) && keyPressed != '.' && keyPressed != (char)Keys.Delete && keyPressed != (char)Keys.Back && !char.IsControl(keyPressed))
            {
                e.Handled = true; // Evitar que se procese el carácter
            }

            // Si se ingresa un punto decimal y ya hay otro presente o es el primer carácter, evitar que se procese
            if ((keyPressed == '.' && (txtPrecioVenta.Text.Contains(".") || txtPrecioVenta.Text.Length == 0)))
            {
                e.Handled = true;
            }

            // Validar que solo se ingresen hasta 6 dígitos antes del punto decimal
            if (keyPressed != '.' && txtPrecioVenta.Text.Contains("."))
            {
                int dotIndex = txtPrecioVenta.Text.IndexOf('.');
                if (dotIndex != -1 && dotIndex < txtPrecioVenta.Text.Length - 7)
                {
                    e.Handled = true;
                }
            }
        }


        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta != null)
            {
                // Si el último carácter es un punto decimal, eliminarlo
                if (txtPrecioVenta.Text.EndsWith("."))
                {
                    txtPrecioVenta.Text = txtPrecioVenta.Text.TrimEnd('.');
                }

                // Si no hay un punto decimal o si el último carácter es el punto decimal, añadir ".00" al final
                if (txtPrecioVenta.Text.IndexOf('.') == -1 || txtPrecioVenta.Text.EndsWith("."))
                {
                    txtPrecioVenta.Text += ".00";
                }
                // Si hay un punto decimal, pero solo un dígito después de él, agregar un cero adicional
                else if (txtPrecioVenta.Text.Length - txtPrecioVenta.Text.IndexOf('.') == 2)
                {
                    txtPrecioVenta.Text += "0";
                }
                // Si no hay dígitos después del punto decimal, agregar dos ceros adicionales
                else if (txtPrecioVenta.Text.Length - txtPrecioVenta.Text.IndexOf('.') == 1)
                {
                    txtPrecioVenta.Text += "00";
                }
            }
        }


    }

}

