using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._6._1.Modelo
{
    class PersonaInglesa : Persona
    {
        public PersonaInglesa()
        {
            nombre = "Jhon";
        }
        public PersonaInglesa(string nombre)
        {
            this.nombre = nombre;
        }
        public void Saludar2()
        {
            Console.WriteLine($"Hi, I am {nombre}");
        }
        public void TomarCafe()
        {
            Console.WriteLine("Estoy tomando café");
        }
        ~PersonaInglesa()
        { 
            
        }
    }
}
