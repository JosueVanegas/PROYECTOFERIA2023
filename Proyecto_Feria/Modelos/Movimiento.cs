using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Movimiento
    {
        public int ID { get; set; }
        public string TIPO { get; set; }
        public DateTime FECHA { get; set; }
        public Modelos.Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
    }
}
