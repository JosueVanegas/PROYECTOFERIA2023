using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos
{
    public class DataProducto
    {
        string mensaje = "";
        public DataProducto() { }
        public List<Modelos.Producto> listarProductos()
        {
            List<Modelos.Producto> lista = new List<Modelos.Producto>();
            string query = "SELECT P.ID AS ID,P.BARCODE AS BARCODE,P.NAMES AS NAME,P.BRAND AS BRAND,P.IMAGES AS IMAGES,P.UNIT AS UNIT, P.PURCHASE_PRICE AS P1,P.SALE_PRICE AS P2,P.DUE_DATE AS DUE,P.STOCK AS STOCK,P.STOCK_SECURITY AS STOCK_SECURITY,\r\nP.ID_SUPPLIERS AS IDS,P.ID_CATEGORYS AS IDC,C.NAMES AS CATEGORY,S.COMPANY AS SUPPLIER\r\nFROM INVENTORY.PRODUCTS P \r\nINNER JOIN INVENTORY.CATEGORYS C ON C.ID = P.ID_CATEGORYS \r\nINNER JOIN INVENTORY.SUPPLIERS S ON S.ID = P.ID_SUPPLIERS\r\nWHERE P.ACTIVE = 1";
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Modelos.Producto producto = new Modelos.Producto
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CODIGO = reader["BARCODE"].ToString(),
                                    NOMBRE = reader["NAME"].ToString(),
                                    MARCA = reader["BRAND"].ToString(),
                                    UNIDAD = reader["UNIT"].ToString(),
                                    IMAGEN = (byte[])reader["IMAGES"],
                                    PRECIO_COMPRA = Convert.ToDecimal(reader["P1"]),
                                    PRECIO_VENTA = Convert.ToDecimal(reader["P2"]),
                                    STOCK_SEGURIDAD = Convert.ToInt32(reader["STOCK_SECURITY"]),
                                    STOCK = Convert.ToInt32(reader["STOCK"]),
                                    VENCIMIENTO = Convert.ToDateTime(reader["DUE"]),
                                    CATEGORIA = new Modelos.Categoria
                                    {
                                        ID = Convert.ToInt32(reader["IDC"]),
                                        NOMBRE = reader["CATEGORY"].ToString()
                                    },
                                    PROVEEDOR = new Modelos.Proveedor
                                    {
                                        ID = Convert.ToInt32(reader["IDS"]),
                                        EMPRESA = reader["SUPPLIER"].ToString()
                                    }
                                };
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Producto>();
            }
            return lista;
        }
        public string accionesProducto(Modelos.Producto p)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTER_PRODUCT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", p.ID);
                        cmd.Parameters.AddWithValue("@BARCODE", p.CODIGO);
                        cmd.Parameters.AddWithValue("@NAME", p.NOMBRE);
                        cmd.Parameters.AddWithValue("@BRAND", p.MARCA);
                        cmd.Parameters.AddWithValue("@UNIT", p.UNIDAD);
                        cmd.Parameters.AddWithValue("@IMAGE", p.IMAGEN);
                        cmd.Parameters.AddWithValue("@STOCK_SECURITY", p.STOCK_SEGURIDAD);
                        cmd.Parameters.AddWithValue("@P1", p.PRECIO_COMPRA);
                        cmd.Parameters.AddWithValue("@P2", p.PRECIO_VENTA);
                        cmd.Parameters.AddWithValue("@ID_SUPPLIER", p.PROVEEDOR.ID);
                        cmd.Parameters.AddWithValue("@ID_CATEGORY", p.CATEGORIA.ID);
                        cmd.Parameters.AddWithValue("@DUE", p.VENCIMIENTO);
                        cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
        public string eliminarProducto(int id)
        {
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand("PROC_DELETE_PRODUCT", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.Add("MESSAGE", System.Data.SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo eliminar el producto.\n" + ex.Message;
            }
            return mensaje;
        }
    }
}
