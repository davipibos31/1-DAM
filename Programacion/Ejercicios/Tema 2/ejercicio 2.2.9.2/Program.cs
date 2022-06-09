using System;

namespace ejercicio_2._2._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int i;

            Console.WriteLine("Introduzca el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduze el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= numero1; i++)
            {
                for (i = 1; i <= numero2; i++)
                {
                    if ((numero1 % i == 0) && (numero2 % i == 0))
                    {
                        Console.WriteLine("Los divisores comunes son los siguientes: {0}", i);
                    }
                }
                break;
            }
        }
    }
}
