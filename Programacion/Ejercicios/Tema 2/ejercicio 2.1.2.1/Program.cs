using System;

namespace ejercicio_2._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 10 == 0)
            {
                Console.WriteLine("El número si es múltiplo de 10");
                int numero2;
                Console.WriteLine("Introduzca otro número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                if (numero2 % 10 == 0)
                {
                    Console.WriteLine("El número si es múltiplo de 10");
                }
                else
                {
                    Console.WriteLine("El número no es múltiplo de 10");
                }
            }
            else 
            {
                Console.WriteLine("El número no es multiplo de 10");
            }
        }
    }
}
