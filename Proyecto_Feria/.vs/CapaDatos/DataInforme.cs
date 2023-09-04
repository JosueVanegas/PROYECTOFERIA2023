using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datainforme
    {
        public List<informeVentas> ObtenerDatosInformeVentas(string fechaInicio, string fechaFin)
        {
            List<informeVentas> lista = new List<informeVentas>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_ORDENAR_FECHA_VENTA";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new informeVentas
                                {
                                    noFactura = reader[0].ToString(),
                                    nombreCliente = reader[1].ToString(),
                                    nombreEmpleado = reader[2].ToString(),
                                    iva = Convert.ToDecimal(reader[3]),
                                    subtotal = Convert.ToDecimal(reader[4]),
                                    descuento = Convert.ToDecimal(reader[5]),
                                    total = Convert.ToDecimal(reader[6]),
                                    fecha = reader[7].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<informeVentas>();
            }
            return lista;
        }

        public List<informeInventario> ObtenerDatosInformeInventario()
        {
            List<informeInventario> lista = new List<informeInventario>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string query = "SELECT P.CODIGO_PRODUCTO,P.NOMBRE_PRODUCTO,C.NOMBRE_CATEGORIA,PR.NOMBRE_EMPRESA,P.PRECIO_COMPRA,P.PRECIO_VENTA,P.CANTIDAD_INVENTARIO,P.FECHA_REGISTRO FROM PRODUCTO P  INNER JOIN PROVEEDOR PR ON P.ID_PROVEEDOR = PR.ID_PROVEEDOR INNER JOIN CATEGORIA C ON C.ID_CATEGORIA = P.ID_CATEGORIA";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new informeInventario
                                {
                                    codigo = reader[0].ToString(),
                                    producto = reader[1].ToString(),
                                    categoria = reader[2].ToString(),
                                    proveedor = reader[3].ToString(),
                                    precioCompra = Convert.ToDecimal(reader[4]),
                                    precioVenta = Convert.ToDecimal(reader[5]),
                                    cantidad = Convert.ToInt32(reader[6]),
                                    fecha = reader[7].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<informeInventario>();
            }
            return lista;
        }
    }
}

