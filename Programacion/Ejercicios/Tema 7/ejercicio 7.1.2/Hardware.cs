using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._1._2
{
    class Hardware
    {
        public void BorrarPantalla()
        {
            for (byte i = 0; i < 25; i++)
                Console.WriteLine();
        }
        public void EscribirCentrado(string texto)
        {
            Console.WriteLine($"{texto}");
        }
    }
}
