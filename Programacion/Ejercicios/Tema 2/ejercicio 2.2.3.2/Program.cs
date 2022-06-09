using System;

namespace ejercicio_2._2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int resto;

            for (cont = 1; cont <= 50; cont++)
            {
                resto = cont % 3;
               if (resto == 0)
                    Console.WriteLine(cont);
                else
                    cont++;
            }
        }
    }
}
