using System;

namespace ejercicio_4._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números enteros va a introducir?");
            int pedir = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[pedir];

            for (int i = 0; i <= pedir -1; i++)
            {
                Console.WriteLine($"Introduce el dato número {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i <= pedir-1; i++)
            {
                suma += numeros[i];
            }
            Console.WriteLine($"La media es {suma / pedir}");
        }
    }
}
