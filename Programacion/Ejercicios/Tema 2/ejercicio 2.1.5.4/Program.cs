using System;

namespace ejercicio_2._1._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int resto1;
            int resto2;

            Console.WriteLine("Introduze un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            resto1 = numero1 % 2;
            resto2 = numero1 % 3;

            if (!(resto1 == 0) && (!(resto2 == 0)))
            {
                Console.WriteLine("El número {0} no es múltiplo de 2 y 3", numero1);
            }
            else
            {
                Console.WriteLine("El número {0} si es múltiplo de 2 ni 3", numero1);
            }
        }
    }
}
