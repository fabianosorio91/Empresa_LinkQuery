using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_LinkQ.models
{
    public class Nominas: Empleados
    {
            private DateTime _Fecha = DateTime.Now;

            public int IdNomina { get; set; }
            public DateTime Fecha { get { return _Fecha;} set { Fecha = _Fecha; } }
           
            public decimal Sueldo { get; set; }
            public int Dias { get; set; }
            public decimal TotalBasico { get; set; }
            public decimal Otros { get; set; }
            public decimal Devengado { get; set; }
        }
    }
