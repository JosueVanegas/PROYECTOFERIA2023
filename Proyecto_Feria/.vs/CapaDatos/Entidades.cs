namespace CapaDatos
{
    public class Entidades
    {
    }
    //clases relacionadas con el login y nominas
    public class Empleado
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string fechaRegistro { get; set; }

    }
    public class Rol
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string fechaRegistro { get; set; }
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
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }
    }

    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Producto
    {
        public int id { get; set; }
        public byte[] Imagen { get; set; }
        public string nombre { get; set; }
        public Categoria oCategoria { get; set; }
        public int ProveedorId { get; set; }
        public decimal Precio { get; set; }

        public Categoria Categoria { get; set; }
        public Proveedor Proveedor { get; set; }
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
