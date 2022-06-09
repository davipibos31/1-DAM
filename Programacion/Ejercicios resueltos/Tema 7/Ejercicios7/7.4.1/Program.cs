using System;

/*
 * Crea una versión ampliada del ejercicio 7.3.3, en la que el método "Hablar" 
 * de todas las clases hijas se apoye en el de la clase "Trabajador".
 */
namespace _7._4._1
{
    class Trabajador
    {
        public void Hablar()
        {
            Console.Write("Hola, soy un trabajador. ");
        }
    }
    class Informatico : Trabajador
    {
        public new void Hablar()
        {
            base.Hablar();
            Console.Write("Soy informático.\n");
        }
    }
    class Electricista : Trabajador
    {
        public new void Hablar()
        {
            base.Hablar();
            Console.Write("Soy electricista.\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador trabajador = new Trabajador();
            Informatico informatico = new Informatico();
            Electricista electricista = new Electricista();

            informatico.Hablar();
            electricista.Hablar();
            trabajador.Hablar();
        }
    }
}
