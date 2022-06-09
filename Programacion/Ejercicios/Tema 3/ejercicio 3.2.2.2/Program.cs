using System;

namespace ejercicio_3._2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            Console.WriteLine("Introduce un radio: ");
            radio = Convert.ToInt32(Console.ReadLine());
            float pi = 3.14f;
            double area;
            area = radio * radio * pi;
            Console.WriteLine("El área del circulo es {0}", area);
        }
    }
}
