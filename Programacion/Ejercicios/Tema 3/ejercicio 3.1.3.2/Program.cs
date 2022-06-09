using System;

namespace ejercicio_3._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = ++a;
            int c = a++;
            Console.WriteLine("El resultado de a es {0}", a);
            Console.WriteLine("El resultado de b es {0}", b);
            Console.WriteLine("El resultado de c es {0}", c);
            Console.WriteLine("El resultado de b = b * 5 es {0}", b = b * 5);
            Console.WriteLine("El resultado de a = a * 2 es {0}", a = a * 2);

        }
    }
}
