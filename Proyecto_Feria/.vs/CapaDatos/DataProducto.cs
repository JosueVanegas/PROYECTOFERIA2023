using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataProducto
    {
        string mensaje = "";
        public DataProducto() { }
        public List<Producto> listarProductos()
        {
            List<Producto> lista = new List<Producto>();
            string query = "SELECT ID_PRODUCTO,CODIGO_PRODUCTO,NOMBRE_PRODUCTO,IMAGEN_PRODUCTO,PRECIO_COMPRA,PRECIO_VENTA,CANTIDAD_INVENTARIO,P.ID_PROVEEDOR,P.ID_CATEGORIA,NOMBRE_CATEGORIA,NOMBRE_EMPRESA FROM PRODUCTO P INNER JOIN CATEGORIA C ON P.ID_CATEGORIA = C.ID_CATEGORIA INNER JOIN PROVEEDOR PP ON P.ID_PROVEEDOR = PP.ID_PROVEEDOR";
            try
            {
                using (var con = new conexion().conectar())
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Producto
                                {
                                    id = Convert.ToInt32(reader["ID_PRODUCTO"]),
                                    codigo = Convert.ToInt32(reader["CODIGO_PRODUCTO"]),
                                    nombre = reader["NOMBRE_PRODUCTO"].ToString(),
                                    Imagen = (byte[])reader["IMAGEN_PRODUCTO"],
                                    PrecioCompra = Convert.ToDecimal(reader["PRECIO_COMPRA"]),
                                    PrecioVenta = Convert.ToDecimal(reader["PRECIO_VENTA"]),
                                    cantidad = Convert.ToInt32(reader["CANTIDAD_INVENTARIO"]),
                                    oCategoria = new Categoria
                                    {
                                        id = Convert.ToInt32(reader["P.ID_CATEGORIA"]),
                                        nombre = reader["NOMBRE_CATEGORIA"].ToString()
                                    },
                                    oProveedor = new Proveedor
                                    {
                                        id = Convert.ToInt32(reader["P.ID_PROVEEDOR"]),
                                        nombreProveedor = reader["NOMBRE_EMPRESA"].ToString()
                                    }

                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Producto>();
            }
            return lista;
        }
        public string accionesProducto(Producto p)
        {
            return mensaje;
        }
        public string eliminarProducto(int id)
        {
            try
            {
                using (var con = new conexion().conectar())
                {
                    using (var cmd = new SqlCommand("PROC_ELIMINAR_PRODUCTO", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", id);
                        cmd.Parameters.Add("@mensaje", System.Data.SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();
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
