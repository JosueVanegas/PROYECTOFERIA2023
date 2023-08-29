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
    }
}
