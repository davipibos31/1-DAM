using System;

namespace ejercicio_2._1._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduzca un número del 1 al 5: ");
            numero = Convert.ToChar(Console.ReadLine());

            switch (numero)
            {
                case '1': Console.WriteLine("Uno");
                    break;
                case '2': Console.WriteLine("Dos");
                    break;
                case '3': Console.WriteLine("Tres");
                    break;
                case '4': Console.WriteLine("Cuatro");
                    break;
                case '5': Console.WriteLine("Cinco");
                    break;
            }
        }
    }
}
