using System;

namespace ejercicio_5._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menor(2,2);
        }
        static void Menor(int num, int num2)
        {
            if (num > num2)
                Console.WriteLine($"El menor es {num2}");
            else if (num2 > num)
                Console.WriteLine($"El menor es {num}");
            else
                Console.WriteLine("Los dos números son iguales");
        }
    }
}
