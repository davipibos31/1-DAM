using System;

namespace ejercicio_3._2._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float B;
            float A;
            float C;
            
            Console.Write("Introduce el número A para la ecuación: ");
            A = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Introduce el número B para la ecuación: ");
            B = Convert.ToSingle(Console.ReadLine());
           
            Console.Write("Introduce el número C para la ecuación: ");
            C = Convert.ToSingle(Console.ReadLine());

            double raizpositiva = (-B + (Math.Sqrt((B * B)) - 4 * (A * C) / (2 * A)));
            double raiznegativa = (-B - (Math.Sqrt((B * B)) - 4 * (A * C) / (2 * A)));
            Console.WriteLine(raizpositiva);
            Console.WriteLine(raiznegativa);

        }
    }
}
