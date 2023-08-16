using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlVenta
    {
        DataVenta dVenta = new DataVenta();
        public string procesoDeVenta(infoVenta v,List<DetalleVenta> detalles)
        {
            return dVenta.procesoDeVenta(v, detalles);
        }
    }
}
