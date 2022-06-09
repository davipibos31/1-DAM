using System;

namespace ejercicio_1._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos las variables

            int numero1;
            int numero2;
            int resto;

            // damos valor a las variables

            numero1 = 301;
            numero2 = 3;
            resto = numero1 % numero2;

            //realizamos las operaciones

            Console.WriteLine("El resultado de la operacion es el siguiente:");
            Console.WriteLine(resto);
        }
    }
}
