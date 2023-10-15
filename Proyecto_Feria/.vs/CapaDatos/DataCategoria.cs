using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataCategoria
    {
        string mensaje = "";
        public DataCategoria() { }
        public List<Modelos.Categoria> listarCategorias()
        {
            List<Modelos.Categoria> lista = new List<Modelos.Categoria>();
            string query = "SELECT ID,NAMES FROM INVENTORY.CATEGORYS WHERE ACTIVED = 1";
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
                                lista.Add(new Modelos.Categoria
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    NOMBRE = reader["NAMES"].ToString(),
                                });
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Categoria>();
                }
            }
            return lista;
        }

        public string accionesCategoria(Modelos.Categoria ca)
        {
            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_CATEGORY", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", ca.ID);
                        cmd.Parameters.AddWithValue("@NAME", ca.NOMBRE);
                        cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
            return mensaje;
        }
        public string eliminarCategoria(int id)
        {
            mensaje = "";
            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_DELETE_CATEGORY", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
            return mensaje;
        }
    }
}
