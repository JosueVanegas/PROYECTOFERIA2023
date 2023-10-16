using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Producto
    {
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string MARCA { get; set; }
        public string UNIDAD { get; set; }
        public byte[] IMAGEN {  get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public DateTime VENCIMIENTO { get; set; }
        public int STOCK {  get; set; }
        public int STOCK_SEGURIDAD { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public Categoria CATEGORIA { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
