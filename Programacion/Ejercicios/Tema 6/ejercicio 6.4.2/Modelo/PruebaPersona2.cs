using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._4._2.Modelo
{
    class PruebaPersona2
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            PersonaInglesa p3 = new PersonaInglesa();
            Console.Write("Escribe tu nombre: ");
            p1.SetNombre(Console.ReadLine());
            p1.Saludar();
            Console.Write("Escribe un segundo nombre: ");
            p2.SetNombre(Console.ReadLine());
            p2.Saludar();
            Console.Write("Escribe un tercer nombre: ");
            p3.SetNombre(Console.ReadLine());
            p3.Saludar();
            Console.WriteLine("¿Quieres tomar café?");
            p3.TomarCafe();
        }
    }
}
