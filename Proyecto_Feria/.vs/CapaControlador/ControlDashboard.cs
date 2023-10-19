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
        public List<Modelos.Top> datosGraficaProductos()
        {
            return dash.datosGraficaProductosMasVendidos();
        }
        public List<Modelos.Dash> datosGraficaVentas(DateTime fechaInicio,DateTime fechaFin)
        {
        
             if(fechaFin != null && fechaInicio != null)
             {
                 return dash.datosGraficaVentas(fechaInicio, fechaFin);
             }
             else
             {
                return new List<Modelos.Dash>();
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
