using System;

namespace ejercicio_3._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 13;
            float num2 = 6;
            float divisionF;
            divisionF = num / num2;
            int num3 = 13;
            int num4 = 6;
            int divisionI;
            divisionI = num3 / num4;
            double num5 = 13;
            double num6 = 6;
            double divisionD;
            divisionD = num5 / num6;

            Console.WriteLine("El resultado es dividir {0} entre {1} es igual a {2}", num3, num4, divisionI);
            Console.WriteLine("El resultado es dividir {0} entre {1} es igual a {2}", num, num2, divisionF);
            Console.WriteLine("El resultado es dividir {0} entre {1} es igual a {2}", num5, num6, divisionD);
        }
    }
}
