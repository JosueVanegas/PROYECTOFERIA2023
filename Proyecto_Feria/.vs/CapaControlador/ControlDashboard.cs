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
        public Dictionary<string,int> datosGraficaProductos(DateTime fechaInicio,DateTime fechaFinal)
        {
            return dash.datosGraficaProductosMasVendidos(fechaInicio,fechaFinal);
        }
        public Dictionary<string, decimal> datosGraficaVentas(DateTime fechaInicio,DateTime fechaFin)
        {
        
             if(fechaFin != null && fechaInicio != null)
             {
                 return dash.datosGraficaVentas(fechaInicio, fechaFin);
             }
             else
             {
                 return new Dictionary<string, decimal>();
             }
        }
        public string valorInventario()
        {
            return dash.valorInventario().ToString("0.00");
        }

        public List<Modelos.Producto> stockDisponible()
        {
            return dash.listaStock();
        }
    }
}
