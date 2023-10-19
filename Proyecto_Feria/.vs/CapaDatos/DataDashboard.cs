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
        public List<Modelos.Top> datosGraficaProductosMasVendidos()
        {
            List<Modelos.Top> datos = new List<Modelos.Top>();

            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();

                    string query = "SELECT TOP 5 P.NAMES AS PRODUCT,S.AMOUNT AS AMOUNT FROM SALES.SALES_DETAILS S INNER JOIN INVENTORY.PRODUCTS P ON S.ID_PRODUCT = P.ID INNER JOIN SALES.SALES SS ON SS.ID = S.ID_SALE GROUP BY P.NAMES,S.AMOUNT ORDER BY S.AMOUNT ASC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            datos.Add(new Modelos.Top
                            {
                                PRODUCTO = reader["PRODUCT"].ToString(),
                                CANTIDAD = Convert.ToInt32(reader["AMOUNT"])
                            });
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                datos = new List<Modelos.Top>();
            }

            return datos;
        }
        public List<Modelos.Dash> datosGraficaVentas(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Modelos.Dash> lista = new List<Modelos.Dash>();
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();

                    string query = "SELECT CONVERT(DATE,CREATED_AT) AS FECHA,SUBTOTAL-DISCOUNT AS TOTAL FROM SALES.SALES WHERE CONVERT(DATE,CREATED_AT) BETWEEN CONVERT(DATE,@START_DATE) AND CONVERT(DATE,@END_DATE) GROUP BY CREATED_AT,SUBTOTAL,DISCOUNT";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@START_DATE", fechaInicio);
                        command.Parameters.AddWithValue("@END_DATE", fechaFinal);
                        command.ExecuteNonQuery();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DateTime fechaRegistro = Convert.ToDateTime(reader[0]);
                            lista.Add(new Modelos.Dash
                            {
                                FECHA = fechaRegistro.ToShortDateString(),
                                TOTAL = Convert.ToDecimal(reader[1])
                            });
                        }



                    }
                }
            } 
           
            return lista;
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


        public List<Modelos.Producto> listaStock()
        {
            List<Modelos.Producto> lista = new List<Modelos.Producto>();
            try
            {
                string query = "SELECT BARCODE,NAMES +' '+BRAND+' '+UNIT AS PRODUCT,STOCK,STOCK_SECURITY, FROM INVENTORY.PRODUCTS WHERE ACTIVE = 1";
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Modelos.Producto
                                {
                                    CODIGO = reader["BARCODE"].ToString(),
                                    NOMBRE = reader["PRODUCT"].ToString(),
                                    STOCK = Convert.ToInt32(reader["STOCK"].ToString()),
                                    STOCK_SEGURIDAD = Convert.ToInt32(reader["STOCK_SECURITY"].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Producto>();
            }
            return lista;

        }
    }
}


