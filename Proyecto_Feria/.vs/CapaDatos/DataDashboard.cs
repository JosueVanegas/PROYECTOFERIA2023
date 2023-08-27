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
        public List<productosMasVendidos> topProductos()
        {
            List<productosMasVendidos> productosVendidos = new List<productosMasVendidos>();

#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
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
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                            string nombreProducto = reader["NombreProducto"].ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                            int totalVentas = Convert.ToInt32(reader["TotalVentas"]);

#pragma warning disable CS8601 // Posible asignación de referencia nula
                            productosMasVendidos productoVendido = new productosMasVendidos
                            {
                                nombre = nombreProducto,
                                cantidad = totalVentas
                            };
#pragma warning restore CS8601 // Posible asignación de referencia nula

                            productosVendidos.Add(productoVendido);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                productosVendidos = new List<productosMasVendidos>();
            }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            return productosVendidos;
        }
    }
}

