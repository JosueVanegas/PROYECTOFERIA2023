using CapaDatos;

namespace CapaControlador
{
    public class ControlCliente
    {
        DataCliente dCliente = new DataCliente();
        public ControlCliente() { }

        public List<Cliente> listarClientes()
        {
            return dCliente.listarClientes();
        }

        public string registrarCliente(Cliente cliente)
        {
            return dCliente.accionesClientes(cliente);
        }

        public string eliminarCliente(int id)
        {
            return dCliente.eliminarCliente(id);
        }
    }
}
