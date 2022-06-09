using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._2.Modelo
{
    class PersonaInglesa : Persona
    {
        public void Saludar2()
        {
            Console.WriteLine($"Hi, I am {nombre}");
        }
        public void TomarCafe()
        {
            Console.WriteLine("Estoy tomando café");
        }
    }
}
