using System;

namespace ejercicio_4._4._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dime tu nombre: ");
            string nombre = Console.ReadLine();

            int dia_nacimiento;
            Console.Write("Dime tu dia de nacimiento: ");
            dia_nacimiento = Convert.ToInt32(Console.ReadLine());

            int mes_nacimiento;
            Console.Write("Dime tu mes de nacimiento en número: ");
            mes_nacimiento = Convert.ToInt32(Console.ReadLine());
            int anyo_nacimiento;
            Console.Write("Dime tu año de nacimiento: ");
            anyo_nacimiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nombre}, nacido/a el {dia_nacimiento}/{mes_nacimiento}/{anyo_nacimiento}");
        }
    }
}
