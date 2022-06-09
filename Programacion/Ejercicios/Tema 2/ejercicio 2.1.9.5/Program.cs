using System;

namespace ejercicio_2._1._9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Char letra;

            Console.WriteLine("Introduce un carácter: ");
            letra = Convert.ToChar(Console.ReadLine());

            if ((letra >= '0') && (letra <= '9'))
            {
                Console.WriteLine("Es una cifra numérica");
            }
            else if ((letra == ';') || (letra == ':') || (letra == ',') || (letra == '.'))

            {

                Console.WriteLine("Es un signo de puntuación");
            }
            else
                Console.WriteLine("Es otro carácter");
        }
    }
}
