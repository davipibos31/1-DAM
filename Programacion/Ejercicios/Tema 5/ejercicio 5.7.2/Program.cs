using System;

namespace ejercicio_5._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu nombre y primer apellido: ");
            string nombre = Console.ReadLine();
            char letra1, letra2;
            Iniciales(nombre, out letra1, out letra2);
            Console.WriteLine($"La primera letra del nombre es {letra1} y la del apellido es {letra2}");
        }

        static void Iniciales(string nombre, out char letra1, out char letra2)
        {
           
            char delimitador = ' ';

            string[] nombre1 = nombre.Split(delimitador);
            letra1 = Convert.ToChar(nombre1[0].Substring(0, 1));
            letra2 = Convert.ToChar(nombre1[1].Substring(0, 1));
        }
    }
}
