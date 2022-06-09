using System;

namespace ejercicio_5._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            EscribirTablaMultiplicar(num);
        }
        static void EscribirTablaMultiplicar(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}
