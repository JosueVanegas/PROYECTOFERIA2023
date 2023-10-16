using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace CapaDatos
{
    public class DataProveedor
    {
        string mensaje = "";
        public DataProveedor() { }
        public List<Modelos.Proveedor> listarProveedores()
        {
            string query = "SELECT ID,COMPANY,NAMES_CONTACT,PHONE_CONTACT,COUNTRY,CITY FROM INVENTORY.SUPPLIERS WHERE ACTIVE = 1";
            List<Modelos.Proveedor> lista = new List<Modelos.Proveedor>();

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

                                lista.Add(new Modelos.Proveedor
                                {
                                    ID = reader.GetInt32("ID"),
                                    EMPRESA = reader["COMPANY"].ToString(),
                                    CONTACTO = reader["NAMES_CONTACT"].ToString(),
                                    TELEFONO = reader["PHONE_CONTACT"].ToString(),
                                    PAIS = reader["COUNTRY"].ToString(),
                                    CIUDAD = reader["CITY"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Proveedor>();
            }
            return lista;
        }
        public string accionesProveedor(Modelos.Proveedor prov)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTER_SUPPLIER", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", prov.ID);
                    comand.Parameters.AddWithValue("@COMPANY", prov.EMPRESA);
                    comand.Parameters.AddWithValue("@CONTACT", prov.CONTACTO);
                    comand.Parameters.AddWithValue("@PHONE", prov.TELEFONO);
                    comand.Parameters.AddWithValue("@COUNTRY", prov.PAIS);
                    comand.Parameters.AddWithValue("@CITY", prov.CIUDAD);
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
        public string eliminarProveedor(int id)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("[PROC_DELETE_SUPPLIER]", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", id);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
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
