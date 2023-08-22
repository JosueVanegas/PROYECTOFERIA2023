using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class OrderDao 
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = new conexion().conectar())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"PROC_ORDENAR_FECHA_VENTA";
                    command.Parameters.AddWithValue("@fechaInicio", fromDate);
                    command.Parameters.AddWithValue("@fechaFin", toDate);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }
    }
}
