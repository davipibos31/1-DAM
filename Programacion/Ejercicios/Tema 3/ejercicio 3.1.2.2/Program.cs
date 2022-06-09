using System;

namespace ejercicio_3._1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            byte num2;
            ushort resultado;
            
            Console.WriteLine("Introduce un número: ");
            num = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduce un número más: ");
            num2 = Convert.ToByte(Console.ReadLine());
            resultado = Convert.ToByte(num*num2);
            Console.WriteLine(resultado);
        }
    }
}
