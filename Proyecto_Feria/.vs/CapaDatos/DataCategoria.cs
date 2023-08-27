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
            estados.Add(new Estado { estado = true, descripcion = "ACTIVA" });
            estados.Add(new Estado { estado = false, descripcion = "INACTIVA" });
            return estados;
        }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "SELECT * FROM CATEGORIA";
            using (var con = new conexion().conectar())
            {
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
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
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                                lista.Add(new Categoria
                                {
                                    id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                                    nombre = reader["NOMBRE_CATEGORIA"].ToString(),
                                    oEstado = estado,
                                    fechaRegistro = reader["FECHA_REGISTRO"].ToString()
                                });
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
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

#pragma warning disable CS8601 // Posible asignación de referencia nula
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula

                    }
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

#pragma warning disable CS8601 // Posible asignación de referencia nula
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula

                    }
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
    }
}
