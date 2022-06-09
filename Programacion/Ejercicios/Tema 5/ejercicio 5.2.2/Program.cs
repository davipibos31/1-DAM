using System;

namespace ejercicio_5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DibujarCuadrado3x3();
        }

        static void DibujarCuadrado3x3()
        {
            int ancho, alto;
            ancho = 3;
            alto = 3;
            for (int fila = 1; fila <= alto; fila++)
            {
                for (int columna = 1; columna <= ancho; columna++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
