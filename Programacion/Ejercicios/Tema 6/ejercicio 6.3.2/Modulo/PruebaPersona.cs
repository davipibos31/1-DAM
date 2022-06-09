using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._2.Modulo
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            Console.Write("Escribe tu nombre: ");
            p1.SetNombre(Console.ReadLine());
            p1.Saludar();
            Console.Write("Escribe un segundo nombre: ");
            p2.SetNombre(Console.ReadLine());
            p2.Saludar();
        }
    }
}
