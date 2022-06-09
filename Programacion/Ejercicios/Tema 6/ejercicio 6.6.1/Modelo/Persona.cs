using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._6._1.Modelo
{
    class Persona
    {
        public Persona()
        { 
            
        }

        public string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola soy {nombre}");
        }
        ~Persona()
        {
            
        }
    }
}
