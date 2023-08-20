using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataCliente
    {
        public DataCliente() { }
        string mensaje = "";
        public List<Cliente> listarClientes()
        {
            string query = "SELECT * FROM CLIENTE";
            List<Cliente> lista = new List<Cliente>();
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
                                lista.Add(new Cliente
                                {
                                    id = reader.GetInt32("ID_CLIENTE"),
                                    nombre = reader.GetString("NOMBRE"),
                                    apellido = reader.GetString("APELLIDO"),
                                    telefono = reader.GetString("TELEFONO"),
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Cliente>();
            }
            return lista;
        }
        public string accionesClientes(Cliente clie)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_PROVEEDOR", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_PROVEEDOR", clie.id);
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
        public string eliminarCliente(int idC)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_ELIMINAR_PROVEEDOR", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_PROVEEDOR", idC);
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
