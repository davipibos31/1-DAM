using System;

namespace ejercicio_3._2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, numero2;

            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(numero.ToString("############.###"));
           
            Console.WriteLine("Introduce un número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(numero2.ToString("############.###"));

            double dividir = numero / numero2;
            Console.WriteLine($"La división de {numero} entre {numero2} es igual a {dividir}");




        }
    }
}
