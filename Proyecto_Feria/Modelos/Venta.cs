using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venta
    {
        public int ID { get; set; }
        public Modelos.Usuario USUARIO { get; set; }
        public Modelos.Cliente CLIENTE { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal IVA { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }
    }
}
