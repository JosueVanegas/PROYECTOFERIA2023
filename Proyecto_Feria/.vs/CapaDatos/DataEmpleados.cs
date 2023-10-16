using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataEmpleados
    {
        string mensaje = "";
        public List<Modelos.Empleado> listaEmpleados()
        {
            List <Modelos.Empleado> lista = new List<Modelos.Empleado>();
            string query = "SELECT ID,DNI,NAMES,LASTNAMES,SEX,BIRTHDATE,PHONE,ADDRESS_,EMAIL,JOB_TITLE,HOURLY_RATE FROM SALES.EMPLOYEES WHERE ACTIVE = 1";
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
                                lista.Add(new Modelos.Empleado
                                {
                                    ID = Convert.ToInt32(reader["ID"].ToString()),
                                    DNI = reader["DNI"].ToString(),
                                    NOMBRE = reader["NAMES"].ToString(),
                                    APELLIDO = reader["LASTNAMES"].ToString(),
                                    SEXO = Convert.ToChar(reader["SEX"]),
                                    NACIMIENTO = Convert.ToDateTime(reader["BIRTHDATE"]),
                                    TELEFONO = reader["PHONE"].ToString(),
                                    DIRECCION = reader["ADDRESS_"].ToString(),
                                    CORREO = reader["EMAIL"].ToString(),
                                    CARGO = reader["JOB_TITLE"].ToString(),
                                    SALARIOPH = Convert.ToDecimal(reader["HOURLY_RATE"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Modelos.Empleado>();
                }
            }
            return lista;
        }
        public string accionesEmpleados(Modelos.Empleado emp)
        {
            using (SqlConnection connection = new conexion().conectar())
            {
                try
                {
                    connection.Open();
                    SqlCommand comand = new SqlCommand("PROC_REGISTER_EMPLOYEE", connection);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", emp.ID);
                    comand.Parameters.AddWithValue("@DNI", emp.DNI);
                    comand.Parameters.AddWithValue("@NAME", emp.NOMBRE);
                    comand.Parameters.AddWithValue("@LASTNAME", emp.APELLIDO);
                    comand.Parameters.AddWithValue("@SEX", emp.SEXO);
                    comand.Parameters.AddWithValue("@BIRTHDATE", emp.NACIMIENTO);
                    comand.Parameters.AddWithValue("@PHONE", emp.TELEFONO);
                    comand.Parameters.AddWithValue("@ADDRESS", emp.DIRECCION);
                    comand.Parameters.AddWithValue("@EMAIL", emp.CORREO);
                    comand.Parameters.AddWithValue("@JODTITLE ", emp.CARGO);
                    comand.Parameters.AddWithValue("@HOURLYRATE", emp.SALARIOPH);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["MESSAGE"].Value.ToString();
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
                    SqlCommand comand = new SqlCommand("PROC_DELETE_EMPLOYEE", con);
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@ID", id);
                    comand.Parameters.Add("MESSAGE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comand.ExecuteNonQuery();
                    mensaje = comand.Parameters["MESSAGE"].Value.ToString();
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
