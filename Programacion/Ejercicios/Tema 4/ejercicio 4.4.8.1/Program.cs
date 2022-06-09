
using System;

namespace ejercicio_4._4._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;

            Console.WriteLine("Escriba la primera frase: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda frase: ");
            frase2 = Console.ReadLine();

            if (string.Compare(frase1, frase2) > 0)
                Console.WriteLine($"Es mayor {frase2} que {frase1}");
            if (string.Compare(frase2, frase1) > 0)
                Console.WriteLine($"Es mayor {frase1} que {frase2}");
        }
    }
}
