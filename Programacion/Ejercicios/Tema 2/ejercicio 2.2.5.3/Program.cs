using System;

namespace ejercicio_2._2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int division;
            int division1;
            int division2;

            for (cont = 10; cont <= 20; cont++)
            {
                division = cont % 5;
                if (division == 0)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Es divisible entre 5");
                }
                else
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("No es divisible entre 5");
                }
                division1 = cont % 6;
                if (division1 == 0)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Es divisible entre 6");
                }
                else
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("No es divisible entre 6");
                }
                division2 = cont % 7;
                if (division2 == 0)
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("Es divisible entre 7");
                }
                else
                {
                    Console.WriteLine(cont);
                    Console.WriteLine("No es divisible entre 7");
                }
            }
        }
    }
}
