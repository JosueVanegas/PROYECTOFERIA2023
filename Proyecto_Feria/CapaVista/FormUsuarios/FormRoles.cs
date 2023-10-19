using CapaControlador;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormUsuarios
{
    public partial class FormRoles : MaterialForm
    {
        ControlRolesyAccesos cRoles = new ControlRolesyAccesos();
        public FormRoles()
        {
            InitializeComponent();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            mostrarRoles();
        }
        private void mostrarRoles()
        {
            //falta crear la clase control y data
            List<Modelos.AccesoRol> lista = cRoles.listarRoles();
            tbRoles.Rows.Clear();
            foreach (Modelos.AccesoRol r in lista)
            {
                //EDITAR, ELIMINAR, A0,A1,A2, , A3, A4, A5, A6, A7, ID_ROL, NOMBRE
                tbRoles.Rows.Add("", "",
                    r.VENTAS, r.INVENTARIO, r.HERRAMIENTAS,
                    r.USUARIOS, r.CLIENTES, r.INFORMES,
                    r.EMPLEADOS, r.CONFIGURACIONES, r.ID, r.ROL.NOMBRE);
            }
        }
        private void eliminar(int id)
        {
            if (MessageBox.Show("desea eliminar el rol de usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cRoles.eliminarRol(id);
                mostrarRoles();
            }

        }
        private void guardar()
        {

            if (validarCampos())
            {
                Modelos.AccesoRol ac = new Modelos.AccesoRol
                {
                    ROL = new Modelos.Rol
                    {
                        ID = Convert.ToInt32(txtIdRol.Text),
                        NOMBRE = txtRol.Text
                    },
                    VENTAS = ckVentas.Checked,
                    INVENTARIO = ckInventario.Checked,
                    HERRAMIENTAS = ckHerramientas.Checked,
                    USUARIOS = ckUsuarios.Checked,
                    CLIENTES = ckClientes.Checked,
                    INFORMES = ckInformes.Checked,
                    EMPLEADOS = ckEmpleados.Checked,
                    CONFIGURACIONES = ckEmpresa.Checked
                };
                MessageBox.Show(cRoles.registrarRol(ac));
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del rol primero");
            }
        }
        private bool validarCampos()
        {
            if (txtRol.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbRoles.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                int id = (int)tbRoles.Rows[indice].Cells["ID"].Value;
                eliminar(id);
            }
            if (tbRoles.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                txtIdRol.Text = tbRoles.Rows[indice].Cells["ID_ROL"].Value.ToString();
                txtRol.Text = tbRoles.Rows[indice].Cells["NOMBRE"].Value.ToString();
                ckVentas.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A0"].Value);
                ckInventario.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A1"].Value);
                ckHerramientas.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A2"].Value);
                ckUsuarios.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A3"].Value);
                ckClientes.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A4"].Value);
                ckInformes.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A5"].Value);
                ckEmpleados.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A6"].Value);
                ckEmpresa.Checked = Convert.ToBoolean(tbRoles.Rows[indice].Cells["A7"].Value);
            }
        }

        private void tbRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = CapaPresentacion.Properties.Resources.pen.Height;
                var w = CapaPresentacion.Properties.Resources.pen.Width;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpiar();
            mostrarRoles();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtIdRol.Text = "0";
            txtRol.Text = "";
            ckVentas.Checked = false;
            ckInventario.Checked = false;
            ckHerramientas.Checked = false;
            ckUsuarios.Checked = false;
            ckClientes.Checked = false;
            ckInformes.Checked = false;
            ckEmpleados.Checked = false;
            ckEmpresa.Checked = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.SetToolTip(pictureBox2, "Bienvenido al area de creación de roles:\n" +
                                          "Para crear un roles :\n" +
                                          "Seleccione (haga click) en cada uno de los funciones que desea permitir al rol\n" +
                                          "'Guardar' para guardar el rol\n" +
                                          "Si desea limpiar la creacion de un roles click en 'Limpiar'\n");
        }
    }
}
