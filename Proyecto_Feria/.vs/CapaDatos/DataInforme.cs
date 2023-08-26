using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datainforme
    {
        public DataTable ObtenerDatosInformeVentas(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_ORDENAR_FECHA_VENTA";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.VarChar, 10)).Value = fechaFin;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt); 
                    }
                }
            }
            catch (Exception ex)
            {
    
            }

            return dt;
        }
    }
}

