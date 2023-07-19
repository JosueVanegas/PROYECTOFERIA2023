using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataCategoria
    {
        string mensaje = "";
        public DataCategoria() { }

        public List<Estado> listarEstados()
        {
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado {estado = true,descripcion = "ACTIVA" });
            estados.Add(new Estado { estado = false, descripcion = "INACTIVA" });
            return estados;
        }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "SELECT * FROM CATEGORIA";
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
                                string descrip = "";
                                bool sta = Convert.ToBoolean(reader["ESTADO_CATEGORIA"]);
                                if (sta == true)
                                {
                                    descrip = "ACTIVA";
                                }
                                else
                                {
                                    descrip = "INACTIVA";
                                }
                                Estado estado = new Estado
                                {
                                    estado = sta,
                                    descripcion = descrip
                                };
                                lista.Add(new Categoria
                                {
                                    id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                                    nombre = reader["NOMBRE_CATEGORIA"].ToString(),
                                    oEstado = estado,
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
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
