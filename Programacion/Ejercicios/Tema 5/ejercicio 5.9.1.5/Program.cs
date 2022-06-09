using System;

namespace ejercicio_5._9._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Asteriscos();
        }
        static void Asteriscos()
        {
            Random dibujar = new Random();
            dibujar.Next(0, 9);
            int[,] mapa = new int[25,80];
            for (int i = 1; i < 24; i++)
            {
                for (int j = 1; j < 79; j++)
                {
                    int jw = mapa[i,j]= dibujar.Next(0, 9);
                    Console.Write(jw);
                }
                Console.WriteLine();
            }
           
        }
    }
}
