using CapaDatos;

namespace CapaControlador
{
    public class Controles
    {
        public Controles()
        {
        }

        public string verificarConexion()
        {
            return new conexion().conexionExitosa();
        }
    }
}
