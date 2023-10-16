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
        public List<informeCompras> datosCompras(string fechaInicio, string fechaFin)
        {
            return dInforme.ObtenerDatosInformeCompras(fechaInicio, fechaFin);
        }
        public List<movimientoProducto> datosMovientoInventario(int idProducto,string fechaInicio, string fechaFin)
        {
            return dInforme.ObtenerDatosInformeMovimientoProducto(idProducto,fechaInicio,fechaFin);
        }
        public nomina calcularnomina(Modelos.Empleado empleado,int horasTrabajadas,int horasExtras)
        {
            return dInforme.calcularnomina(empleado, horasTrabajadas, horasExtras);
        }
    }
}
