using System;

namespace ejercicio_2._6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;

            do
            {
                Console.Write("Escribe el ancho (máximo 9): ");
                ancho = Convert.ToInt32(Console.ReadLine());
            }
            while (ancho > 9);

            for (int filaActual = 0; filaActual < ancho; filaActual++)
            {
                for (int columnaActual = 0; columnaActual < ancho; columnaActual++)
                {
                    Console.Write(filaActual + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
