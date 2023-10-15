using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;
using System.Text;

namespace CapaDatos
{
    public class DataCliente
    {
        public DataCliente() { }
        string mensaje = "";
        public List<Modelos.Cliente> listarClientes()
        {
            string query = "SELECT ID,DNI,NAMES,LASTNAMES,PHONE,BIRTHDATE FROM SALES.CLIENTS WHERE ACTIVE = 1";
            List<Modelos.Cliente> lista = new List<Modelos.Cliente>();
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
                                lista.Add(new Modelos.Cliente
                                {
                                    ID = reader.GetInt32("ID"),
                                    CEDULA = reader.GetString("DNI"),
                                    NOMBRES = reader.GetString("NAMES"),
                                    APELLIDOS = reader.GetString("LASTNAMES"),
                                    TELEFONO = reader.GetString("PHONE"),
                                    NACIMIENTO = reader.GetDateTime("BIRTHDATE")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Cliente>();
            }
            return lista;
        }
        public string accionesClientes(Modelos.Cliente clie)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTER_CLIENT", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", clie.ID);
                    comand.Parameters.AddWithValue("@DNI", clie.CEDULA);
                    comand.Parameters.AddWithValue("@NAME", clie.NOMBRES);
                    comand.Parameters.AddWithValue("@LASTNAME", clie.APELLIDOS);
                    comand.Parameters.AddWithValue("@PHONE", clie.TELEFONO);
                    comand.Parameters.AddWithValue("@BIRTHDATE", clie.NACIMIENTO);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["MESSAGE"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
            return mensaje;
        }
        public string eliminarCliente(int id)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_DELETE_CLIENT", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", id);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["MESSAGE"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el cliente. error: " + ex.Message;
                }
            }
            return mensaje;
        }
    }
}
