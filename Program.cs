using Actividad_LinkQ.controllers;
using System;

namespace Actividad_LinkQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Otros otros = new Otros();
            
            otros.MenuPrincipal();          
        }
    }
}
