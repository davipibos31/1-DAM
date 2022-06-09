using System;

namespace ejercicio_5._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduze un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduze un número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            ElevarNumero(num, num2);
        }

        static void ElevarNumero(int num, int num2)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(Math.Pow(num,num2));
            }
        }
    }
}
