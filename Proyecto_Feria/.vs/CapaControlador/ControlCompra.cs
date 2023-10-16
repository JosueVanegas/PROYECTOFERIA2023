using CapaDatos;

namespace CapaControlador
{
    public class ControlCompra
    {
        DataCompra dCompra = new DataCompra();
        public string procesoCompra(Modelos.Compra v, List<Modelos.DetalleCompra> detalles)
        {
            return dCompra.procesoDeCompra(v, detalles);
        }
        public List<Modelos.Compra> listarCompra()
        {
            return dCompra.listarCompras();
        }
    }
}
