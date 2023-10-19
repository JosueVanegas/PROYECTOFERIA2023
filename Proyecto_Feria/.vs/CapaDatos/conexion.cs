﻿using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        string cadenaConexion = "Data Source=.;Initial Catalog=PEARSON;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;";

        // string cadenaConexion = "Data Source=(local);Initial Catalog=PEARSON;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;";
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
