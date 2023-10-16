using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos
{
    public class DataEmpresa
    {

        public Modelos.Empresa datosDeEmpresa()
        {
            Modelos.Empresa empresa = new Modelos.Empresa();
            string query = "SELECT NAME,IMAGE,ADDRESS,PHONE,EMAIL FROM METADATA_COMPANY ";
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
                                empresa = new Modelos.Empresa
                                {
                                    NOMBRE = reader["NAME"].ToString(),
                                    IMAGEN = (byte[])reader["IMAGE"],
                                    DIRECCION = reader["ADDRESS"].ToString(),
                                    TELEFONO = reader["PHONE"].ToString(),
                                    CORREO = reader["EMAIL"].ToString(),
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
        public String editarInformacionEmpresa(Modelos.Empresa emp)
        {
            string mensaje = "";
            try
            {
                using(SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("PROC_METADATA_COMPANY", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", 1);
                    cmd.Parameters.AddWithValue("@NAME", emp.NOMBRE);
                    cmd.Parameters.AddWithValue("@IMAGE", emp.IMAGEN);
                    cmd.Parameters.AddWithValue("@ADDRESS", emp.DIRECCION);
                    cmd.Parameters.AddWithValue("@PHONE", emp.TELEFONO);
                    cmd.Parameters.AddWithValue("@EMAIL", emp.CORREO);
                    cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                }

            }catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }
    }
}
