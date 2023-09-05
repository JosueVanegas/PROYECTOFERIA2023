using CapaDatos;

namespace CapaControlador
{
    public class ControlVenta
    {
        string mensaje = "";
        DataVenta dVenta = new DataVenta();
        public ControlVenta()
        {
        }
        public string retornarMensaje()
        {
            return dVenta.mensaje ;
        }
        public string procesoDeVenta(infoVenta v, List<DetalleVenta> detalles)
        {
            return dVenta.procesoDeVenta(v, detalles);
        }
    }
}
