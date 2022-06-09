using System;

namespace ejercicio_3._2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5;
            Console.WriteLine("El valor de a es {0}", a);
            a /= 2;
            Console.WriteLine("El valor de a es {0}", a);
            a += 1;
            Console.WriteLine("El valor de a es {0}", a);
            a *= 3;
            Console.WriteLine("El valor de a es {0}", a);
            --a;
            Console.WriteLine("El valor de a es {0}", a);
        }
    }
}
