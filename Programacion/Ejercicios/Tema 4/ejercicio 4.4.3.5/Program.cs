using System;

namespace ejercicio_4._4._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = Console.ReadLine();
            string numero1 = Console.ReadLine();
            double suma = Convert.ToDouble(numero) + Convert.ToDouble(numero1);
            Console.WriteLine($"La suma entre {numero} + {numero1} es igual a {suma}");
        }
    }
}