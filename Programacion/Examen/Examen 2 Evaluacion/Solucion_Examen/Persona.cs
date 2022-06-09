using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Solucion
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string telefono1;
        protected string telefono2;
        protected string direccion;
        protected string email;
        protected string poblacion;
        protected string provincia;
        protected Random random = new Random();

        public Persona(string nombre, string apellido, string telefono1, string telefono2, string direccion, string email, string poblacion, string provincia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.direccion = direccion;
            this.email = email;
            this.poblacion = poblacion;
            this.provincia = provincia;
        }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
