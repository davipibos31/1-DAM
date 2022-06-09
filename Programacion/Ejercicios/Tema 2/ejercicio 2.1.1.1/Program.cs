using System;

namespace ejercicio_2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduce un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if (numero1 % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El numero no es par");
            }
        }
    }
}
