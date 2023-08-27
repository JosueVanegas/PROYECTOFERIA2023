﻿using CapaControlador;
using CapaDatos;
using ReaLTaiizor.Forms;

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
#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
            int rolU = 0;
#pragma warning restore CS0219 // La variable está asignada pero nunca se usa su valor
            comboEmpleado emp;
            if (validarCampos() == true)
            {
                if (txtClave.Text == txtConfirmarClave.Text)
                {
                    if (txtIdUsuario.Text == "")
                        txtIdUsuario.Text = "1";
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    emp = cbxEmpleados.SelectedItem as comboEmpleado;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    Rol rol = cbxRol.SelectedItem as Rol;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                    Usuario user = new Usuario
                    {
                        id = Convert.ToInt32(txtIdUsuario.Text),
                        oEmpleado = emp,
                        usuario = txtUsuario.Text,
                        clave = txtClave.Text,
                        oRol = rol,
                    };
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
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
                var w = CapaPresentacion.Properties.Resources.pen_circle.Width;
                var h = CapaPresentacion.Properties.Resources.pen_circle.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.pen_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = CapaPresentacion.Properties.Resources.eliminar.Width;
                var h = CapaPresentacion.Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(CapaPresentacion.Properties.Resources.eliminar, new Rectangle(x, y, w, h));
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    string rol = tbUsuarios.Rows[indice].Cells["rol"].Value.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

                }
            }
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                if (indice >= 0)
                {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    string valor = tbUsuarios.Rows[indice].Cells["id"].Value.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                    eliminarUsuario(Convert.ToInt32(valor));
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string columna = cbxBuscar.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (tbUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in tbUsuarios.Rows)
                {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    if (i.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        i.Visible = true;
                    else
                        i.Visible = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
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
