﻿using System;

namespace ejercicio_5._3._2
{
    class Program
    {
        public static void Main(string[] args)
        {

            DibujarCuadrado(3, 4);
        }
        public static void DibujarCuadrado(int ancho, int alto)
        {

            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
