using System;

namespace ejercicio_1._6._3._3
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

            numero1 = 3784;
            numero2 = 16;
            resto = numero1 % numero2;

            //realizamos las operaciones

            Console.WriteLine("El producto de {0} y {1} es igual a {2}", numero1, numero2, resto);
        }
    }
}
