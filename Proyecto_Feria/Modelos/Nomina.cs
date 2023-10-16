using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Nomina
    {
        public string TRABAJADOR { get; set; }
        public string CARGO { get; set; }
        public decimal SALARIOPH { get; set; }
        public int HORAS_TRABAJADAS { get; set; }
        public decimal MONTO_HORAS_TRABAJASDAS { get; set; }
        public int HORAS_EXTRAS { get; set; }
        public decimal MONTO_HORAS_EXTRAS { get; set; }
        public decimal SALARIO_DEVENGADO { get; set; }
        public decimal INSS { get; set; }
        public decimal IR { get; set; }
        public decimal TOTAL_DEDUCCIONES { get; set; }
        public decimal SALARIO_NETO { get; set; }
    }
}
