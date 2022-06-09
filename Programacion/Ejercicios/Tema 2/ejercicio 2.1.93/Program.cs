using System;

namespace ejercicio_2._1._93
{
    class Program
    {
        static void Main(string[] args)
        {
            int letra;

            Console.WriteLine("Introduce un caracter: ");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '8':
                case '9':
                case '0': Console.WriteLine("Es una cifra numérica");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("Es una vocal");
                    break;
                case 'q':
                case 'w':
                case 'r':
                case 't':
                case 'y':
                case 'p':
                case 'ñ':
                case 'l':
                case 'k':
                case 'j':
                case 'h':
                case 'g':
                case 'f':
                case 'd':
                case 's':
                case 'z':
                case 'x':
                case 'c':
                case 'v':
                case 'b':
                case 'n':
                case 'm': Console.WriteLine("Es una consonante");
                    break;
            }
        }
    }
}
