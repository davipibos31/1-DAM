using System;

namespace ejercicio_3._2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float Euro;
            float Interes;
            float años;

            Console.Write("Introduce la cantidad de euros que se quieren convertir: ");
            Euro = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduce la cantidad de años que tendrá el interés: ");
            años = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduce la cantidad de interés anual en %: ");
            Interes = Convert.ToSingle(Console.ReadLine());
            double resultado =  Euro * ((1 + Interes) * años);
            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
