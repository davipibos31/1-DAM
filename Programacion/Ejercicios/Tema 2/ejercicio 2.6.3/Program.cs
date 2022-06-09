using System;

namespace ejercicio_2._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            
            int potencia;
            Console.WriteLine("Introduce un número: ");
            potencia = Convert.ToInt32(Console.ReadLine());
            
            int var;
            Console.WriteLine("Introduce un número: ");
            var = Convert.ToInt32(Console.ReadLine());

            total = 1;
            int cont = 0;
            while (cont <= potencia)
            {
                total = total * var;
                cont++;
            }
            Console.WriteLine(total);
        }
    }
}
