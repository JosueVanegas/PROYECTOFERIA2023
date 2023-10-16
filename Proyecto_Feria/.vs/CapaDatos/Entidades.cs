using System.Security.Cryptography;

namespace CapaDatos
{
    //RELACIONADOS CON EL PROCESO DE COMPRA Y VENTA
    public class ResumenVenta
    {
        public decimal descuento { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
   
    public class DetalleVenta
    {
        public int ID_VENTA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string NOMBRE { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public decimal SUBTOTAL { get; set; }
    }
    public class infoVenta
    {
        public int ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal IVA { get; set; }
    }
   

    //RELACIONADAS CON INFORMES
    public class informeVentas
    {
        public string noFactura { get; set; }
        public string nombreCliente { get; set; }
        public string nombreEmpleado { get; set; }
        public decimal iva { get; set; }
        public decimal subtotal { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public string fecha { get; set; }
    }
    public class informeInventario
    {
        public string codigo { get; set; }
        public string producto { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public string fecha { get; set; }
    }
    public class informeCompras
    {
        public string factura { get; set;}
        public string usuario { get; set;}
        public string empleado { get; set; }
        public decimal total { get; set; }
        public string fecha { get; set; }
    }
    public class nomina
    {
        public string trabajador { get; set; }
        public string cargo { get; set; }
        public decimal salarioHora { get; set; }
        public int horastrabajadas { get; set; }
        public decimal montoHorasTrabajadas { get; set; }
        public int horasExtras { get; set; }
        public decimal montoHorasExtras { get; set; }
        public decimal salarioDevengado { get; set; }
        public decimal inss { get; set; }
        public decimal ir { get; set; }
        public decimal totalDeducciones { get; set; }
        public decimal salarioNeto { get; set; }
    }

    public class movimientoProducto
    {
        public string fecha { get; set; }
        public string tipo { get; set; }
        public int cantidad { get;set; }
        public decimal precio { get; set; }
        public decimal total { get; set; }
    }
}
