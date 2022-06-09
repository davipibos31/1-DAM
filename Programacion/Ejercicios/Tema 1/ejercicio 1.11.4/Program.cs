using System;

namespace ejercicio_1._11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int grados;
            int kelvin;
            int fah;

            Console.WriteLine("Escribe el numero de grados centígrados: ");
            grados = Convert.ToInt32(Console.ReadLine());

            kelvin = grados + 273;
            fah = grados * 18 / 10 + 32;

            Console.Write("Cambio a kelvin: ");
            Console.WriteLine(kelvin);
            Console.Write("Cambio a Fahrenheit: ");
            Console.WriteLine(fah);

        }
    }
}
