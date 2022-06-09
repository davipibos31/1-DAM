using System;

namespace ejercicio_5._10._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Introduze un número: ");
            long num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze un número base: ");
            long num_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Su resultado es: {Elevacion(num, num_base)}");
        }
        public static long Elevacion(long num, long num_base)
        {
            if (num_base == 0)
                return 1;
            return num * Elevacion(num, num_base - 1);
        }
    }
}
