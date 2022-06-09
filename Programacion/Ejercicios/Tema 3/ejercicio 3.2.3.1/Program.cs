using System;

namespace ejercicio_3._2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            Console.WriteLine("Introduce un radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            float num = 4 / 3;
            double volumen;
            double pi = 3.14d;
            volumen = pi * (radio * radio * radio) * num;
            Console.WriteLine("El volumen de la esfera es {0}", volumen);
        }
    }
}
