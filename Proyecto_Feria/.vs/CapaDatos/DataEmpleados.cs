using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataEmpleados
    {
        public List<Empleado> listaEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            string query = "SELECT * FROM EMPLEADO";
            using (var con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    using (var command = new SqlCommand(query, con))
                    {
                        command.CommandType = CommandType.Text;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Empleado
                                {
                                    id = Convert.ToInt32(reader["ID_EMPLEADO"]),
                                    nombres = reader["NOMBRE"].ToString(),
                                    apellidos = reader["APELLIDO"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Empleado>();
                }
            }
            return lista;
        }
    }
}
