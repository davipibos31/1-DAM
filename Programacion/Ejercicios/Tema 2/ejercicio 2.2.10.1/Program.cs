using System;

namespace ejercicio_2._2._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2;
            int num1;
            int tem;

            Console.WriteLine("Introduzca un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            while (num2 != 0)
            {
                tem = num2;
                num2 = num1 % num2;
                num1 = tem;
            }
            Console.WriteLine(num1);
        }
    }
}
