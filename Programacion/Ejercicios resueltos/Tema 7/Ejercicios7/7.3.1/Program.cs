using System;

/*
 * Crea una versión ampliada del ejercicio 6.5.1 (Persona, PersonaInglesa, etc), 
 * en la que se cree un único array que contenga personas de varios tipos.
 */

namespace _7._3._1
{
    class Persona
    {
        public virtual void Saludar()
        {
            Console.WriteLine("Soy una persona");
        }
    }
	
    class PersonaInglesa : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Soy una persona inglesa");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    personas[i] = new PersonaInglesa();
                else
                    personas[i] = new Persona();
            }

            for (int i = 0; i < 10; i++)
            {
                personas[i].Saludar();
            }
        }
    }
}
