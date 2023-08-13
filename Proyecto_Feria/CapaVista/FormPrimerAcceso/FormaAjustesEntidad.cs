using CapaVista.FormConfiguracion;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Text.RegularExpressions;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormaAjustesEntidad : MaterialForm
    {
        bool Acceso = true;
        bool Mod;
        public FormaAjustesEntidad(Boolean Dmod, Boolean Acceso)
        {
            InitializeComponent();
            this.Acceso = Acceso;
            this.Mod = Dmod;
            EstadoDeLaEntidad(this.Acceso);
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
            FormUsuarioInicial form = new FormUsuarioInicial(Mod);

            form.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (this.Acceso)
            {
                //Para FrmIniciar
                if (txtDireccion.Text != null && txtNombreEmpresa != null && pictureEmpresa.Image != null && cbxPais.Text != null)
                {
                    this.Close();
                    MessageBox.Show("Perfecto Datos Guarda a continuacion puedes iniciar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este elemento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        formLogin login = new formLogin();
                        login.ShowDialog();
                    }

                }
                else
                {
                    this.Close();
                    MessageBox.Show("Por favor completar cada uno de los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (!Acceso)
            {
                //Para formConfiguracion

                if (txtDireccion.Text != null && txtNombreEmpresa != null && pictureEmpresa.Image != null && cbxPais.Text != null)
                {
                    this.Close();
                    MessageBox.Show("Perfecto Datos Guarda a continuacion puedes iniciar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    this.Close();
                    MessageBox.Show("Por favor completar cada uno de los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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
