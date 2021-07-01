﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenWiston.POCO
{
   public class Prestamos
    {
        public double Monto { get; set; }
        public double Plazo { get; set; }
        public double Tasa { get; set; }
        
        public enum TipoPeriodo {
            ANUAL, 
            MENSUAL,
        }
    }
}
