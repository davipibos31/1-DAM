using System;

namespace ejercicio_2._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creas las variables

            int numero1;
            int numero2;

            // Valores de variables

            Console.WriteLine("Introduzca el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            // Bucle

            if (numero1 % numero2 == 0)
            {
                Console.WriteLine("El número {0} es múltiplo de {1}", numero1, numero2);
            }
            else
            {
                Console.WriteLine("El número {0} no es múltiplo de {1}", numero1, numero2);
            }
        }
    }
}
