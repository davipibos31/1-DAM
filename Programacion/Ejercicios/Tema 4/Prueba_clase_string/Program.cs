using System;

namespace Prueba_clase_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "Hola Adios Pepe Pablo";
            int numero = original.Split(' ').Length;

            string[] resultado = new string[numero];

            int inicio;
            int num_caracteres, fin;
            Console.WriteLine(numero);
            Console.WriteLine();
            Console.WriteLine(original);
            for (int i = 0; i < numero; i++)
            {
                int posicion = original.IndexOf(' ');
                Console.WriteLine(original.Substring(0,posicion));
            }
        }
    }
}
