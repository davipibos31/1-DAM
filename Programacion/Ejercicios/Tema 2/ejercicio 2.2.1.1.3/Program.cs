﻿using System;

namespace ejercicio_2._2._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int multiplo;

            
            Console.WriteLine("Introduzca dos números: ");
            Console.WriteLine("Introduzca el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            multiplo = numero1 % numero2;

            while ((numero1 != 0) && (numero2 != 0))
            {
                if ((multiplo == 0) && (numero1 > 0))
                {
                    Console.WriteLine("El número {0} es míltiplo de {1}", numero1, numero2);
                    
                }
                else
                {
                    Console.WriteLine("El número {0} no es múltiplo de {1}", numero1, numero2);
                }
                Console.WriteLine("Introduzca otros dos números: ");
                Console.WriteLine("Introduzca el primer número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                multiplo = numero1 % numero2;
            }
        }
    }
}
