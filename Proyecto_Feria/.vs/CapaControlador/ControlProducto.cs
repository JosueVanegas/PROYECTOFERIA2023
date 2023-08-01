using CapaDatos;

namespace CapaControlador
{

    public class ControlProducto
    {
        DataProducto dProd = new DataProducto();

        public List<Producto> listarProductos()
        {
            return dProd.listarProductos();
        }
        public string accionesProducto()
        {
            return dProd.accionesProducto(null);
        }
        public string eliminarProducto(int id)
        {
            return dProd.eliminarProducto(id);
        }
    }
}
