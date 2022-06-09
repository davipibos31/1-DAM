using System;

namespace ejercicio_4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] num;
            Console.WriteLine("Introduzca dos bloques de 10 números: ");
            num = new int[2][];
            num[0] = new int[10];
            num[1] = new int[10];
            int z = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {

                    Console.WriteLine($"Introduze el número {z++}");
                    num[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Los dos bloques de 10 números son los siguientes: ");

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.WriteLine($" {num[i][j]}");
                }
                Console.WriteLine();
            }
            int max = num[0][0];
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    if (num[i][j] > max)
                        max = num[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"El mayor número es {max}");
        }
    }
}
