﻿using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class formProductos : MaterialForm
    {

        public formProductos(Boolean Mod)
        {
            InitializeComponent();
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                tbProductos.BackgroundColor = Color.FromArgb(50, 50, 50);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                tbProductos.BackgroundColor = Color.White;

            }
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
            if ((keyPressed == '.' && (txtPrecioCompra.Text.Contains(".") || txtPrecioCompra.Text.Length == 0)))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioDeCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra != null)
            {
                // Si el último carácter es un punto decimal, eliminarlo
                if (txtPrecioCompra.Text.EndsWith("."))
                {
                    txtPrecioCompra.Text = txtPrecioCompra.Text.TrimEnd('.');
                }

                // Si no hay un punto decimal o si el último carácter es el punto decimal, añadir ".00" al final
                if (txtPrecioCompra.Text.IndexOf('.') == -1 || txtPrecioCompra.Text.EndsWith("."))
                {
                    txtPrecioCompra.Text += ".00";
                }
                // Si hay un punto decimal, pero solo un dígito después de él, agregar un cero adicional
                else if (txtPrecioCompra.Text.Length - txtPrecioCompra.Text.IndexOf('.') == 2)
                {
                    txtPrecioCompra.Text += "0";
                }
                // Si no hay dígitos después del punto decimal, agregar dos ceros adicionales
                else if (txtPrecioCompra.Text.Length - txtPrecioCompra.Text.IndexOf('.') == 1)
                {
                    txtPrecioCompra.Text += "00";
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
