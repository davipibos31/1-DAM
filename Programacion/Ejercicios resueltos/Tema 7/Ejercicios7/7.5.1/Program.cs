using System;

/*
 * Crea una versión ampliada del ejercicio 7.4.2, en la que el constructor sin parámetros de la clase "Trabajador" 
 * se apoye en otro constructor que reciba como parámetro el nombre de esa persona. 
 * La versión sin parámetros asignará el valor "Nombre no detallado" al nombre de esa persona.
 */

namespace _7._5._1
{
    class Trabajador
    {
        public string nombre;
        
		public Trabajador() 
        {
			this.nombre = "Nombre no detallado";
        }
		
        public Trabajador(string nombre)
        {
            this.nombre = nombre;
        }
		
        public void Hablar()
        {
            Console.WriteLine("Mi nombre es {0}", this.nombre);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // con nombre
            Trabajador trabajador1 = new Trabajador("Ana");
            trabajador1.Hablar();
            // sin nombre
            Trabajador trabajador2 = new Trabajador();
            trabajador2.Hablar();
        }
    }
}
