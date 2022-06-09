using System;

namespace ejercicio_3._2._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("introduce un número: ");
            x = Convert.ToDouble(Console.ReadLine());

            Math.Pow(x, 2);
            double funcion;
            funcion = Math.Pow(x, 2) - 1;
            Console.WriteLine("La función y = {0}", funcion);
        }
    }
}
