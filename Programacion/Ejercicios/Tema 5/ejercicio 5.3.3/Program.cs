using System;

namespace ejercicio_5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un alto: ");
            int alto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca un ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            DibujarRectanguloHueco(alto, ancho, letra);
        }
        static void DibujarRectanguloHueco(int alto, int ancho, char letra)
        {
            for (int i = 1; i <= ancho; i++)
            {
                for (int j = 1; j <= alto; j++)
                {
                    if (((j > 1) && (i < ancho)) && ((i > 1) && (j < alto)))
                    {
                        Console.Write(" ");

                    }
                    else
                        Console.Write(letra);
                }
                Console.WriteLine();
            }
        }
    }
}
