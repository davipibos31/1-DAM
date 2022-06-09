using System;

namespace ejercicio_2._2._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            int filaActual;
            int columnaActual;

            Console.WriteLine("Inserte un ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte un alto");
            alto = Convert.ToInt32(Console.ReadLine());

            for (filaActual = 1; filaActual <= alto; filaActual++)
            {
                for (columnaActual = 1; columnaActual <= ancho; columnaActual++)
                    Console.Write("*", columnaActual);
                Console.WriteLine();
            }

        }
    }
}
