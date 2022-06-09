using System;

namespace ejercicio_2._1._5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Los números son iguales");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("El número {0} es el mayor", numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El número {0} es el mayor", numero2);
            }
        }
    }
}
