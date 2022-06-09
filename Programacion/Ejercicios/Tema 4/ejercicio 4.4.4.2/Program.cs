using System;

namespace ejercicio_4._4._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            int longitud = nombre.Length;
            string subcadena;
            for (int i = 0; i <= longitud; i++)
            {
                subcadena = nombre.Substring(0, i);
                Console.WriteLine(subcadena);
            }
        }
    }
}
