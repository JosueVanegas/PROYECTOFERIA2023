using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataProveedor
    {
        string mensaje = "";
        public DataProveedor() { }
        public List<Proveedor> listarProveedores()
        {
            string query = "SELECT * FROM PROVEEDOR";
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    id = reader.GetInt32("ID_PROVEEDOR"),
                                    nombreProveedor = reader["NOMBRE_EMPRESA"].ToString(),
                                    nombreContacto = reader["NOMBRE_CONTACTO"].ToString(),
                                    numeroContacto = reader["NUMERO_CONTACTO"].ToString(),
                                    pais = reader["PAIS"].ToString(),
                                    ciudad = reader["CIUDAD"].ToString(),
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Proveedor>();
            }
            return lista;
        }
        public string accionesProveedor(Proveedor prov)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_PROVEEDOR", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_PROVEEDOR", prov.id);
                    comand.Parameters.AddWithValue("@NOMBRE_EMPRESA", prov.nombreProveedor);
                    comand.Parameters.AddWithValue("@NOMBRE_CONTACTO", prov.nombreContacto);
                    comand.Parameters.AddWithValue("@NUMERO_CONTACTO", prov.numeroContacto);
                    comand.Parameters.AddWithValue("@PAIS", prov.pais);
                    comand.Parameters.AddWithValue("@CIUDAD", prov.ciudad);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    comand.ExecuteNonQuery();

                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
            return mensaje;
        }
        public string eliminarProveedor(int idP)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_ELIMINAR_PROVEEDOR", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_PROVEEDOR", idP);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();

                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el usuario. error: " + ex.Message;
                }
            }
            return mensaje;
        }
    }
}
