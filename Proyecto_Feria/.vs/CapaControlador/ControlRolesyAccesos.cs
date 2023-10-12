using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlRolesyAccesos
    {
        DataRolesyAccesos dRoles = new DataRolesyAccesos();
        public List<Modelos.AccesoRol> listarRoles()
        {
            return dRoles.listarRoles();
        }
    }
}
