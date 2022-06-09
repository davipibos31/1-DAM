using System;

namespace ejercicio_4._1._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int mayor = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Introduzca el dato número {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                if (numeros[i] > mayor)
                    mayor = numeros[i];
            }
            Console.WriteLine("El mayor es {0}", mayor);
        }
    }
}
