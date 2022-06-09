using System;

namespace ejercicio_3._2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double raiz;
            raiz = (float)Math.Sqrt(numero);
            Console.WriteLine("La raíz de {1} es {0}", raiz, numero);
        }
    }
}
