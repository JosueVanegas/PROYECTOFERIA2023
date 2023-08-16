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

                            productosMasVendidos productoVendido = new productosMasVendidos
                            {
                                nombre = nombreProducto,
                                cantidad = totalVentas
                            };

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
            return productosVendidos;
        }
    }
}

