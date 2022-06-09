using System;

namespace ejercicio_4._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [4];

            Console.WriteLine("Introduce un número: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());

            int suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            int media = suma / 4;
            Console.WriteLine($"La media de los datos es {media}");
        }
    }
}
