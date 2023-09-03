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
        public List<graficaProductos> datosGraficaProductosMasVendidos()
        {
            List<graficaProductos> productosVendidos = new List<graficaProductos>();

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
                            graficaProductos productoVendido = new graficaProductos
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
                productosVendidos = new List<graficaProductos>();
            }

            return productosVendidos;
        }
        public List<graficaVentas> datosGraficaVentas(string fechaInicio, string fechaFinal)
        {
            List<graficaVentas> lista = new List<graficaVentas>();
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
                            string fechaRegistro = reader[0].ToString();
                            int totalVentas = Convert.ToInt32(reader[1]);
                            graficaVentas valor = new graficaVentas
                            {
                                fecha = fechaRegistro,
                                total = totalVentas
                            };

                            lista.Add(valor);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<graficaVentas>();
            }
            return lista;
        }
        public decimal valorInventario()
        {
            decimal valor = 0;
            decimal valorInventario = 0;
            decimal costoInventario = 0;
            string query = "SELECT SUM(CANTIDAD_INVENTARIO*PRECIO_VENTA) AS VALOR_INVENTARIO,SUM(CANTIDAD_INVENTARIO*PRECIO_COMPRA) AS COSTO_INVETARIO FROM PRODUCTO";
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
                        costoInventario = reader.GetDecimal(1);
                        }
                    }
                }
            }
            valor = valorInventario - costoInventario;
            return valor;
        }
    }
}


