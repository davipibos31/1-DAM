using System;

namespace ejercicio_2._1._5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 > numero2) && (numero1 > numero3))
            {
                Console.WriteLine("El número {0} es el mayor", numero1);
            }
            else if ((numero2 > numero1) && (numero2 > numero3))
            {
                Console.WriteLine("El número {0} es el mayor", numero2);
            }
            else if ((numero3 > numero1) && (numero3 > numero2))
            {
                Console.WriteLine("El número {0} es el mayor", numero3);
            }
        }
    }
}
