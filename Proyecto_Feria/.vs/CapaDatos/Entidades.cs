using System.Security.Cryptography;

namespace CapaDatos
{
    public class Entidades
    {
    }
    public class Empresa
    {
        public string nombre { get; set; }
        public string rubro { get; set;}
        public string departamento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string fechaFundacion { get; set; }
        public byte[] imagen { get; set; }
    }
    //clases relacionadas con el login y nominas
    public class Empleado
    {
      public int? id { get; set; }
      public string cedula { get; set; }
      public string nombres { get; set; }
      public string apellidos { get; set; }
      public string sexo { get; set; }
      public string nacimiento { get; set; }
      public string telefono { get; set; }
      public string direccion { get; set; }
      public string correo { get; set; }
      public string cargo { get; set; }
      public decimal salarioHora { get; set; }
      public string fechaRegistro { get; set; }
    }
    public class comboEmpleado
    {
        public int? id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public decimal salario { get; set; }
        public override string ToString()
        {
            return nombres + " " + apellidos;
        }
    }
    public class Rol
    {
        public int id { get; set; }
        public string descripcion { get; set; }
       public string fechaRegistro { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
    public class Estado
    {
        public bool estado { get; set; }
      public string descripcion { get; set; }
        public override string ToString()
        {
            return descripcion;
        }
    }
    public class Usuario
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public comboEmpleado oEmpleado { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string usuario { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string clave { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string fechaRegistro { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public Rol oRol { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
    //clases relacionadas con los productos
    public class Categoria
    {
        public int id { get; set; }
 public string nombre { get; set; }
 public Estado oEstado { get; set; }
  public string fechaRegistro { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }

    public class Proveedor
    {
        public int id { get; set; }
 public string nombreProveedor { get; set; }
 public string nombreContacto { get; set; }
public string numeroContacto { get; set; }
 public string pais { get; set; }
public string ciudad { get; set; }
public string fechaRegistro { get; set; }

        public override string ToString()
        {
            return nombreProveedor;
        }
    }

    public class Producto
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int cantidad { get; set; }
        public Categoria oCategoria { get; set; }
        public Proveedor oProveedor { get; set; }
    }
    public class comboProducto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
    public class Cliente
    {
 public int id { get; set; }
 public string nombre { get; set; }
 public string apellido { get; set; }
 public string telefono { get; set; }
 public string fechaRegistro { get; set; }
    }
    //RELACIONADOS CON EL PROCESO DE COMPRA Y VENTA
    public class ResumenVenta
    {
        public decimal descuento { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
    public class Venta
    {
        public int ID_VENTA { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string NO_FACTURA { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public int ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string FECHA_REGISTRO { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
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
        public decimal TOTAL { get; set; }
    }
    public class graficaProductos
    {
      public string nombre { get; set; }    
        public int cantidad { get; set; }
    }
    public class graficaVentas
    {
        public string fecha { get; set;}
        public decimal total { get; set;}
    }
    public class detalleCompra
    {
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioCompra { get; set; }
        public decimal total { get; set; }
    }
    public class realizarCompra
    {
        public int ID_USUARIO { get; set; }
        public decimal TOTAL { get; set; }
    }
    public class compra
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string factura { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public int idUsuario { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string nombreUsuario { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string fechaRegistro { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
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
