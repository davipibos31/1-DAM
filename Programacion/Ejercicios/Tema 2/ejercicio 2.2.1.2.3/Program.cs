using System;

namespace ejercicio_2._2._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numero1;

            Console.WriteLine("Introduzca un número positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            numero1 = 3;
            while (numero1 != 1)
            {
                if (numero <= 999)
                {
                    numero = numero / 10;
                    Console.WriteLine(numero);
                }
                numero1--;
            }

        }
    }
}
