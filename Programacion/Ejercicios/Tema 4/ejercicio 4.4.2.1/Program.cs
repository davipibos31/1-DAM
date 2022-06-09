using System;

namespace ejercicio_4._4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dime tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"La incial de {nombre} es {nombre[0]}");
        }
    }
}
