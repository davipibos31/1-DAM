using System;

namespace ejercicio_1._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int numero1;
            int numero2;
            int division;
            int resto;

            //damos valor a las variables

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            division = numero1 / numero2;
            resto = numero1 % numero2;

            //realizamos la operación

            System.Console.WriteLine("La división de {0} entre {1} es igual a {2}", numero1, numero2, division);
            System.Console.WriteLine("El resto de {0} y {1} es igual a {2}", numero1, numero2, resto);
        }

    }
}
