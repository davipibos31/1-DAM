using System;

namespace ejercicio_3._2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho, alto, perimetro, diagonal, area;
            Console.WriteLine("Introduce un ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce un ancho: ");
            alto = Convert.ToDouble(Console.ReadLine());

            perimetro = ancho + ancho + alto + alto;

            Console.WriteLine($"El perimetro del rectangulo es igual a {perimetro}");

            diagonal = ancho * ancho + alto * alto;

            Console.WriteLine($"El diagonal del rectangulo es igual a {diagonal}");

            area = ancho * alto;
            Console.WriteLine($"El area del rectangulo es igual a {area}");
        }
    }
}
