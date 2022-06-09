using System;

namespace ejercicio_5._5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduze una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduze un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Triangulo(letra, num);
        }
        static void Triangulo(char letra, int num)
        {
            for (int i = num; i >= 1; i--)
            {
                for (int j = num; j>=1; j--)
                    Console.Write(letra);
                Console.WriteLine();
                num--;
            }
        }
    }
}
