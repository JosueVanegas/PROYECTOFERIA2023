using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaControlador;

namespace CapaControlador
{
     public class ReporteVentas
    {
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<reporteVenta> salesListing { get; private set; }
        public List<VentaNetoPorPeriodo> netSalesByPeriod { get; private set; }
        public double totalNetSales { get; private set; }

        public void CrearReporteVentas(DateTime fromDate, DateTime toDate)
        {
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;
            var orderDao = new OrderDao();
            var result = orderDao.getSalesOrder(fromDate, toDate);
            salesListing = new List<reporteVenta>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var reporteVen = new reporteVenta()
                {
                    No_Factura = Convert.ToString(rows[0]),
                    Nombre_Cliente = Convert.ToString(rows[1]),
                    Apellido_Cliente = Convert.ToString(rows[2]),
                    Atendido_Por = Convert.ToString(rows[3]),
                    Descuento = Convert.ToDecimal(rows[4]),
                    Subtotal = Convert.ToDecimal(rows[5]),
                    IVA = Convert.ToDecimal(rows[6]),
                    Total = Convert.ToDecimal(rows[7]),
                    Fecha = Convert.ToString(rows[8])
                };
                salesListing.Add(reporteVen);
                //calculate total net sales
                totalNetSales += Convert.ToDouble(rows[4]);
            }
            //create net sales by period
            ////create temp list net sales by date
            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.Fecha
                       into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.Total)
                                   }).AsEnumerable();
            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);
            ////group period by days
            /*
             * if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales
                           into listSales
                                    select new VentaNetoPorPeriodo
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            else if (totalDays <= 30)
        {
            netSalesByPeriod = (from sales in listSalesByDate
                                group sales by
                                System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                  sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                    into listSales
                                select new NetSalesByPeriod
                                {
                                    period = "Week " + listSales.Key.ToString(),
                                    netSales = listSales.Sum(item => item.amount)
                                }).ToList();
        }
        ////group period by months
        else if (totalDays <= 365)
        {
            netSalesByPeriod = (from sales in listSalesByDate
                                group sales by sales.date.ToString("MMM-yyyy")
                    into listSales
                                select new NetSalesByPeriod
                                {
                                    period = listSales.Key,
                                    netSales = listSales.Sum(item => item.amount)
                                }).ToList();
        }
        ////group period by years
        else
        {
            netSalesByPeriod = (from sales in listSalesByDate
                                group sales by sales.date.ToString("yyyy")
                    into listSales
                                select new NetSalesByPeriod
                                {
                                    period = listSales.Key,
                                    netSales = listSales.Sum(item => item.amount)
                                }).ToList();
        }
             */
            ////group period by weeks

        }
    }
}
