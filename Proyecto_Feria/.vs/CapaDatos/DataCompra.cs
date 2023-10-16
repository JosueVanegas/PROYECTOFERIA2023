using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataCompra
    {
        public int idCreado = 0;
        public bool acceder;
        string mensaje = string.Empty;
        public DataCompra() { }

        public string procesoDeCompra(Modelos.Compra compra, List<Modelos.DetalleCompra> detalles)
        {
            string mensaje = "";
            try
            {
                if (registrarCompra(compra) == true)
                {
                    
                    if (idCreado > 0)
                    {
                        foreach (Modelos.DetalleCompra d in detalles)
                        {
                            registrarDetalleCompra(d, idCreado);
                        }
                        idCreado = 0;
                        mensaje = "Proceso de compra realizado con exito";
                    }
                    else
                    {
                        mensaje = "No se ha podido generar el id de compra";
                    }
                }
                else
                {
                    mensaje = "No se pudo registrar la compra";
                }
                
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        public List<Modelos.Compra> listarCompras()
        {
            List<Modelos.Compra> lista = new List<Modelos.Compra>();
            string query = "SELECT P.ID,U.USERS_NAME,P.SUBTOTAL,P.CREATED_AT FROM INVENTORY.PURCHASES P INNER JOIN SALES.USERS U ON U.ID = P.ID_USER\r\n";
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
                                lista.Add(new Modelos.Compra
                                {
                                    ID = Convert.ToInt32(reader[0]),
                                    USUARIO = new Modelos.Usuario { NOMBRE = reader[1].ToString()},
                                    SUBTOTAL = Convert.ToDecimal(reader[2]),
                                    FECHA_REGISTRO = Convert.ToDateTime(reader[3]),
                                });
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Compra>();
                }
            }
            return lista;
        }
        public bool registrarCompra(Modelos.Compra c)
        {
            idCreado = 0;
            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_PURCHASE", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_USER", c.USUARIO.ID);
                        cmd.Parameters.AddWithValue("@SUBTOTAL", c.SUBTOTAL);
                        cmd.Parameters.Add("NEWID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add("RESULT", System.Data.SqlDbType.Bit, 30).Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        idCreado = (int)cmd.Parameters["NEWID"].Value;
                        acceder = (bool)cmd.Parameters["RESULT"].Value;
                    }
                }
                catch (Exception ex)
                {
                    idCreado = 0;
                }
            }
            return acceder;
        }
        public void registrarDetalleCompra(Modelos.DetalleCompra d, int id)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_PURCHASE_DETAILS", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_PURCHASE", id);
                        cmd.Parameters.AddWithValue("@ID_PRODUCT", d.PRODUCTO.ID);
                        cmd.Parameters.AddWithValue("@AMOUNT", d.CANTIDAD);
                        cmd.Parameters.AddWithValue("@LASTPRICE", d.ULTIMO_PRECIO);
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

