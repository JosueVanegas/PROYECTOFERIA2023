using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public Modelos.Venta VENTA { get; set; }
        public Modelos.Producto PRODUCTO { get; set; }
        public decimal PRECIO {  get; set; }
        public int CANTIDAD { get; set; }
        public decimal DESCUENTO { get; set; }
    }
}
