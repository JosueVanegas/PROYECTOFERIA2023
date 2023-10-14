using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CapaDatos
{
    public class DataRolesyAccesos
    {
        string mensaje = "";
        public List<Modelos.AccesoRol> listarRoles()
        {
            List<Modelos.AccesoRol> lista = new List<Modelos.AccesoRol>();
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    string query = "SELECT RA.ID,R.ID,R.NAME_ROLS,AC_SALE,AC_INVENTORY,AC_TOOL,AC_USER,AC_CLIENT,AC_INFORM,AC_EMPLOYEE,AC_SETTING FROM SALES.ROL_ACCESS RA INNER JOIN SALES.ROLS R ON RA.ID_ROL = R.ID WHERE R.ACTIVE = 1";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Modelos.AccesoRol
                                {
                                    ID = Convert.ToInt32(reader[0]),
                                    ROL = new Modelos.Rol
                                    {
                                        ID = Convert.ToInt32(1),
                                        NOMBRE = reader[2].ToString()
                                    },
                                    VENTAS = reader.GetBoolean(3),
                                    INVENTARIO = reader.GetBoolean(4),
                                    HERRAMIENTAS = reader.GetBoolean(5),
                                    USUARIOS = reader.GetBoolean(6),
                                    CLIENTES = reader.GetBoolean(7),
                                    INFORMES = reader.GetBoolean(8),
                                    EMPLEADOS = reader.GetBoolean(9),
                                    CONFIGURACIONES = reader.GetBoolean(10)
                                });
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                lista = new List<Modelos.AccesoRol>();
            }
            return lista;
        }
        public string registrarRol(Modelos.AccesoRol ar)
        {
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using(var cmd = new SqlCommand("PROC_REGISTER_ROL",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID ",ar.ROL.ID);
                        cmd.Parameters.AddWithValue("@NAME", ar.ROL.NOMBRE);
                        cmd.Parameters.AddWithValue("@SALE",ar.VENTAS);
                        cmd.Parameters.AddWithValue("@INVENTORY ",ar.INVENTARIO);
                        cmd.Parameters.AddWithValue("@TOOL",ar.HERRAMIENTAS);
                        cmd.Parameters.AddWithValue("@USER",ar.USUARIOS);
                        cmd.Parameters.AddWithValue("@CLIENT",ar.CLIENTES);
                        cmd.Parameters.AddWithValue("@INFORM",ar.INFORMES);
                        cmd.Parameters.AddWithValue("@EMPLOYEE",ar.EMPLEADOS);
                        cmd.Parameters.AddWithValue("@SETTING",ar.CONFIGURACIONES);
                        cmd.Parameters.Add("MESSAGE", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                mensaje = "Error: "+ex.Message;
            }
            return mensaje;
        }
        public string eliminarRol(int id)
        {
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand("PROC_DELETE_ROL",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ID", id);
                        cmd.Parameters.Add("MESSAGE",SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["MESSAGE"].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                mensaje = "Error: "+ex.Message;
            }
            return mensaje;
        }

        public bool[] accesoUsuarios(int id)
        {
            bool[] accesos = new bool[8];
            string query =  "SELECT "+
                "AC_SALE,AC_INVENTORY,AC_TOOL," +
                "AC_USER,AC_CLIENT,AC_INFORM,"+
                "AC_EMPLOYEE,AC_SETTING "+ 
                $"FROM SALES.ROL_ACCESS WHERE ID_ROL = {id}";
            try
            {
                using (var con = new conexion().conectar())
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                accesos[0] = Convert.ToBoolean(0);
                                accesos[1] = Convert.ToBoolean(1);
                                accesos[2] = Convert.ToBoolean(2);
                                accesos[3] = Convert.ToBoolean(3);
                                accesos[4] = Convert.ToBoolean(4);
                                accesos[5] = Convert.ToBoolean(5);
                                accesos[6] = Convert.ToBoolean(6);
                                accesos[7] = Convert.ToBoolean(7);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }
            return accesos;
        }
    }
}
