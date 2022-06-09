using System;

namespace ejercicio_2._2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            int Fila;
            int Columna;

            Console.WriteLine("Introduzca un ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un alto: ");
            alto = Convert.ToInt32(Console.ReadLine());
            for (Fila = 1; Fila <= alto; Fila++)
            {
                for (Columna = 1; Columna <= ancho; Columna++)
                {
                    Console.Write("*", Columna);
                }
                Console.WriteLine();
            }
        }
    }
}
