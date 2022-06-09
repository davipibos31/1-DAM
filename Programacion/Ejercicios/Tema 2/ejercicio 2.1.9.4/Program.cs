using System;

namespace ejercicio_2._1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número del 1 al 5: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero >= 1) && (numero <= 5))
            {
                if (numero == 5)
                    Console.WriteLine("Cinco");
                else if (numero == 4)
                    Console.WriteLine("cuatro");
                else if (numero == 3)
                    Console.WriteLine("Tres");
                else if (numero == 2)
                    Console.WriteLine("Dos");
                else if (numero == 1)
                    Console.WriteLine("Uno");
            }
            else
                Console.WriteLine("No es un número del 1 al 5");
        }
    }
}
