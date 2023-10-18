using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DataOferta
    {
        string mensaje = "";
        public List<Modelos.Ofertas> listarOfertas()
        {
            List<Modelos.Ofertas> lista = new List<Modelos.Ofertas>();
            string query = "SELECT O.ID,O.DESCRIPTIONS,O.AMOUNT,O.PORCENT_DISCOUNT,O.STATE,O.STARTDATE,O.ENDDATE,O.CREATED_AT,P.ID,P.NAMES +' '+P.BRAND + ' '+P.UNIT AS PRODUCT  FROM INVENTORY.OFFERS O INNER JOIN INVENTORY.PRODUCTS P ON P.ID = O.ID_PRODUCT WHERE O.ACTIVE = 1";
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Modelos.Ofertas
                                {
                                    ID = Convert.ToInt32(reader[0]),
                                    DESCRIPCION = reader[1].ToString(),
                                    
                                    CANTIDAD = Convert.ToInt32(reader[2].ToString()),
                                    PORCENTAJE_DESCUENTO = Convert.ToInt32(reader[3].ToString()),
                                    ESTADO = Convert.ToBoolean(reader[4]),
                                    FECHA_INICIO = Convert.ToDateTime(reader[5]),
                                    FECHA_FIN = Convert.ToDateTime(reader[6]),
                                    FECHA_REGISTRO = Convert.ToDateTime(reader[7]),
                                    PRODUCTO = new Modelos.Producto
                                    {
                                        ID = Convert.ToInt32(reader[8].ToString()),
                                        NOMBRE = reader[9].ToString()
                                    },

                                });
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                lista = new List<Modelos.Ofertas>();
            }
            return lista;
        }
        public string registrar(Modelos.Ofertas oferta)
        {
            mensaje = "";
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using(var cmd = new SqlCommand("PROC_REGISTER_OFFER", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", oferta.ID);
                        cmd.Parameters.AddWithValue("@DESCRIPTION", oferta.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@ID_PRODUCT", oferta.PRODUCTO.ID);
                        cmd.Parameters.AddWithValue("@AMOUNT", oferta.CANTIDAD);
                        cmd.Parameters.AddWithValue("@PORCENT_DISCOUNT", oferta.PORCENTAJE_DESCUENTO);
                        cmd.Parameters.AddWithValue("@STATE", oferta.ESTADO);
                        cmd.Parameters.AddWithValue("@STARTDATE", oferta.FECHA_INICIO);
                        cmd.Parameters.AddWithValue("@ENDDATE", oferta.FECHA_FIN);
                        
                        cmd.Parameters.Add("MESSAGE", System.Data.SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }
            return mensaje;
        }
        public string eliminar(int id)
        {
            mensaje = "";
            try
            {
                using(var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand("PROC_DELETE_OFFER", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar,200).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }
            return mensaje;
        }
    }
}
