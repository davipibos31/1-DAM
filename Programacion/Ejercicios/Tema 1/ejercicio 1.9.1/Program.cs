using System;

namespace ejercicio_1._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El primer número introducido por el usuario es {0} y  el segundo número es {1}", numero1, numero2);
        }
    }
}
