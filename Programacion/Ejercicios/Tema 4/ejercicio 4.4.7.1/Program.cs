using System;

namespace ejercicio_4._4._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase");
            string frase = Convert.ToString(Console.ReadLine());

            char[] delimitadores = { ' ' };
            string[] frase_real = frase.Split(delimitadores);
           
            for (int i = frase_real.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Fragmento {i} es {frase_real[i]}");
                Console.WriteLine();
            }
        }
    }
}
