using System;

namespace ejercicio_4._1._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] componentes = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Introduzca el vector número {i+1}: ");
                componentes[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += componentes[i];
            }
            double potencia = Math.Pow(suma,2);
            double raiz = Math.Sqrt(Math.Pow(suma, 2));
            Console.WriteLine($"El módulo del vector es {raiz}");
        }
    }
}
