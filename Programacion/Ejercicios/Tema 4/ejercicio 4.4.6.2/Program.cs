using System;

namespace ejercicio_4._4._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase2 = "";
            Console.Write("Escribe una frase: ");
            string frase = Convert.ToString(Console.ReadLine());
            int longitud = frase.Length;
            for (int i = 0; i < longitud; i++)
            {
                int buscar =frase.IndexOf(" ");
                frase2 = frase.Remove(buscar,2);
            }
            Console.WriteLine(frase2);
        }
    }
}
