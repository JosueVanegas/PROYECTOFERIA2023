using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datainforme
    {
        public List<informeVentas> ObtenerDatosInformeVentas(string fechaInicio, string fechaFin)
        {
            List<informeVentas> lista = new List<informeVentas>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_ORDENAR_FECHA_VENTA";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new informeVentas
                                {
                                    noFactura = reader[0].ToString(),
                                    nombreCliente = reader[1].ToString(),
                                    nombreEmpleado = reader[2].ToString(),
                                    iva = Convert.ToDecimal(reader[3]),
                                    subtotal = Convert.ToDecimal(reader[4]),
                                    descuento = Convert.ToDecimal(reader[5]),
                                    total = Convert.ToDecimal(reader[6]),
                                    fecha = reader[7].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<informeVentas>();
            }
            return lista;
        }

        public List<informeInventario> ObtenerDatosInformeInventario()
        {
            List<informeInventario> lista = new List<informeInventario>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string query = "SELECT P.CODIGO_PRODUCTO,P.NOMBRE_PRODUCTO,C.NOMBRE_CATEGORIA,PR.NOMBRE_EMPRESA,P.PRECIO_COMPRA,P.PRECIO_VENTA,P.CANTIDAD_INVENTARIO,P.FECHA_REGISTRO FROM PRODUCTO P  INNER JOIN PROVEEDOR PR ON P.ID_PROVEEDOR = PR.ID_PROVEEDOR INNER JOIN CATEGORIA C ON C.ID_CATEGORIA = P.ID_CATEGORIA";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new informeInventario
                                {
                                    codigo = reader[0].ToString(),
                                    producto = reader[1].ToString(),
                                    categoria = reader[2].ToString(),
                                    proveedor = reader[3].ToString(),
                                    precioCompra = Convert.ToDecimal(reader[4]),
                                    precioVenta = Convert.ToDecimal(reader[5]),
                                    cantidad = Convert.ToInt32(reader[6]),
                                    fecha = reader[7].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<informeInventario>();
            }
            return lista;
        }
        public List<informeCompras> ObtenerDatosInformeCompras(string fechaInicio, string fechaFin)
        {
            List<informeCompras> lista = new List<informeCompras>();
            try
            {
                using (SqlConnection connection = new conexion().conectar())
                {
                    connection.Open();
                    string procedure = "PROC_ORDENAR_FECHA_COMPRA";
                    using (SqlCommand cmd = new SqlCommand(procedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.VarChar, 10)).Value = fechaInicio;
                        cmd.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.VarChar, 10)).Value = fechaFin;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new informeCompras
                                {
                                    factura = reader[0].ToString(),
                                    usuario = reader[1].ToString(),
                                    empleado = reader[2].ToString(),
                                    total = Convert.ToDecimal(reader[3]),
                                    fecha = reader[4].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<informeCompras>();
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

