using Actividad_LinkQ.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_LinkQ.controllers
{
    public class NominaController
    {
        public NominaController()
        {
            _Nomina = new List<Nominas>();
        }

        private List<Nominas> _Nomina;

        public List<Nominas> Nomina { get { return _Nomina; } }

        #region LlenarDatos
        public void LlenarLista()
        {
            Nomina.Clear();
            Nomina.Add(new Nominas()
            {
                IdNomina = 1,               
                Sueldo = 1000000,
                Dias = 30,
                TotalBasico = 1000000 * 30 / 30,
                Otros = 25000,
                Devengado = (1000000 * 30 / 30) + 25000,
                IdEmpleado = 1
              });

            Nomina.Add(new Nominas()
            {
                IdNomina = 2,             
                Sueldo = 1500000,
                Dias = 30,
                TotalBasico = 1500000 * 30 / 30,
                Otros = 25000,
                Devengado = (1500000 * 30 / 30) + 25000,
                IdEmpleado = 2

            });

            Nomina.Add(new Nominas()
            {
                IdNomina = 3,
                Sueldo = 2000000,
                Dias = 28,
                TotalBasico = 2000000 * 28 / 30,
                Otros = 28000,
                Devengado = (2000000 * 28 / 30) + 28000,
                IdEmpleado = 3
            });

            Nomina.Add(new Nominas()
            {
                IdNomina = 4,
                Sueldo = 2500000,
                Dias = 20,
                TotalBasico = 2500000 * 20 / 30,
                Otros = 12000,
                Devengado = (2500000 * 20 / 30) + 12000,
                IdEmpleado = 4
            });
        }
        #endregion LlenarDatos

        //GET
        #region Mostrar
        public void get()
        {
            List<Nominas> lista = new List<Nominas>();
            lista.AddRange(from a in Nomina select a);
            if (lista.Count > 0)
            {
                ImprimirDatos.ImprimirNomina(lista);
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
            List<Nominas> lista = new List<Nominas>();
            lista.AddRange(from o in Nomina where o.IdNomina == id select o);
            if (lista.Count > 0)
            {
                ImprimirDatos.ImprimirNomina(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nuestra BD");
            }
        }
        #endregion getAreasById

        //post
        #region crearAreas
        public void post()
        {
            
            Console.WriteLine("Ingrese el Sueldo");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese los dias");
            int dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Otros");
            decimal otros =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese Id del empleado");
            int idEmpleado = Convert.ToInt32(Console.ReadLine());

            int autoIncremento()
            {
                return _Nomina.Count == 0 ?
                    1
                    :
                    (_Nomina[_Nomina.Count - 1].IdNomina) + 1;
            }


            var verificarId = Nomina.Any(i => i.IdNomina == autoIncremento());
           

            if (!verificarId)
            {
                Nomina.Add(new Nominas()
                {
                    IdNomina = autoIncremento(),
                    Sueldo = sueldo,
                    Dias = dias,
                    TotalBasico = Convert.ToDecimal(sueldo * dias / 30),
                    Otros = otros,
                    Devengado = Convert.ToDecimal((sueldo * dias / 30) + otros),
                    IdEmpleado = idEmpleado

                }) ;
                Console.WriteLine("Nomina Creada Correctamente!");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }

        }
        #endregion crearAreas

        //put
        #region ActualizarArea
        public void update()
        {
            Console.WriteLine("Ingrese Id de rigristro a Actualizar");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Sueldo");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese los dias");
            int dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Otros");
            decimal otros = Convert.ToDecimal( Console.ReadLine());
            var ReplaceItem = new Nominas
            {
                IdNomina = id,
                Sueldo = sueldo,
                Dias = dias,
                TotalBasico = Convert.ToDecimal(sueldo * dias / 30),
                Otros = otros,
                Devengado = Convert.ToDecimal((sueldo * dias / 30) + otros)

            };
            var element = Nomina.FirstOrDefault(i => i.IdNomina == ReplaceItem.IdNomina);
            if (element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
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
            var element = Nomina.FirstOrDefault(i => i.IdNomina == id);
            if (element != null)
            {
                Nomina.Remove(element);
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
