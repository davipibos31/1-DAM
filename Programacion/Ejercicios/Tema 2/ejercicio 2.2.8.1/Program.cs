using System;

namespace ejercicio_2._2._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea;
            int numero;

            for (linea = 1; linea <= 6; linea++)
            {
                for (numero = 1; numero <= 7; numero++)
                    Console.Write(numero);
                Console.WriteLine();
            }
        }
    }
}
