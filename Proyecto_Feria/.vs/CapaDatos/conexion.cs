using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        //kerlint para que vos podas usar la base de datos nueva cambia LAPTOP-9REFC867\SQLEXPRESS por PERSONAL
        string cadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PEARSON;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";
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
