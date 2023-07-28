using CapaVista.FormConfiguracion;
using Microsoft.Identity.Client;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormaAjustesEntidad : MaterialForm
    {

        public FormaAjustesEntidad(Boolean Mod,Boolean Acceso)
        {
            InitializeComponent();
            EstadoDeLaEntidad(Acceso) ;
            MaterialSkinManager manager;
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.EnforceBackcolorOnAllComponents = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 22);
            lblUsuario.Font = new Font("Microsoft Sans Serif", 12);
            if (Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
                lblTitulo.Font = new Font("Microsoft Sans Serif", 22);
                lblUsuario.Font = new Font("Microsoft Sans Serif", 12);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                lblTitulo.Font = new Font("Microsoft Sans Serif", 22);
                lblUsuario.Font = new Font("Microsoft Sans Serif", 12);

            }


        }
        public Boolean EstadoDeLaEntidad(Boolean Acceso)
        {
            Boolean Confirmacion = true;
            //Confirmacion si es de primer acceso verificamos en la tabla de entidad de la empresa esta en null
            //tiene que caer en el primer If y asi con su opuesto en el cual lo vamos usar para las configuraciones en
            //Cual podemos cambiar los valores de la entidad de la misma;

            if (Acceso)
            {
                Confirmacion = true;
                this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
                btnUsuario.Visible = true;
                lblUsuario.Visible = true;
            }
            if (!Acceso)
            {
                Confirmacion |= false;
                this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
                btnUsuario.Visible = false;
                lblUsuario.Visible = false;
            }


            return Confirmacion;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarioInicial form = new FormUsuarioInicial(formConfiguraciones.Mod);

            form.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text != null && txtNombreEmpresa != null && pictureEmpresa.Image != null && cbxPais.Text != null)
            {
                this.Close();
                formLogin login = new formLogin();
                login.ShowDialog();
            }
            else
            {
                this.Close();
                MessageBox.Show("Por favor completar cada uno de los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formLogin login = new formLogin();
                login.ShowDialog();
            }
        }

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPais.SelectedValue == "Nicaragua")
            {
                cbxDepartamento.Visible = true;

            }
            if (!(cbxPais.SelectedValue == "Nicaragua"))
            {
                //SI no es de nicaragua ponele espacio en blanco xd
                cbxDepartamento.Visible = false;
            }

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }
        private void materialTextBoxEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar la entrada solo al presionar la tecla de retorno
            if (e.KeyChar == (char)Keys.Enter)
            {
                System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
                if (textBox != null)
                {
                    string input = textBox.Text.Trim();
                    if (IsValidEmail(input))
                    {
                        MessageBox.Show("Correo electrónico válido.");
                    }
                    else
                    {
                        MessageBox.Show("Correo electrónico inválido.");
                    }
                }
                bool IsValidEmail(string email)
                {
                    // Utilizar una expresión regular para validar el formato del correo electrónico
                    string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                    Regex regex = new Regex(pattern);
                    return regex.IsMatch(email);
                }
            }
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }
        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }

            // Verificar la longitud de la entrada
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }
    }
}
