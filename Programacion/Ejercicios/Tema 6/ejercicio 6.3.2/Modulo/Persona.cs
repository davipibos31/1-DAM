using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._2.Modulo
{
    class Persona
    {
        public string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola soy {nombre}");
        }
    }
}
