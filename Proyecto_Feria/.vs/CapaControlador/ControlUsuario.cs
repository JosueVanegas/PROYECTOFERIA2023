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
        public List<Rol> listarRoles()
        {
            return dUser.listaRoles();
        }
        public List<Empleado> listarEmpleados()
        {
            return dUser.listaEmpleados();
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
        public string encriptarClave(Usuario u)
        {
            return dUser.encriptarClave(u);
        }
        public bool validarAcceso(string usuario,string clave)
        {
            return dUser.validarAcceso(usuario,clave);
        }
    }
}
