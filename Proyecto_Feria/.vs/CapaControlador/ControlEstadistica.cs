using CapaDatos;

namespace CapaControlador
{
    public class ControlEstadistica
    {
        DataEstadistica dEstat = new DataEstadistica();
        public int cantidadCategorias(string tabla)
        {
            return dEstat.cantidadDeObjetosEnTabla(tabla);
        }
    }
}
