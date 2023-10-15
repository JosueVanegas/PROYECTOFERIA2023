using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        //SELECT ID, DNI, NAMES, LASTNAMES, PHONE, BIRTHDATE, PHONE FROM SALES.CLIENTS WHERE ACTIVE = 1
        public int ID { get; set; }
        public string CEDULA { get; set; }
        public string NOMBRES { get; set; }
        public string  APELLIDOS { get; set; }
        public string TELEFONO { get; set; }
        public DateTime NACIMIENTO { get; set; }
        public int FECHA_REGISTRO { get; set; }
    }
}
