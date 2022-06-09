using System;

namespace ejercicio_4._4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "david";
            Console.Write("Dime tu nombre: ");
            string nombre_usuario = Console.ReadLine();

            if (nombre == nombre_usuario)
                Console.WriteLine("Bienvenido jefe");
            else
                Console.WriteLine($"Saludos, {nombre_usuario}");
        }
    }
}
