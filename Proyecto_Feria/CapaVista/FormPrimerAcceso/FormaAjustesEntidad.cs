using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace CapaVista.FormPrimerAcceso
{
    public partial class FormaAjustesEntidad : MaterialForm
    {
        bool Acceso = true;

        public FormaAjustesEntidad(Boolean Acceso)
        {
            InitializeComponent();

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
            FormUsuarioInicial form = new FormUsuarioInicial();

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
#pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cbxPais.SelectedValue == "Nicaragua")
            {
                cbxDepartamento.Visible = true;

            }
#pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
#pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (!(cbxPais.SelectedValue == "Nicaragua"))
            {
                //SI no es de nicaragua ponele espacio en blanco xd
                cbxDepartamento.Visible = false;
            }
#pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión

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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
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
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(pictureBox4, "Bienvenido a la configuracion de la Identidad\n" +
                                            "Para Configurar la entidad de la empresa:\n" +
                                            "1. Seleccionar el logotipo de la identidad\n" +
                                            "2. Ingresar el nombre de la Entidad" +
                                            "3. Ingresar el Paies ( si ha seleccionado nicaragua Selecione el Departamento)\n" +
                                            "4. Ingrese el correo electronico de la empresa\n" +
                                            "5. Ingrese el numero telefonico de la empresa\n" +
                                            "'Guarda' La informacion de la Entidad");
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            if (textBox != null && textBox.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se procese el carácter
            }
        }

        private void lblUsuario_MouseHover(object sender, EventArgs e)
        {
            // Crear un objeto ToolTip
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            // Establecer el icono de información (puedes cambiar el icono si lo deseas)
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            // Establecer el texto de la descripción
            toolTip.SetToolTip(lblUsuario, "Si es primer acceso, por favor crear un usuario de Tipo \n" +
                                           "administrador para poder acceder al programa y sus funciones");
            toolTip.SetToolTip(btnUsuario, "Si es primer acceso, por favor crear un usuario de Tipo \n" +
                                           "administrador para poder acceder al programa y sus funciones");
        }
    }
}
