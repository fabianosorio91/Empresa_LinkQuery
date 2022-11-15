using Actividad_LinkQ.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_LinkQ.controllers
{
    public class EmpleadosController
    {
        public EmpleadosController()
        {
            _Empleados = new List<Empleados>();
        }
        private List<Empleados> _Empleados;

        public List<Empleados> Empleados { get { return _Empleados; } }

        #region LlenarDatos
        public void LlenarLista()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                IdEmpleado = 1,
                Nombre = "Jeisson",
                Apellido = "Olivares",
                Direccion = "Cll 3 cr 4",
                Telefono = "3123456567",
                FechaIngreso = DateTime.Today,
                IdArea = 1
            });

            Empleados.Add(new Empleados()
            {
                IdEmpleado = 2,
                Nombre = "Fabian",
                Apellido = "Osorio",
                Direccion = "Cll 4 cr 5",
                Telefono = "3123456567",
                FechaIngreso = DateTime.Today,
                IdArea = 2
            });

            Empleados.Add(new Empleados()
            {
                IdEmpleado = 3,
                Nombre = "Pablo",
                Apellido = "Escobar",
                Direccion = "Cll 3 cr 6",
                Telefono = "3123456567",
                FechaIngreso = DateTime.Today,
                IdArea = 1
            });

            Empleados.Add(new Empleados()
            {
                IdEmpleado = 4,
                Nombre = "Martin",
                Apellido = "Estrada",
                Direccion = "Cll 3 cr 9",
                Telefono = "3123456567",
                FechaIngreso = DateTime.Today,
                IdArea = 3
            });

        }
        #endregion LlenarDatos

        //GET
        #region Mostrar
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from a in Empleados select a);
            if (lista.Count > 0)
            {
                ImprimirDatos.ImprimirEmpleados(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        #endregion Mostrar


        //get by Id
        #region getAreasByID
        //getxId
        public void getbyId()
        {
            Console.WriteLine("Ingrese ID a buscar");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.IdEmpleado == id select o);
            if (lista.Count > 0)
            {
                ImprimirDatos.ImprimirEmpleados(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nuestra BD");
            }
        }
        #endregion getAreasById

        //post
        #region crearEmpleados
        public void post()
        {
            Console.WriteLine("Ingrese el nombre del Empleados");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la apellido del Empleado");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el direccion del Empleado");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del Empleado");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de ingreso Empleado");
            DateTime fechaIngreso = Convert.ToDateTime((Console.ReadLine()));
            Console.WriteLine("Ingrese el id del area");
            int idArea = Convert.ToInt32((Console.ReadLine()));

            int autoIncremento()
            {
                return _Empleados.Count == 0 ?
                    1
                    :
                    (_Empleados[_Empleados.Count - 1].IdEmpleado) + 1;
            }

            var verificarId = Empleados.Any(i => i.IdEmpleado == autoIncremento());

            if (!verificarId)
            {
                Empleados.Add(new Empleados()
                {
                    IdEmpleado = autoIncremento(),                   
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    FechaIngreso = fechaIngreso,
                    IdArea = idArea

                });
                Console.WriteLine("Empleado Creado Con Correctamente!");
            }
            else
            {
                Console.WriteLine("Este Empleado ya existe");
            }

        }
        #endregion crearAreas

        //put
        #region ActualizarArea
        public void update()
        {
            Console.WriteLine("Ingrese el Id del Empleado");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del Empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la apellido del Empleado");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el direccion del Empleado");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del Empleado");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de ingreso Empleado");
            DateTime fechaIngreso = Convert.ToDateTime((Console.ReadLine()));

            var ReplaceItem = new Empleados
            {
                IdArea = id,
                NomArea = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = telefono,
                FechaIngreso = fechaIngreso

            };
            var element = Empleados.FirstOrDefault(i => i.IdEmpleado == ReplaceItem.IdEmpleado);
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }
        }
        #endregion ActualizarArea

        //delete
        #region eliminarArea
        public void DeletexId()
        {
            Console.WriteLine("Ingrese el ID del registro a Eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            //var EliminarItem = new Productos { Id = id };
            var element = Empleados.FirstOrDefault(i => i.IdEmpleado == id);
            if (element != null)
            {
                Empleados.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }
        }
        #endregion eliminarArea
    }
}
