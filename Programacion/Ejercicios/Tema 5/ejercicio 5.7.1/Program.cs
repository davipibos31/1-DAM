using System;

namespace ejercicio_5._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduze un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze un número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El valor del primer número es {num}");
            Console.WriteLine($"El valor del segundo número es {num2}");
            Intercambiar(ref num, ref num2);
        }

        static void Intercambiar(ref int x, ref int y)
        {
            int intercambio = x;
            x = y;
            Console.WriteLine($"Ahora el primer número vale {x}");
            y = intercambio;
            Console.WriteLine($"Ahora el segundo número vale {y}");
        }
    }
}
