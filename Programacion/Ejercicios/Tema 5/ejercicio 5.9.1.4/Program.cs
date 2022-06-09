using System;

namespace ejercicio_5._9._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Media();
        }
        static void Media()
        {
            Random numeros = new Random();
            int[] num = new int[100];
            int suma = 0;
            int media = 0;

            for (int i = 0; i < 100; i++)
            { 
                num[i] = numeros.Next(-1000, 1000);
                Console.WriteLine($"El número {i} es {num[i]}");
                suma += num[i];
                media = suma / 100;
            }
            Console.WriteLine($"La media de los números es {media}");
        }
    }
}
