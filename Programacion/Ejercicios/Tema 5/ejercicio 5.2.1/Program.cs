using System;

namespace ejercicio_5._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BorrarPantalla();
        }

        static void BorrarPantalla()
        {
            for (int i = 0; i < 25; i++)
                Console.WriteLine();
        }
    }
}
