using System;

namespace ejercicio_4._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            foreach (char letras in nombre)
            {
                Console.Write($"{letras} ");
            }
        }
    }
}
