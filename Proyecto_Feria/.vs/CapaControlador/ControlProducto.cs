using CapaDatos;

namespace CapaControlador
{

    public class ControlProducto
    {
        DataProducto dProd = new DataProducto();

        public List<Modelos.Producto> listarProductos()
        {
            return dProd.listarProductos();
        }
        public string accionesProducto(Modelos.Producto p)
        {
            return dProd.accionesProducto(p);
        }
        public string eliminarProducto(int id)
        {
            return dProd.eliminarProducto(id);
        }
    }
}
