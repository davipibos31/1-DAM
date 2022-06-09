using System;

namespace ejercicio_3._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x;
            int y;
            long z;
            x = 15;
            y = -10;
            z = 2147483647;

            Console.WriteLine("El valor de x es {0}", x);
            x++;
            Console.WriteLine("Tras incrementar x es {0}", x);
            Console.WriteLine("El valor de y es {0}", y);
            y++;
            Console.WriteLine("Tras incrementar y es {0}", y);
            Console.WriteLine("El valor de Z es {0}", z);
            z++;
            Console.WriteLine("Tras incrementar z es {0}", z);
        }
    }
}
