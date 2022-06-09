using System;

namespace ejercicio_4._1._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectores = new int[2];

            for (int i = 0; i <2; i++)
            {
                Console.WriteLine($"Introduce el vector número {i+1}");
                vectores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
