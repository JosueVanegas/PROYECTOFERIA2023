using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataCompra
    {
        public int idCreado = 0;
        public string noFactura = string.Empty;
        string mensaje = string.Empty;
        public DataCompra() { }

        public string procesoDeCompra(realizarCompra rc, List<detalleCompra> detalles)
        {
            string mensaje = "";
            try
            {
                int id = registrarCompra(rc);
                if (id > 0)
                {
                    foreach (detalleCompra d in detalles)
                    {
                        registrarDetalleCompra(d, id);
                    }
                    mensaje = "Proceso de compra realizado con exito";
                }
                else
                {
                    mensaje = "No se ha podido realizar el registro de la compra";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        public List<compra> listarCompras()
        {
            List<compra> lista = new List<compra>();
            string query = "SELECT C.ID_COMPRA,C.NO_FACTURA,C.ID_USUARIO,U.USUARIO,C.TOTAL_COMPRA,C.FECHA_REGISTRO FROM COMPRA C INNER JOIN USUARIO U ON C.ID_USUARIO = U.ID_USUARIO ";
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
                                    id = Convert.ToInt32(reader["C.ID_COMPRA"]),
                                    factura = reader["C.NO_FACTURA"].ToString(),
                                    idUsuario = Convert.ToInt32(reader["C.ID_USUARIO"]),
                                    nombreUsuario  = reader["U.USUARIO"].ToString(),
                                    total = Convert.ToInt32(reader["C.TOTAL_COMPRA"]),
                                    fechaRegistro = reader["C.FECHA_REGISTRO"].ToString()
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
        public int registrarCompra(realizarCompra c)
        {
            idCreado = 0;
            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_COMPRA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_USUARIO", c.ID_USUARIO);
                        cmd.Parameters.AddWithValue("@TOTAL_COMPRA", c.TOTAL);
                        cmd.Parameters.Add("ID_CREADO", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add("NO_FACTURA", System.Data.SqlDbType.VarChar, 30).Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        idCreado = (int)cmd.Parameters["ID_CREADO"].Value;
                        noFactura = cmd.Parameters["NO_FACTURA"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    idCreado = 0;
                }
            }
            return idCreado;
        }
        public void registrarDetalleCompra(detalleCompra d, int id)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_DETALLE_COMPRA", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_COMPRA", id);
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", d.idProducto);
                        cmd.Parameters.AddWithValue("@CANTIDAD", d.cantidad);
                        cmd.Parameters.AddWithValue("@SUBTOTAL", d.total);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}

