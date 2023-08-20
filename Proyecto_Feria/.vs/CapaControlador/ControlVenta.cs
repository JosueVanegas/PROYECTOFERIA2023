using CapaDatos;

namespace CapaControlador
{
    public class ControlVenta
    {
        DataVenta dVenta = new DataVenta();
        public string procesoDeVenta(infoVenta v, List<DetalleVenta> detalles)
        {
            return dVenta.procesoDeVenta(v, detalles);
        }
    }
}
