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
                        using(SqlDataReader reader =  cmd.ExecuteReader())
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
    }
}

