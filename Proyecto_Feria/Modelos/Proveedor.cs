using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Proveedor
    {
        
        public int ID { get; set; }
        public string EMPRESA {  get; set; }
        public string CONTACTO { get; set; }
        public string TELEFONO { get; set; }
        public string PAIS { get; set; }
        public string CIUDAD { get; set; }
        public override string ToString()
        {
            return EMPRESA;
        }

    }
}
