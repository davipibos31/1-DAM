using System;

namespace ejercicio_2._2._11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            for (cont = 1; cont <= 106; cont++)
            {
                if (cont != cont++)
                    continue;
                Console.WriteLine("{0}", cont);
            }
        }
    }
}
