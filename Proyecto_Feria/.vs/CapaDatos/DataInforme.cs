using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datainforme
    {
        public List<Modelos.Venta> ObtenerDatosInformeVentas(string fechaInicio, string fechaFin)
        {
            List<Modelos.Venta> lista = new List<Modelos.Venta>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_REPORT_SALES";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@START_DATE", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@END_DATE", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Modelos.Venta
                                {
                                    ID = Convert.ToInt32(reader[0].ToString()),
                                    CLIENTE = new Modelos.Cliente
                                    {
                                        NOMBRES = reader[1].ToString()
                                    },
                                    USUARIO = new Modelos.Usuario
                                    {
                                        NOMBRE = reader[2].ToString()
                                    },
                                    SUBTOTAL = Convert.ToDecimal(reader[3].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Venta>();
            }
            return lista;
        }
        public List<Modelos.Compra> ObtenerDatosInformeCompras(string fechaInicio, string fechaFin)
        {
            List<Modelos.Compra> lista = new List<Modelos.Compra>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_REPORT_PURCHASE";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@START_DATE", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@END_DATE", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Modelos.Compra
                                {
                                    ID = Convert.ToInt32(reader[0]),
                                    USUARIO = new Modelos.Usuario { NOMBRE = reader[1].ToString() },
                                    SUBTOTAL = Convert.ToDecimal(reader[2]),
                                    FECHA_REGISTRO = Convert.ToDateTime(reader[3])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Modelos.Compra>();
            }
            return lista;
        }
        public nomina calcularnomina(Modelos.Empleado e, int horasTrabajadas, int horasExtras)
        {
            nomina no = new nomina();
            decimal valorhoras = e.SALARIOPH;
            decimal valorHorasExtras = valorhoras * 2;
            no.trabajador = e.NOMBRE + " " + e.APELLIDO;
            no.cargo = e.CARGO;
            no.salarioHora = valorhoras;
            no.horastrabajadas = horasTrabajadas;
            no.montoHorasTrabajadas = Convert.ToDecimal(horasTrabajadas) *valorhoras;
            no.horasExtras = horasExtras;
            no.montoHorasExtras = Convert.ToDecimal(horasExtras) * valorHorasExtras;
            no.salarioDevengado = no.montoHorasTrabajadas + no.montoHorasExtras;
            no.inss = no.salarioDevengado * Convert.ToDecimal(0.07);
            no.ir = calcularIR(no.salarioDevengado);
            no.totalDeducciones = no.inss + no.ir;
            no.salarioNeto = no.salarioDevengado - no.totalDeducciones;
            return no;
        }
        public List<movimientoProducto> ObtenerDatosInformeMovimientoProducto(int id,string fechaInicio, string fechaFin)
        {
            List<movimientoProducto> lista = new List<movimientoProducto>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_ORDENAR_FECHA_MOVIMIENTO_INVENTARIO";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ID_PRODUCTO", SqlDbType.VarChar, 10)).Value = id;
                        cmd.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new movimientoProducto
                                {
                                    fecha = reader[0].ToString(),
                                    tipo = reader[1].ToString(),
                                    cantidad = Convert.ToInt32(reader[2]),
                                    precio = Convert.ToDecimal(reader[3]),
                                    total = Convert.ToDecimal(reader[4]),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<movimientoProducto>();
            }
            return lista;
        }
        private decimal calcularIR(decimal salariodevengado)
        {
            decimal salario = 0, INSS = 0, IR = 0, suma = 0, NETO, impuestoBase = 0, porcetajeAplicable = 0, sobreExceso = 0;
            if (salariodevengado!= 0)
            {
                salario = salariodevengado;

                INSS = salario * Convert.ToDecimal(0.07);
                suma = salario - INSS;
                suma = suma * 12;

                if ((suma >= Convert.ToDecimal(0.01)) && (suma <= 100000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = 0;
                    sobreExceso = 0;
                }
                else if ((suma > 100000) && (suma <= 200000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = Convert.ToDecimal(0.15);
                    sobreExceso = 100000;
                }
                else if ((suma > 200000) && (suma <= 350000))
                {
                    impuestoBase = 15000;
                    porcetajeAplicable = Convert.ToDecimal(0.20);
                    sobreExceso = 200000;
                }
                else if ((suma > 350000) && (suma <= 500000))
                {
                    impuestoBase = 45000;
                    porcetajeAplicable = Convert.ToDecimal(0.25);
                    sobreExceso = 350000;
                }
                else if (suma > 500000)
                {
                    impuestoBase = 82500;
                    porcetajeAplicable = Convert.ToDecimal(0.30);
                    sobreExceso = 500000;
                }
                suma = suma - sobreExceso;
                suma = suma * porcetajeAplicable;
                suma = suma + impuestoBase;

                IR = suma / 12;
            }
            return IR;
        }
    }
}

