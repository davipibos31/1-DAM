using System;

namespace _2._1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Introduzca un caracter: ");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case '.': Console.WriteLine("Es un signo de puntuación");
                    break;
                case ',': goto case '.';
                    break;
                case ';': goto case '.';
                    break;
                case ':': goto case '.';
                    break;
                case '1': 
                case '2':
                case '3': 
                case '4': 
                case '5': 
                case '6': 
                case '7':             
                case '8': 
                case '9':
                case '0': Console.WriteLine("Es una cifra numérica");
                    break;
                default: Console.WriteLine("Es otro caracter");
                    break;
            }
        }
    }
}
