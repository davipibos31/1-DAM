using System;

namespace ejercicio_2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num_usu;
            int cont;

            num = 56;
            Console.WriteLine("Adivina un número del 1 al 100");
            Console.WriteLine("Inserte un número: ");
            num_usu = Convert.ToInt32(Console.ReadLine());

            cont = 1;
            while (cont <= 5)
            {
                if (num == num_usu)
                {
                    Console.WriteLine("El número {0} es el correcto", num_usu);
                    Console.WriteLine("Fin del programa");
                    break;
                }
                else if ((num_usu > num) && (num_usu <= 100))
                {
                    Console.WriteLine("Inserte un número: ");
                    Console.WriteLine("El número {0} es incorrecto");
                    num_usu = Convert.ToInt32(Console.ReadLine());
                    cont++;
                }
                else if ((num_usu < num) && (num_usu >= 1))
                {
                    Console.WriteLine("Inserte un número: ");

                    Console.WriteLine("El número {0} es incorrecto");
                    num_usu = Convert.ToInt32(Console.ReadLine());
                    cont++;
                }
            }
            Console.WriteLine("Fin del programa");
        }
    }
}
