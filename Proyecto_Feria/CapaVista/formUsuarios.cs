using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CapaVista
{
    public partial class formUsuarios : MaterialForm
    {
        ControlUsuario controlUsuario = new ControlUsuario();
        bool EmpleadoNulo = false;
        public formUsuarios(Boolean Mod)
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
                tbUsuarios.BackgroundColor = Color.FromArgb(50, 50, 50);
            }
            if (!Mod)
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.BLACK);
                tbUsuarios.BackgroundColor = Color.White;

            }

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
            txtIdUsuario.Text = "";
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
            List<Usuario> usuarios = controlUsuario.listarUsuarios();
            tbUsuarios.Rows.Clear();
            foreach (Usuario i in usuarios)
            {
                tbUsuarios.Rows.Add("", "", i.id, i.usuario, i.oRol.descripcion, i.fechaRegistro, i.oRol.id, i.clave, "");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            registrarUsuario();
        }
        private void registrarUsuario()
        {
            int rolU = 0;
            Empleado emp;
            if (validarCampos() == true)
            {
                if (txtClave.Text == txtConfirmarClave.Text)
                {
                    if (txtIdUsuario.Text == "")
                        txtIdUsuario.Text = "1";
                    emp = cbxEmpleados.SelectedItem as Empleado;
                    Rol rol = cbxRol.SelectedItem as Rol;
                    Usuario user = new Usuario
                    {
                        id = Convert.ToInt32(txtIdUsuario.Text),
                        oEmpleado = emp,
                        usuario = txtUsuario.Text,
                        clave = txtClave.Text,
                        oRol = rol,
                    };
                    MessageBox.Show(controlUsuario.registrar(user, EmpleadoNulo));
                    controlUsuario.encriptarClave(user);
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
                var w = Properties.Resources.pen_circle.Width;
                var h = Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.eliminar.Width;
                var h = Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (indice >= 0)
                {
                    txtIdUsuario.Text = tbUsuarios.Rows[indice].Cells["id"].Value.ToString();
                    txtUsuario.Text = tbUsuarios.Rows[indice].Cells["usuario"].Value.ToString();
                    string rol = tbUsuarios.Rows[indice].Cells["rol"].Value.ToString();

                }
            }
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
                    string valor = tbUsuarios.Rows[indice].Cells["id"].Value.ToString();
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

        private void ckbEmpleadoNulo_CheckedChanged(object sender)
        {
            if (ckbEmpleadoNulo.Checked == true)
            {
                cbxEmpleados.Enabled = false;
                EmpleadoNulo = true;
                MessageBox.Show("el empleado es nulo");
            }
            else
            {
                cbxEmpleados.Enabled = true;
                EmpleadoNulo = false;
                MessageBox.Show("el empleado es activo");
            }
        }
    }
}
