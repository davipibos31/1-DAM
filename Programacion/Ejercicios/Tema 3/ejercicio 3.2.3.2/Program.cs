using System;

namespace ejercicio_3._2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int metros;
            Console.WriteLine("Introduce la distancia en metros: ");
            metros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca las horas: ");
            int tiempo_horas;
            tiempo_horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca los minutos: ");
            int tiempo_minutos;
            tiempo_minutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca los segundos: ");
            int tiempo_segundos;
            tiempo_segundos = Convert.ToInt32(Console.ReadLine());

            int ms = metros / tiempo_segundos;
            Console.WriteLine($"{ms} m/s");

            int kh = metros / tiempo_horas;
            Console.WriteLine($"{kh} k/h");

            int milla = 1 / 1600;
            int mh = milla / tiempo_horas;
            Console.WriteLine($"{mh} m/h");




        }
    }
}
