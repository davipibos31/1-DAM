using System;

namespace ejercicio_1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int numero1;
            int numero2;
            int division;

            //le damos algun valor a las variables

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            division = numero1 / numero2;

            //realziamos la operación

            Console.WriteLine("La división entre {0} y {1} es gual a {2}", numero1, numero2, division);
        }
    }
}
