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
                tbRoles.Rows.Add("", "", r.ID, r.ROL.ID,r.VENTAS,r.INVENTARIO);
            }
        }
    }
}
