using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_LinkQ.controllers
{
    class AreasControllers
    {
        public AreasControllers()
        {
            _Areas = new List<Areas>();
        }

        private List<Areas> _Areas;
        
        public List<Areas> Areas { get { return _Areas; } }

        #region LlenarDatos
        public void LlenarLista() {
            Areas.Clear();
            Areas.Add(new Areas()
            {
                IdArea = 1,
                NomArea = "Contabilidad"
            });
            Areas.Add(new Areas()
            {
                IdArea = 2,
                NomArea = "Ventas"
            });
            Areas.Add(new Areas()
            {
                IdArea = 3,
                NomArea = "Sistemas"
            });
        }
        #endregion LlenarDatos

        //GET
        #region Mostrar
        public void get() {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from a in Areas select a);
            if (lista.Count > 0)
            {
                ImprimirDatos.Imprimir(lista);
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
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.IdArea == id select o);
            if (lista.Count > 0)
            {
                ImprimirDatos.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nueestra BD");
            }
        }
        #endregion getAreasById

        //post
        #region crearAreas
        public void post()
        {
            //Console.WriteLine("Ingrese el Id del Area");
            //int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del Area");
            string nombre = Console.ReadLine();

            int autoIncremento()
            {
                return _Areas.Count == 0 ?
                    1
                    :
                    (_Areas[_Areas.Count - 1].IdArea) + 1;
            }
  

            var verificarId = Areas.Any(i => i.IdArea == autoIncremento());

            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    IdArea = autoIncremento(),
                    NomArea = nombre,

                });
                Console.WriteLine("Area Creada Correctamente!");
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
            Console.WriteLine("Ingrese el Id del Area");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del Area");
            string nombre = Console.ReadLine();
            var ReplaceItem = new Areas
            {
                IdArea = id,
                NomArea = nombre,

            };
            var element = Areas.FirstOrDefault(i => i.IdArea == ReplaceItem.IdArea);
            if (element != null)
            {
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
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
            var element = Areas.FirstOrDefault(i => i.IdArea == id);
            if (element != null)
            {
                Areas.Remove(element);
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
