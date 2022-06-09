using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_2
{
    class CPersona
    {
        private string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Saludar()
        {
            return "Hola, soy " + this.nombre;
        }
    }
}
