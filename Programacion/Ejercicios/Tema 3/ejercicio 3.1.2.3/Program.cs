using System;

namespace ejercicio_3._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num;
            long num2;
            long resultado;
            Console.WriteLine("Introduce un número: ");
            num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            num2 = Convert.ToInt64(Console.ReadLine());

            resultado = num + num2;
            Console.WriteLine("El resultado de la suma entre {0} y {1} es {2}", num, num2, resultado);
            resultado = num - num2;
            Console.WriteLine("El resultado de la resta entre {0} y {1} es {2}", num, num2, resultado);
            resultado = num * num2;
            Console.WriteLine("El resultado de la multiplicación entre {0} y {1} es {2}", num, num2, resultado);
        }
    }
}
