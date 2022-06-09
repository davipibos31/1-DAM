using System;

namespace ejercicio_5._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "Hola";

            Console.WriteLine(inicial(palabra));
        }
        static string inicial(string palabra)
        {
            return palabra.Substring(palabra.Length - 1, 1);

        }
    }
}
