using System;

namespace ejercicio_5._9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dado();
        }
        static void Dado()
        {
            Random dado = new Random();
            int numero = dado.Next(1,6);
            Console.WriteLine($"Número aleatorio del dado: {numero}");
        }
    }
}
