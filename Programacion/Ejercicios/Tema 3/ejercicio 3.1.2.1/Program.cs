using System;

namespace ejercicio_3._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;

            Console.WriteLine("Introduce tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas {0} años", edad);
        }
    }
}
