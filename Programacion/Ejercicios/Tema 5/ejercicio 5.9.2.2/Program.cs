using System;

namespace ejercicio_5._9._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Raiz();
        }
        static void Raiz()
        {
            Console.Write("Introduze un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze el nivel: ");
            int nivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(numero, 1.0/nivel));
        }
    }
}
