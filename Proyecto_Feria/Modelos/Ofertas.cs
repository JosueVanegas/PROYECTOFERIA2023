using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Ofertas
    {
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public Modelos.Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public int PORCENTAJE_DESCUENTO { get; set; }
        public bool ESTADO { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public  DateTime FECHA_REGISTRO { get; set; }
    }
}
