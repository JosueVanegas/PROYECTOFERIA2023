using CapaDatos;
using System.Data;

namespace CapaControlador
{
    public class ControlUsuario
    {
        DataUsuarios dUser = new DataUsuarios();

        public List<Modelos.Usuario> listarUsuarios()
        {
            return dUser.ListaUsuarios();
        }
        public List<Modelos.Rol> listarRoles()
        {
            return dUser.listaRoles();
        }
        public List<Modelos.Empleado> listarEmpleados()
        {
            return dUser.listaEmpleados();
        }
        public string registrar(Modelos.Usuario u, bool empleadonulo)
        {
            string mensaje = dUser.accionesUsuario(u, empleadonulo);
            return mensaje;
        }
        public string eliminar(int id)
        {
            return dUser.eliminarUsuario(id);
        }
        public bool validarAcceso(string usuario, string clave)
        {
            return dUser.validarAcceso(usuario, clave);
        }
    }
}
