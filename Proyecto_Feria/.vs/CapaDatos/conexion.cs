using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        string cadenaConexion = "Data Source=PERSONAL;Initial Catalog=DBPUNTO_DE_VENTA;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";
        public conexion() { }
        public string conexionExitosa()
        {
            string mensaje = "";
            using (SqlConnection con = conectar())
            {
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
                try
                {
                    con.Open();
                    mensaje = "conexion a base de datos establecida con exito";
                }
                catch (Exception ex)
                {
                    mensaje = "lo sentimos no se a podido conectar a la base";
                }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
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
