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
            string query = "SELECT P.ID_PRODUCTO, P.CODIGO_PRODUCTO, P.NOMBRE_PRODUCTO, P.IMAGEN_PRODUCTO, P.PRECIO_COMPRA, P.PRECIO_VENTA, P.CANTIDAD_INVENTARIO, C.ID_CATEGORIA, C.NOMBRE_CATEGORIA, PP.ID_PROVEEDOR, PP.NOMBRE_EMPRESA FROM PRODUCTO P INNER JOIN CATEGORIA C ON P.ID_CATEGORIA = C.ID_CATEGORIA INNER JOIN PROVEEDOR PP ON P.ID_PROVEEDOR = PP.ID_PROVEEDOR";
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
                                Producto producto = new Producto
                                {
                                    id = Convert.ToInt32(reader["ID_PRODUCTO"]),
                                    codigo = reader["CODIGO_PRODUCTO"].ToString(),
                                    nombre = reader["NOMBRE_PRODUCTO"].ToString(),
                                    imagen = (byte[])reader["IMAGEN_PRODUCTO"],
                                    PrecioCompra = Convert.ToDecimal(reader["PRECIO_COMPRA"]),
                                    PrecioVenta = Convert.ToDecimal(reader["PRECIO_VENTA"]),
                                    cantidad = Convert.ToInt32(reader["CANTIDAD_INVENTARIO"]),
                                    oCategoria = new Categoria
                                    {
                                        id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                                        nombre = reader["NOMBRE_CATEGORIA"].ToString()
                                    },
                                    oProveedor = new Proveedor
                                    {
                                        id = Convert.ToInt32(reader["ID_PROVEEDOR"]),
                                        nombreProveedor = reader["NOMBRE_EMPRESA"].ToString()
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
                lista = new List<Producto>();
            }
            return lista;
        }
        public List<comboProducto> listarComboProductos()
        {
            List<comboProducto> lista = new List<comboProducto>();
            string query = "SELECT CODIGO_PRODUCTO,NOMBRE_PRODUCTO FROM PRODUCTO";
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
                                comboProducto producto = new comboProducto
                                {
                                    codigo = reader[0].ToString(),
                                    nombre = reader[1].ToString(),
                                };
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<comboProducto>();
            }
            return lista;
        }
        public List<Proveedor> listarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            string query = "SELECT ID_PROVEEDOR,NOMBRE_EMPRESA FROM PROVEEDOR";
            using (var con = new conexion().conectar())
            {
                con.Open();
                try
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    id = Convert.ToInt32(reader["ID_PROVEEDOR"]),
                                    nombreProveedor = reader["NOMBRE_EMPRESA"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            }
            return lista;
        }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "SELECT ID_CATEGORIA,NOMBRE_CATEGORIA FROM CATEGORIA";
            using (var con = new conexion().conectar())
            {
                con.Open();
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
                try
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
#pragma warning disable CS8601 // Posible asignación de referencia nula
                                lista.Add(new Categoria
                                {
                                    id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                                    nombre = reader["NOMBRE_CATEGORIA"].ToString()
                                });
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
        public string accionesProducto(Producto p)
        {
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("PROC_REGISTRAR_PRODUCTO", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", p.id);
                        cmd.Parameters.AddWithValue("@CODIGO", p.codigo);
                        cmd.Parameters.AddWithValue("@NOMBRE", p.nombre);
                        cmd.Parameters.AddWithValue("@IMAGEN", p.imagen);
                        cmd.Parameters.AddWithValue("@PRECIOCOMPRA", p.PrecioCompra);
                        cmd.Parameters.AddWithValue("@PRECIOVENTA", p.PrecioVenta);
                        cmd.Parameters.AddWithValue("@ID_PROVEEDOR", p.oProveedor.id);
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", p.oCategoria.id);
                        cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
#pragma warning disable CS8601 // Posible asignación de referencia nula
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return mensaje;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
        public string eliminarProducto(int id)
        {
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand("PROC_ELIMINAR_PRODUCTO", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", id);
                        cmd.Parameters.Add("mensaje", System.Data.SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
#pragma warning disable CS8601 // Posible asignación de referencia nula
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();
#pragma warning restore CS8601 // Posible asignación de referencia nula
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo eliminar el producto.\n" + ex.Message;
            }
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return mensaje;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
    }
}
