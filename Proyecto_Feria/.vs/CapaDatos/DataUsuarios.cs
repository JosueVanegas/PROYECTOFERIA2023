using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaDatos
{
    public class DataUsuarios
    {
        string mensaje = "";
        public DataUsuarios() { }
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
                                    oRol = new Rol { id = Convert.ToInt32(reader["ROL"]),descripcion = reader["DESCRIPCION"].ToString() }
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
        public string accionesUsuario(Usuario user)
        {
              using (SqlConnection connection = new conexion().conectar())
             {
                 try
                 {
                    connection.Open();

                    SqlCommand comand = new SqlCommand("registroEdicionUsuario", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@Id", user.id);
                    comand.Parameters.AddWithValue("@NombreCompleto", user.oEmpleado.nombres );
                    comand.Parameters.AddWithValue("@Usuario",user.usuario);
                    comand.Parameters.AddWithValue("@Clave", user.clave);
                    //comand.Parameters.AddWithValue("@Rol", user.rol);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

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
            
            using( SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("eliminarUsuario", con);
                    comand.CommandType =CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@Id", idU);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery ();

                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el usuario. error: " + ex.Message;
                }
            }
            return mensaje;
        }
    }
}