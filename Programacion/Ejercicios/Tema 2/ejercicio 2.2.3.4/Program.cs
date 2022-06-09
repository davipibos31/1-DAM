using System;

namespace ejercicio_2._2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int division;

            for (cont = 1; cont <= 90; cont++)
            {
                division = cont % 9;
                if (division == 0)
                    Console.WriteLine(cont);
                else
                    cont++;
            }
        }
    }
}
