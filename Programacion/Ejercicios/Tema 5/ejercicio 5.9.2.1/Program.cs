using System;

namespace ejercicio_5._9._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Raiz();
        }
        static void Raiz()
        {
            int numero = 1;
            while (numero != 0) 
            {
                Console.Write("Introduze un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(numero));
            }
        }
    }
}
