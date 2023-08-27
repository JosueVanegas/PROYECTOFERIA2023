using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataUsuarios
    {
        string mensaje = "";
        public DataUsuarios() { }

        public string encriptarClave(Usuario u)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_ENCRIPTAR_CLAVE", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", u.id);
                        cmd.Parameters.AddWithValue("@USUARIO", u.usuario);
                        cmd.Parameters.AddWithValue("@CLAVE", u.clave);
                        cmd.ExecuteNonQuery();
                        mensaje = "se encripto la clave de usuario correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        public bool validarAcceso(string usuario, string clave)
        {
            bool acceder = false;
            using (SqlConnection con = new conexion().conectar())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("PROC_VALIDAR_ACCESO", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USUARIO", usuario);
                    cmd.Parameters.AddWithValue("@CLAVE", clave);
                    cmd.Parameters.Add("@RESULTADO", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    acceder = (bool)cmd.Parameters["@RESULTADO"].Value;
                }
            }
            return acceder;
        }
        public List<Rol> listaRoles()
        {
            List<Rol> lista = new List<Rol>();
            string query = "SELECT ID_ROL,DESCRIPCION FROM ROL_DE_USUARIO";
            using (var con = new conexion().conectar())
            {
                con.Open();
                try
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Rol
                                {
                                    id = Convert.ToInt32(reader["ID_ROL"]),
                                    descripcion = reader["DESCRIPCION"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }
            return lista;
        }
        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string query = "SELECT * FROM USUARIO p INNER JOIN ROL_DE_USUARIO r ON P.ROL = R.ID_ROL";

            using (var con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Usuario
                                {
                                    id = Convert.ToInt32(reader["ID_USUARIO"]),
                                    usuario = reader["USUARIO"].ToString(),
                                    clave = reader["CLAVE"].ToString(),
                                    oRol = new Rol { id = Convert.ToInt32(reader["ROL"]), descripcion = reader["DESCRIPCION"].ToString() },
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
        public List<comboEmpleado> listaEmpleados()
        {
            List<comboEmpleado> lista = new List<comboEmpleado>();
            string query = "SELECT ID_EMPLEADO,NOMBRE,APELLIDO FROM EMPLEADO";
            using (var con = new conexion().conectar())
            {
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
                try
                {
                    con.Open();
                    using (var command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.Text;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                                lista.Add(new comboEmpleado
                                {
                                    id = Convert.ToInt32(reader["ID_EMPLEADO"]),
                                    nombres = reader["NOMBRE"].ToString(),
                                    apellidos = reader["APELLIDO"].ToString()
                                });
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<comboEmpleado>();
                }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            }
            return lista;
        }
        public string accionesUsuario(Usuario user, bool empleadoNulo)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_USUARIO", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_USUARIO", user.id);
                    if (empleadoNulo == true)
                    {
                        comand.Parameters.AddWithValue("@ID_EMPLEADO", DBNull.Value);
                    }
                    else
                    {
                        comand.Parameters.AddWithValue("@ID_EMPLEADO", user.oEmpleado.id);
                    }
                    comand.Parameters.AddWithValue("@USUARIO", user.usuario);
                    comand.Parameters.AddWithValue("@CLAVE", user.clave);
                    comand.Parameters.AddWithValue("@ID_ROL", user.oRol.id);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    comand.ExecuteNonQuery();

#pragma warning disable CS8601 // Posible asignación de referencia nula
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula
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
        public string eliminarUsuario(int idU)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_ELIMINAR_USUARIO", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_USUARIO", idU);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();

#pragma warning disable CS8601 // Posible asignación de referencia nula
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula
                }
                catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el usuario. error: " + ex.Message;
                }
            }
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return mensaje;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
    }
}