using System;

namespace Ejercicio_2._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int año_nacimiento;
            bool mensaje = true;
            do 
            {

                try
                {
                    Console.Write("Introduce su edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduce su año de nacimiento: ");
                    año_nacimiento = Convert.ToInt32(Console.ReadLine());
                    mensaje = false;
                }
               catch (FormatException x)
                {
                    Console.WriteLine("Ha habido un error: {0}", x.Message);
                }
                catch (OverflowException x)
                {
                    Console.WriteLine("Ha habido un error : {0}", x.Message);
                }
            }
            while (mensaje);
        }
    }
}
