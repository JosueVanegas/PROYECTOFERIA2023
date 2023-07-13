using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        string cadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=DBPUNTO_DE_VENTA;Integrated Security=true;TrustServerCertificate=true;";

        public conexion() { }
        public string conexionExitosa()
        {
            string mensaje = "";
            using (SqlConnection con = conectar())
            {
                try
                {
                    con.Open();
                    mensaje = "conexion a base de datos establecida con exito";
                }
                catch (Exception ex)
                {
                    mensaje = "lo sentimos no se a podido conectar a la base";
                }
            }
            return mensaje;
        }
        public SqlConnection conectar()
        {
            return new SqlConnection(cadenaConexion);
        }

        public void desconectar()
        {
            SqlConnection c = conectar();
            c.Open();
            c.Close();
        }

    }
}
