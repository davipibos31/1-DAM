using System;

namespace ejercicio_4._4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();

            int longitud = nombre.Length;
            Console.WriteLine($"La longitud de {nombre} es {longitud}");

            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"{nombre[i]} ");
            }
        }
    }
}
