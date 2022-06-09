using System;

namespace ejercicio_4._4._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frase = new string[5];
            string cadena;
            int z = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                Console.WriteLine($"Escriba la frase {z++}: ");
                frase[i] = Console.ReadLine();
            }
            z = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                Console.WriteLine($"Las frase {z++}: {frase[i]}");
            }
            cadena = frase[0];
            for (int i = 1; i < frase.Length; i++)
            {
                if (string.Compare(cadena, frase[i], true) < 0)
                    cadena = frase[i];
            }
            Console.WriteLine();
            Console.WriteLine($"La frase mayor es {cadena}");
        }
    }
}
