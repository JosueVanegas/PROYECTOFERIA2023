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
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
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
#pragma warning disable CS8601 // Posible asignación de referencia nula
                                lista.Add(new Cliente
                                {
                                    id = reader.GetInt32("ID_CLIENTE"),
                                    nombre = reader.GetString("NOMBRE"),
                                    apellido = reader.GetString("APELLIDO"),
                                    telefono = reader.GetString("TELEFONO"),
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
#pragma warning restore CS8601 // Posible asignación de referencia nula
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Cliente>();
            }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            return lista;
        }
        public string accionesClientes(Cliente clie)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_CLIENTE", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_CLIENTE", clie.id);
                    comand.Parameters.AddWithValue("@NOMBRE", clie.nombre);
                    comand.Parameters.AddWithValue("@APELLIDO", clie.apellido);
                    comand.Parameters.AddWithValue("@TELEFONO", clie.telefono);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return mensaje;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
        public string eliminarCliente(int idC)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_ELIMINAR_CLIENTE", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_CLIENTE", idC);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();

#pragma warning disable CS8601 // Posible asignación de referencia nula
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula
                }
                catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el cliente. error: " + ex.Message;
                }
            }
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return mensaje;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
    }
}
