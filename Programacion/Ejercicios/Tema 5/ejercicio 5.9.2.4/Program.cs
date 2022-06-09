using System;

namespace ejercicio_5._9._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduze un número: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Elige un número de esos 5: ");
            double elegir = Convert.ToDouble(Console.ReadLine());
            
            for (int i = 0; i < 5; i++)
            {
                if (elegir == num[i])
                    Console.WriteLine(Math.Ceiling(num[i]));
            }
        }
    }
}
