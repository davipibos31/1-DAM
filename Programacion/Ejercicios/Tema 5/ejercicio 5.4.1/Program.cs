using System;

namespace ejercicio_5._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cubo(3.2f, 5f);
        }
        static void Cubo(float num, float num2)
        {
            float resultado = num * num * num;
            Console.WriteLine($"El resultado con 3,2 es {resultado}");
            resultado = num2 * num2 * num2;
            Console.WriteLine($"El resultado con 5 es {resultado}");
        }
    }
}
