using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataEmpleados
    {
        string mensaje = "";
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
                                    salarioHora = Convert.ToDecimal(reader[10]),
                                    fechaRegistro = reader[11].ToString()
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
        public string accionesEmpleados(Empleado emp)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTRAR_EMPLEADO", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_EMPLEADO", emp.id);
                    comand.Parameters.AddWithValue("@CEDULA", emp.cedula);
                    comand.Parameters.AddWithValue("@NOMBRE", emp.nombres);
                    comand.Parameters.AddWithValue("@APELLIDO", emp.apellidos);
                    comand.Parameters.AddWithValue("@SEXO", emp.sexo);
                    comand.Parameters.AddWithValue("@FECHA_NACIMIENTO", emp.nacimiento);
                    comand.Parameters.AddWithValue("@TELEFONO", emp.telefono);
                    comand.Parameters.AddWithValue("@DIRECCION", emp.direccion);
                    comand.Parameters.AddWithValue("@CORREO", emp.correo);
                    comand.Parameters.AddWithValue("@CARGO ", emp.cargo);
                    comand.Parameters.AddWithValue("@SALARIO", emp.salarioHora);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "Lo sentimos a ocurrido un \nerror : " + ex.Message;
                }
            }
            return mensaje;
        }
        public string eliminarEmpleado(int id)
        {

            using (SqlConnection con = new conexion().conectar())
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand("PROC_ELIMINAR_EMPLEADO", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID_EMPLEADO", id);
                    comand.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "no se pudo eliminar el empleado. error: " + ex.Message;
                }
            }
            return mensaje;
        }
    }
}
