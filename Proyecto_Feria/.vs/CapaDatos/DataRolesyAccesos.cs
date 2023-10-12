using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataRolesyAccesos
    {

        public List<Modelos.AccesoRol> listarRoles()
        {
            List<Modelos.AccesoRol> lista = new List<Modelos.AccesoRol>();
            using(var con = new conexion().conectar())
            {
                con.Open();
                string query = "SELECT RA.ID,R.ID,AC_SALE,AC_INVENTORY,AC_TOOL,AC_USER,AC_CLIENT,AC_INFORM,AC_EMPLOYEE,AC_SETTING,AC_ACCOUNTING "+
                    "FROM SALES.ROL_ACCESS RA INNER JOIN SALES.ROLS R ON RA.ID_ROL = R.ID WHERE R.ACTIVE = 1";
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
                                    ID = Convert.ToInt32(1)
                                },
                                VENTAS = reader.GetBoolean(2),
                                INVENTARIO = reader.GetBoolean(3),
                                HERRAMIENTAS = reader.GetBoolean(4),
                                USUARIOS = reader.GetBoolean(5),
                                CLIENTES = reader.GetBoolean(6),
                                INFORMES = reader.GetBoolean(7),
                                EMPLEADOS = reader.GetBoolean(8),
                                CONFIGURACIONES = reader.GetBoolean(9),
                                DASHBOARD = reader.GetBoolean(10)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
