using System;

namespace ejercicio_2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2 = 2;
           
            Console.WriteLine("Inserta un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (!(num == 1))
            {
                if (num % num2 == 0)
                {
                    num = num / num2;
                    Console.Write(" {1}", num, num2);
                }
                else
                {
                    num2 = num2 + 1;
                    
                }
            }
        }
    }
}
