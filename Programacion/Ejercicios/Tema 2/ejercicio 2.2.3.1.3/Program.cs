using System;

namespace ejercicio_2._2._3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int division1;
            int division2;

            for (cont = 100; cont <= 200; cont++)
            {
                division1 = cont % 7;
                division2 = cont % 3;
                if ((division2 == 0) && (division1 == 0))
                    Console.WriteLine(cont);
                else
                    cont++;
            }
        }
    }
}
