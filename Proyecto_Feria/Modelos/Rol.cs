using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Rol
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public bool ESTADO { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
