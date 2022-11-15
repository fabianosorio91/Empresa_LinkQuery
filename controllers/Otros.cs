using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_LinkQ.controllers
{
    public class Otros
    {
        public Otros()
        {
        }

        public void MenuPrincipal()
        {
            int op = 0;
            do {
                Console.Clear();
                Console.WriteLine("¡Menu Principal!");
                Console.WriteLine("1. Areas");
                Console.WriteLine("2. Empleados");
                Console.WriteLine("3. Nomina");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese una opcion");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case 1:
                        #region CrudAreas
                        int opc1 = 0;
                        AreasControllers AC = new AreasControllers();
                        AC.LlenarLista();
                        do {
                            opc1 = MenuCrud("Areas");
                            switch (opc1)
                            {
                                case 1:
                                    AC.get();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    AC.getbyId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();

                                    break;
                                case 3:
                                    AC.post();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    AC.update();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    AC.DeletexId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("Hasta la proxima!");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida");
                                    break;
                            }

                        } while (opc1 < 6 && opc1 >= 1);
                        break;
                    #endregion CrudAreas
                    case 2:
                        #region CrudEmpleados
                        int opc2 = 0;
                        EmpleadosController EC = new EmpleadosController();
                        EC.LlenarLista();
                        do
                        {
                            opc2 = MenuCrud("Empleados");
                            switch (opc2)
                            {
                                case 1:
                                    EC.get();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    EC.getbyId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    EC.post();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    EC.update();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    EC.DeletexId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("Hasta la proxima!");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida");
                                    break;
                            }
                        } while (opc2 < 6 && opc2 >= 1);
                        break;
                    #endregion CrudEmpleados
                    case 3:
                        #region CrudNomina
                        int opc3 = 0;
                        NominaController NC = new NominaController();
                        NC.LlenarLista();
                        do
                        {
                            opc3 = MenuCrud("Nomina");
                            switch (opc3)
                            {
                                case 1:
                                    NC.get();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    NC.getbyId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    NC.post();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    NC.update();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    NC.DeletexId();
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("Hasta la proxima!");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida");
                                    break;
                            }
                        } while (opc3 < 6 && opc3 >= 1);
                        #endregion CrudNomina
                        break;
                    case 4:
                        Console.WriteLine("Hasta la proxima!!");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }

            } while (op < 4 && op >=1);
            
        }

        public int MenuCrud(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg);
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Mostrar por Id");
            Console.WriteLine("3. Crear");
            Console.WriteLine("4. Actualizar");
            Console.WriteLine("5. Eliminar");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Ingrese una opcion");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
