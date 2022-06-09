using System;

namespace ejercicio_2._2._12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            for (cont = 100; cont <= 200; cont++)
            {
                Console.Write("{0} ", cont);
            }
            Console.WriteLine();
            cont = 100;
            while (cont <= 200)
            {
                Console.Write("{0} ", cont);
                cont++;
            }

        }
    }
}
