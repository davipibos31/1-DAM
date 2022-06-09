using System;

namespace ejercicio_2._2._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            
            for (letra = 'L'; letra <= 'N'; letra++)
            {
                for (letra = 'L'; letra <= 'N'; letra++)
                {
                    Console.Write(letra);
                    Console.Write(letra);
                    Console.Write(letra);
                    Console.Write(letra);
                    Console.Write(letra);
                }
                    Console.WriteLine();
            }
        }
    }
}
