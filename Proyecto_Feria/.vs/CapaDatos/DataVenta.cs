using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DataVenta
    {
        public int idCreado = 0;
        public string noFactura = string.Empty;
        public DataVenta() { }

        public string tomarFactura()
        {
            return noFactura;
        }
        public string procesoDeVenta(infoVenta v, List<DetalleVenta> detalles)
        {
            string mensaje = "";
            try
            {
                int id = registrarVenta(v);
                if (id > 0)
                {
                    foreach (DetalleVenta d in detalles)
                    {
                        registrarDetalleVenta(d, id);
                    }
                    mensaje = "Proceso de venta realizado con exito";
                }
                else
                {
                    mensaje = "No se ha podido realizar el registro de la venta";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        public int registrarVenta(infoVenta v)
        {
            idCreado = 0;
            noFactura = string.Empty;
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_VENTA", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_USUARIO", v.ID_USUARIO);
                        cmd.Parameters.AddWithValue("@ID_CLIENTE", v.ID_CLIENTE);
                        cmd.Parameters.AddWithValue("@DESCUENTO", v.DESCUENTO);
                        cmd.Parameters.AddWithValue("@SUBTOTAL", v.SUBTOTAL);
                        cmd.Parameters.AddWithValue("@IVA", v.IVA);
                        cmd.Parameters.AddWithValue("@TOTAL", v.TOTAL);
                        cmd.Parameters.Add("ID_CREADO", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add("FACTURA", System.Data.SqlDbType.VarChar, 30).Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        idCreado = (int)cmd.Parameters["ID_CREADO"].Value;
                        noFactura = cmd.Parameters["FACTURA"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                idCreado = 0;
                noFactura = string.Empty;
            }
            return idCreado;
        }
        public void registrarDetalleVenta(DetalleVenta d, int id)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_DETALLE_VENTA", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_VENTA", id);
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", d.ID_PRODUCTO);
                        cmd.Parameters.AddWithValue("@PRECIOVENTA", d.PRECIO);
                        cmd.Parameters.AddWithValue("@CANTIDAD", d.CANTIDAD);
                        cmd.Parameters.AddWithValue("@SUBTOTAL", d.SUBTOTAL);
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
