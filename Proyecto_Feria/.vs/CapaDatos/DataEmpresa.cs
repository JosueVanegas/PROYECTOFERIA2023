using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataEmpresa
    {

        public Empresa datosDeEmpresa()
        {
            Empresa empresa = new Empresa();
            string query = "SELECT NOMBRE,CATEGORIA,DEPARTAMENTO,DIRECCION,EMAIL," +
                "TELEFONO,FECHA_DE_CREACION,IMAGEN FROM DATOS_DE_NEGOCIO WHERE ID = 1";
            try
            {
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                empresa = new Empresa
                                {
                                    nombre = reader[0].ToString(),
                                    rubro = reader[1].ToString(),
                                    departamento = reader[2].ToString(),
                                    direccion = reader[3].ToString(),
                                    email = reader[4].ToString(),
                                    telefono = reader[5].ToString(),
                                    fechaFundacion = reader[6].ToString(),
                                    imagen = (byte[])reader[7]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return empresa;
        }
        public String editarInformacionEmpresa(Empresa emp)
        {
            string mensaje = "";
            try
            {
                using(SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("PROC_DATOS_NEGOCIO", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", emp.nombre);
                    cmd.Parameters.AddWithValue("@CATEGORIA", emp.rubro);
                    cmd.Parameters.AddWithValue("@DEPARTAMENTO", emp.departamento);
                    cmd.Parameters.AddWithValue("@DIRECCION", emp.direccion);
                    cmd.Parameters.AddWithValue("@EMAIL", emp.email);
                    cmd.Parameters.AddWithValue("@TELEFONO", emp.telefono);
                    cmd.Parameters.AddWithValue("@FECHACREACION", emp.fechaFundacion);
                    cmd.Parameters.AddWithValue("@IMAGEN", emp.imagen);
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
    }
}
