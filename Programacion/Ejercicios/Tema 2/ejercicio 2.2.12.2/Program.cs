using System;

namespace ejercicio_2._2._12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            for (cont = 21; cont >= 10; cont--)
            {
                if ((cont != cont--) || (cont == 14))
                    continue;
                Console.Write("{0} ", cont);
            }
        }
    }
}
