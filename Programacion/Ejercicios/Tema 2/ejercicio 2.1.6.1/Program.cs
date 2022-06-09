
using System;

namespace ejercicio_2._1._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)
                Console.WriteLine("El número es cero.");
            else
            if (numero < 0)
                Console.WriteLine("El número es negativo. Y el número es {0}", numero);
            else
                Console.WriteLine("El número es positivo. Y el número es {0}", numero);
        }
    }
}
