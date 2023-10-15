using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Categoria
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
