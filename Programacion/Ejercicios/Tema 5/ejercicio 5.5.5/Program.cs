using System;

namespace ejercicio_5._5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            SumaCifras(num);
        }
        static void SumaCifras(int num)
        {
            int suma = 0;

            while (num != 0)
            {
                suma += num % 10;
                num /= 10;
            }
            Console.WriteLine(suma);            
        }
    }
}
