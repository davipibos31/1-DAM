using System;

namespace ejercicio_2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
      
            if (numero1 > numero2)
            {
                Console.WriteLine("El número {0} es mayor que {1}", numero1, numero2);
                Console.Write("El mayor es {0}", numero1);
            }
            else
            {
                Console.WriteLine("El número {0} es menor que {1}", numero1, numero2);
                Console.Write("El mayor es {0}", numero2);
            }
        }
    }
}
