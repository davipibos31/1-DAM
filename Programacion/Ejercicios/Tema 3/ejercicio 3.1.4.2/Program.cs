using System;

namespace ejercicio_3._1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("El valor de a es {0}", a);
            int b = a + 2;
            Console.WriteLine("El valor de b = a + 2 es {0}", b);
            b -= 3;
            Console.WriteLine("El valor de b -= 3 es {0}", b);
            int c = -3;
            Console.WriteLine("El valor de c es {0}", c);
            c *= 2;
            Console.WriteLine("El valor de c *= 2 es {0}", c);
            ++c;
            Console.WriteLine("El valor de ++c es {0}", c);
            a *= b;
            Console.WriteLine("El valor de a *= b es {0}", a );
            
        }
    }
}
