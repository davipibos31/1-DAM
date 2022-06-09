using System;

namespace ejercicio_1._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int numero1;
            int numero2;
            int producto;

            //damos valor a las variables

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            producto = numero1 * numero2;

            //realizamos la operación

            System.Console.WriteLine("El producto de {0} y {1} es igual a {2}", numero1, numero2, producto);
        }
    }
}
