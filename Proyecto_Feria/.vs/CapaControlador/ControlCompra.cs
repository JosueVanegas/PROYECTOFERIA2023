using CapaDatos;

namespace CapaControlador
{
    public class ControlCompra
    {
        DataCompra dCompra = new DataCompra();
        public string procesoCompra(realizarCompra v, List<detalleCompra> detalles)
        {
            return dCompra.procesoDeCompra(v, detalles);
        }
        public List<compra> listarCompra()
        {
            return dCompra.listarCompras();
        }
    }
}
