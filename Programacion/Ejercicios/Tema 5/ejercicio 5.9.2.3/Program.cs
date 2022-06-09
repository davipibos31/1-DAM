using System;

namespace ejercicio_5._9._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduze el valor a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze el valor b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze el valor c: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double num1 = 5;
            double num2 = 5;
            CalcularRaicesSegundoGrado(a, b, c,ref num1, ref num2);
            Console.WriteLine("Con Raiz positiva el valor es {0}", num1);
            Console.WriteLine("Con Raiz negatica el valor es {0}", num2);
        }
        static double CalcularRaicesSegundoGrado(double a, double b, double c,ref double num1, ref double num2)
        {
             num2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            num1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            if (num1.ToString() == "NaN")
            {
                num1 = 100000;
                return num1;
            }
            else if (num2.ToString() == "NaN")
            {
                num2 = 100000;
                return num2;
            }
            else if (num2 != num1)
                return num2;
            else
                return num1;
        }
    }
}
