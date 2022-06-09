using System;

namespace ejercicio_2._2._1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numero1;
            int numero2;

            numero = 3;
            while (numero > 0)
            {
                numero = numero - 1;
                Console.WriteLine("Adivine un número del 1 al 10");
                Console.WriteLine("Tienes tres oportunidades");
                Console.WriteLine("Teclea el número que creas: ");
                numero1 = 5;
                numero2 = Convert.ToInt32(Console.ReadLine());
                if (numero1 == numero2)
                    Console.WriteLine("Número Correcto");
                else
                    Console.WriteLine("Número Erroreo");
            }
        }
    }
}
