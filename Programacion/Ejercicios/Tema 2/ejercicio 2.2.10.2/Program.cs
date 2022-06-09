using System;

namespace ejercicio_2._2._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int min = Math.Min(num1, num2);
            int mcm = 0;
            
            for (int i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    int mcd;
                    mcd = i;
                    mcm = (num1 * num2) / mcd;
                }
            }
            Console.WriteLine("El mínimo común múltiplo entre {0} y {1} es {2}", num1, num2, mcm);
        }
    }
}
