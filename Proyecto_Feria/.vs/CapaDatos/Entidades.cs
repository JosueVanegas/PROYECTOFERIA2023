namespace CapaDatos
{
    public class Entidades
    {
    }
    public class empresa
    {
        public string nombre { get; set; }
    }
    //clases relacionadas con el login y nominas
    public class Empleado
    {
        public int? id { get;  set; }
        public string cedula { get;  set; }
        public string nombres { get;  set; }
        public string apellidos { get;  set; }
        public string sexo { get;  set; }
        public string telefono { get;  set; }
        public string direccion { get;  set; }
        public string correo { get;  set; }
        public string fechaRegistro { get;  set; }

        public override string ToString()
        {
            return nombres + " " + apellidos;
        }
    }
    public class Rol
    {
        public int id { get;  set; }
        public string descripcion { get;  set; }
        public string fechaRegistro { get;  set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
    public class Estado
    {
        public bool estado { get;  set; }
        public string descripcion { get;  set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
    public class Usuario
    {
        public int id { get;  set; }
        public Empleado oEmpleado { get;  set; }
        public string usuario { get;  set; }
        public string clave { get;  set; }
        public string fechaRegistro { get;  set; }
        public Rol oRol { get;  set; }
    }
    //clases relacionadas con los productos
    public class Categoria
    {
        public int id { get;  set; }
        public string nombre { get;  set; }
        public Estado oEstado { get;  set; }
        public string fechaRegistro { get;  set; }

        public override string ToString()
        {
            return nombre;
        }
    }

    public class Proveedor
    {
        public int id { get;  set; }
        public string nombreProveedor { get;  set; }
        public string nombreContacto { get;  set; }
        public string numeroContacto { get;  set; }
        public string pais { get;  set; }
        public string ciudad { get;  set; }
        public string fechaRegistro { get;  set; }

        public override string ToString()
        {
            return nombreProveedor;
        }
    }

    public class Producto
    {
        public int id { get;  set; }
        public string codigo { get;  set; }
        public string nombre { get;  set; }
        public byte[] imagen { get;  set; }
        public decimal PrecioCompra { get;  set; }
        public decimal PrecioVenta { get;  set; }
        public int cantidad { get;  set; }
        public Categoria oCategoria { get;  set; }
        public Proveedor oProveedor { get;  set; }
    }
    public class Cliente
    {
        public int id { get;  set; }
        public string nombre {get;   set;}
        public string apellido { get;  set;}
        public string telefono { get;  set; }
        public string fechaRegistro { get;  set; }
    }
    public class ResumenVenta
    {
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
    public class Venta
    {
        public int ID_VENTA { get; set; }
        public string NO_FACTURA { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }
    public class DetalleVenta
    {
        public int ID_VENTA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal SUBTOTAL { get; set; }
    }
    public class infoVenta
    {
        public int ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
    }
    public class productosMasVendidos
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }
    }
}
