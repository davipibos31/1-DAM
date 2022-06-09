using System;
/*
 * A partir del ejemplo 07.02b y del ejercicio 6.8.1 (clase Trabajador y relacionadas), 
 * crea un array de trabajadores en el que no sean todos de la misma clase
 */
namespace _7._2._4
{
    class Trabajador
    {
        public Trabajador()
        {
            Console.WriteLine("Soy un trabajador");
        }
    }
    class Programador : Trabajador
    {
        public Programador()
        {
            Console.WriteLine("Soy un Programador");
        }
    }
    class Electricista : Trabajador
    {
        public Electricista()
        {
            Console.WriteLine("Soy un Electricista");
        }
    }
	
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador[] empleados = new Trabajador[10];

            for(int i=0; i<3; i++)
                empleados[i] = new Trabajador();

            Console.WriteLine();

            for(int i=3; i<6; i++)
                empleados[i] = new Programador();

            Console.WriteLine();

            for (int i = 6; i < 10; i++)
                empleados[i] = new Electricista();
        }
    }
}
