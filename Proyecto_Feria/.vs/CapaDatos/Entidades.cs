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
        public int? id { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string fechaRegistro { get; set; }

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
        public Empleado oEmpleado { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string fechaRegistro { get; set; }
        public Rol oRol { get; set; }
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
    /*
     * para pedir la imagen 
     * OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecciona una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                // Aquí puedes hacer algo con la ruta de la imagen seleccionada
                Console.WriteLine("Ruta de la imagen: " + rutaImagen);
            }
         con esta line se convierte a : byte[] datosImagen = File.ReadAllBytes(rutaImagen);
     */
}
