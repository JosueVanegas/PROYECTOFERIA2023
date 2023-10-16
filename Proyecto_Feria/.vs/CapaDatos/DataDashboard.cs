using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DataDashboard
    {
        public DataDashboard() { }

        public int cantidadDeObjetosEnTabla(string nombreTabla)
        {
            int cantidadFilas = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM " + nombreTabla;

                using (SqlConnection con = new conexion().conectar())
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    cantidadFilas = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return cantidadFilas;
        }
        public Dictionary<string,int> datosGraficaProductosMasVendidos()
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();

                    string query = "SELECT TOP 5 p.NOMBRE_PRODUCTO AS NombreProducto, " +
                        "SUM(v.Cantidad) AS TotalVentas FROM DETALLE_DE_VENTA v " +
                        "JOIN PRODUCTO p ON v.ID_PRODUCTO = p.ID_PRODUCTO " +
                        "GROUP BY p.NOMBRE_PRODUCTO, v.ID_PRODUCTO ORDER BY TotalVentas DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string nombreProducto = reader["NombreProducto"].ToString();
                            int totalVentas = Convert.ToInt32(reader["TotalVentas"]);
                            datos.Add(nombreProducto, totalVentas);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                datos = new Dictionary<string, int>();
            }

            return datos;
        }
        public Dictionary<DateTime,decimal> datosGraficaVentas(string fechaInicio, string fechaFinal)
        {
            Dictionary<DateTime, decimal> datos = new Dictionary<DateTime, decimal>();  
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();

                    string query = "SELECT FECHA_REGISTRO,TOTAL FROM VENTA where CONVERT(DATE, FECHA_REGISTRO, 103) " +
                        "BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' order by ID_VENTA asc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DateTime fechaRegistro = Convert.ToDateTime(reader[0]);
                            int totalVentas = Convert.ToInt32(reader[1]);
                            datos.Add(fechaRegistro, totalVentas);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                datos = new Dictionary<DateTime, decimal>();
            }
            return datos;
        }
        public decimal valorInventario()
        {
            decimal valor = 0;
            decimal valorInventario = 0;
            try
            {
                string query = "SELECT SUM(STOCK*PURCHASE_PRICE) AS TOTAL FROM INVENTORY.PRODUCTS ";
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                valorInventario = reader.GetDecimal(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            valor = valorInventario;
            return valor;
        }
    }
}


