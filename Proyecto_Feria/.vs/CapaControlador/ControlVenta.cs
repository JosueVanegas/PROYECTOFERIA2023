using CapaDatos;

namespace CapaControlador
{
    public class ControlVenta
    {
        DataVenta dVenta = new DataVenta();
        public ControlVenta()
        {
           
        }
        public string procesoDeVenta(infoVenta v, List<DetalleVenta> detalles)
        {
            return dVenta.procesoDeVenta(v, detalles);
        }
        public string tomarNoFactura()
        {
            return dVenta.tomarFactura();
        }
    }
}
