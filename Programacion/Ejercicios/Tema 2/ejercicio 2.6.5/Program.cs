using System;

namespace ejercicio_2._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            int num;
            int num2;

            Console.WriteLine("Introduce un alto: ");
            alto = Convert.ToInt32(Console.ReadLine());
            ancho = alto;

            for (num2 = 1; num2 <= ancho; num2++)
            {
                for (num = 1; num <= alto; num++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                alto--;
            }
        }
    }
}
