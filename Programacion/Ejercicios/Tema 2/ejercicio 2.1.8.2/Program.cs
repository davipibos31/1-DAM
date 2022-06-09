using System;

namespace ejercicio_2._1._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int menor;
            int numero2;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            menor = numero1 > numero2 ? numero1 : numero2;

            Console.WriteLine("El número menor entre los dos números es: {0}");

        }
    }
}
