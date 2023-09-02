using CapaDatos;

namespace CapaControlador
{
    public class ControlDashboard
    {
        DataDashboard dash = new DataDashboard();
        public int cantidadCategorias(string tabla)
        {
            return dash.cantidadDeObjetosEnTabla(tabla);
        }
        public List<graficaProductos> datosGraficaProductos()
        {
            return dash.datosGraficaProductosMasVendidos();
        }
        public List<graficaVentas> datosGraficaVentas(string fechaInicio,string fechaFin)
        {
        
             if(fechaFin != null && fechaInicio != null)
             {
                 return dash.datosGraficaVentas(fechaInicio, fechaFin);
             }
             else
             {
                 return new List<graficaVentas>();
             }
        }
        public string valorInventario()
        {
            return dash.valorInventario().ToString("0.00");
        }
    }
}
