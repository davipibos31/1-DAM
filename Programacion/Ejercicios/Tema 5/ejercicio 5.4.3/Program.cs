using System;

namespace ejercicio_5._4._3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número real: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El retorno es {0}", Signo(num));
        }
        public static int Signo(int num)
        {
            
            if (num > 0)
                return 1;
            else if (num < 0)
                return -1;
            else
                return 0;
        }
    }
}
