using System;

namespace ejercicio_2._2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fila, numero;
            for (Fila = 1; Fila <= 4; Fila++)
            {
                for (numero = 1; numero <= 5; numero++)
                    Console.Write("número {1} ", Fila, numero);
                Console.WriteLine();
                }
            }
    }
}
