using System;

namespace ejercicio_1._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int numero1;
            int numero2;
            int numero3;
            int suma;

            //damos valor a las variables

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());
            suma = numero1 + numero2 + numero3;

            //realizamos la operación

            Console.WriteLine("La suma de {0}, {1} y {2} es igual a {3}", numero1, numero2, numero3, suma);
        }
    }
}
