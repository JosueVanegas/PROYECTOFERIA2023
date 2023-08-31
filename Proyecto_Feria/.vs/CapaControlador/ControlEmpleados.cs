using CapaDatos;

namespace CapaControlador
{
    public class ControlEmpleados
    {
        DataEmpleados dEmp = new DataEmpleados();
        public ControlEmpleados() { }
        public List<Empleado> listarEmpleados()
        {
            return dEmp.listaEmpleados();
        }
        public string registrarEmpleados(Empleado e)
        {
            return dEmp.accionesEmpleados(e);
        }
        public string eliminarEmpleado(int id)
        {
            return dEmp.eliminarEmpleado(id);
        }
    }
}
