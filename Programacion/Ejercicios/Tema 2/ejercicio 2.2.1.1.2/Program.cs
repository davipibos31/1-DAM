using System;

namespace ejercicio_2._2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cuadrado;
           
            Console.WriteLine("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            cuadrado = (numero * numero);
            while (numero != 0)
            {
                if (numero > 0)
                    Console.WriteLine("El cuadrado del número {0} es {1}", numero, cuadrado);
                else 
                    Console.WriteLine("El número es 0 no funciona su cuadrado");
                Console.WriteLine("Introduzca otro número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                cuadrado = (numero * numero);
            }
        }
    }
}
