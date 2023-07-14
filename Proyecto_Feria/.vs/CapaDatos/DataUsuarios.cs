using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataUsuarios
    {
        string mensaje = "";
        public DataUsuarios() { }
        
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
                        using (var reader = cmd.ExecuteReader()) { 
                           while(reader.Read())
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
            string query = "SELECT ID_USUARIO,USUARIO,CLAVE,ROL,DESCRIPCION FROM USUARIO p INNER JOIN ROL_DE_USUARIO r ON P.ROL = R.ID_ROL";

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
                                    oRol = new Rol { id = Convert.ToInt32(reader["ROL"]), descripcion = reader["DESCRIPCION"].ToString() }
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
        public List<Empleado> listaEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            string query = "SELECT ID_EMPLEADO,NOMBRE,APELLIDO FROM EMPLEADO";
            using(var con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (var command = new SqlCommand(query,con))
                    {
                        command.CommandType = CommandType.Text;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Empleado
                                {
                                    id= Convert.ToInt32(reader["ID_EMPLEADO"]),
                                    nombres = reader["NOMBRE"].ToString(),
                                    apellidos = reader["APELLIDO"].ToString()
                                });
                            }
                        }
                    }
                }catch (Exception ex)
                {
                    lista = new List<Empleado>();
                }
            }
            return lista;
        }
        public string accionesUsuario(Usuario user)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_USUARIO", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_USUARIO", user.id);
                    comand.Parameters.AddWithValue("@ID_EMPLEADO", user.oEmpleado.id);
                    comand.Parameters.AddWithValue("@USUARIO", user.usuario);
                    comand.Parameters.AddWithValue("@CLAVE", user.clave);
                    comand.Parameters.AddWithValue("@ID_ROL", user.oRol.id);
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
        public string eliminarUsuario(int idU)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("eliminarUsuario", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@Id", idU);
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