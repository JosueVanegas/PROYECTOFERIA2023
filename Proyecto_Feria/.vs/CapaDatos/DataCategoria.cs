using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataCategoria
    {
        string mensaje = "";
        public DataCategoria() { }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "SELECT * FROM CategoriaProducto";
            using (var con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using(var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using(var reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                lista.Add(new Categoria
                                {
                                   id = Convert.ToInt32(reader["Id"]),
                                   nombre = reader["Nombre"].ToString()
                                });
                            }
                        }
                    }
                    
                }catch (Exception ex)
                {
                    string x = ex.Message;
                    lista = new List<Categoria>();
                }
            }
           return lista;
        }

        public string accionesCategoria(Categoria ca)
        {
            mensaje = "";

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("registrarEditarCategoria", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", ca.id);
                        cmd.Parameters.AddWithValue("@Nombre", ca.nombre);
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
            using(SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("eliminarCategoria", con))
                    {
                        cmd.CommandType= CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id",id);
                        cmd.Parameters.Add("mensaje",SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    }
                }catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }

            return mensaje;
        }
    }
}
