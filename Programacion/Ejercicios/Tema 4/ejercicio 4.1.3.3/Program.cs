using System;

namespace ejercicio_4._1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Introduce el dato número {i+1}: ");
                numero[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            for (int i = 0; i <= 9; i++)
            {
                suma += numero[i];
            }
            Console.WriteLine($"La media es {suma / 10}");
        }
    }
}
