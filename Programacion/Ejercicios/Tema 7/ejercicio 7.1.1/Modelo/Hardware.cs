using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._1._1.Modelo
{
    class Hardware
    {
        public static void BorrarPantalla()
        {
            for (byte i = 0; i < 25; i++)
                Console.WriteLine();
        }
        public static void EscribirCentrado(string texto)
        {
            Console.WriteLine($"{texto}");
        }
    }
}
