using System;

/*
 * Crea una versión ampliada del ejercicio 7.4.1, en la que el constructor de 
 * todas las clases hijas se apoye en el de la clase "Trabajador".
 */

namespace _7._4._2
{
    class Trabajador
    {
        public string nombre;

        public Trabajador(string nombre)
        {
            this.nombre = nombre;
            Console.Write("Hola, soy {0} y trabajo ", this.nombre);
        }
    }
    class Informatico : Trabajador
    {
        public Informatico(string nombre) : base(nombre)
        {
            Console.Write("de informático\n");
        }
    }
    class Electricista : Trabajador
    {
        public Electricista(string nombre) : base(nombre)
        {
            Console.Write("de electricista\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Informatico informatico = new Informatico("Kevin");
            Electricista electricista = new Electricista("María");
            Trabajador trabajador = new Trabajador("Lucas");

        }
    }
}
