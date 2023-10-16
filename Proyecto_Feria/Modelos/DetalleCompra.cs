using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleCompra
    {
        public int ID { get; set; }
        public Modelos.Compra COMPRA { get; set; }
        public Modelos.Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal ULTIMO_PRECIO {  get; set; }
       
    }
}
