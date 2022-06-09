using System;

namespace ejercicio_3._2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Introduce la variable x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x.ToString("#################.##"));
            Console.WriteLine("Introduce la variable y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(y.ToString("#################.##"));
            Console.WriteLine("Introduce la variable z: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(z.ToString("#################.##"));

            double calculo = x * x + y - z;
            Console.WriteLine($"El resultado es {calculo}");
        }
    }
}
