using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_LinkQ.models
{
    public class Empleados: Areas
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        
    }
}

