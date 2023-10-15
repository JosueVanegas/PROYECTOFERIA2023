using CapaDatos;

namespace CapaControlador
{
    public class ControlCliente
    {
        DataCliente dCliente = new DataCliente();
        public ControlCliente() { }

        public List<Modelos.Cliente> listarClientes()
        {
            return dCliente.listarClientes();
        }

        public string registrarCliente(Modelos.Cliente cliente)
        {
            return dCliente.accionesClientes(cliente);
        }

        public string eliminarCliente(int id)
        {
            return dCliente.eliminarCliente(id);
        }
    }
}
