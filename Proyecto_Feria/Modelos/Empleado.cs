using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empleado
    {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public char SEXO { get; set; }
        public DateTime NACIMIENTO { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string CARGO { get; set; }
        public decimal SALARIOPH { get; set; }
        public bool ESTADO { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }

        public override string ToString()
        {
            return DNI;
        }
    }
}
