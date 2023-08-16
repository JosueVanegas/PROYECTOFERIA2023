using CapaDatos;

namespace CapaControlador
{
    public class ControlDashboard
    {
        DataDashboard dash = new DataDashboard();
        public int cantidadCategorias(string tabla)
        {
            return dash.cantidadDeObjetosEnTabla(tabla);
        }
         public List<productosMasVendidos> productosTop()
        {
            return dash.topProductos();
        }
    }
}
