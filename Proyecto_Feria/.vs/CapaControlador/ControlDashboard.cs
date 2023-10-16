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
        public Dictionary<string,int> datosGraficaProductos()
        {
            return dash.datosGraficaProductosMasVendidos();
        }
        public Dictionary<DateTime, decimal> datosGraficaVentas(string fechaInicio,string fechaFin)
        {
        
             if(fechaFin != null && fechaInicio != null)
             {
                 return dash.datosGraficaVentas(fechaInicio, fechaFin);
             }
             else
             {
                 return new Dictionary<DateTime, decimal>();
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
