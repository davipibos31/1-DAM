using System;

namespace ejercicio_4._1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = { 31, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };

            int dia_anio = 0;
            Console.WriteLine("Introduce un mes en número: ");
            int usu_mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un día en número: ");
            int usu_dia = Convert.ToInt32(Console.ReadLine());
            usu_mes--;
            for (int i = 0; i < usu_mes; i++)
            {
                dia_anio = dia_anio + meses[i];
            }
            dia_anio += usu_dia;
            Console.WriteLine($"El dia introducido es {dia_anio}");
        }
    }
}
