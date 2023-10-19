using CapaDatos;

namespace CapaControlador
{
    public class ControlVenta
    {
        string mensaje = "";
        public int idCreado = 0;
        DataVenta dVenta = new DataVenta();
        public ControlVenta()
        {
        }
        public string procesoDeVenta(Modelos.Venta v, List<Modelos.DetalleVenta> detalles)
        {
            return dVenta.procesoDeVenta(v, detalles);
            idCreado = dVenta.idCreado;
        }
        public int retornarId()
        {
            return dVenta.retornarId();
        }
    }
}
