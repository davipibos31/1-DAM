using System;

namespace ejercicio_2._2._1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int multiplo;


            Console.WriteLine("Introduzca dos números ");
            Console.WriteLine("Introduzca el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            

            while ((numero1 != 0) && (numero2 != 0))
            {
                multiplo = numero1 % numero2;
                if ((numero1 > numero2) && (multiplo == 0))
                {
                    Console.WriteLine("El número {0} es múltiplo de {1}", numero1, numero2);

                }
                multiplo = numero2 % numero1;
                if ((numero2 > numero1) && (multiplo == 0))
                {
                    multiplo = numero2 % numero1;
                    Console.WriteLine("El número {1} es múltiplo de {0}", numero1, numero2);
                }
                else if ((multiplo != 0) && ((numero1 > numero2) || (numero1 < numero2)))
                {
                    multiplo = numero1 % numero2;
                    multiplo = numero2 % numero1;
                    Console.WriteLine("Ninguno de ellos es múltiplo del otro");
                }
                Console.WriteLine("Introduzca otros dos números ");
                Console.WriteLine("Introduzca el primer número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                multiplo = numero1 % numero2;
            }
        }
    }
}
