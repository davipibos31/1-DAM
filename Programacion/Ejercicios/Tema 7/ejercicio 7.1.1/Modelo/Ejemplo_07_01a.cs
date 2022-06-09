using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._1._1.Modelo
{
    class Ejemplo_07_01a
    {
        public static void Main()
        {
            Console.WriteLine("Pulsa Intro para borrar");
            Console.ReadLine();
            Hardware.BorrarPantalla();
            Console.WriteLine("Borrado!");
            Hardware.EscribirCentrado("Hola que tal");
        }
    }
}
