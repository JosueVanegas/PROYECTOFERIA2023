using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlEmpresa
    {
        DataEmpresa dEmp = new DataEmpresa();
        public Empresa datosEmpresa()
        {
            return dEmp.datosDeEmpresa();
        }
        public string actualizarDatosEmpresa(Empresa emp)
        {
            return dEmp.editarInformacionEmpresa(emp);
        }
    }
}
