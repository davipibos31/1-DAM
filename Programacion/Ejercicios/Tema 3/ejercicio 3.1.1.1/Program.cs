using System;

namespace ejercicio_3._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            long producto;
            int producto1;
            long num = 1000000;
            long num1 = 1000000;
            int num2 = 1000000;
            int num3 = 1000000;
            producto = num * num1;
            producto1 = num2 * num3;
            Console.WriteLine("Resultado con long es igual a {0}", producto);
            Console.WriteLine("Resultado con int es igual a {0}", producto1);
        }
    }
}
