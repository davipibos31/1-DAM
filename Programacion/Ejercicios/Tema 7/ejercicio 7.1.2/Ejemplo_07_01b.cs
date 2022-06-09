using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._1._2
{
    class Ejemplo_07_01b
    {
        public static void Main()
        {
            Console.WriteLine("Pulsa Intro para borrar");
            Console.ReadLine();
            Hardware miPantalla = new Hardware();
            miPantalla.BorrarPantalla();
            Console.WriteLine("Borrado!");
            miPantalla.EscribirCentrado("Hola que tal");
        }
    }
}
