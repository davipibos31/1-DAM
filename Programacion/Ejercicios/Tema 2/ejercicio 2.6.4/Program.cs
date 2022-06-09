using System;

namespace ejercicio_2._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            int num;
            int num2;

            Console.WriteLine("Introduce un ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            for (num = 1; num <= ancho; num++)
            {
                for (num2 = 1; num2 <= alto; num2++)
                {
                    Console.Write("*", num2);
                   
                }
                Console.WriteLine();
            }
        }
    }
}
