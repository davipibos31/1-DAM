using System;

namespace ejercicio_4._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            Console.WriteLine("Introduce un número: ");
            numeros[0] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[1] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[2] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[3] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            numeros[4] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(numeros[4]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[0]);
        }
    }
}
