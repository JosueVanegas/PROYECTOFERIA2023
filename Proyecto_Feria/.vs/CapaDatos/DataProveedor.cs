using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        using(SqlDataReader reader = cmd.ExecuteReader()) {
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
        //hay que adaptarlo para proveedor enves de usuario
        public string accionesProveedor(Proveedor prov)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_PROVEEDOR", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_USUARIO", prov.id);
                    comand.Parameters.AddWithValue("@ID_EMPLEADO", prov.nombreProveedor);
                    comand.Parameters.AddWithValue("@USUARIO", prov.nombreContacto);
                    comand.Parameters.AddWithValue("@CLAVE", prov.numeroContacto);
                    comand.Parameters.AddWithValue("@ID_ROL", prov.pais);
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
                    comand.Parameters.AddWithValue("@ID_USUARIO", idP);
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
