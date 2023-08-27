using CapaDatos;
using System.Data;

namespace CapaControlador
{
    public class ControlInforme
    {
        Datainforme dInforme = new Datainforme();

        public DataTable datosDeVentas(string fechaInicio, string fechaFin)
        {
            return dInforme.ObtenerDatosInformeVentas(fechaInicio, fechaFin);
        }
    }
}
