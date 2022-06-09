using System;

namespace ejercicio_4._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] num;
            int pedir_num, pedir_num2;
            num = new int[2][];
            Console.Write("introduce un número para el primer bloque de números: ");
            pedir_num = Convert.ToInt32(Console.ReadLine());
            num[0] = new int[pedir_num];
            Console.Write("introduce un número para el segundo bloque de números: ");
            pedir_num2 = Convert.ToInt32(Console.ReadLine());
            num[1] = new int[pedir_num2];
            int z = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.WriteLine($"Introduce el número {z++}");
                    num[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.WriteLine($"Los números de los dos bloques son: {num[i][j]}");
                }
            }

            int max = num[0][0];
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    if (num[i][j] > max)
                        max = num[i][j];
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"El número mayor es {max}");
        }
    }
}
