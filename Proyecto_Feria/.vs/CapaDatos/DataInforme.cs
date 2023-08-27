using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datainforme
    {
        public DataTable ObtenerDatosInformeVentas(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
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
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa

            return dt;
        }
    }
}

