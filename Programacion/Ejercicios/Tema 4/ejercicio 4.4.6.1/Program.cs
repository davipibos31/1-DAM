using System;

namespace ejercicio_4._4._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int total_frases = 10;
            string[] frase = new string[total_frases];
            string buscar;

            for (int i = 0; i < total_frases; i++)
            {
                Console.Write("Escribe la {0}º frase: ", i + 1);
                frase[i] = Console.ReadLine();
            }
            do
            {
                Console.Write("Escribe el texto a buscar: ");
                buscar = Console.ReadLine();

                for (int i = 0; i < total_frases; i++)
                {
                    if (frase[i].IndexOf(buscar.ToLower()) == 0)
                        Console.WriteLine("El texto aparece en la frase nº{0} y se encuentra al principio. ", i + 1);
                    else if (frase[i].Contains(buscar.ToLower()))
                        Console.WriteLine("El texto aparece en la frase nº{0} ", i + 1);
                }
            } while (buscar != "fin");
        }
    }
}
