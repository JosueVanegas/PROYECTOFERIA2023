using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Reflection.PortableExecutable;
using Modelos;
using System;

namespace CapaDatos
{
    public class DataUsuarios
    {
        string mensaje = "";
        public DataUsuarios() { }
        public bool validarAcceso(string usuario, string clave)
        {
            bool acceder = false;
            using (SqlConnection con = new conexion().conectar())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("PROC_READ_ENCRYP_PASSWORD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USER", usuario);
                    cmd.Parameters.AddWithValue("@PASSWORD", clave);
                    cmd.Parameters.Add("@ACCESS", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    acceder = (bool)cmd.Parameters["@ACCESS"].Value;
                }
            }
            return acceder;
        }
        public List<Modelos.Rol> listaRoles()
        {
            List<Modelos.Rol> lista = new List<Modelos.Rol> ();
            string query = "SELECT ID,NAME_ROLS AS NOMBRE FROM SALES.ROLS WHERE ACTIVE = 1";
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
                            while(reader.Read())
                            {
                                lista.Add(new Modelos.Rol
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    NOMBRE = reader["NOMBRE"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Rol>();
                }
            }
            return lista;
        }
        public List<Modelos.Usuario> ListaUsuarios()
        {
            List <Modelos.Usuario> lista = new List<Modelos.Usuario> ();
            string query = "SELECT SU.ID AS ID,SU.USERS_NAME AS NOMBRE,SR.ID AS 'ID ROL',SR.NAME_ROLS AS 'ROL',SE.ID AS 'ID EMPLEADO' ," +
                "SE.NAMES +' '+ SE.LASTNAMES AS EMPLEADO FROM SALES.USERS SU INNER JOIN SALES.ROLS SR  ON SU.ID_ROL = SR.ID " +
                "INNER JOIN SALES.EMPLOYEES SE ON SE.ID = SU.ID_EMPLOYEE WHERE SU.ACTIVE = 1";
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
                                lista.Add(new Modelos.Usuario
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    NOMBRE = reader["NOMBRE"].ToString(),
                                    ROL = new Modelos.Rol
                                    {
                                        ID = Convert.ToInt32(reader["ID ROL"]),
                                        NOMBRE = reader["ROL"].ToString()
                                    },
                                    EMPLEADO = new Modelos.Empleado
                                    {
                                        ID= Convert.ToInt32(reader["ID EMPLEADO"]),
                                        NOMBRE = reader["EMPLEADO"].ToString()
                                    }
                                }) ;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Usuario>();
                }
            }
            return lista;
        }
        public List<Modelos.Empleado> listaEmpleados()
        {
            List<Modelos.Empleado> lista = new List<Modelos.Empleado>();
            string query = "SELECT ID,DNI FROM SALES.EMPLOYEES WHERE ACTIVE = 1";
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
                                lista.Add(new Modelos.Empleado
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    DNI = reader["DNI"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Empleado>();
                }

            }
            return lista;
        }
        public string accionesUsuario(Modelos.Usuario user, bool empleadoNulo)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTER_USER", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", user.ID);
                    comand.Parameters.AddWithValue("@ID_EMPLOYEE", user.EMPLEADO.ID);
                    comand.Parameters.AddWithValue("@NAME", user.NOMBRE);
                    comand.Parameters.AddWithValue("@PASSWORD", user.CLAVE);
                    comand.Parameters.AddWithValue("@ID_ROL", user.ROL.ID);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
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
        public string eliminarUsuario(int idU)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_DELETE_USER", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", idU);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["MESSAGE"].Value.ToString();
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