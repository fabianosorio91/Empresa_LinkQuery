using Actividad_LinkQ.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_LinkQ.controllers
{
    public static class ImprimirDatos
    {
        public static void Imprimir(List<Areas> Area) {
            foreach (var item in Area) {
                Console.WriteLine("Id: {0} Nombre: {1}", item.IdArea, item.NomArea);
            }
        }

        public static void ImprimirEmpleados(List<Empleados> Empleado)
        {
            foreach (var item in Empleado)
            {
                Console.WriteLine("Id: {0} Nombre: {1} Apellido: {2} Direccion: {3} Telefono: {4} FechaIngreso: {5} IdArea: {6}", 
                    item.IdEmpleado, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.FechaIngreso, item.IdArea);
            }
        }

        public static void ImprimirNomina(List<Nominas> Nominas)
        {
            foreach (var item in Nominas)
            {
                Console.WriteLine("Id: {0} Fecha: {1} Sueldo: {2} Días: {3} TotalBasico: {4} Otros: {5} Devengado: {6} IdEmpleado: {7}",
                    item.IdNomina, item.Fecha, item.Sueldo, item.Dias, item.TotalBasico, item.Otros, item.Devengado, item.IdEmpleado);
            }
        }
    }
}
