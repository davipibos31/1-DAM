using System;

namespace ejercicio_2._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int division;

            Console.WriteLine("Introduzca un número: ");
            numero1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 != 0)
            {
                division = numero1 / numero2;
                Console.WriteLine("La división entre {0} y {1} es igual a {2}", numero1, numero2, division);
            }
            else if (numero2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
        }
    }
}
