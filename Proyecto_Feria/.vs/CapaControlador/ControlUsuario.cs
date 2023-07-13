using CapaDatos;

namespace CapaControlador
{
    public class ControlUsuario
    {
        DataUsuarios dUser = new DataUsuarios();

        public List<Usuario> listarUsuarios()
        {
            return dUser.ListaUsuarios();
        }
        public string registrar(Usuario u)
        {
            string mensaje = dUser.accionesUsuario(u);
            return mensaje;
        }
        public string eliminar(int id)
        {
            return dUser.eliminarUsuario(id);
        }
    }
}
