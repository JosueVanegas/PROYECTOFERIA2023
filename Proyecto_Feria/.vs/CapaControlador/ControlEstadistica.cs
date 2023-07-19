using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlEstadistica
    {
        DataEstadistica dEstat = new DataEstadistica();
        public int cantidadCategorias(string tabla)
        {
            return dEstat.cantidadDeObjetosEnTabla(tabla);
        }
    }
}
