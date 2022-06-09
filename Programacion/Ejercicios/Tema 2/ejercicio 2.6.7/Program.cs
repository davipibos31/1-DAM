using System;

namespace ejercicio_2._6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe el alto: ");
            int alto = Convert.ToInt32(Console.ReadLine());

            int blancos = alto - 1;

            for (int i = 1; i <= alto; i++)
            {
                for (int j = i + 1; j <= alto; j++)
                    Console.Write(" ");

                for (int j = 1; j <= alto - blancos; j++)
                    Console.Write("*");

                blancos--;

                Console.WriteLine();
            }
        }
    }
}
