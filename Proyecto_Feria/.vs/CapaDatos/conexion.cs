﻿using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        string cadenaConexion = "Data Source=LAPTOP-L5B7AIOU\\SQLEXPRESS;Initial Catalog=PEARSON;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
