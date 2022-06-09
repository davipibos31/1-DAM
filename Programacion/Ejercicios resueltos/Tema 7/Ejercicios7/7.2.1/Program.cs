using System;

/*
 * Crea una versión ampliada del ejercicio 6.8.1 (clase Trabajador y relacionadas), 
 * en la que no se cree un único objeto de cada clase, sino un array de tres objetos.
 */
namespace _7._2._1
{
    class Trabajador
    {
        public Trabajador()
        {
            Console.WriteLine("Hola, soy un trabajador");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador[] trabajador = new Trabajador[3];

            for(int i=0; i<3; i++)
            {
                trabajador[i] = new Trabajador();
            }
        }
    }
}
