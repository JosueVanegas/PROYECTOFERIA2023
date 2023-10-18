using CapaDatos;

namespace CapaControlador
{
    public class ControlInforme
    {
        Datainforme dInforme = new Datainforme();

        public List<Modelos.Venta> datosDeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dInforme.ObtenerDatosInformeVentas(fechaInicio, fechaFin);
        }
        public List<Modelos.Compra> datosCompras(DateTime fechaInicio, DateTime fechaFin)
        {
            return dInforme.ObtenerDatosInformeCompras(fechaInicio, fechaFin);
        }
        public List<Modelos.Movimiento> datosMovientoInventario(int idProducto, DateTime fechaInicio, DateTime fechaFin)
        {
            return dInforme.ObtenerDatosInformeMovimientoProducto(idProducto,fechaInicio,fechaFin);
        }
        public Modelos.Nomina calcularnomina(Modelos.Empleado empleado,int horasTrabajadas,int horasExtras)
        {
            return dInforme.calcularnomina(empleado, horasTrabajadas, horasExtras);
        }
    }
}
