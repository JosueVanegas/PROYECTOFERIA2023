using CapaControlador;
using CapaDatos;
using CapaPresentacion.FormUsuarios;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVista
{
    public partial class formUsuarios : MaterialForm
    {
        ControlUsuario controlUsuario = new ControlUsuario();
        bool EmpleadoNulo = false;
        public formUsuarios()
        {
            InitializeComponent();
        }
        private void formUsuarios_Load(object sender, EventArgs e)
        {
            mostarEmpleados();
            mostrarRoles();
            mostrarUsuarios();
        }
        public void mostrarRoles()
        {
            cbxRol.DataSource = controlUsuario.listarRoles();
        }
        public void mostarEmpleados()
        {
            cbxEmpleados.DataSource = controlUsuario.listarEmpleados();
        }
        private void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtIdUsuario.Text = "0";
            txtBuscar.Text = "";
            txtConfirmarClave.Text = "";
        }
        private bool validarCampos()
        {
            bool continuar = false;
            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                continuar = true;
            }
            return continuar;
        }
        private void mostrarUsuarios()
        {
            List<Modelos.Usuario> lista = controlUsuario.listarUsuarios();
            tbUsuarios.Rows.Clear();
            foreach (Modelos.Usuario c in lista)
            {
                if (c.ID != 1)
                {

                    int index = tbUsuarios.Rows.Add("", "", c.ID, c.EMPLEADO.ID, c.ROL.ID, c.NOMBRE, c.EMPLEADO.NOMBRE, c.ROL.NOMBRE);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            registrarUsuario();
        }
        private void registrarUsuario()
        {
            int rolU = 0;
            if (validarCampos() == true)
            {
                if (txtClave.Text == txtConfirmarClave.Text)
                {
                    Modelos.Empleado emp = cbxEmpleados.SelectedItem as Modelos.Empleado;
                    Modelos.Rol rol = cbxRol.SelectedItem as Modelos.Rol;

                    Modelos.Usuario user = new Modelos.Usuario
                    {
                        ID = Convert.ToInt32(txtIdUsuario.Text),
                        EMPLEADO = emp,
                        NOMBRE = txtUsuario.Text,
                        CLAVE = txtClave.Text,
                        ROL = rol,
                    };
                    MessageBox.Show(controlUsuario.registrar(user, EmpleadoNulo));
                    limpiarCampos();
                    mostrarUsuarios();
                }
                else
                {
                    MessageBox.Show("las claves ingresadas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("llene primero todos los campos");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void eliminarUsuario(int id)
        {
            if (MessageBox.Show("Desea eliminar al usuario actual? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(controlUsuario.eliminar(id));
                mostrarUsuarios();
                limpiarCampos();
            }
        }

        private void ckbVerContraseña_CheckedChanged(object sender)
        {
            if (ckbVerContraseña.Checked == true)
            {
                ckbVerContraseña.Text = "ocultar contraseña";
                txtClave.PasswordChar = '\0';
                txtConfirmarClave.PasswordChar = '\0';
            }
            else
            {
                ckbVerContraseña.Text = "ver contraseña";
                txtClave.PasswordChar = '*';
                txtConfirmarClave.PasswordChar = '*';
            }
        }

        private void tbUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.pen.Width;
                var h = CapaPresentacion.Properties.Resources.pen.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.delete.Width;
                var h = CapaPresentacion.Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                if (indice >= 0)
                {
                    txtIdUsuario.Text = tbUsuarios.Rows[indice].Cells["ID"].Value.ToString();
                    txtUsuario.Text = tbUsuarios.Rows[indice].Cells["USUARIO"].Value.ToString();
                    string rol = tbUsuarios.Rows[indice].Cells["ROL"].Value.ToString();
                }
            }
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                if (indice >= 0)
                {
                    string valor = tbUsuarios.Rows[indice].Cells["ID"].Value.ToString();
                    eliminarUsuario(Convert.ToInt32(valor));
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columna = cbxBuscar.SelectedItem.ToString();
            if (tbUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbUsuarios.Rows)
                {
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
                }
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cbxBuscar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cbxBuscar, "Para una busqueda mas efeciente se pueden realizar busqueda por filtros");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Bienvenido al area de Usuario de accesos:\n" +
                                          "Para crear un Usuario :\n" +
                                          "1. Ingrese el nombre del Usuario\n" +
                                          "2. Ingrese Clave de Usuario\n" +
                                          "3. Compruebe la clave de usuario\n" +
                                          "4. Seleccione el Rol del Empleado\n" +
                                          "5. Seleccione el Empleado\n" +
                                          "6. 'Guardar' en los registros de usuarios\n" +
                                          "Si desea Editar un usuario click en 'Editar\n" +
                                          "Si desea Cancelar la creacion de un usuario click en 'Limpiar'\n" +
                                          "Si desea Eliminar un usuario click en 'Eliminar'");
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnGuardar, "Guardar");
        }

        private void rjButton2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(rjButton2, "limpiar");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormRoles roles = new FormRoles();
            roles.ShowDialog();
        }
    }
}
