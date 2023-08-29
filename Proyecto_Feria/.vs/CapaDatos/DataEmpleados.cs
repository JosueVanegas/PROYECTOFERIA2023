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
                                    id = Convert.ToInt32(reader[0]),
                                    cedula = reader[1].ToString(),
                                    nombres = reader[2].ToString(),
                                    apellidos = reader[3].ToString(),
                                    sexo = reader[4].ToString(),
                                    nacimiento = reader[5].ToString(),
                                    telefono = reader[6].ToString(),
                                    direccion = reader[7].ToString(),
                                    correo = reader[8].ToString(),
                                    cargo = reader[9].ToString(),
                                    salario = Convert.ToDecimal(reader[10]),
                                    fechaRegistro = reader[9].ToString()
                                    
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
