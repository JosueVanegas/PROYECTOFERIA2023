using CapaDatos;

namespace CapaControlador
{
    public class ControlConexion
    {
        public ControlConexion()
        {
        }

        public string verificarConexion()
        {
            return new conexion().conexionExitosa();
        }
    }
}
