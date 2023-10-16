using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empresa
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public byte[] IMAGEN { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string TELEFONO { get; set; }
    }
}
