using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class AccesoRol
    {
        public int ID { get; set; }
        public Rol ROL { get; set; }
        public bool CONFIGURACIONES { get; set; }
        public bool VENTAS { get; set; }
        public bool INVENTARIO { get; set; }
        public bool EMPLEADOS { get; set; }
        public bool HERRAMIENTAS { get; set; }
        public bool USUARIOS { get; set; }
        public bool CLIENTES { get; set; }
        public bool INFORMES { get; set; }
        public bool DASHBOARD { get; set; }
        public bool ACTIVO { get; set; }
    }
}
