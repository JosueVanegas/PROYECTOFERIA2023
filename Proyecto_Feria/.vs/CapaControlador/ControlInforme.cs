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
    }
}
