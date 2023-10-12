namespace Modelos
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string CLAVE { get; set; }
        public bool ESTADO { get; set; }
        public Rol ROL { get; set; }
        public Empleado EMPLEADO { get; set; }
        public int FECHA_REGISTRO { get; set; }
    }
}