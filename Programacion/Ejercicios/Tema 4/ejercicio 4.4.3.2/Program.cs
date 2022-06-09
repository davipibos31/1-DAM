using System;

namespace ejercicio_4._4._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase: ");
            string frase = Console.ReadLine();
            string invertido = "";
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                invertido += frase[i];
            }
            Console.WriteLine($"La frase invertida es: {invertido}");
        }
    }
}
