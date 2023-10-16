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
        public Modelos.Empresa datosEmpresa()
        {
            return dEmp.datosDeEmpresa();
        }
        public string actualizarDatosEmpresa(Modelos.Empresa emp)
        {
            return dEmp.editarInformacionEmpresa(emp);
        }
    }
}
