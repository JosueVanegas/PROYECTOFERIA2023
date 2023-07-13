﻿using CapaControlador;
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
        private readonly MaterialSkinManager manager;
        public formUsuarios()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Cyan700, MaterialPrimary.Cyan700, MaterialPrimary.Indigo100, MaterialAccent.Cyan700, MaterialTextShade.WHITE);
        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtClave.Text = "";
            txtIdUsuario.Text = "";
            txtBuscar.Text = "";
            txtConfirmarClave.Text = "";
        }
        private bool validarCampos()
        {
            bool continuar = false;
            if (txtNombre.Text != "" && txtUsuario.Text != "" && txtClave.Text != "")
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

                tbUsuarios.Rows.Add("", i.id, i.usuario, i.oRol.descripcion, i.fechaRegistro, i.oRol.id, i.clave);

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
                    if (cbxRol.SelectedIndex == 0)
                    {
                        rolU = 1;
                    }
                    else if (cbxRol.SelectedIndex == 1)
                    {
                        rolU = 2;
                    }
                    if (txtIdUsuario.Text == "")
                        txtIdUsuario.Text = "1";
                    MessageBox.Show(
                    controlUsuario.registrar(new Usuario
                    {
                        /*
                         * id = Convert.ToInt32(txtIdUsuario.Text),
                        nombre = txtNombre.Text,
                        usuario = txtUsuario.Text,
                        clave = txtClave.Text,
                        rol = rolU
                         */
                    })
                    );
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                if (MessageBox.Show("Desea eliminar al usuario actual? ", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(controlUsuario.eliminar(Convert.ToInt32(txtIdUsuario.Text)));
                    mostrarUsuarios();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la tabla");
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
        }

        private void tbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIdUsuario.Text = tbUsuarios.Rows[indice].Cells["id"].Value.ToString();
                    txtUsuario.Text = tbUsuarios.Rows[indice].Cells["usuario"].Value.ToString();
                    txtClave.Text = tbUsuarios.Rows[indice].Cells["clave"].Value.ToString();
                    string rol = tbUsuarios.Rows[indice].Cells["rol"].Value.ToString();

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
    }
}
