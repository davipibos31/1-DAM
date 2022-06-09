using System;

namespace ejercicio_4._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Introduce el dato número {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
