using System;

namespace ejercicio_2._1._9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Introduzca un carácter: ");
            letra = Convert.ToChar(Console.ReadLine());

            if ((letra >= '0') && (letra <= '9'))
            {
                Console.WriteLine("Es una cifra numérica");
            }
            else if ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))
            {
                Console.WriteLine("Es una vocal");
            }
            else if (!(letra == 'a') || (!(letra == 'e')) || (!(letra == 'i')) || (!(letra == 'o')) || (!(letra == 'u')))
                Console.WriteLine("Es una consonante");




        }
    }
}
