using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataCompra
    {
        string mensaje = "";
        public DataCompra() { }

        public List<compra> listarCategorias()
        {
            List<compra> lista = new List<compra>();
            string query = "SELECT * FROM COMPRA";
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
                              
                                lista.Add(new compra
                                {
                                    id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                                   total = 0,
                                 
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<compra>();
                }
            }
            return lista;
        }

        public string accionesCategoria(Categoria ca)
        {
            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_CATEGORIA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", ca.id);
                        cmd.Parameters.AddWithValue("@NOMBRE_CATEGORIA", ca.nombre);
                        cmd.Parameters.AddWithValue("@ESTADO_CATEGORIA", ca.oEstado.estado);
                        cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        mensaje = cmd.Parameters["mensaje"].Value.ToString();

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
                    using (SqlCommand cmd = new SqlCommand("PROC_ELIMINAR_CATEGORIA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", id);
                        cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        mensaje = cmd.Parameters["mensaje"].Value.ToString();

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

