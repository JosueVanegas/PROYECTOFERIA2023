using CapaDatos;

namespace CapaControlador
{
    public class ControlProveedor
    {
        DataProveedor dProv = new DataProveedor();
        public List<Proveedor> listarProveedores()
        {
            return dProv.listarProveedores();
        }
        public string accionProveedor(Proveedor p)
        {
            return dProv.accionesProveedor(p);
        }
        public string eliminarProveedor(int id)
        {
            return dProv.eliminarProveedor(id);
        }
    }
}
