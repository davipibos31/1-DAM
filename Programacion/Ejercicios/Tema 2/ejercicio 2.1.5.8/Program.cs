using System;

namespace ejercicio_2._1._5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 >= 0) && (numero2 >= 0))
            {
                Console.WriteLine("Los dos números son positivos");
            }
            else if ((numero1 < 0) && (numero2 >= 0) || (numero1 >= 0) && (numero2 < 0))
            {
                Console.WriteLine("Uno de los dos número es positivo");
            }
            else if ((numero1 < 0) && (numero2 < 0))
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }
        }
    }
}
