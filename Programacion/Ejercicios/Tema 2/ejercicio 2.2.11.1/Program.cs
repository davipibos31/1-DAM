using System;

namespace ejercicio_2._2._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            for (cont = 20; cont >= 10; cont--)
            {
                if (cont == 13)
                    continue;
                Console.WriteLine("{0}", cont);
            }
        }
    }
}
