using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._6._1.Modelo
{
    class PruebaPersona3
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            PersonaInglesa p2 = new PersonaInglesa();
            PersonaInglesa p3 = new PersonaInglesa();
            PersonaItaliana p4 = new PersonaItaliana();

            Console.Write("Escribe tu nombre: ");
            p1.SetNombre(Console.ReadLine());
            p1.Saludar();
            p1.Saludar("Lorena");
            Console.WriteLine();
            Console.Write("Escribe un segundo nombre: ");
            p2.SetNombre(Console.ReadLine());
            p2.Saludar();
            Console.WriteLine();
            Console.Write("Escribe un tercer nombre: ");
            p3.SetNombre(Console.ReadLine());
            p3.Saludar();
            Console.WriteLine();
            Console.WriteLine("¿Quieres tomar café?");
            p3.TomarCafe();
            Console.WriteLine();
            Console.WriteLine("Escribe un cuarto nombre");
            p4.SetNombre(Console.ReadLine());
            p4.Saludar2();
        }
    }
}
