using System;

namespace _2._1._5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int division;
            int division1;


            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Itroduzca un segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            division = numero1 % 2;
            division1 = numero2 % 2;
            if ((!(division != 0) || (division1 == 0)) || ((division == 0) || (!(division1 != 0))))
            {

                Console.WriteLine("El número {0} y {1} uno es par", numero1, numero2);
            }
            else
            {
                Console.WriteLine("El número {0} y {1} niguno es par", numero1, numero2);
            }
        }
    }
}
