using System;

namespace ejercicio_2._2._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int division;
            Console.WriteLine("Introduze un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            for (; numero >= 9; numero--)
            {
                division = numero % 9;
                if (division == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
