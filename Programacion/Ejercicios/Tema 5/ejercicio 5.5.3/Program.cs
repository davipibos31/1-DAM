using System;

namespace ejercicio_5._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(num));
        }
        static bool EsPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                    return false;
            }
            return true;
        }
    }
}
