using System;

namespace ejercicio_3._2._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Introduce un número: ");
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            y = (Math.Pow(x - 5, 2));
            Console.WriteLine(Math.Pow(x - 5, 2));
            while (y != 0)
            {
                if ((x >= 1) || (x <= 10))
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                break;
            }
        }
    }
}
