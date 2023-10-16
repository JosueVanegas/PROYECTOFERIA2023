using Microsoft.Data.SqlClient;
using Modelos;

namespace CapaDatos
{
    public class DataVenta
    {
        public int idCreado = 0;
        public bool acceder;
        public string mensaje = "";
        public DataVenta() { }

        public string procesoDeVenta(Modelos.Venta v, List<Modelos.DetalleVenta> detalles)
        {
            mensaje = "";
            try
            {
                if (registrarVenta(v))
                {

                }
                if (idCreado > 0)
                {
                    foreach (Modelos.DetalleVenta d in detalles)
                    {
                        registrarDetalleVenta(d, idCreado);
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
            idCreado = 0;
            return mensaje;
        }
        public bool registrarVenta(Venta v)
        {
            idCreado = 0;
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_SALES", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_USER", v.USUARIO.ID);
                        cmd.Parameters.AddWithValue("@ID_CLIENT", v.CLIENTE.ID);
                        cmd.Parameters.AddWithValue("@DISCOUNT", v.DESCUENTO);
                        cmd.Parameters.AddWithValue("@SUBTOTAL", v.SUBTOTAL);
                        cmd.Parameters.AddWithValue("@IVA", v.IVA);
                        cmd.Parameters.Add("NEWID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add("RESULT", System.Data.SqlDbType.Bit, 30).Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        idCreado = (int)cmd.Parameters["ID_CREADO"].Value;
                        acceder = (bool)cmd.Parameters["FACTURA"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                idCreado = 0;
                acceder = false;
            }
            return acceder;
        }
        public void registrarDetalleVenta(Modelos.DetalleVenta d, int id)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_SALES_DETAILS", con))
                    {
                        con.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_SALE", id);
                        cmd.Parameters.AddWithValue("@ID_PRODUCT", d.PRODUCTO.ID);
                        cmd.Parameters.AddWithValue("@LASTPRICE", d.PRECIO);
                        cmd.Parameters.AddWithValue("@AMOUNT", d.CANTIDAD);
                        cmd.Parameters.AddWithValue("@DISCOUNT", d.DESCUENTO);
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
