using System;

namespace ejercicio_4._4._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            string subcadena = nombre.Substring(0);
            int longitud = nombre.Length;
            
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(subcadena[i] + " ");
            }
        }
    }
}
