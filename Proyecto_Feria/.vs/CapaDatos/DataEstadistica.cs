using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DataEstadistica
    {
        public DataEstadistica() { }

        public int cantidadDeObjetosEnTabla(string nombreTabla)
        {
            int cantidadFilas = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM " + nombreTabla;

                using (SqlConnection con = new conexion().conectar())
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    cantidadFilas = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return cantidadFilas;
        }
        public List<int> TopClientes()
        {
            List<int> lista = new List<int>();
            try
            {
                string query = "";
                using (SqlConnection con = new conexion().conectar())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using(SqlDataReader  reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            }
                        }
                    }
                }
            }catch (Exception ex) 
            {

            }
            return lista;
        }
    }
}
