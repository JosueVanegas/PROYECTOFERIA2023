﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class ControlInforme
    {
        Datainforme dInfo = new Datainforme();
        public DataTable datosDeVentas(string fechaInicio,string fechaFin)
        {
            return dInfo.llenarInformeVentas(fechaInicio,fechaFin);
        }
    }
}
