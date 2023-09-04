using CapaDatos;

namespace CapaControlador
{
    public class ControlInforme
    {
        Datainforme dInforme = new Datainforme();

        public List<informeVentas> datosDeVentas(string fechaInicio, string fechaFin)
        {
            return dInforme.ObtenerDatosInformeVentas(fechaInicio, fechaFin);
        }
        public List<informeInventario> datosInventario()
        {
            return dInforme.ObtenerDatosInformeInventario();
        }
        public nomina calcularnomina(Empleado empleado,int horasTrabajadas,int horasExtras)
        {
            return dInforme.calcularnomina(empleado, horasTrabajadas, horasExtras);
        }
    }
}
